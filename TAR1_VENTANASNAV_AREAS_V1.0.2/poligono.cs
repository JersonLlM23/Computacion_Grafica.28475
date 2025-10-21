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
    public partial class poligono : Form
    {
        // 🔹 Instancia única (Singleton)
        private static poligono instancia = null;

        // 🔹 Propiedad pública para acceder a la instancia
        public static poligono Instancia
        {
            get
            {
                if (instancia == null || instancia.IsDisposed)
                {
                    instancia = new poligono();
                }
                return instancia;
            }
        }

        // 🔹 Constructor privado
        private poligono()
        {
            InitializeComponent();
        }

        private void btn_Poligono_Click(object sender, EventArgs e)
        {
            try
            {
                int numeroladosPoligono = int.Parse(txt_numladosPoligono.Text);
                if (numeroladosPoligono <= 4)
                {
                    MessageBox.Show("El número de lados debe ser mayor a 4. Si es de 4 lados, se trata de un cuadrilátero.");
                    return;
                }

                int ladoPoligono = int.Parse(txt_ladoPoligono.Text);
                if (ladoPoligono <= 0)
                {
                    MessageBox.Show("El valor del lado debe ser mayor a 0.");
                    return;
                }

                int apotemaPoligono = int.Parse(txt_apotemaPoligono.Text);
                if (apotemaPoligono <= 0)
                {
                    MessageBox.Show("El valor del apotema debe ser mayor a 0.");
                    return;
                }

                float perimetroPoligono = numeroladosPoligono * ladoPoligono;
                float areaPoligono = (perimetroPoligono * apotemaPoligono) / 2;

                MessageBox.Show("El perímetro del polígono es: " + perimetroPoligono +
                                "\nEl área del polígono es: " + areaPoligono);
            }
            catch
            {
                MessageBox.Show("Ingrese valores válidos.");
            }
        }

        private void poligono_Load(object sender, EventArgs e)
        {
        }

        private void poligono_Shown(object sender, EventArgs e)
        {
            string rutaImagen = System.IO.Path.Combine(Application.StartupPath, "resources", "poligono.png");

            if (System.IO.File.Exists(rutaImagen))
            {
                pictureBox_poligono.Image = Image.FromFile(rutaImagen);
                pictureBox_poligono.SizeMode = PictureBoxSizeMode.Zoom; // Ajusta la imagen al PictureBox
            }
            else
            {
                MessageBox.Show("No se encontró la imagen del rombo en la carpeta resources.");
            }
        }
    }
}
