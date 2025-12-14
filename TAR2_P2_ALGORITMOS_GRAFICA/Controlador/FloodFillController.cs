using System.Collections.Generic;
using System.Drawing;
using TAR2_P2_ALGORITMOS_GRAFICA.Modelos;

namespace TAR2_P2_ALGORITMOS_GRAFICA.Controladores
{
    public class FloodFillController
    {
        private FloodFillModelo modelo;

        public void Iniciar(Bitmap lienzo, int x, int y, Color relleno)
        {
            Color objetivo = lienzo.GetPixel(x, y);

            if (objetivo.ToArgb() == relleno.ToArgb())
                return;

            modelo = new FloodFillModelo(lienzo, objetivo, relleno);
            modelo.Iniciar(x, y);
        }

        public List<Point> EjecutarPaso(int cantidad)
        {
            if (modelo == null || !modelo.HayPendientes())
                return null;

            return modelo.ProcesarPaso(cantidad);
        }

        public bool Sigue()
        {
            return modelo != null && modelo.HayPendientes();
        }
    }
}
