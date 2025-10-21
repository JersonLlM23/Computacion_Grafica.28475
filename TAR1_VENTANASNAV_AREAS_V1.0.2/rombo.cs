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
    public partial class rombo : Form
    {
        // 🔹 Instancia única (Singleton)
        private static rombo instancia = null;

        // 🔹 Propiedad pública para acceder a la instancia
        public static rombo Instancia
        {
            get
            {
                if (instancia == null || instancia.IsDisposed)
                {
                    instancia = new rombo();
                }
                return instancia;
            }
        }

        // 🔹 Constructor privado
        private rombo()
        {
            InitializeComponent();
        }

        private void btn_Rombo_Click(object sender, EventArgs e)
        {
            try
            {
                int ladoRombo = int.Parse(txt_ladoRombo.Text);
                if (ladoRombo <= 0)
                {
                    MessageBox.Show("El lado del rombo debe ser un número positivo mayor que cero.");
                    return;
                }

                int diagonalMayor = int.Parse(txt_diagonalMayor.Text);
                if (diagonalMayor <= 0)
                {
                    MessageBox.Show("La diagonal mayor del rombo debe ser un número positivo mayor que cero.");
                    return;
                }

                int diagonalMenor = int.Parse(txt_diagonalMenor.Text);
                if (diagonalMenor <= 0)
                {
                    MessageBox.Show("La diagonal menor del rombo debe ser un número positivo mayor que cero.");
                    return;
                }

                float areaRombo = (diagonalMayor * diagonalMenor) / 2;
                float perimetroRombo = ladoRombo * 4;

                MessageBox.Show("El área del rombo es: " + areaRombo +
                                "\nEl perímetro del rombo es: " + perimetroRombo);
            }
            catch
            {
                MessageBox.Show("Ingrese valores válidos.");
            }
        }

        private void rombo_Load(object sender, EventArgs e)
        {
        }

        private void rombo_Shown(object sender, EventArgs e)
        {
            string rutaImagen = System.IO.Path.Combine(Application.StartupPath, "resources", "rombo.png");

            if (System.IO.File.Exists(rutaImagen))
            {
                pictureBox_rombo.Image = Image.FromFile(rutaImagen);
                pictureBox_rombo.SizeMode = PictureBoxSizeMode.Zoom; // Ajusta la imagen al PictureBox
            }
            else
            {
                MessageBox.Show("No se encontró la imagen del rombo en la carpeta resources.");
            }
        }
    }
}
