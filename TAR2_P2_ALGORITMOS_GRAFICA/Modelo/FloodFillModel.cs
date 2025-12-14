using System.Collections.Generic;
using System.Drawing;

namespace TAR2_P2_ALGORITMOS_GRAFICA.Modelos
{
    public class FloodFillModelo
    {
        private Bitmap lienzo;
        private Color colorObjetivo;
        private Color colorRelleno;
        private Stack<Point> pila;

        public FloodFillModelo(Bitmap bitmap, Color objetivo, Color relleno)
        {
            lienzo = bitmap;
            colorObjetivo = objetivo;
            colorRelleno = relleno;
            pila = new Stack<Point>();
        }

        public void Iniciar(int x, int y)
        {
            pila.Push(new Point(x, y));
        }

        public bool HayPendientes()
        {
            return pila.Count > 0;
        }

        public List<Point> ProcesarPaso(int cantidad)
        {
            List<Point> pintados = new List<Point>();

            for (int i = 0; i < cantidad && pila.Count > 0; i++)
            {
                Point p = pila.Pop();
                int x = p.X;
                int y = p.Y;

                if (x < 0 || x >= lienzo.Width || y < 0 || y >= lienzo.Height)
                    continue;

                if (lienzo.GetPixel(x, y).ToArgb() != colorObjetivo.ToArgb())
                    continue;

                lienzo.SetPixel(x, y, colorRelleno);
                pintados.Add(p);

                pila.Push(new Point(x - 1, y)); // O
                pila.Push(new Point(x + 1, y)); // E
                pila.Push(new Point(x, y - 1)); // N
                pila.Push(new Point(x, y + 1)); // S
            }

            return pintados;
        }
    }
}
