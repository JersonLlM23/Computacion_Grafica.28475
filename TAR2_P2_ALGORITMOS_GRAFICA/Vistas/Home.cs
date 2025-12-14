using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TAR2_P2_ALGORITMOS_GRAFICA.Vistas;

namespace TAR2_P2_ALGORITMOS_GRAFICA
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void AbrirFormulario(Form frm)
        {
            OcultarFormulariosHijos();
            frm.MdiParent = this;
            frm.Dock = DockStyle.Fill;
            frm.Show();
            frm.BringToFront();
        }

        private void OcultarFormulariosHijos()
        {
            foreach (Form frm in this.MdiChildren)
            {
                frm.Hide();
            }
        }

        private void algoritmoDDAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormulario(LineaDDA.Instancia);
        }

        private void Home_Load(object sender, EventArgs e)
        {
            AbrirFormulario(Bienvenida.Instancia);
            this.WindowState = FormWindowState.Maximized; 
        }

        private void algoritmoPuntoMedioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormulario(LineaPM.Instancia);
        }

        private void algoritmoDeBToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormulario(LineaBresenham.Instancia);
        }

        private void trazadoDeCircunferenciasToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void algoritmoEcuaciónParamétricaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormulario(CirculoParametrico.Instancia);
        }

        private void algoritmoPuntoMedioToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AbrirFormulario(CirculoPM.Instancia);
        }

        private void algoritmoDeBresenhamCirculosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormulario(CirculoBresenham.Instancia);
        }

        private void alogirmo1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormulario(RellenoFloodFill.Instancia);
        }

        private void alogirmo2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormulario(RellenoFloodFillBFS.Instancia);
        }

        private void alogirmo3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormulario(BoundaryFill.Instancia);
        }

        private void cohenSutherlandToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormulario(CutLinesCohenS.Instancia);
        }

        private void liangBarskyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormulario(CutLinesLiangB.Instancia);
        }

        private void nichollLeeNichollToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormulario(CutLineNLN.Instancia);
        }

        private void sutherlandHodgmanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormulario(cutPoligSutherlandH.Instancia);
        }

        private void liangBarskyToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AbrirFormulario(cutPoligLiangB.Instancia);
        }

        private void weilerAthertonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormulario(cutPoligWeilerA.Instancia);
        }
    }
}
