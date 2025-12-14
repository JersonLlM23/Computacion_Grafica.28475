using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using TAR2_P2_ALGORITMOS_GRAFICA.Modelos;

namespace TAR2_P2_ALGORITMOS_GRAFICA.Controladores
{
    public class LineaBresenhamController
    {
        private Timer timer;
        private List<Point> puntos;
        private int index;
        private PictureBox pictureBox;
        private bool animando;

        public LineaBresenhamController(PictureBox pb)
        {
            pictureBox = pb;
            timer = new Timer();
            timer.Interval = 40;
            timer.Tick += AnimarPaso;
        }

        public void Iniciar(int x0, int y0, int x1, int y1)
        {
            if (animando) return;

            puntos = LineaBresenhamModel.CalcularLinea(x0, y0, x1, y1);
            index = 0;

            Bitmap bmp = new Bitmap(pictureBox.Width, pictureBox.Height);
            pictureBox.Image = bmp;

            DibujarCuadricula(Graphics.FromImage(bmp), bmp.Width, bmp.Height, 20);

            animando = true;
            timer.Start();
        }

        private void AnimarPaso(object sender, EventArgs e)
        {
            if (index >= puntos.Count)
            {
                timer.Stop();
                animando = false;
                return;
            }

            Bitmap bmp = (Bitmap)pictureBox.Image;

            int cx = bmp.Width / 2;
            int cy = bmp.Height / 2;

            int px = cx + puntos[index].X;
            int py = cy - puntos[index].Y;

            if (px >= 0 && px < bmp.Width && py >= 0 && py < bmp.Height)
                bmp.SetPixel(px, py, Color.Red);

            pictureBox.Invalidate();
            index++;
        }

        private void DibujarCuadricula(Graphics g, int ancho, int alto, int tam)
        {
            Pen grid = new Pen(Color.LightGray, 1);
            Pen eje = new Pen(Color.Black, 2);

            for (int x = 0; x < ancho; x += tam)
                g.DrawLine(grid, x, 0, x, alto);

            for (int y = 0; y < alto; y += tam)
                g.DrawLine(grid, 0, y, ancho, y);

            g.DrawLine(eje, 0, alto / 2, ancho, alto / 2);
            g.DrawLine(eje, ancho / 2, 0, ancho / 2, alto);
        }

        public void Reset()
        {
            timer.Stop();
            animando = false;
            pictureBox.Image = null;
            index = 0;
        }
    }
}
