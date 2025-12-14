using System;
using System.Collections.Generic;
using System.Drawing;

namespace TAR2_P2_ALGORITMOS_GRAFICA.Modelos
{
    public class LineaDDAModel
    {
        public static List<Point> CalcularLinea(int x0, int y0, int x1, int y1)
        {
            List<Point> puntos = new List<Point>();

            int dx = x1 - x0;
            int dy = y1 - y0;

            int steps = Math.Max(Math.Abs(dx), Math.Abs(dy));

            float xInc = dx / (float)steps;
            float yInc = dy / (float)steps;

            float x = x0;
            float y = y0;

            for (int i = 0; i <= steps; i++)
            {
                puntos.Add(new Point(
                    (int)Math.Round(x),
                    (int)Math.Round(y)
                ));

                x += xInc;
                y += yInc;
            }

            return puntos;
        }
    }
}
