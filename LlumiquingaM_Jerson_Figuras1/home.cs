using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TAR1_VENTANASNAV_AREAS
{
    public partial class home : Form
    {
        public home()
        {
            InitializeComponent();
        }

        private void home_Load(object sender, EventArgs e)
        {
            // Cambiar el color del fondo del MDI
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is MdiClient mdi)
                {
                    mdi.BackColor = Color.LightSteelBlue;
                }
            }
        }

        // 🔹 Ocultar todos los formularios hijos en vez de cerrarlos
        private void OcultarFormulariosHijos()
        {
            foreach (Form frm in this.MdiChildren)
            {
                frm.Hide(); // ✨ ocultamos el formulario
            }
        }

        private void AbrirFormulario(Form frm)
        {
            OcultarFormulariosHijos(); // ✨ ocultamos cualquier otro formulario

            frm.MdiParent = this;
            frm.Dock = DockStyle.Fill; // Ocupa todo el MDI
            frm.Show();
            frm.BringToFront();
        }

        private void cuadradoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormulario(cuadrado.Instancia);
        }

        private void rectanguloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormulario(rectangulo.Instancia);
        }

        private void trianguloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormulario(triangulo.Instancia);
        }

        private void romboToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormulario(rombo.Instancia);
        }

        private void romboideToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormulario(romboide.Instancia);
        }

        private void trapecioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormulario(trapecio.Instancia);
        }

        private void circuloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormulario(circulo.Instancia);
        }

        private void poligonoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormulario(poligono.Instancia);
        }
    }
}
