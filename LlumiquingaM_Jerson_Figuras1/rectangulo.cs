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
    public partial class rectangulo : Form
    {
        // 🔹 Instancia única (Singleton)
        private static rectangulo instancia = null;

        // 🔹 Propiedad para acceder a la instancia
        public static rectangulo Instancia
        {
            get
            {
                if (instancia == null || instancia.IsDisposed)
                {
                    instancia = new rectangulo();
                }
                return instancia;
            }
        }

        // 🔹 Constructor privado (evita crear nuevas instancias externas)
        private rectangulo()
        {
            InitializeComponent();
        }

        private void btn_Rectangulo_Click(object sender, EventArgs e)
        {
            try
            {
                int alturarect = int.Parse(txt_alturarectangulo.Text);
                if (alturarect <= 0)
                {
                    MessageBox.Show("La altura debe ser un número positivo mayor que cero.");
                    return;
                }

                int baserect = int.Parse(txt_baserectangulo.Text);
                if (baserect <= 0)
                {
                    MessageBox.Show("La base debe ser un número positivo mayor que cero.");
                    return;
                }

                float perimetro = (alturarect + baserect) * 2;
                float area = alturarect * baserect;

                MessageBox.Show("El perímetro del rectángulo es: " + perimetro +
                                "\nEl área del rectángulo es: " + area);
            }
            catch
            {
                MessageBox.Show("Ingrese valores válidos.");
            }
        }

        private void rectangulo_Load(object sender, EventArgs e)
        {
        }

        private void picFigura_rectangulo_Click(object sender, EventArgs e)
        {
            try
            {
                picFigura_rectangulo.Image = Image.FromFile("resources/rectangulo.png");
                picFigura_rectangulo.SizeMode = PictureBoxSizeMode.Zoom;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar la imagen: " + ex.Message);
            }
        }

        private void rectangulo_Shown(object sender, EventArgs e)
        {
            string rutaImagen = System.IO.Path.Combine(Application.StartupPath, "resources", "rectangulo.png");

            if (System.IO.File.Exists(rutaImagen))
            {
                picFigura_rectangulo.Image = Image.FromFile(rutaImagen);
                picFigura_rectangulo.SizeMode = PictureBoxSizeMode.Zoom; // Ajusta la imagen al PictureBox
            }
            else
            {
                MessageBox.Show("No se encontró la imagen del rectángulo en la carpeta resources.");
            }
        }
    }
}
