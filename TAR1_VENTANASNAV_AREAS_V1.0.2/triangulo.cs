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
    public partial class triangulo : Form
    {
        // 🔹 Instancia única (Singleton)
        private static triangulo instancia = null;

        // 🔹 Propiedad para acceder a la instancia
        public static triangulo Instancia
        {
            get
            {
                if (instancia == null || instancia.IsDisposed)
                {
                    instancia = new triangulo();
                }
                return instancia;
            }
        }

        // 🔹 Constructor privado
        private triangulo()
        {
            InitializeComponent();
        }

        private void btn_Triangulo_Click(object sender, EventArgs e)
        {
            try
            {
                int alturatri = int.Parse(txt_alturaTriangulo.Text);
                if (alturatri <= 0)
                {
                    MessageBox.Show("La altura debe ser un número positivo mayor que cero.");
                    return;
                }

                int lado1Triangulo = int.Parse(txt_lado1Triangulo.Text);
                if (lado1Triangulo <= 0)
                {
                    MessageBox.Show("El lado uno debe ser un número positivo mayor que cero.");
                    return;
                }

                int lado2Triangulo = int.Parse(txt_lado2Triangulo.Text);
                if (lado2Triangulo <= 0)
                {
                    MessageBox.Show("El lado dos debe ser un número positivo mayor que cero.");
                    return;
                }

                int basetri = int.Parse(txt_baseTriangulo.Text);
                if (basetri <= 0)
                {
                    MessageBox.Show("La base debe ser un número positivo mayor que cero.");
                    return;
                }

                float perimetro_tri = (lado1Triangulo + lado2Triangulo + basetri);
                float area_tri = (basetri * alturatri) / 2;

                MessageBox.Show("El perímetro del triángulo es: " + perimetro_tri +
                                "\nEl área del triángulo es: " + area_tri);
            }
            catch
            {
                MessageBox.Show("Ingrese valores válidos");
            }
        }

        private void triangulo_Load(object sender, EventArgs e)
        {
        }

        private void triangulo_Shown(object sender, EventArgs e)
        {
            string rutaImagen = System.IO.Path.Combine(Application.StartupPath, "resources", "triangulo.png");

            if (System.IO.File.Exists(rutaImagen))
            {
                pictureBox_triangulo.Image = Image.FromFile(rutaImagen);
                pictureBox_triangulo.SizeMode = PictureBoxSizeMode.Zoom; // Ajusta la imagen al PictureBox
            }
            else
            {
                MessageBox.Show("No se encontró la imagen del triángulo en la carpeta resources.");
            }
        }
    }
}
