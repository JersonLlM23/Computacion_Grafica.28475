using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using TAR2_P2_ALGORITMOS_GRAFICA.controlador;

namespace TAR2_P2_ALGORITMOS_GRAFICA.Vistas
{
    public partial class cutPoligSutherlandH : Form
    {
        // (Opcional) Singleton como en los otros formularios
        private static cutPoligSutherlandH instancia = null;
        public static cutPoligSutherlandH Instancia
        {
            get
            {
                if (instancia == null || instancia.IsDisposed)
                    instancia = new cutPoligSutherlandH();
                return instancia;
            }
        }

        // === Lienzo ===
        private Bitmap _lienzoCP;
        private Graphics _gCP;

        private enum ModoDibujo
        {
            Ventana,
            Poligono
        }

        private ModoDibujo _modoActual = ModoDibujo.Ventana;

        // === Ventana de recorte ===
        private bool _tienePrimerPuntoVentana = false;
        private Point _primerPuntoVentana;
        private Rectangle _clipWindow;
        private bool _ventanaDefinida = false;

        // === Polígono sujeto ===
        private List<PointF> _poligono = new List<PointF>();
        private bool _tieneVerticePrevio = false;
        private PointF _verticePrevio;

        public cutPoligSutherlandH()
        {
            InitializeComponent();
            InicializarLienzoCP();

            picturebxCP.MouseClick += picturebxCP_MouseClick;
            btnPoligonoCP.Click += btnPoligonoCP_Click;
            btnCortarCP.Click += btnCortarCP_Click;
            btnResetCP.Click += btnResetCP_Click;
        }

        private void InicializarLienzoCP()
        {
            _lienzoCP = new Bitmap(picturebxCP.Width, picturebxCP.Height);
            _gCP = Graphics.FromImage(_lienzoCP);
            _gCP.Clear(Color.White);
            picturebxCP.Image = _lienzoCP;

            _modoActual = ModoDibujo.Ventana;

            _tienePrimerPuntoVentana = false;
            _ventanaDefinida = false;

            _poligono.Clear();
            _tieneVerticePrevio = false;
        }

        // ================== CLICK EN PICTUREBOX ==================
        private void picturebxCP_MouseClick(object sender, MouseEventArgs e)
        {
            if (_modoActual == ModoDibujo.Ventana)
            {
                ManejarClickVentana(e.Location);
            }
            else if (_modoActual == ModoDibujo.Poligono)
            {
                ManejarClickPoligono(e.Location);
            }

            picturebxCP.Invalidate();
        }

        // === Definir ventana rectangular con 2 clics ===
        private void ManejarClickVentana(Point p)
        {
            if (!_tienePrimerPuntoVentana)
            {
                _primerPuntoVentana = p;
                _tienePrimerPuntoVentana = true;

                int r = 3;
                _gCP.FillEllipse(Brushes.Black, p.X - r, p.Y - r, 2 * r, 2 * r);
            }
            else
            {
                int x1 = _primerPuntoVentana.X;
                int y1 = _primerPuntoVentana.Y;
                int x2 = p.X;
                int y2 = p.Y;

                int left = Math.Min(x1, x2);
                int top = Math.Min(y1, y2);
                int width = Math.Abs(x2 - x1);
                int height = Math.Abs(y2 - y1);

                _clipWindow = new Rectangle(left, top, width, height);
                _ventanaDefinida = true;

                using (Pen penVentana = new Pen(Color.Black, 2))
                {
                    _gCP.DrawRectangle(penVentana, _clipWindow);
                }

                _tienePrimerPuntoVentana = false;
            }
        }

        // === Dibujar polígono por clics ===
        private void ManejarClickPoligono(Point p)
        {
            PointF pf = new PointF(p.X, p.Y);
            _poligono.Add(pf);

            int r = 3;
            _gCP.FillEllipse(Brushes.Red, p.X - r, p.Y - r, 2 * r, 2 * r);

            if (_tieneVerticePrevio)
            {
                using (Pen penPolig = new Pen(Color.Blue, 1))
                {
                    _gCP.DrawLine(penPolig, _verticePrevio, pf);
                }
            }

            _verticePrevio = pf;
            _tieneVerticePrevio = true;
        }

        // ================== BOTÓN POLÍGONO ==================
        private void btnPoligonoCP_Click(object sender, EventArgs e)
        {
            if (!_ventanaDefinida)
            {
                MessageBox.Show("Primero define la ventana de recorte con dos clics sobre el lienzo.");
                return;
            }

            _modoActual = ModoDibujo.Poligono;
            _poligono.Clear();
            _tieneVerticePrevio = false;
        }

        // ================== BOTÓN CORTAR ==================
        private void btnCortarCP_Click(object sender, EventArgs e)
        {
            if (!_ventanaDefinida)
            {
                MessageBox.Show("Primero define la ventana de recorte.");
                return;
            }

            if (_poligono.Count < 3)
            {
                MessageBox.Show("Dibuja un polígono con al menos 3 vértices.");
                return;
            }

            // Clipping
            List<PointF> poligonoRecortado = SutherlandHodgmanClipper.ClipPolygon(_clipWindow, _poligono);

            // Redibujar todo
            _gCP.Clear(Color.White);

            // Ventana
            using (Pen penVentana = new Pen(Color.Black, 2))
            {
                _gCP.DrawRectangle(penVentana, _clipWindow);
            }

            // Polígono original en gris
            using (Pen penOriginal = new Pen(Color.LightGray, 1))
            {
                DibujarPoligono(_gCP, penOriginal, _poligono);
            }

            // Polígono recortado en verde
            using (Pen penClipped = new Pen(Color.Green, 2))
            {
                DibujarPoligono(_gCP, penClipped, poligonoRecortado);
            }

            picturebxCP.Invalidate();
        }

        private void DibujarPoligono(Graphics g, Pen pen, List<PointF> puntos)
        {
            if (puntos == null || puntos.Count < 2)
                return;

            for (int i = 0; i < puntos.Count; i++)
            {
                PointF a = puntos[i];
                PointF b = puntos[(i + 1) % puntos.Count]; // cerrar polígono
                g.DrawLine(pen, a, b);
            }
        }

        // ================== BOTÓN RESET ==================
        private void btnResetCP_Click(object sender, EventArgs e)
        {
            InicializarLienzoCP();
        }
    }
}
