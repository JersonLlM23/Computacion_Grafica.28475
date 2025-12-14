using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using TAR3_P2_ALGORITMOS_CURVAS.Modelo;

namespace TAR3_P2_ALGORITMOS_CURVAS.Vistas
{
    public enum ModoCurva { Bezier, BSpline }

    public partial class frmCurvas : Form
    {
        // Campos Bézier
        private PointF p0, p1, p2, p3, q;
        private float t = 0.0f;
        private float deltaT = 0.01f; // Velocidad de la animación
        private bool animacionEnCurso = false;
        private int gradoSeleccionado = 2; // 1: lineal (2 puntos), 2: cuadrática (3 puntos), 3: cúbica (4 puntos)
        private int puntoSeleccionado = -1; // índice del punto seleccionado para arrastrar
        private bool arrastrando = false;
        private float anchoLinea = 1.0f; // grosor de líneas
        private int radioPunto = 6; // diámetro de los puntos dibujados
        private int puntoHover = -1; // índice del punto en hover para resaltado visual

        // Campos B-Spline
        private ModoCurva modoActual = ModoCurva.Bezier;
        private List<PointF> puntosBSpline = new List<PointF>();
        private bool curvaBSplineDibujada = false;

        public frmCurvas()
        {
            InitializeComponent();

            // Configuramos el Timer para la animación
            timerBEZIER.Interval = 50; // Intervalo de 50ms para animación
            timerBEZIER.Tick += TimerBEZIER_Tick;

            // Inicializamos el ComboBox para seleccionar el grado (aunque solo usaremos grado 2)
            cmbGrado.SelectedIndex = 1; // Seleccionar el grado 2 por defecto
            cmbGrado.SelectedIndexChanged += CmbGrado_SelectedIndexChanged;

            // Suscribir eventos de arrastre
            pictureBoxCurva.MouseDown += pictureBoxCurva_MouseDown;
            pictureBoxCurva.MouseMove += pictureBoxCurva_MouseMove;
            pictureBoxCurva.MouseUp += pictureBoxCurva_MouseUp;

            // Habilitar detección de teclas
            this.KeyPreview = true;
            this.KeyDown += frmCurvas_KeyDown;
        }

        // Método que se llama en cada tick del timer
        private void TimerBEZIER_Tick(object sender, EventArgs e)
        {
            // Calculamos el punto de la curva según el modo
            if (modoActual == ModoCurva.Bezier)
            {
                if (gradoSeleccionado == 1)
                {
                    q = CurvaBezier.CalcularCurvaBezier(p0, p1, t);
                }
                else if (gradoSeleccionado == 2)
                {
                    q = CurvaBezier.CalcularCurvaBezier(p0, p1, p2, t);
                }
                else // gradoSeleccionado == 3
                {
                    q = CurvaBezier.CalcularCurvaBezier(p0, p1, p2, p3, t);
                }
            }
            else // ModoCurva.BSpline
            {
                if (puntosBSpline.Count >= 4)
                {
                    q = CurvaBSpline.CalcularPuntoBSpline(puntosBSpline, t);
                }
            }

            // Redibujamos la imagen en el PictureBox
            pictureBoxCurva.Invalidate();

            // Incrementamos t
            t += deltaT;
            if (t > 1.0f)
            {
                // Cambiar dirección del movimiento: De adelante a atrás (bucle)
                deltaT = -deltaT;  // Invertir la dirección
            }

            if (t < 0.0f)  // Si t vuelve a 0, reiniciamos la animación
            {
                t = 0.0f;
                animacionEnCurso = false;
                timerBEZIER.Stop(); // Detener la animación
            }
        }

        // Método para iniciar la animación
        private void btnDibujarCurva_Click_1(object sender, EventArgs e)
        {
            bool puntosListos = gradoSeleccionado == 1
                ? (p0 != PointF.Empty && p1 != PointF.Empty)
                : gradoSeleccionado == 2
                    ? (p0 != PointF.Empty && p1 != PointF.Empty && p2 != PointF.Empty)
                    : (p0 != PointF.Empty && p1 != PointF.Empty && p2 != PointF.Empty && p3 != PointF.Empty);

            if (!animacionEnCurso && puntosListos)
            {
                t = 0.0f; // Reiniciar t
                deltaT = Math.Abs(deltaT); // Asegurar dirección inicial hacia adelante
                animacionEnCurso = true;
                timerBEZIER.Start(); // Comenzar la animación
            }
            else if (!puntosListos)
            {
                string msg = gradoSeleccionado == 1
                    ? "Por favor, define los puntos P0 y P1 primero."
                    : gradoSeleccionado == 2
                        ? "Por favor, define los puntos P0, P1 y P2 primero."
                        : "Por favor, define los puntos P0, P1, P2 y P3 primero.";
                MessageBox.Show(msg);
            }
        }

        // Evento de dibujo de la curva (pintar la línea y el punto Q(t))
        private void pictureBoxCurva_Paint_1(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            using (var pen = new Pen(Color.Black, anchoLinea))
            {
                if (modoActual == ModoCurva.Bezier)
                {
                    DibujarBezier(g, pen);
                }
                else // ModoCurva.BSpline
                {
                    DibujarBSpline(g, pen);
                }

                // Dibujar los puntos Q(t)
                if (q != PointF.Empty)
                {
                    g.FillEllipse(Brushes.Green, q.X - radioPunto / 2f, q.Y - radioPunto / 2f, radioPunto, radioPunto);
                }
            }
        }

        private void DibujarBezier(Graphics g, Pen pen)
        {
            // Dibuja puntos en cuanto existan y líneas cuando haya pares completos
            if (gradoSeleccionado == 2)
            {
                if (p0 != PointF.Empty) g.FillEllipse(Brushes.Blue, p0.X - radioPunto / 2f, p0.Y - radioPunto / 2f, radioPunto, radioPunto);
                if (p1 != PointF.Empty) g.FillEllipse(Brushes.Red, p1.X - radioPunto / 2f, p1.Y - radioPunto / 2f, radioPunto, radioPunto);
                if (p2 != PointF.Empty) g.FillEllipse(Brushes.Purple, p2.X - radioPunto / 2f, p2.Y - radioPunto / 2f, radioPunto, radioPunto);

                if (p0 != PointF.Empty && p1 != PointF.Empty) g.DrawLine(pen, p0, p1);
                if (p1 != PointF.Empty && p2 != PointF.Empty) g.DrawLine(pen, p1, p2);
            }
            else if (gradoSeleccionado == 1)
            {
                if (p0 != PointF.Empty) g.FillEllipse(Brushes.Blue, p0.X - radioPunto / 2f, p0.Y - radioPunto / 2f, radioPunto, radioPunto);
                if (p1 != PointF.Empty) g.FillEllipse(Brushes.Red, p1.X - radioPunto / 2f, p1.Y - radioPunto / 2f, radioPunto, radioPunto);

                if (p0 != PointF.Empty && p1 != PointF.Empty) g.DrawLine(pen, p0, p1);
            }
            else // gradoSeleccionado == 3
            {
                if (p0 != PointF.Empty) g.FillEllipse(Brushes.Blue, p0.X - radioPunto / 2f, p0.Y - radioPunto / 2f, radioPunto, radioPunto);
                if (p1 != PointF.Empty) g.FillEllipse(Brushes.Red, p1.X - radioPunto / 2f, p1.Y - radioPunto / 2f, radioPunto, radioPunto);
                if (p2 != PointF.Empty) g.FillEllipse(Brushes.Purple, p2.X - radioPunto / 2f, p2.Y - radioPunto / 2f, radioPunto, radioPunto);
                if (p3 != PointF.Empty) g.FillEllipse(Brushes.Orange, p3.X - radioPunto / 2f, p3.Y - radioPunto / 2f, radioPunto, radioPunto);

                if (p0 != PointF.Empty && p1 != PointF.Empty) g.DrawLine(pen, p0, p1);
                if (p1 != PointF.Empty && p2 != PointF.Empty) g.DrawLine(pen, p1, p2);
                if (p2 != PointF.Empty && p3 != PointF.Empty) g.DrawLine(pen, p2, p3);
            }

            // Dibujar la curva completa de Bézier
            DibujarCurvaBezierCompleta(g);
        }

        private void DibujarBSpline(Graphics g, Pen pen)
        {
            // Dibujar puntos de control
            for (int i = 0; i < puntosBSpline.Count; i++)
            {
                var color = i % 2 == 0 ? Brushes.Blue : Brushes.Red;
                g.FillEllipse(color, puntosBSpline[i].X - radioPunto / 2f, puntosBSpline[i].Y - radioPunto / 2f, radioPunto, radioPunto);
            }

            // Dibujar resaltado para puntos en hover/selección
            for (int i = 0; i < puntosBSpline.Count; i++)
            {
                if ((puntoHover == i) || (puntoSeleccionado == i && arrastrando))
                {
                    using (var penResaltado = new Pen(Color.Red, Math.Max(2f, pen.Width)))
                    {
                        float r = radioPunto + 6;
                        g.DrawEllipse(penResaltado, puntosBSpline[i].X - r / 2f, puntosBSpline[i].Y - r / 2f, r, r);
                    }
                }
            }

            // Dibujar polígono de control
            if (puntosBSpline.Count > 1)
            {
                for (int i = 0; i < puntosBSpline.Count - 1; i++)
                {
                    g.DrawLine(pen, puntosBSpline[i], puntosBSpline[i + 1]);
                }
            }

            // Dibujar curva B-Spline si se presionó clic derecho
            if (curvaBSplineDibujada && puntosBSpline.Count >= 4)
            {
                var puntosCurva = CurvaBSpline.GenerarCurvaBSpline(puntosBSpline, 100);
                using (var penCurva = new Pen(Color.DodgerBlue, 2.5f))
                {
                    for (int i = 0; i < puntosCurva.Count - 1; i++)
                    {
                        g.DrawLine(penCurva, puntosCurva[i], puntosCurva[i + 1]);
                    }
                }
            }
        }

        private void DibujarCurvaBezierCompleta(Graphics g)
        {
            // Dibujar la curva completa según el grado seleccionado
            bool puntosCompletos = false;
            
            if (gradoSeleccionado == 1 && p0 != PointF.Empty && p1 != PointF.Empty)
                puntosCompletos = true;
            else if (gradoSeleccionado == 2 && p0 != PointF.Empty && p1 != PointF.Empty && p2 != PointF.Empty)
                puntosCompletos = true;
            else if (gradoSeleccionado == 3 && p0 != PointF.Empty && p1 != PointF.Empty && p2 != PointF.Empty && p3 != PointF.Empty)
                puntosCompletos = true;

            if (!puntosCompletos) return;

            // Calcular puntos de la curva
            var puntosCurva = new System.Collections.Generic.List<PointF>();
            int numPuntos = 100; // Cantidad de puntos para dibujar la curva suave

            for (int i = 0; i <= numPuntos; i++)
            {
                float tCurva = i / (float)numPuntos;
                PointF punto;

                if (gradoSeleccionado == 1)
                    punto = CurvaBezier.CalcularCurvaBezier(p0, p1, tCurva);
                else if (gradoSeleccionado == 2)
                    punto = CurvaBezier.CalcularCurvaBezier(p0, p1, p2, tCurva);
                else
                    punto = CurvaBezier.CalcularCurvaBezier(p0, p1, p2, p3, tCurva);

                puntosCurva.Add(punto);
            }

            // Dibujar la curva con líneas entre puntos consecutivos
            using (var penCurva = new Pen(Color.LimeGreen, 2.5f))
            {
                for (int i = 0; i < puntosCurva.Count - 1; i++)
                {
                    g.DrawLine(penCurva, puntosCurva[i], puntosCurva[i + 1]);
                }
            }
        }

        // Evento de reset para reiniciar todo
        private void btnResetCurvas_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Detectar clics del usuario en el PictureBox para definir P0, P1, P2
        private void pictureBoxCurva_MouseClick(object sender, MouseEventArgs e)
        {
            if (!animacionEnCurso)
            {
                if (modoActual == ModoCurva.BSpline)
                {
                    if (e.Button == MouseButtons.Left)
                    {
                        // En modo B-Spline, agregar puntos solo si no estamos sobre un punto existente
                        if (HitTestPoint(e.Location) < 0)
                        {
                            puntosBSpline.Add(e.Location);
                            pictureBoxCurva.Invalidate();
                        }
                    }
                    else if (e.Button == MouseButtons.Right)
                    {
                        // Clic derecho para dibujar la curva B-Spline
                        if (puntosBSpline.Count >= 4)
                        {
                            curvaBSplineDibujada = true;
                            pictureBoxCurva.Invalidate();
                        }
                        else
                        {
                            MessageBox.Show("Se necesitan al menos 4 puntos de control para dibujar la curva B-Spline.");
                        }
                    }
                    return;
                }

                // Modo Bézier
                if (gradoSeleccionado == 1)
                {
                    if (p0 == PointF.Empty)
                    {
                        p0 = e.Location;
                        pictureBoxCurva.Invalidate();
                    }
                    else if (p1 == PointF.Empty)
                    {
                        p1 = e.Location;
                        pictureBoxCurva.Invalidate();
                    }
                }
                else if (gradoSeleccionado == 2)
                {
                    if (p0 == PointF.Empty)
                    {
                        p0 = e.Location;
                        pictureBoxCurva.Invalidate();
                    }
                    else if (p1 == PointF.Empty)
                    {
                        p1 = e.Location;
                        pictureBoxCurva.Invalidate();
                    }
                    else if (p2 == PointF.Empty)
                    {
                        p2 = e.Location;
                        pictureBoxCurva.Invalidate();
                    }
                }
                else // gradoSeleccionado == 3
                {
                    if (p0 == PointF.Empty)
                    {
                        p0 = e.Location;
                        pictureBoxCurva.Invalidate();
                    }
                    else if (p1 == PointF.Empty)
                    {
                        p1 = e.Location;
                        pictureBoxCurva.Invalidate();
                    }
                    else if (p2 == PointF.Empty)
                    {
                        p2 = e.Location;
                        pictureBoxCurva.Invalidate();
                    }
                    else if (p3 == PointF.Empty)
                    {
                        p3 = e.Location;
                        pictureBoxCurva.Invalidate();
                    }
                }
            }
        }

        private void pictureBoxCurva_MouseDown(object sender, MouseEventArgs e)
        {
            if (animacionEnCurso) return;
            if (e.Button == MouseButtons.Left)
            {
                puntoSeleccionado = HitTestPoint(e.Location);
                if (puntoSeleccionado >= 0)
                {
                    arrastrando = true;
                }
            }
        }

        private void pictureBoxCurva_MouseMove(object sender, MouseEventArgs e)
        {
            if (arrastrando)
            {
                if (modoActual == ModoCurva.Bezier)
                {
                    switch (puntoSeleccionado)
                    {
                        case 0: p0 = e.Location; break;
                        case 1: p1 = e.Location; break;
                        case 2: p2 = e.Location; break;
                        case 3: p3 = e.Location; break;
                    }
                }
                else // BSpline
                {
                    if (puntoSeleccionado >= 0 && puntoSeleccionado < puntosBSpline.Count)
                    {
                        puntosBSpline[puntoSeleccionado] = e.Location;
                    }
                }
                pictureBoxCurva.Invalidate();
            }
            else
            {
                puntoHover = HitTestPoint(e.Location);
                pictureBoxCurva.Cursor = (puntoHover >= 0) ? Cursors.Hand : Cursors.Default;
            }
        }

        private void pictureBoxCurva_MouseUp(object sender, MouseEventArgs e)
        {
            arrastrando = false;
            puntoSeleccionado = -1;
        }

        private int HitTestPoint(PointF pos)
        {
            // Retorna índice del punto cercano al mouse, -1 si no hay
            float umbral = Math.Max(radioPunto, 8);
            float u2 = umbral * umbral;

            if (modoActual == ModoCurva.BSpline)
            {
                for (int i = 0; i < puntosBSpline.Count; i++)
                {
                    if (Dist2(pos, puntosBSpline[i]) <= u2)
                        return i;
                }
            }
            else // Bézier
            {
                if (p0 != PointF.Empty && Dist2(pos, p0) <= u2) return 0;
                if (p1 != PointF.Empty && Dist2(pos, p1) <= u2) return 1;
                if (gradoSeleccionado >= 2 && p2 != PointF.Empty && Dist2(pos, p2) <= u2) return 2;
                if (gradoSeleccionado >= 3 && p3 != PointF.Empty && Dist2(pos, p3) <= u2) return 3;
            }
            return -1;
        }

        private void btnPausa_Click(object sender, EventArgs e)
        {
            if (animacionEnCurso)
            {
                // Pausar la animación
                timerBEZIER.Stop();
                animacionEnCurso = false;
            }
            else if (p0 != PointF.Empty && p1 != PointF.Empty && 
                     (gradoSeleccionado == 1 || (gradoSeleccionado == 2 && p2 != PointF.Empty) || 
                      (gradoSeleccionado == 3 && p2 != PointF.Empty && p3 != PointF.Empty)))
            {
                // Reanudar la animación
                animacionEnCurso = true;
                timerBEZIER.Start();
            }
        }

        private void btnDibujarBeziers_Click(object sender, EventArgs e)
        {
            // Cambiar a modo Bézier y resetear
            modoActual = ModoCurva.Bezier;
            ResetearTodo();
            
            // Actualizar información del algoritmo
            txtAlgoritmo.Text = "Curva de Bézier";
            txtDescripcion.Text = " Una curva de Bézier es definida por un conjunto de puntos de control, y la forma de la curva es influenciada por la posición de estos puntos. Dependiendo del número de puntos de control, la curva puede ser de grado 1, 2, 3, etc. En la curva de Bézier de grado 1, la curva es simplemente una línea recta entre dos puntos. En las curvas de grado 2 y grado 3, la curva se ajusta y pasa por diferentes combinaciones de los puntos de control, siendo más suave y flexible con cada grado superior. La fórmula matemática que describe la curva depende de la interpolación lineal entre puntos de control y la combinación ponderada de esos puntos utilizando un parámetro que varía entre 0 y 1. ";
        }

        private void btnDibujarBSpline_Click(object sender, EventArgs e)
        {
            // Cambiar a modo B-Spline y resetear
            modoActual = ModoCurva.BSpline;
            ResetearTodo();
            
            // Actualizar información del algoritmo
            txtAlgoritmo.Text = "B-Spline Cúbica Uniforme";
            txtDescripcion.Text = "Curva suave de control local usando funciones de base cúbicas uniformes. Requiere mínimo 4 puntos. Clic derecho para finalizar la curva. Arrastra los puntos para ajustar los 'valles'.";
        }

        private void btnAnimarBS_Click(object sender, EventArgs e)
        {
            if (modoActual == ModoCurva.BSpline && !animacionEnCurso && puntosBSpline.Count >= 4)
            {
                if (!curvaBSplineDibujada)
                {
                    MessageBox.Show("Primero dibuja la curva B-Spline con clic derecho.");
                    return;
                }
                t = 0.0f;
                deltaT = Math.Abs(deltaT);
                animacionEnCurso = true;
                timerBEZIER.Start();
            }
            else if (puntosBSpline.Count < 4)
            {
                MessageBox.Show("Se necesitan al menos 4 puntos de control para animar.");
            }
        }

        private void btnPausarBS_Click(object sender, EventArgs e)
        {
            if (modoActual == ModoCurva.BSpline)
            {
                if (animacionEnCurso)
                {
                    // Pausar la animación
                    timerBEZIER.Stop();
                    animacionEnCurso = false;
                }
                else if (puntosBSpline.Count >= 4 && curvaBSplineDibujada)
                {
                    // Reanudar la animación
                    animacionEnCurso = true;
                    timerBEZIER.Start();
                }
            }
        }

        private void frmCurvas_KeyDown(object sender, KeyEventArgs e)
        {
            // Reservado para futuros atajos de teclado
        }

        private void ResetearTodo()
        {
            // Resetear Bézier
            p0 = p1 = p2 = p3 = q = PointF.Empty;
            
            // Resetear B-Spline
            puntosBSpline.Clear();
            curvaBSplineDibujada = false;
            
            // Resetear animación
            t = 0.0f;
            deltaT = 0.01f;
            animacionEnCurso = false;
            timerBEZIER.Stop();
            
            pictureBoxCurva.Invalidate();
        }

        private float Dist2(PointF a, PointF b)
        {
            float dx = a.X - b.X;
            float dy = a.Y - b.Y;
            return dx * dx + dy * dy;
        }

        private void pictureBoxCurva_Click(object sender, EventArgs e)
        {

        }

        private void pnlUp_Paint(object sender, PaintEventArgs e)
        {

        }

        private void CmbGrado_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Actualizar grado seleccionado: índice 0 => "1", índice 1 => "2", etc.
            var texto = cmbGrado.SelectedItem?.ToString();
            gradoSeleccionado = texto == "1" ? 1 : texto == "2" ? 2 : 3;

            // Reiniciar lienzo y estado al cambiar a grado 1
            p0 = p1 = p2 = p3 = q = PointF.Empty;
            t = 0.0f;
            deltaT = 0.01f;
            animacionEnCurso = false;
            timerBEZIER.Stop();
            pictureBoxCurva.Invalidate();
        }
    }
}
