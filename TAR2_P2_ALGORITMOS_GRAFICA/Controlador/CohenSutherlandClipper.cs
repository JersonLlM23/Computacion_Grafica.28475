using System;
using System.Drawing;

namespace TAR2_P2_ALGORITMOS_GRAFICA.Algoritmos
{
    public class CohenSutherlandClipper
    {
        // Códigos de región
        private const int INSIDE = 0; // 0000
        private const int LEFT = 1; // 0001
        private const int RIGHT = 2; // 0010
        private const int BOTTOM = 4; // 0100
        private const int TOP = 8; // 1000

        public Rectangle ClipWindow { get; }

        public CohenSutherlandClipper(Rectangle window)
        {
            ClipWindow = window;
        }

        private int ComputeOutCode(double x, double y)
        {
            int code = INSIDE;

            if (x < ClipWindow.Left)
                code |= LEFT;
            else if (x > ClipWindow.Right)
                code |= RIGHT;

            if (y < ClipWindow.Top)
                code |= TOP;
            else if (y > ClipWindow.Bottom)
                code |= BOTTOM;

            return code;
        }

        /// <summary>
        /// Aplica Cohen–Sutherland a una línea.
        /// Devuelve true si la línea (posiblemente recortada) queda visible.
        /// </summary>
        public bool ClipLine(ref PointF p0, ref PointF p1)
        {
            double x0 = p0.X, y0 = p0.Y;
            double x1 = p1.X, y1 = p1.Y;

            int outcode0 = ComputeOutCode(x0, y0);
            int outcode1 = ComputeOutCode(x1, y1);

            bool accept = false;

            while (true)
            {
                // Ambos dentro
                if ((outcode0 | outcode1) == 0)
                {
                    accept = true;
                    break;
                }
                // Ambos comparten una región fuera → se rechaza
                else if ((outcode0 & outcode1) != 0)
                {
                    break;
                }
                else
                {
                    // Al menos uno está fuera
                    int outcodeOut = (outcode0 != 0) ? outcode0 : outcode1;
                    double x = 0, y = 0;

                    // Intersección con los bordes
                    if ((outcodeOut & TOP) != 0)
                    {
                        // y = top
                        double dy = y1 - y0;
                        if (Math.Abs(dy) < 1e-6) break;
                        x = x0 + (x1 - x0) * (ClipWindow.Top - y0) / dy;
                        y = ClipWindow.Top;
                    }
                    else if ((outcodeOut & BOTTOM) != 0)
                    {
                        // y = bottom
                        double dy = y1 - y0;
                        if (Math.Abs(dy) < 1e-6) break;
                        x = x0 + (x1 - x0) * (ClipWindow.Bottom - y0) / dy;
                        y = ClipWindow.Bottom;
                    }
                    else if ((outcodeOut & RIGHT) != 0)
                    {
                        // x = right
                        double dx = x1 - x0;
                        if (Math.Abs(dx) < 1e-6) break;
                        y = y0 + (y1 - y0) * (ClipWindow.Right - x0) / dx;
                        x = ClipWindow.Right;
                    }
                    else if ((outcodeOut & LEFT) != 0)
                    {
                        // x = left
                        double dx = x1 - x0;
                        if (Math.Abs(dx) < 1e-6) break;
                        y = y0 + (y1 - y0) * (ClipWindow.Left - x0) / dx;
                        x = ClipWindow.Left;
                    }

                    // Reemplazamos el punto fuera por el punto de intersección
                    if (outcodeOut == outcode0)
                    {
                        x0 = x;
                        y0 = y;
                        outcode0 = ComputeOutCode(x0, y0);
                    }
                    else
                    {
                        x1 = x;
                        y1 = y;
                        outcode1 = ComputeOutCode(x1, y1);
                    }
                }
            }

            if (accept)
            {
                p0 = new PointF((float)x0, (float)y0);
                p1 = new PointF((float)x1, (float)y1);
            }

            return accept;
        }
    }
}
