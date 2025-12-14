using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using TAR2_P2_ALGORITMOS_GRAFICA.Controlador;

namespace TAR2_P2_ALGORITMOS_GRAFICA.Vistas
{
    public partial class cutPoligWeilerA : Form
    {
        private static cutPoligWeilerA instancia = null;
        public static cutPoligWeilerA Instancia
        {
            get
            {
                if (instancia == null || instancia.IsDisposed)
                    instancia = new cutPoligWeilerA();
                return instancia;
            }
        }

        private Bitmap _lienzoCP3;
        private Graphics _gCP3;

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

        public cutPoligWeilerA()
        {
            InitializeComponent();
            InicializarLienzoCP3();

            picturebxCP3.MouseClick += picturebxCP3_MouseClick;
            btnPoligonoCP3.Click += btnPoligonoCP3_Click;
            btnCortarCP3.Click += btnCortarCP3_Click;
            btnResetCP3.Click += btnResetCP3_Click;
        }

        private void InicializarLienzoCP3()
        {
            _lienzoCP3 = new Bitmap(picturebxCP3.Width, picturebxCP3.Height);
            _gCP3 = Graphics.FromImage(_lienzoCP3);
            _gCP3.Clear(Color.White);
            picturebxCP3.Image = _lienzoCP3;

            _modoActual = ModoDibujo.Ventana;

            _tienePrimerPuntoVentana = false;
            _ventanaDefinida = false;

            _poligono.Clear();
            _tieneVerticePrevio = false;
        }

        private void picturebxCP3_MouseClick(object sender, MouseEventArgs e)
        {
            if (_modoActual == ModoDibujo.Ventana)
            {
                ManejarClickVentana(e.Location);
            }
            else if (_modoActual == ModoDibujo.Poligono)
            {
                ManejarClickPoligono(e.Location);
            }

            picturebxCP3.Invalidate();
        }

        private void ManejarClickVentana(Point p)
        {
            if (!_tienePrimerPuntoVentana)
            {
                _primerPuntoVentana = p;
                _tienePrimerPuntoVentana = true;

                int r = 3;
                _gCP3.FillEllipse(Brushes.Black, p.X - r, p.Y - r, 2 * r, 2 * r);
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
                    _gCP3.DrawRectangle(penVentana, _clipWindow);
                }

                _tienePrimerPuntoVentana = false;
            }
        }

        private void ManejarClickPoligono(Point p)
        {
            PointF pf = new PointF(p.X, p.Y);
            _poligono.Add(pf);

            int r = 3;
            _gCP3.FillEllipse(Brushes.Red, p.X - r, p.Y - r, 2 * r, 2 * r);

            if (_tieneVerticePrevio)
            {
                using (Pen penPolig = new Pen(Color.Blue, 1))
                {
                    _gCP3.DrawLine(penPolig, _verticePrevio, pf);
                }
            }

            _verticePrevio = pf;
            _tieneVerticePrevio = true;
        }

        private void btnPoligonoCP3_Click(object sender, EventArgs e)
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

        private void btnCortarCP3_Click(object sender, EventArgs e)
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

            // Aquí, no necesitamos crear una instancia de la clase estática
            var poligonoRecortado = WeilerAthertonClipper.ClipPolygon(_clipWindow, _poligono);

            // Limpiamos y redibujamos
            _gCP3.Clear(Color.White);

            // Ventana
            using (Pen penVentana = new Pen(Color.Black, 2))
            {
                _gCP3.DrawRectangle(penVentana, _clipWindow);
            }

            // Polígono original en gris
            using (Pen penOriginal = new Pen(Color.LightGray, 1))
            {
                DibujarPoligono(_gCP3, penOriginal, _poligono);
            }

            // Polígono recortado en verde
            using (Pen penClipped = new Pen(Color.Green, 2))
            {
                DibujarPoligono(_gCP3, penClipped, poligonoRecortado);
            }

            picturebxCP3.Invalidate();
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

        private void btnResetCP3_Click(object sender, EventArgs e)
        {
            InicializarLienzoCP3();
        }
    }
}
