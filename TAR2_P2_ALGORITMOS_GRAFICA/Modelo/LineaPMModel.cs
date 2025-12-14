using System;
using System.Collections.Generic;
using System.Drawing;

namespace TAR2_P2_ALGORITMOS_GRAFICA.Modelos
{
    public class LineaPMModel
    {
        public static List<Point> CalcularLinea(int x0, int y0, int x1, int y1)
        {
            List<Point> puntos = new List<Point>();

            int dx = x1 - x0;
            int dy = y1 - y0;

            int sx = dx < 0 ? -1 : 1;
            int sy = dy < 0 ? -1 : 1;

            dx = Math.Abs(dx);
            dy = Math.Abs(dy);

            int err = dx - dy;

            while (true)
            {
                puntos.Add(new Point(x0, y0));

                if (x0 == x1 && y0 == y1)
                    break;

                int e2 = 2 * err;

                if (e2 > -dy)
                {
                    err -= dy;
                    x0 += sx;
                }

                if (e2 < dx)
                {
                    err += dx;
                    y0 += sy;
                }
            }

            return puntos;
        }
    }
}
