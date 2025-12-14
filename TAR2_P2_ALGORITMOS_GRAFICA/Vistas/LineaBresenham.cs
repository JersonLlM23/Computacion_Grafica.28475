using System;
using System.Windows.Forms;
using TAR2_P2_ALGORITMOS_GRAFICA.Controladores;

namespace TAR2_P2_ALGORITMOS_GRAFICA.Vistas
{
    public partial class LineaBresenham : Form
    {
        private static LineaBresenham instancia = null;
        public static LineaBresenham Instancia
        {
            get
            {
                if (instancia == null || instancia.IsDisposed)
                {
                    instancia = new LineaBresenham();
                }
                return instancia;
            }
        }

        private LineaBresenhamController controller;

        public LineaBresenham()
        {
            InitializeComponent();
            controller = new LineaBresenhamController(pictureBoxB);
        }

        private void btnGraficarB_Click(object sender, EventArgs e)
        {
            try
            {
                int x0 = int.Parse(txtBoxXoB.Text);
                int y0 = int.Parse(txtBoxYoB.Text);
                int x1 = int.Parse(txtBoxXfB.Text);
                int y1 = int.Parse(txtBoxYfB.Text);

                controller.Iniciar(x0, y0, x1, y1);
            }
            catch
            {
                MessageBox.Show("Ingrese solo valores numéricos.");
            }
        }

        private void LineaBresenham_Load(object sender, EventArgs e)
        {
        
        }

        private void btnResetB_Click(object sender, EventArgs e)
        {
            controller.Reset();

            txtBoxXoB.Clear();
            txtBoxYoB.Clear();
            txtBoxXfB.Clear();
            txtBoxYfB.Clear();
        }
    }
}
