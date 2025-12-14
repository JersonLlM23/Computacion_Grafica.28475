using System;
using System.Collections.Generic;

namespace TAR2_P2_ALGORITMOS_GRAFICA.Modelos
{
    public class CirculoParametricoModelo
    {
        public List<(int x, int y)> CalcularPuntos(int xc, int yc, int r)
        {
            List<(int x, int y)> puntos = new List<(int x, int y)>();

            double t = 0.0;
            double deltaT = Math.PI / 100;

            while (t <= 2 * Math.PI)
            {
                int x = (int)(xc + r * Math.Cos(t));
                int y = (int)(yc + r * Math.Sin(t));

                puntos.Add((x, y));
                t += deltaT;
            }

            return puntos;
        }
    }
}
