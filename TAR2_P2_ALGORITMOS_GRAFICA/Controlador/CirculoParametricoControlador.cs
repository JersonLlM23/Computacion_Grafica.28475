using System.Collections.Generic;
using TAR2_P2_ALGORITMOS_GRAFICA.Modelos;

namespace TAR2_P2_ALGORITMOS_GRAFICA.Controladores
{
    public class CirculoParametricoControlador
    {
        private CirculoParametricoModelo modelo;

        public CirculoParametricoControlador()
        {
            modelo = new CirculoParametricoModelo();
        }

        public List<(int x, int y)> ObtenerPuntos(int xc, int yc, int r)
        {
            return modelo.CalcularPuntos(xc, yc, r);
        }
    }
}
