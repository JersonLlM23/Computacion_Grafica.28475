using System;
using System.Drawing;

namespace TAR2_P2_ALGORITMOS_GRAFICA.Algoritmos
{
    public class LiangBarskyClipper
    {
        public Rectangle ClipWindow { get; }

        public LiangBarskyClipper(Rectangle window)
        {
            ClipWindow = window;
        }

        // Método principal de recorte
        public bool ClipLine(ref PointF p0, ref PointF p1)
        {
            float x0 = p0.X, y0 = p0.Y;
            float x1 = p1.X, y1 = p1.Y;

            float dx = x1 - x0;
            float dy = y1 - y0;

            float u1 = 0.0f;
            float u2 = 1.0f;

            // Lados de la ventana
            float xmin = ClipWindow.Left;
            float xmax = ClipWindow.Right;
            float ymin = ClipWindow.Top;
            float ymax = ClipWindow.Bottom;

            // Función interna para procesar cada límite
            bool ClipTest(float p, float q, ref float u1Ref, ref float u2Ref)
            {
                if (Math.Abs(p) < 1e-6)
                {
                    // Segmento paralelo al borde
                    if (q < 0) return false; // fuera
                    return true;             // dentro todo el tiempo
                }

                float r = q / p;

                if (p < 0)
                {
                    // entrada potencial
                    if (r > u2Ref) return false;
                    if (r > u1Ref) u1Ref = r;
                }
                else if (p > 0)
                {
                    // salida potencial
                    if (r < u1Ref) return false;
                    if (r < u2Ref) u2Ref = r;
                }

                return true;
            }

            // Probar contra cada borde de la ventana
            if (!ClipTest(-dx, x0 - xmin, ref u1, ref u2)) return false; // izquierda
            if (!ClipTest(dx, xmax - x0, ref u1, ref u2)) return false; // derecha
            if (!ClipTest(-dy, y0 - ymin, ref u1, ref u2)) return false; // arriba
            if (!ClipTest(dy, ymax - y0, ref u1, ref u2)) return false; // abajo

            if (u1 > u2) return false;

            // Ajustar extremos recortados
            float nx0 = x0 + u1 * dx;
            float ny0 = y0 + u1 * dy;
            float nx1 = x0 + u2 * dx;
            float ny1 = y0 + u2 * dy;

            p0 = new PointF(nx0, ny0);
            p1 = new PointF(nx1, ny1);

            return true;
        }
    }
}
