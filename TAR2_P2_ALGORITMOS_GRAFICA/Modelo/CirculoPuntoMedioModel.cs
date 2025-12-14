using System;
using System.Collections.Generic;
using System.Drawing;

namespace TAR2_P2_ALGORITMOS_GRAFICA.Modelos
{
    public class CirculoPuntoMedioModel
    {
        public List<Point> CalcularPuntos(int xc, int yc, int r)
        {
            List<Point> puntos = new List<Point>();

            int x = 0;
            int y = r;
            int p = 1 - r;

            while (x <= y)
            {
                puntos.AddRange(ObtenerSimetricos(xc, yc, x, y));

                if (p < 0)
                    p += 2 * x + 3;
                else
                {
                    p += 2 * (x - y) + 5;
                    y--;
                }
                x++;
            }

            return puntos;
        }

        private List<Point> ObtenerSimetricos(int xc, int yc, int x, int y)
        {
            return new List<Point>
            {
                new Point(xc + x, yc + y),
                new Point(xc - x, yc + y),
                new Point(xc + x, yc - y),
                new Point(xc - x, yc - y),
                new Point(xc + y, yc + x),
                new Point(xc - y, yc + x),
                new Point(xc + y, yc - x),
                new Point(xc - y, yc - x)
            };
        }
    }
}
