using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TAR2_P2_ALGORITMOS_GRAFICA.Controlador
{
    internal class BoundaryFillAlgorithm
    {
        public static void Fill(
            Bitmap bmp,
            int xInicio,
            int yInicio,
            Color fillColor,
            Color borderColor,
            IList<Point> logPixels = null)
        {
            if (bmp == null)
                return;

            if (xInicio < 0 || xInicio >= bmp.Width ||
                yInicio < 0 || yInicio >= bmp.Height)
                return;

            Color colorActual = bmp.GetPixel(xInicio, yInicio);

            // Si ya está relleno o es borde, no hacemos nada
            if (colorActual.ToArgb() == fillColor.ToArgb() ||
                colorActual.ToArgb() == borderColor.ToArgb())
                return;

            Stack<Point> pila = new Stack<Point>();
            pila.Push(new Point(xInicio, yInicio));

            while (pila.Count > 0)
            {
                Point p = pila.Pop();
                int x = p.X;
                int y = p.Y;

                if (x < 0 || x >= bmp.Width || y < 0 || y >= bmp.Height)
                    continue;

                Color c = bmp.GetPixel(x, y);

                // Si es borde o ya está relleno, no seguimos
                if (c.ToArgb() == borderColor.ToArgb() ||
                    c.ToArgb() == fillColor.ToArgb())
                    continue;

                // Pintar
                bmp.SetPixel(x, y, fillColor);
                logPixels?.Add(p);

                // Vecinos 4-conectados: N, E, S, O
                pila.Push(new Point(x, y - 1)); // N
                pila.Push(new Point(x + 1, y)); // E
                pila.Push(new Point(x, y + 1)); // S
                pila.Push(new Point(x - 1, y)); // O
            }
        }
    }
}
 