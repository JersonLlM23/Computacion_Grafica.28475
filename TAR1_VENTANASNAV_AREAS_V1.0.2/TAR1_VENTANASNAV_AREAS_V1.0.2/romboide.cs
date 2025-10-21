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
    public partial class romboide : Form
    {
        // 🔹 Instancia única (Singleton)
        private static romboide instancia = null;

        // 🔹 Propiedad pública para acceder a la instancia
        public static romboide Instancia
        {
            get
            {
                if (instancia == null || instancia.IsDisposed)
                {
                    instancia = new romboide();
                }
                return instancia;
            }
        }

        // 🔹 Constructor privado
        private romboide()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void btn_Romboide_Click(object sender, EventArgs e)
        {
            try
            {
                int baseRomboide = int.Parse(txt_baseRomboide.Text);
                if (baseRomboide <= 0)
                {
                    MessageBox.Show("La base del romboide debe ser un número positivo mayor que cero.");
                    return;
                }

                int alturaRomboide = int.Parse(txt_alturaRomboide.Text);
                if (alturaRomboide <= 0)
                {
                    MessageBox.Show("La altura del romboide debe ser un número positivo mayor que cero.");
                    return;
                }

                float areaRomboide = baseRomboide * alturaRomboide;
                float perimetroRombo = 2 * (baseRomboide + alturaRomboide);

                MessageBox.Show("El área del romboide es: " + areaRomboide +
                                "\nEl perímetro del romboide es: " + perimetroRombo);
            }
            catch
            {
                MessageBox.Show("Ingrese valores válidos.");
            }
        }

        private void romboide_Load(object sender, EventArgs e)
        {
        }

        private void romboide_Shown(object sender, EventArgs e)
        {
            string rutaImagen = System.IO.Path.Combine(Application.StartupPath, "resources", "romboide.png");

            if (System.IO.File.Exists(rutaImagen))
            {
                pictureBox_romboide.Image = Image.FromFile(rutaImagen);
                pictureBox_romboide.SizeMode = PictureBoxSizeMode.Zoom; // Ajusta la imagen al PictureBox
            }
            else
            {
                MessageBox.Show("No se encontró la imagen del rombo en la carpeta resources.");
            }
        }
    }
}
