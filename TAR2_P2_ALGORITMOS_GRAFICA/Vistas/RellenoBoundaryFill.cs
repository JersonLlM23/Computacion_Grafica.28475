using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TAR2_P2_ALGORITMOS_GRAFICA.Controlador;

namespace TAR2_P2_ALGORITMOS_GRAFICA.Vistas
{
    public partial class BoundaryFill : Form
    {
        private static BoundaryFill instancia = null;
        public static BoundaryFill Instancia
        {
            get
            {
                if (instancia == null || instancia.IsDisposed)
                    instancia = new BoundaryFill();
                return instancia;
            }
        }
        private Bitmap lienzo3;
        private Graphics g3;
        private bool tienePuntoPrevio3 = false;
        private Point puntoPrevio3;

        
        private bool modoRelleno3 = false;
        private bool boundaryEnProgreso3 = false;
        private Stack<Point> pilaBoundary3;
        private Color fillColor3 = Color.Yellow;   // color de relleno
        private Color borderColor3 = Color.Blue;   // color de borde (líneas)

        public BoundaryFill()
        {
            InitializeComponent();
            InicializarLienzo3();

            pictureBoxPaint3.MouseClick += pictureBoxPaint3_MouseClick;
            btnReset3.Click += btnReset3_Click;
            btnRellenar3.Click += btnRellenar3_Click;

 
            timerPaint3.Interval = 10; // ajusta velocidad
            timerPaint3.Tick += timerPaint3_Tick;
        }

        private void InicializarLienzo3()
        {
            lienzo3 = new Bitmap(pictureBoxPaint3.Width, pictureBoxPaint3.Height);
            g3 = Graphics.FromImage(lienzo3);
            g3.Clear(Color.White);
            pictureBoxPaint3.Image = lienzo3;

            tienePuntoPrevio3 = false;
            listBoxCalculos3.Items.Clear();

            boundaryEnProgreso3 = false;
            timerPaint3.Stop();
            modoRelleno3 = false;
        }
        // ================== CLICK EN PICTUREBOX ==================
        private void pictureBoxPaint3_MouseClick(object sender, MouseEventArgs e)
        {
            if (modoRelleno3)
            {
                // Iniciar boundary fill animado desde el punto semilla
                IniciarBoundaryFillAnimado(e.Location);
                modoRelleno3 = false;
                return;
            }

            // --- Modo dibujo de bordes ---
            Point p = e.Location;
            int r = 3;

            // Punto rojo
            g3.FillEllipse(Brushes.Red, p.X - r, p.Y - r, 2 * r, 2 * r);

            // Líneas de borde en azul
            if (tienePuntoPrevio3)
            {
                using (Pen penBorde = new Pen(borderColor3, 1))
                {
                    g3.DrawLine(penBorde, puntoPrevio3, p);
                }
            }

            puntoPrevio3 = p;
            tienePuntoPrevio3 = true;

            pictureBoxPaint3.Invalidate();
        }

        // ================== BOTONES ==================
        private void btnRellenar3_Click(object sender, EventArgs e)
        {
            if (boundaryEnProgreso3) return;
            modoRelleno3 = true;
            MessageBox.Show("Haz clic dentro de la figura para aplicar Boundary Fill (animado).");
        }

        private void btnReset3_Click(object sender, EventArgs e)
        {
            InicializarLienzo3();
        }

        // ================== INICIO BOUNDARY FILL ANIMADO ==================
        private void IniciarBoundaryFillAnimado(Point seed)
        {
            int sx = seed.X;
            int sy = seed.Y;

            if (sx < 0 || sx >= lienzo3.Width || sy < 0 || sy >= lienzo3.Height)
                return;

            Color cSeed = lienzo3.GetPixel(sx, sy);

            // Si el punto es borde o ya está relleno, no sirve como semilla
            if (cSeed.ToArgb() == borderColor3.ToArgb() ||
                cSeed.ToArgb() == fillColor3.ToArgb())
            {
                MessageBox.Show("El punto semilla debe estar dentro de la figura (no sobre el borde ni zona ya rellenada).");
                return;
            }

            pilaBoundary3 = new Stack<Point>();
            pilaBoundary3.Push(new Point(sx, sy));

            listBoxCalculos3.Items.Clear();
            boundaryEnProgreso3 = true;
            timerPaint3.Start();
        }

        // ================== TIMER: BOUNDARY FILL PASO A PASO ==================
        private void timerPaint3_Tick(object sender, EventArgs e)
        {
            if (!boundaryEnProgreso3 || pilaBoundary3 == null || pilaBoundary3.Count == 0)
            {
                timerPaint3.Stop();
                boundaryEnProgreso3 = false;
                return;
            }

            int pasosPorTick = 30; // píxeles que se pintan en cada tick

            for (int i = 0; i < pasosPorTick && pilaBoundary3.Count > 0; i++)
            {
                Point p = pilaBoundary3.Pop();
                int x = p.X;
                int y = p.Y;

                if (x < 0 || x >= lienzo3.Width || y < 0 || y >= lienzo3.Height)
                    continue;

                Color c = lienzo3.GetPixel(x, y);

                // si es borde o ya está relleno, no seguimos
                if (c.ToArgb() == borderColor3.ToArgb() ||
                    c.ToArgb() == fillColor3.ToArgb())
                    continue;

                // pintar
                lienzo3.SetPixel(x, y, fillColor3);
                listBoxCalculos3.Items.Add($"({x}, {y})");

                // vecinos 4-conectados (N, E, S, O).
                // Como usamos pila, los empujamos en orden inverso para que se procesen más o menos NESO.
                pilaBoundary3.Push(new Point(x - 1, y)); // O
                pilaBoundary3.Push(new Point(x, y + 1)); // S
                pilaBoundary3.Push(new Point(x + 1, y)); // E
                pilaBoundary3.Push(new Point(x, y - 1)); // N
            }

            pictureBoxPaint3.Invalidate();
        }

        private void btnReset3_Click_1(object sender, EventArgs e)
        {

        }
    }
}
