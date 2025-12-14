using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace TAR2_P2_ALGORITMOS_GRAFICA.Vistas
{
    public partial class RellenoFloodFill : Form
    {
        private static RellenoFloodFill instancia = null;
        public static RellenoFloodFill Instancia
        {
            get
            {
                if (instancia == null || instancia.IsDisposed)
                    instancia = new RellenoFloodFill();
                return instancia;
            }
        }

        // --- Dibujo ---
        private Bitmap lienzo;
        private Graphics g;
        private bool tienePuntoPrevio = false;
        private Point puntoPrevio;

        // --- Relleno / animación ---
        private bool modoRelleno = false;
        private Color colorRelleno = Color.Yellow;
        private Color colorObjetivoFlood;
        private Stack<Point> pilaFlood;     // Pila para FloodFill
        private bool floodEnProgreso = false;

        public RellenoFloodFill()
        {
            InitializeComponent();
            InicializarLienzo();

            pictureBoxPaint.MouseClick += pictureBoxPaint_MouseClick;
            btnReset.Click += btnReset_Click;
            btnRellenar.Click += btnRellenar_Click;

            // configurar timerPaint (ya lo tienes en el diseñador)
            timerPaint.Interval = 10;           // ajusta velocidad
            timerPaint.Tick += timerPaint_Tick;
        }

        private void InicializarLienzo()
        {
            lienzo = new Bitmap(pictureBoxPaint.Width, pictureBoxPaint.Height);
            g = Graphics.FromImage(lienzo);
            g.Clear(Color.White);
            pictureBoxPaint.Image = lienzo;

            tienePuntoPrevio = false;
            listBoxCalculos.Items.Clear();

            // por si se estaba rellenando
            floodEnProgreso = false;
            timerPaint.Stop();
        }

        // ------------- DIBUJO CON EL MOUSE -------------
        private void pictureBoxPaint_MouseClick(object sender, MouseEventArgs e)
        {
            if (modoRelleno)
            {
                // iniciar flood animado
                IniciarFloodFillAnimado(e.Location.X, e.Location.Y);
                modoRelleno = false;
                return;
            }

            // modo dibujo bordes
            Point p = e.Location;

            int r = 3;
            g.FillEllipse(Brushes.Red, p.X - r, p.Y - r, 2 * r, 2 * r);

            if (tienePuntoPrevio)
            {
                g.DrawLine(Pens.Blue, puntoPrevio, p);
            }

            puntoPrevio = p;
            tienePuntoPrevio = true;

            pictureBoxPaint.Invalidate();
        }

        // ------------- BOTONES -------------
        private void btnRellenar_Click(object sender, EventArgs e)
        {
            if (floodEnProgreso) return;
            modoRelleno = true;
            MessageBox.Show("Haz clic dentro de la figura para aplicar Flood Fill (animado).");
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            InicializarLienzo();
        }

        // ------------- FLOOD FILL ANIMADO -------------
        private void IniciarFloodFillAnimado(int xInicio, int yInicio)
        {
            if (xInicio < 0 || xInicio >= lienzo.Width ||
                yInicio < 0 || yInicio >= lienzo.Height)
                return;

            colorObjetivoFlood = lienzo.GetPixel(xInicio, yInicio);

            // si ya está relleno, salimos
            if (colorObjetivoFlood.ToArgb() == colorRelleno.ToArgb())
                return;

            pilaFlood = new Stack<Point>();
            pilaFlood.Push(new Point(xInicio, yInicio));

            floodEnProgreso = true;
            timerPaint.Start();
        }

        private void timerPaint_Tick(object sender, EventArgs e)
        {
            if (!floodEnProgreso || pilaFlood == null || pilaFlood.Count == 0)
            {
                timerPaint.Stop();
                floodEnProgreso = false;
                return;
            }

            // cuantos píxeles pintamos por tick (ajusta para más/menos velocidad)
            int pasosPorTick = 30;

            for (int i = 0; i < pasosPorTick && pilaFlood.Count > 0; i++)
            {
                Point p = pilaFlood.Pop();
                int x = p.X;
                int y = p.Y;

                if (x < 0 || x >= lienzo.Width || y < 0 || y >= lienzo.Height)
                    continue;

                if (lienzo.GetPixel(x, y).ToArgb() != colorObjetivoFlood.ToArgb())
                    continue;

                // pintar
                lienzo.SetPixel(x, y, colorRelleno);
                listBoxCalculos.Items.Add($"({x}, {y})");

                // vecinos en orden N, E, S, O
                pilaFlood.Push(new Point(x - 1, y)); // O
                pilaFlood.Push(new Point(x, y + 1)); // S
                pilaFlood.Push(new Point(x + 1, y)); // E
                pilaFlood.Push(new Point(x, y - 1)); // N
            }

            pictureBoxPaint.Invalidate();
        }

        private void btnReset_Click_1(object sender, EventArgs e)
        {

        }
    }
}
