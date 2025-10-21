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
    public partial class circulo : Form
    {
        // 🔹 Instancia única (Singleton)
        private static circulo instancia = null;

        // 🔹 Propiedad pública para acceder a la instancia
        public static circulo Instancia
        {
            get
            {
                if (instancia == null || instancia.IsDisposed)
                {
                    instancia = new circulo();
                }
                return instancia;
            }
        }

        // 🔹 Constructor privado
        private circulo()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {
        }

        private void btn_Circulo_Click(object sender, EventArgs e)
        {
            try
            {
                int radioCirculo = int.Parse(txt_radioCirculo.Text);
                if (radioCirculo <= 0)
                {
                    MessageBox.Show("El valor del radio debe ser mayor a 0.");
                    return;
                }

                float areaCirculo = (float)(Math.PI * Math.Pow(radioCirculo, 2));
                float perimetroCirculo = (float)(2 * Math.PI * radioCirculo);

                MessageBox.Show("El área del círculo es: " + areaCirculo +
                                "\nEl perímetro del círculo es: " + perimetroCirculo);
            }
            catch
            {
                MessageBox.Show("Ingrese valores válidos.");
            }
        }

        private void circulo_Load(object sender, EventArgs e)
        {
        }

        private void circulo_Shown(object sender, EventArgs e)
        {
            string rutaImagen = System.IO.Path.Combine(Application.StartupPath, "resources", "circulo.png");

            if (System.IO.File.Exists(rutaImagen))
            {
                pictureBox_circulo.Image = Image.FromFile(rutaImagen);
                pictureBox_circulo.SizeMode = PictureBoxSizeMode.Zoom; // Ajusta la imagen al PictureBox
            }
            else
            {
                MessageBox.Show("No se encontró la imagen del rombo en la carpeta resources.");
            }
        }
    }
}
