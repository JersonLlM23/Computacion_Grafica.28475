using System;
using System.Windows.Forms;
using TAR2_P2_ALGORITMOS_GRAFICA.Controladores;

namespace TAR2_P2_ALGORITMOS_GRAFICA.Vistas
{
    public partial class LineaDDA : Form
    {
        private LineaDDAController controller;
        private static LineaDDA instancia = null; 
            public static LineaDDA Instancia {
            get 
            { 
                if (instancia == null || instancia.IsDisposed) {
                    instancia = new LineaDDA(); 
                } return instancia; 
            } 
        }
        public LineaDDA()
        {
            InitializeComponent();
            controller = new LineaDDAController(pictureBox1);
        }

        private void btnGraficarDDA_Click(object sender, EventArgs e)
        {
            try
            {
                int x0 = int.Parse(txtBoxXo.Text);
                int y0 = int.Parse(txtBoxYo.Text);
                int x1 = int.Parse(txtBoxXf.Text);
                int y1 = int.Parse(txtBoxYf.Text);

                controller.Iniciar(x0, y0, x1, y1);
            }
            catch
            {
                MessageBox.Show("Ingrese solo valores numéricos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnResetDDA_Click_1(object sender, EventArgs e)
        {
            controller.Reset();

            txtBoxXo.Clear();
            txtBoxYo.Clear();
            txtBoxXf.Clear();
            txtBoxYf.Clear();
        }
    }
}
