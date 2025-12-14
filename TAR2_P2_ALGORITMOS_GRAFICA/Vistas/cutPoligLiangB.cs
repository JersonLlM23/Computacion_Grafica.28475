using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using TAR2_P2_ALGORITMOS_GRAFICA.Controlador;

namespace TAR2_P2_ALGORITMOS_GRAFICA.Vistas
{
    public partial class cutPoligLiangB : Form
    {
        private static cutPoligLiangB instancia = null;
        public static cutPoligLiangB Instancia
        {
            get
            {
                if (instancia == null || instancia.IsDisposed)
                    instancia = new cutPoligLiangB();
                return instancia;
            }
        }

        private Bitmap _lienzoCP2;
        private Graphics _gCP2;

        private enum ModoDibujo
        {
            Ventana,
            Poligono
        }

        private ModoDibujo _modoActual = ModoDibujo.Ventana;

        private bool _tienePrimerPuntoVentana = false;
        private Point _primerPuntoVentana;
        private Rectangle _clipWindow;
        private bool _ventanaDefinida = false;

        private List<PointF> _poligono = new List<PointF>();
        private bool _tieneVerticePrevio = false;
        private PointF _verticePrevio;

        public cutPoligLiangB()
        {
            InitializeComponent();
            InicializarLienzoCP2();

            picturebxCP2.MouseClick += picturebxCP2_MouseClick;
            btnPoligonoCP2.Click += btnPoligonoCP2_Click;
            btnCortarCP2.Click += btnCortarCP2_Click;
            btnResetCP2.Click += btnResetCP2_Click;
        }

        private void InicializarLienzoCP2()
        {
            _lienzoCP2 = new Bitmap(picturebxCP2.Width, picturebxCP2.Height);
            _gCP2 = Graphics.FromImage(_lienzoCP2);
            _gCP2.Clear(Color.White);
            picturebxCP2.Image = _lienzoCP2;

            _modoActual = ModoDibujo.Ventana;

            _tienePrimerPuntoVentana = false;
            _ventanaDefinida = false;

            _poligono.Clear();
            _tieneVerticePrevio = false;
        }

        private void picturebxCP2_MouseClick(object sender, MouseEventArgs e)
        {
            if (_modoActual == ModoDibujo.Ventana)
            {
                ManejarClickVentana(e.Location);
            }
            else if (_modoActual == ModoDibujo.Poligono)
            {
                ManejarClickPoligono(e.Location);
            }

            picturebxCP2.Invalidate();
        }

        private void ManejarClickVentana(Point p)
        {
            if (!_tienePrimerPuntoVentana)
            {
                _primerPuntoVentana = p;
                _tienePrimerPuntoVentana = true;

                int r = 3;
                _gCP2.FillEllipse(Brushes.Black, p.X - r, p.Y - r, 2 * r, 2 * r);
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
                    _gCP2.DrawRectangle(penVentana, _clipWindow);
                }

                _tienePrimerPuntoVentana = false;
            }
        }

        private void ManejarClickPoligono(Point p)
        {
            PointF pf = new PointF(p.X, p.Y);
            _poligono.Add(pf);

            int r = 3;
            _gCP2.FillEllipse(Brushes.Red, p.X - r, p.Y - r, 2 * r, 2 * r);

            if (_tieneVerticePrevio)
            {
                using (Pen penPolig = new Pen(Color.Blue, 1))
                {
                    _gCP2.DrawLine(penPolig, _verticePrevio, pf);
                }
            }

            _verticePrevio = pf;
            _tieneVerticePrevio = true;
        }

        private void btnPoligonoCP2_Click(object sender, EventArgs e)
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

        private void btnCortarCP2_Click(object sender, EventArgs e)
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

            var clipper = new LiangBarskyClipper(_clipWindow);

            // Limpiamos y redibujamos
            _gCP2.Clear(Color.White);

            // Ventana
            using (Pen penVentana = new Pen(Color.Black, 2))
            {
                _gCP2.DrawRectangle(penVentana, _clipWindow);
            }

            // Polígono original en gris
            using (Pen penOriginal = new Pen(Color.LightGray, 1))
            {
                DibujarPoligono(_gCP2, penOriginal, _poligono);
            }

            // Polígono recortado en verde
            using (Pen penClipped = new Pen(Color.Green, 2))
            {
                List<PointF> poligonoRecortado = clipper.ClipPolygon(_poligono);
                DibujarPoligono(_gCP2, penClipped, poligonoRecortado);
            }

            picturebxCP2.Invalidate();
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

        private void btnResetCP2_Click(object sender, EventArgs e)
        {
            InicializarLienzoCP2();
        }
    }
}
