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
    public partial class cuadrado : Form
    {
        // 🔹 Instancia única (patrón Singleton)
        private static cuadrado instancia = null;

        // 🔹 Propiedad pública para acceder a la instancia
        public static cuadrado Instancia
        {
            get
            {
                // Si no existe o fue cerrada, se crea una nueva
                if (instancia == null || instancia.IsDisposed)
                {
                    instancia = new cuadrado();
                }
                return instancia;
            }
        }

        // 🔹 Constructor privado para evitar crear nuevas instancias fuera del Singleton
        private cuadrado()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void btn_Cuadrado_Click(object sender, EventArgs e)
        {
            try
            {
                int ladocuadrado = int.Parse(txt_lado_cuadrado.Text);
                if (ladocuadrado <= 0)
                {
                    MessageBox.Show("El lado del cuadrado debe ser positivo mayor que cero.");
                    return;
                }

                float perimetro_cuadrado = (ladocuadrado * 4);
                float area_cuadrado = (ladocuadrado * ladocuadrado);
                MessageBox.Show("El perimetro del cuadrado es: " + perimetro_cuadrado + "\n" + "El area del cuadrado es: " + area_cuadrado);
            }
            catch
            {
                MessageBox.Show("Ingrese valores válidos");
            }
        }

        private void cuadrado_Load(object sender, EventArgs e)
        {
            try
            {
                // Cargar la imagen del cuadrado desde la carpeta resources
                picFigura_cuadrado.Image = Image.FromFile("resources/cuadrado.png");
                picFigura_cuadrado.SizeMode = PictureBoxSizeMode.Zoom; // Ajusta la imagen al tamaño del PictureBox
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo cargar la imagen del cuadrado: " + ex.Message);
            }
        }
    }
}
