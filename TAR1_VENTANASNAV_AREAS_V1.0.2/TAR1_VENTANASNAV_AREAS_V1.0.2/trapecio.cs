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
    public partial class trapecio : Form
    {
        // 🔹 Instancia única (Singleton)
        private static trapecio instancia = null;

        // 🔹 Propiedad pública para acceder a la instancia
        public static trapecio Instancia
        {
            get
            {
                if (instancia == null || instancia.IsDisposed)
                {
                    instancia = new trapecio();
                }
                return instancia;
            }
        }

        // 🔹 Constructor privado
        private trapecio()
        {
            InitializeComponent();
        }

        private void btn_Trapecio_Click(object sender, EventArgs e)
        {
            try
            {
                int baseMenorTrapecio = int.Parse(txt_baseMenor_Trapecio.Text);
                if (baseMenorTrapecio <= 0)
                {
                    MessageBox.Show("La base menor debe ser un número positivo mayor que cero.");
                    return;
                }

                int baseMayorTrapecio = int.Parse(txt_baseMayor_Trapecio.Text);
                if (baseMayorTrapecio <= 0)
                {
                    MessageBox.Show("La base mayor debe ser un número positivo mayor que cero.");
                    return;
                }

                int ladoTrapecio = int.Parse(txt_lado_Trapecio.Text);
                if (ladoTrapecio <= 0)
                {
                    MessageBox.Show("El lado debe ser un número positivo mayor que cero.");
                    return;
                }

                int alturaTrapecio = int.Parse(txt_altura_Trapecio.Text);
                if (alturaTrapecio <= 0)
                {
                    MessageBox.Show("La altura debe ser un número positivo mayor que cero.");
                    return;
                }

                float areaTrapecio = ((baseMayorTrapecio + baseMenorTrapecio) * alturaTrapecio) / 2;
                float perimetroTrapecio = baseMayorTrapecio + baseMenorTrapecio + (ladoTrapecio * 2);

                MessageBox.Show("El área del trapecio es: " + areaTrapecio +
                                "\nEl perímetro del trapecio es: " + perimetroTrapecio);
            }
            catch
            {
                MessageBox.Show("Ingrese valores válidos.");
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {
        }

        private void txt_lado_Trapecio_TextChanged(object sender, EventArgs e)
        {
        }

        private void trapecio_Load(object sender, EventArgs e)
        {
        }

        private void trapecio_Shown(object sender, EventArgs e)
        {
            string rutaImagen = System.IO.Path.Combine(Application.StartupPath, "resources", "trapecio.png");

            if (System.IO.File.Exists(rutaImagen))
            {
                pictureBox_trapecio.Image = Image.FromFile(rutaImagen);
                pictureBox_trapecio.SizeMode = PictureBoxSizeMode.Zoom; // Ajusta la imagen al PictureBox
            }
            else
            {
                MessageBox.Show("No se encontró la imagen del rombo en la carpeta resources.");
            }
        }
    }
}
