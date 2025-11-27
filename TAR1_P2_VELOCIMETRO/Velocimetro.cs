using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace TAR1_P2_VELOCIMETRO
{
    public partial class Velocimetro : Form
    {
        private float velocidad = 0;  
        private float anguloAguja = 0;
        private const int radio = 150;
        private const int centroX = 200;
        private const int centroY = 200;

        public Velocimetro()
        {
            InitializeComponent();
            this.KeyPreview = true;  
            pictureBoxVelocimetro.Paint += pictureBoxVelocimetro_Paint;  
            timerVelocimetro.Tick += timerVelocimetro_Tick;  
            timerVelocimetro.Start();  
        }

        private void Velocimetro_Load(object sender, EventArgs e)
        {

        }
       
        private void timerVelocimetro_Tick(object sender, EventArgs e)
        {
        
            anguloAguja = (velocidad / 180) * 180;  
            pictureBoxVelocimetro.Invalidate();  
        }

        private void Velocimetro_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                if (velocidad < 180)
                {
                    velocidad += 10; 
                }
            }
            else if (e.KeyCode == Keys.Down)
            {
                if (velocidad > 0)
                {
                    velocidad -= 10; 
                }
            }
            labelVelocidad.Text = $"{velocidad} km/h";
            if (velocidad > 120)
            {
                labelVelocidad.ForeColor = Color.Red;  
            }
            else
            {
                labelVelocidad.ForeColor = Color.Black;
            }            
            pictureBoxVelocimetro.Invalidate();
        }


        private void pictureBoxVelocimetro_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;            
            Brush brushFondo = new LinearGradientBrush(
                new Point(centroX, centroY),
                new Point(centroX, centroY + radio),
                Color.LightSkyBlue,
                Color.White);
            g.FillEllipse(brushFondo, centroX - radio, centroY - radio, radio * 2, radio * 2);            
            Pen penBorde = new Pen(Color.DarkSlateGray, 6);
            g.DrawEllipse(penBorde, centroX - radio, centroY - radio, radio * 2, radio * 2);            
            for (int i = 0; i <= 180; i += 10)
            {
                float angulo = 180 - (i / 180.0f) * 180;

                float x1 = centroX + radio * (float)Math.Cos(Math.PI * angulo / 180);
                float y1 = centroY - radio * (float)Math.Sin(Math.PI * angulo / 180);
                float x2 = centroX + (radio - 10) * (float)Math.Cos(Math.PI * angulo / 180);
                float y2 = centroY - (radio - 10) * (float)Math.Sin(Math.PI * angulo / 180);
                Pen penSecundaria = new Pen(Color.Gray, 2);
                g.DrawLine(penSecundaria, x1, y1, x2, y2);
                
                if (i % 20 == 0)
                {
                    Pen penPrincipal = new Pen(Color.Blue, 3);
                    g.DrawLine(penPrincipal, x1, y1, x2, y2);

                    // Mostrar los números con contorno
                    string texto = i.ToString();
                    SizeF size = g.MeasureString(texto, this.Font);
                    g.DrawString(texto, new Font("Arial", 10, FontStyle.Bold), Brushes.White, x2 - size.Width / 2 + 1, y2 - size.Height / 2 + 1);  // Sombra blanca
                    g.DrawString(texto, new Font("Arial", 10, FontStyle.Bold), Brushes.Black, x2 - size.Width / 2, y2 - size.Height / 2);  // Texto principal
                }
            }

            // Dibujar la aguja con borde y color más llamativo
            Pen penAguja = new Pen(Color.Red, 4);
            float anguloAgujaRad = (anguloAguja / 180) * (float)Math.PI;
            float xAguja = centroX + (radio - 20) * (float)Math.Cos(Math.PI * (180 - anguloAguja) / 180);
            float yAguja = centroY - (radio - 20) * (float)Math.Sin(Math.PI * (180 - anguloAguja) / 180);
            g.DrawLine(penAguja, centroX, centroY, xAguja, yAguja);  // Aguja de velocidad
        }

        private void pictureBoxVelocimetro_Click(object sender, EventArgs e)
        {

        }

        private void labelVelocidad_Click(object sender, EventArgs e)
        {

        }
    }
}
