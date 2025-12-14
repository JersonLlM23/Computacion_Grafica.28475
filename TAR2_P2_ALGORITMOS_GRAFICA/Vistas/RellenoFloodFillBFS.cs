using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace TAR2_P2_ALGORITMOS_GRAFICA.Vistas
{
    public partial class RellenoFloodFillBFS : Form
    {
        private static RellenoFloodFillBFS instancia = null;
        public static RellenoFloodFillBFS Instancia
        {
            get
            {
                if (instancia == null || instancia.IsDisposed)
                    instancia = new RellenoFloodFillBFS();
                return instancia;
            }
        }
        // --- Dibujo ---
        private Bitmap lienzo2;
        private Graphics g2;
        private bool tienePuntoPrevio2 = false;
        private Point puntoPrevio2;

        // --- Relleno BFS (cola) + animación ---
        private bool modoRelleno2 = false;
        private bool floodEnProgreso2 = false;
        private Color fillColor2 = Color.Yellow;
        private Color colorObjetivo2;
        private Queue<Point> colaFlood2;
        private bool[,] visitado2;


        public RellenoFloodFillBFS()
        {
            InitializeComponent();
            InicializarLienzo2();

            pictureBoxPaint2.MouseClick += pictureBoxPaint2_MouseClick;
            btnReset2.Click += btnReset2_Click;
            btnRellenar2.Click += btnRellenar2_Click;

          
            timerPaint2.Interval = 10;         
            timerPaint2.Tick += timerPaint2_Tick;
        }
        // ==== Lienzo ====
        private void InicializarLienzo2()
        {
            lienzo2 = new Bitmap(pictureBoxPaint2.Width, pictureBoxPaint2.Height);
            g2 = Graphics.FromImage(lienzo2);
            g2.Clear(Color.White);
            pictureBoxPaint2.Image = lienzo2;

            tienePuntoPrevio2 = false;
            listBoxCalculos2.Items.Clear();

            floodEnProgreso2 = false;
            timerPaint2.Stop();
        }

        // ==== Click en pictureBoxPaint2 ====
        private void pictureBoxPaint2_MouseClick(object sender, MouseEventArgs e)
        {
            if (modoRelleno2)
            {
                if (!floodEnProgreso2)
                    IniciarFloodFillBFS(e.Location);
                modoRelleno2 = false;
                return;
            }

            // --- modo dibujo de bordes ---
            Point p = e.Location;

            int r = 3;
            g2.FillEllipse(Brushes.Red, p.X - r, p.Y - r, 2 * r, 2 * r);

            if (tienePuntoPrevio2)
            {
                g2.DrawLine(Pens.Blue, puntoPrevio2, p);
            }

            puntoPrevio2 = p;
            tienePuntoPrevio2 = true;

            pictureBoxPaint2.Invalidate();
        }

        // ==== Botones ====
        private void btnReset2_Click(object sender, EventArgs e)
        {
            InicializarLienzo2();
        }

        private void btnRellenar2_Click(object sender, EventArgs e)
        {
            if (floodEnProgreso2) return;
            modoRelleno2 = true;
            MessageBox.Show("Haz clic dentro de la figura para aplicar Flood Fill (cola/BFS).");
        }

        // ==== Inicio del Flood Fill con cola (BFS) ====
        private void IniciarFloodFillBFS(Point seed)
        {
            int sx = seed.X;
            int sy = seed.Y;

            if (sx < 0 || sx >= lienzo2.Width || sy < 0 || sy >= lienzo2.Height)
                return;

            colorObjetivo2 = lienzo2.GetPixel(sx, sy);

    
            if (colorObjetivo2.ToArgb() == fillColor2.ToArgb() ||
                colorObjetivo2.ToArgb() == Color.Blue.ToArgb() ||
                colorObjetivo2.ToArgb() == Color.Red.ToArgb())
            {
                MessageBox.Show("El punto semilla debe estar dentro de la figura (zona de fondo).");
                return;
            }

            visitado2 = new bool[lienzo2.Width, lienzo2.Height];
            colaFlood2 = new Queue<Point>();
            colaFlood2.Enqueue(new Point(sx, sy));

            floodEnProgreso2 = true;
            timerPaint2.Start();
        }

        // ==== Timer: animación de relleno ====
        private void timerPaint2_Tick(object sender, EventArgs e)
        {
            if (!floodEnProgreso2 || colaFlood2 == null || colaFlood2.Count == 0)
            {
                timerPaint2.Stop();
                floodEnProgreso2 = false;
                return;
            }

            int pasosPorTick = 30; 

            for (int i = 0; i < pasosPorTick && colaFlood2.Count > 0; i++)
            {
                Point p = colaFlood2.Dequeue();
                int x = p.X;
                int y = p.Y;

                if (x < 0 || x >= lienzo2.Width || y < 0 || y >= lienzo2.Height)
                    continue;

                if (visitado2[x, y])
                    continue;

                Color actual = lienzo2.GetPixel(x, y);

                if (actual.ToArgb() != colorObjetivo2.ToArgb())
                    continue;

                visitado2[x, y] = true;

                // pintar pixel
                lienzo2.SetPixel(x, y, fillColor2);
                listBoxCalculos2.Items.Add($"({x}, {y})");

             
                colaFlood2.Enqueue(new Point(x, y - 1)); // N
                colaFlood2.Enqueue(new Point(x + 1, y)); // E
                colaFlood2.Enqueue(new Point(x, y + 1)); // S
                colaFlood2.Enqueue(new Point(x - 1, y)); // O
            }

            pictureBoxPaint2.Invalidate();
        }

        private void btnReset2_Click_1(object sender, EventArgs e)
        {

        }
    }
}
