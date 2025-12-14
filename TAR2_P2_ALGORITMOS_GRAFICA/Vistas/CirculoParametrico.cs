using System;
using System.Drawing;
using System.Windows.Forms;
using TAR2_P2_ALGORITMOS_GRAFICA.Controladores;

namespace TAR2_P2_ALGORITMOS_GRAFICA.Vistas
{
    public partial class CirculoParametrico : Form
    {
        private static CirculoParametrico instancia = null;
        public static CirculoParametrico Instancia
        {
            get
            {
                if (instancia == null || instancia.IsDisposed)
                    instancia = new CirculoParametrico();
                return instancia;
            }
        }

        private CirculoParametricoControlador controlador;
        private Bitmap bmp;

        public CirculoParametrico()
        {
            InitializeComponent();
            controlador = new CirculoParametricoControlador();
        }

        private void btnGraficarEcP_Click(object sender, EventArgs e)
        {
            int xc, yc, rc;
            try
            {
                xc = int.Parse(txtXC1.Text);
                yc = int.Parse(txtYC1.Text);
                rc = int.Parse(txtRC1.Text);

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


            bmp = new Bitmap(pictureBoxEcP.Width, pictureBoxEcP.Height);
            Graphics g = Graphics.FromImage(bmp);
            g.Clear(Color.White);

            DibujarCuadricula(g, bmp.Width, bmp.Height, 20);

            var puntos = controlador.ObtenerPuntos(xc, yc, rc);

            int centroX = pictureBoxEcP.Width / 2;
            int centroY = pictureBoxEcP.Height / 2;

            foreach (var p in puntos)
            {
                int px = p.x + centroX;
                int py = centroY - p.y;

                if (px >= 0 && px < bmp.Width && py >= 0 && py < bmp.Height)
                    bmp.SetPixel(px, py, Color.Red);
            }

            pictureBoxEcP.Image = bmp;
        }

        private void btnResetEcP_Click(object sender, EventArgs e)
        {
            txtXC1.Clear();
            txtYC1.Clear();
            txtRC1.Clear();
            pictureBoxEcP.Image = null;
        }

        private void CirculoParametrico_Load(object sender, EventArgs e)
        {
 
        }
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
