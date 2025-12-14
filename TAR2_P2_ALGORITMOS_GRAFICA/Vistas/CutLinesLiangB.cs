using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using TAR2_P2_ALGORITMOS_GRAFICA.Algoritmos;

namespace TAR2_P2_ALGORITMOS_GRAFICA.Vistas
{
    public partial class CutLinesLiangB : Form
    {
        // Singleton si quieres usarlo igual que los otros forms
        private static CutLinesLiangB instancia = null;
        public static CutLinesLiangB Instancia
        {
            get
            {
                if (instancia == null || instancia.IsDisposed)
                    instancia = new CutLinesLiangB();
                return instancia;
            }
        }

        // === Lienzo ===
        private Bitmap _lienzo2;
        private Graphics _g2;

        // Modo de dibujo
        private enum ModoDibujo
        {
            Ventana,
            Lineas
        }

        private ModoDibujo _modoActual = ModoDibujo.Ventana;

        // === Ventana de recorte ===
        private bool _tienePrimerPuntoVentana = false;
        private Point _primerPuntoVentana;
        private Rectangle _clipWindow;
        private bool _ventanaDefinida = false;

        // === Líneas ===
        private bool _tienePuntoLineaPrevio = false;
        private Point _puntoLineaPrevio;
        private List<Tuple<Point, Point>> _lineas = new List<Tuple<Point, Point>>();

        public CutLinesLiangB()
        {
            InitializeComponent();
            InicializarLienzo2();

            picturebxCL2.MouseClick += picturebxCL2_MouseClick;
            btnLinea2.Click += btnLinea2_Click;
            btnCortar2.Click += btnCortar2_Click;
            btnResetCL2.Click += btnResetCL2_Click;
        }

        private void InicializarLienzo2()
        {
            _lienzo2 = new Bitmap(picturebxCL2.Width, picturebxCL2.Height);
            _g2 = Graphics.FromImage(_lienzo2);
            _g2.Clear(Color.White);
            picturebxCL2.Image = _lienzo2;

            _modoActual = ModoDibujo.Ventana;

            _tienePrimerPuntoVentana = false;
            _ventanaDefinida = false;

            _tienePuntoLineaPrevio = false;
            _lineas.Clear();
        }

        // =============== CLICK EN PICTUREBOX ===============
        private void picturebxCL2_MouseClick(object sender, MouseEventArgs e)
        {
            if (_modoActual == ModoDibujo.Ventana)
            {
                ManejarClickVentana(e.Location);
            }
            else if (_modoActual == ModoDibujo.Lineas)
            {
                ManejarClickLinea(e.Location);
            }

            picturebxCL2.Invalidate();
        }

        // === Definir ventana de recorte con 2 clics ===
        private void ManejarClickVentana(Point p)
        {
            if (!_tienePrimerPuntoVentana)
            {
                _primerPuntoVentana = p;
                _tienePrimerPuntoVentana = true;

                // pequeño punto de referencia
                int r = 3;
                _g2.FillEllipse(Brushes.Black, p.X - r, p.Y - r, 2 * r, 2 * r);
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
                    _g2.DrawRectangle(penVentana, _clipWindow);
                }

                _tienePrimerPuntoVentana = false;
            }
        }

        // === Dibujar líneas con clic (modo líneas) ===
        private void ManejarClickLinea(Point p)
        {
            int r = 3;
            _g2.FillEllipse(Brushes.DarkRed, p.X - r, p.Y - r, 2 * r, 2 * r);

            if (_tienePuntoLineaPrevio)
            {
                _lineas.Add(Tuple.Create(_puntoLineaPrevio, p));

                using (Pen penLinea = new Pen(Color.Blue, 1)) // color de las líneas “originales”
                {
                    _g2.DrawLine(penLinea, _puntoLineaPrevio, p);
                }

                _tienePuntoLineaPrevio = false; // cada par de clics = una línea
            }
            else
            {
                _puntoLineaPrevio = p;
                _tienePuntoLineaPrevio = true;
            }
        }

        // =============== BOTÓN LINEA2 ===============
        private void btnLinea2_Click(object sender, EventArgs e)
        {
            if (!_ventanaDefinida)
            {
                MessageBox.Show("Primero define la ventana de recorte (dos clics sobre el lienzo).");
                return;
            }

            _modoActual = ModoDibujo.Lineas;
            _tienePuntoLineaPrevio = false;
        }

        // =============== BOTÓN CORTAR2 ===============
        private void btnCortar2_Click(object sender, EventArgs e)
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

            var clipper = new LiangBarskyClipper(_clipWindow);

            // Limpiamos y redibujamos
            _g2.Clear(Color.White);

            // Ventana
            using (Pen penVentana = new Pen(Color.Black, 2))
            {
                _g2.DrawRectangle(penVentana, _clipWindow);
            }

            // Líneas originales en gris claro
            using (Pen penOriginal = new Pen(Color.LightGray, 1))
            {
                foreach (var seg in _lineas)
                {
                    _g2.DrawLine(penOriginal, seg.Item1, seg.Item2);
                }
            }

            // Líneas recortadas en otro color (verde, por ejemplo)
            using (Pen penClipped = new Pen(Color.Green, 2))
            {
                foreach (var seg in _lineas)
                {
                    PointF p0 = seg.Item1;
                    PointF p1 = seg.Item2;

                    if (clipper.ClipLine(ref p0, ref p1))
                    {
                        _g2.DrawLine(penClipped, p0, p1);
                    }
                }
            }

            picturebxCL2.Invalidate();
        }

        // =============== BOTÓN RESET2 ===============
        private void btnResetCL2_Click(object sender, EventArgs e)
        {
            InicializarLienzo2();
        }
    }
}
