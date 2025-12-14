using System;
using System.Collections.Generic;
using System.Drawing;

namespace TAR2_P2_ALGORITMOS_GRAFICA.Controlador
{
    public class LiangBarskyClipper
    {
        public Rectangle ClipWindow { get; }

        public LiangBarskyClipper(Rectangle window)
        {
            ClipWindow = window;
        }

        // Método para recortar un polígono
        public List<PointF> ClipPolygon(List<PointF> polygon)
        {
            List<PointF> output = new List<PointF>(polygon);

            // Recortamos el polígono contra cada borde de la ventana
            output = ClipAgainstEdge(output, ClipWindow, Edge.Left);
            output = ClipAgainstEdge(output, ClipWindow, Edge.Right);
            output = ClipAgainstEdge(output, ClipWindow, Edge.Top);
            output = ClipAgainstEdge(output, ClipWindow, Edge.Bottom);

            return output;
        }

        private enum Edge
        {
            Left,
            Right,
            Top,
            Bottom
        }

        // Método para recortar contra un borde de la ventana
        private List<PointF> ClipAgainstEdge(List<PointF> input, Rectangle clipRect, Edge edge)
        {
            List<PointF> output = new List<PointF>();

            if (input.Count == 0)
                return output;

            PointF S = input[input.Count - 1];  // El último punto

            foreach (PointF P in input)
            {
                bool insideP = IsInside(P, clipRect, edge);
                bool insideS = IsInside(S, clipRect, edge);

                if (insideS && insideP)
                {
                    output.Add(P);
                }
                else if (insideS && !insideP)
                {
                    PointF I = ComputeIntersection(S, P, clipRect, edge);
                    output.Add(I);
                }
                else if (!insideS && insideP)
                {
                    PointF I = ComputeIntersection(S, P, clipRect, edge);
                    output.Add(I);
                    output.Add(P);
                }

                S = P;
            }

            return output;
        }

        private bool IsInside(PointF p, Rectangle clipRect, Edge edge)
        {
            switch (edge)
            {
                case Edge.Left:
                    return p.X >= clipRect.Left;
                case Edge.Right:
                    return p.X <= clipRect.Right;
                case Edge.Top:
                    return p.Y >= clipRect.Top;
                case Edge.Bottom:
                    return p.Y <= clipRect.Bottom;
                default:
                    return false;
            }
        }

        private PointF ComputeIntersection(PointF s, PointF p, Rectangle clipRect, Edge edge)
        {
            float x = 0, y = 0;
            float dx = p.X - s.X;
            float dy = p.Y - s.Y;

            switch (edge)
            {
                case Edge.Left:
                    float xEdge = clipRect.Left;
                    float t = (xEdge - s.X) / dx;
                    x = xEdge;
                    y = s.Y + t * dy;
                    break;
                case Edge.Right:
                    xEdge = clipRect.Right;
                    t = (xEdge - s.X) / dx;
                    x = xEdge;
                    y = s.Y + t * dy;
                    break;
                case Edge.Top:
                    float yEdge = clipRect.Top;
                    t = (yEdge - s.Y) / dy;
                    y = yEdge;
                    x = s.X + t * dx;
                    break;
                case Edge.Bottom:
                    yEdge = clipRect.Bottom;
                    t = (yEdge - s.Y) / dy;
                    y = yEdge;
                    x = s.X + t * dx;
                    break;
            }

            return new PointF(x, y);
        }
    }
}
