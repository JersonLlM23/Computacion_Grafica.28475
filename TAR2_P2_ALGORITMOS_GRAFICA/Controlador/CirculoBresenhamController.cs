using System.Collections.Generic;
using System.Drawing;
using TAR2_P2_ALGORITMOS_GRAFICA.Modelos;

namespace TAR2_P2_ALGORITMOS_GRAFICA.Controladores
{
    public class CirculoBresenhamController
    {
        private CirculoBresenhamModel modelo = new CirculoBresenhamModel();

        public List<Point> ObtenerCircunferencia(int xc, int yc, int r)
        {
            return modelo.CalcularPuntos(xc, yc, r);
        }
    }
}
