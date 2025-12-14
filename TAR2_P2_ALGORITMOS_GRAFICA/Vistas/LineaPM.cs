using System;
using System.Windows.Forms;
using TAR2_P2_ALGORITMOS_GRAFICA.Controladores;

namespace TAR2_P2_ALGORITMOS_GRAFICA.Vistas
{
    public partial class LineaPM : Form
    {
        private static LineaPM instancia = null;
        public static LineaPM Instancia
        {
            get
            {
                if (instancia == null || instancia.IsDisposed)
                {
                    instancia = new LineaPM();
                }
                return instancia;
            }
        }

        private LineaPMController controller;

        public LineaPM()
        {
            InitializeComponent();
            controller = new LineaPMController(pictureBoxPM);
        }

        private void btnGraficarPM_Click(object sender, EventArgs e)
        {
            try
            {
                int x0 = int.Parse(txtBoxXoPM.Text);
                int y0 = int.Parse(txtBoxYoPM.Text);
                int x1 = int.Parse(txtBoxXfPM.Text);
                int y1 = int.Parse(txtBoxYfPM.Text);

                controller.Iniciar(x0, y0, x1, y1);
            }
            catch
            {
                MessageBox.Show("Ingrese solo valores numéricos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnResetPM_Click(object sender, EventArgs e)
        {
            controller.Reset();

            txtBoxXoPM.Clear();
            txtBoxYoPM.Clear();
            txtBoxXfPM.Clear();
            txtBoxYfPM.Clear();
        }
    }
}
