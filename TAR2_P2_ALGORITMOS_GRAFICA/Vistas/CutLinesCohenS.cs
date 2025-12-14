using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using TAR2_P2_ALGORITMOS_GRAFICA.Algoritmos;

namespace TAR2_P2_ALGORITMOS_GRAFICA.Vistas
{
    public partial class CutLinesCohenS : Form
    {
        private static CutLinesCohenS instancia = null;
        public static CutLinesCohenS Instancia
        {
            get
            {
                if (instancia == null || instancia.IsDisposed)
                    instancia = new CutLinesCohenS();
                return instancia;
            }
        }

        // === Lienzo ===
        private Bitmap _lienzo;
        private Graphics _g;

        // === Modo de dibujo ===
        private enum ModoDibujo
        {
            Ventana,  // definir rectángulo de recorte
            Lineas    // dibujar líneas
        }

        private ModoDibujo _modoActual = ModoDibujo.Ventana;

        // === Ventana de recorte (rectángulo) ===
        private bool _tienePrimerPuntoVentana = false;
        private Point _primerPuntoVentana;
        private Rectangle _clipWindow;
        private bool _ventanaDefinida = false;

        // === Líneas ===
        private bool _tienePuntoLineaPrevio = false;
        private Point _puntoLineaPrevio;
        private List<Tuple<Point, Point>> _lineas = new List<Tuple<Point, Point>>();
        public CutLinesCohenS()
        {
            InitializeComponent();
            InicializarLienzo();

            picturebxCL3.MouseClick += picturebxCL_MouseClick;
            btnLinea3.Click += btnLinea_Click;
            btnCortar3.Click += btnCortar_Click;
            btnReset3.Click += btnResetCL_Click;   // <-- aquí
        }


        private void InicializarLienzo()
        {
            _lienzo = new Bitmap(picturebxCL3.Width, picturebxCL3.Height);
            _g = Graphics.FromImage(_lienzo);
            _g.Clear(Color.White);
            picturebxCL3.Image = _lienzo;

            _modoActual = ModoDibujo.Ventana;
            _tienePrimerPuntoVentana = false;
            _ventanaDefinida = false;

            _tienePuntoLineaPrevio = false;
            _lineas.Clear();
        }

        // ================== EVENTO CLICK EN EL LIENZO ==================
        private void picturebxCL_MouseClick(object sender, MouseEventArgs e)
        {
            if (_modoActual == ModoDibujo.Ventana)
            {
                ManejarClickVentana(e.Location);
            }
            else if (_modoActual == ModoDibujo.Lineas)
            {
                ManejarClickLinea(e.Location);
            }

            picturebxCL3.Invalidate();
        }

        // === Definir ventana de recorte con 2 clics (rectángulo) ===
        private void ManejarClickVentana(Point p)
        {
            if (!_tienePrimerPuntoVentana)
            {
                _primerPuntoVentana = p;
                _tienePrimerPuntoVentana = true;

                // Dibujo un pequeño punto para referencia
                int r = 3;
                _g.FillEllipse(Brushes.Black, p.X - r, p.Y - r, 2 * r, 2 * r);
            }
            else
            {
                // Segundo punto → definimos el rectángulo
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

                // Dibujar rectángulo como "polígono" de recorte
                using (Pen penVentana = new Pen(Color.Black, 2))
                {
                    _g.DrawRectangle(penVentana, _clipWindow);
                }

                _tienePrimerPuntoVentana = false;
            }
        }

        private void btnResetCL_Click(object sender, EventArgs e)
        {
            InicializarLienzo();
        }


        // === Dibujar líneas con clic (modo línea) ===
        private void ManejarClickLinea(Point p)
        {
            int r = 3;
            _g.FillEllipse(Brushes.DarkRed, p.X - r, p.Y - r, 2 * r, 2 * r);

            if (_tienePuntoLineaPrevio)
            {
                // Guardamos la línea y la dibujamos
                _lineas.Add(Tuple.Create(_puntoLineaPrevio, p));

                using (Pen penLinea = new Pen(Color.Blue, 1))
                {
                    _g.DrawLine(penLinea, _puntoLineaPrevio, p);
                }

                _tienePuntoLineaPrevio = false; // si quieres que cada par de clics sea una línea independiente
            }
            else
            {
                _puntoLineaPrevio = p;
                _tienePuntoLineaPrevio = true;
            }
        }

        // ================== BOTÓN LINEA ==================
        private void btnLinea_Click(object sender, EventArgs e)
        {
            if (!_ventanaDefinida)
            {
                MessageBox.Show("Primero define la ventana de recorte (dos clics en el lienzo).");
                return;
            }

            _modoActual = ModoDibujo.Lineas;
            _tienePuntoLineaPrevio = false;
        }

        // ================== BOTÓN CORTAR ==================
        private void btnCortar_Click(object sender, EventArgs e)
        {
            if (!_ventanaDefinida)
            {
                MessageBox.Show("Primero define la ventana de recorte.");
                return;
            }

            if (_lineas.Count == 0)
            {
                MessageBox.Show("No hay líneas para recortar.");
                return;
            }

            // Creamos el clipper Cohen–Sutherland
            var clipper = new CohenSutherlandClipper(_clipWindow);

            // Redibujamos todo: limpiamos y volvemos a dibujar ventana + líneas originales
            _g.Clear(Color.White);

            using (Pen penVentana = new Pen(Color.Black, 2))
            {
                _g.DrawRectangle(penVentana, _clipWindow);
            }

            // Dibujar las líneas originales en gris
            using (Pen penOriginal = new Pen(Color.LightGray, 1))
            {
                foreach (var seg in _lineas)
                {
                    _g.DrawLine(penOriginal, seg.Item1, seg.Item2);
                }
            }

            // Aplicar recorte y dibujar resultados en otro color
            using (Pen penClipped = new Pen(Color.Red, 2))
            {
                foreach (var seg in _lineas)
                {
                    PointF p0 = seg.Item1;
                    PointF p1 = seg.Item2;

                    if (clipper.ClipLine(ref p0, ref p1))
                    {
                        _g.DrawLine(penClipped, p0, p1);
                    }
                }
            }

            picturebxCL3.Invalidate();
        }
    }
}
