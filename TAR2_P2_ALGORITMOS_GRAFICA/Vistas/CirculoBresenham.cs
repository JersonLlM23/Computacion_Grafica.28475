using System;
using System.Drawing;
using System.Windows.Forms;
using TAR2_P2_ALGORITMOS_GRAFICA.Controladores;

namespace TAR2_P2_ALGORITMOS_GRAFICA.Vistas
{
    public partial class CirculoBresenham : Form
    {
        private int xc, yc, rc;
        private Bitmap bmpAnim;
        private Graphics gAnim;

        private CirculoBresenhamController controlador = new CirculoBresenhamController();

        private static CirculoBresenham instancia = null;
        public static CirculoBresenham Instancia
        {
            get
            {
                if (instancia == null || instancia.IsDisposed)
                {
                    instancia = new CirculoBresenham();
                }
                return instancia;
            }
        }

        public CirculoBresenham()
        {
            InitializeComponent();
        }

        private void CirculoBresenham_Load(object sender, EventArgs e)
        {
        }

        private void btnGraficarBC_Click(object sender, EventArgs e)
        {
            try
            {
                xc = int.Parse(txtXC3.Text);
                yc = int.Parse(txtYC3.Text);
                rc = int.Parse(txtRC3.Text);

                if (rc <= 0)
                {
                    MessageBox.Show("El radio debe ser mayor que cero.");
                    return;
                }
            }
            catch
            {
                MessageBox.Show("Por favor, ingresa solo números válidos.");
                return;
            }


            bmpAnim = new Bitmap(pictureBoxBC.Width, pictureBoxBC.Height);
            gAnim = Graphics.FromImage(bmpAnim);
            gAnim.Clear(Color.White);

            DibujarCuadricula(gAnim, bmpAnim.Width, bmpAnim.Height, 20);

            DibujarCircunferenciaMVC();

            pictureBoxBC.Image = bmpAnim;
        }

        // ================== DIBUJO DESDE MVC ==================

        private void DibujarCircunferenciaMVC()
        {
            int centroX = pictureBoxBC.Width / 2;
            int centroY = pictureBoxBC.Height / 2;

            var puntos = controlador.ObtenerCircunferencia(xc, yc, rc);

            foreach (var p in puntos)
            {
                int px = centroX + p.X;
                int py = centroY - p.Y;

                if (px >= 0 && px < pictureBoxBC.Width &&
                    py >= 0 && py < pictureBoxBC.Height)
                {
                    bmpAnim.SetPixel(px, py, Color.Red);
                }
            }
        }

        // ================== RESET ==================

        private void btnResetBC_Click(object sender, EventArgs e)
        {
            txtXC3.Clear();
            txtYC3.Clear();
            txtRC3.Clear();
            pictureBoxBC.Image = null;
        }

        // ================== CUADRÍCULA ==================

        private void DibujarCuadricula(Graphics g, int ancho, int alto, int tamCelda)
        {
            Pen penGrid = new Pen(Color.LightGray, 1);
            Pen penEjes = new Pen(Color.Black, 2);

            for (int x = 0; x < ancho; x += tamCelda)
                g.DrawLine(penGrid, x, 0, x, alto);

            for (int y = 0; y < alto; y += tamCelda)
                g.DrawLine(penGrid, 0, y, ancho, y);

            g.DrawLine(penEjes, 0, alto / 2, ancho, alto / 2);
            g.DrawLine(penEjes, ancho / 2, 0, ancho / 2, alto);
        }
    }
}
