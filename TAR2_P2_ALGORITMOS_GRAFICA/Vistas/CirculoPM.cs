using System;
using System.Drawing;
using System.Windows.Forms;
using TAR2_P2_ALGORITMOS_GRAFICA.Controladores;

namespace TAR2_P2_ALGORITMOS_GRAFICA.Vistas
{
    public partial class CirculoPM : Form
    {
        private int xc, yc, rc;
        private Bitmap bmpAnim;
        private Graphics gAnim;

        private CirculoPMController controlador = new CirculoPMController();

        private static CirculoPM instancia = null;
        public static CirculoPM Instancia
        {
            get
            {
                if (instancia == null || instancia.IsDisposed)
                {
                    instancia = new CirculoPM();
                }
                return instancia;
            }
        }

        public CirculoPM()
        {
            InitializeComponent();
        }

        private void CirculoPM_Load(object sender, EventArgs e)
        {
        }

        private void btnGraficarPMC_Click(object sender, EventArgs e)
        {
            try
            {
                xc = int.Parse(txtXC2.Text);
                yc = int.Parse(txtYC2.Text);
                rc = int.Parse(txtRC2.Text);

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


            bmpAnim = new Bitmap(pictureBoxPMC.Width, pictureBoxPMC.Height);
            gAnim = Graphics.FromImage(bmpAnim);
            gAnim.Clear(Color.White);

            DibujarCuadricula(gAnim, bmpAnim.Width, bmpAnim.Height, 20);

            DibujarCircunferenciaMVC();

            pictureBoxPMC.Image = bmpAnim;
        }

        // ================== DIBUJO DESDE MVC ==================

        private void DibujarCircunferenciaMVC()
        {
            int centroX = pictureBoxPMC.Width / 2;
            int centroY = pictureBoxPMC.Height / 2;

            var puntos = controlador.ObtenerCircunferencia(xc, yc, rc);

            foreach (var p in puntos)
            {
                int px = centroX + p.X;
                int py = centroY - p.Y;

                if (px >= 0 && px < pictureBoxPMC.Width &&
                    py >= 0 && py < pictureBoxPMC.Height)
                {
                    bmpAnim.SetPixel(px, py, Color.Red);
                }
            }
        }

        // ================== RESET ==================

        private void btnResetPMC_Click(object sender, EventArgs e)
        {
            txtXC2.Clear();
            txtYC2.Clear();
            txtRC2.Clear();
            pictureBoxPMC.Image = null;
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
