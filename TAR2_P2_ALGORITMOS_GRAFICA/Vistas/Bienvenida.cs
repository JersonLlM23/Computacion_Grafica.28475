using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TAR2_P2_ALGORITMOS_GRAFICA.Vistas
{
    public partial class Bienvenida : Form
    {

        private static Bienvenida instancia = null;
        public static Bienvenida Instancia
        {
            get
            {
                if (instancia == null || instancia.IsDisposed)
                {
                    instancia = new Bienvenida();
                }
                return instancia;
            }
        }
        public Bienvenida()
        {
            InitializeComponent();
        }
    }
}
