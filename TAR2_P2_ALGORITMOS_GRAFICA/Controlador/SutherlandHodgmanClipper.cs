using System;
using System.Collections.Generic;
using System.Drawing;

namespace TAR2_P2_ALGORITMOS_GRAFICA.controlador
{
    public static class SutherlandHodgmanClipper
    {
        public static List<PointF> ClipPolygon(Rectangle clipRect, List<PointF> subject)
        {
            if (subject == null || subject.Count < 3)
                return new List<PointF>();

            List<PointF> output = new List<PointF>(subject);

            // Clip contra cada borde del rectángulo
            output = ClipAgainstEdge(output, clipRect, Edge.Left);
            output = ClipAgainstEdge(output, clipRect, Edge.Right);
            output = ClipAgainstEdge(output, clipRect, Edge.Top);
            output = ClipAgainstEdge(output, clipRect, Edge.Bottom);

            return output;
        }

        private enum Edge
        {
            Left,
            Right,
            Top,
            Bottom
        }

        private static List<PointF> ClipAgainstEdge(List<PointF> input, Rectangle clipRect, Edge edge)
        {
            List<PointF> output = new List<PointF>();

            if (input.Count == 0)
                return output;

            // Recorremos pares (S, P) donde S es el punto anterior y P el actual
            PointF S = input[input.Count - 1];

            foreach (PointF P in input)
            {
                bool insideP = IsInside(P, clipRect, edge);
                bool insideS = IsInside(S, clipRect, edge);

                if (insideS && insideP)
                {
                    // Caso 1: S y P dentro → añadimos P
                    output.Add(P);
                }
                else if (insideS && !insideP)
                {
                    // Caso 2: S dentro, P fuera → añadimos intersección
                    PointF I = ComputeIntersection(S, P, clipRect, edge);
                    output.Add(I);
                }
                else if (!insideS && insideP)
                {
                    // Caso 3: S fuera, P dentro → intersección + P
                    PointF I = ComputeIntersection(S, P, clipRect, edge);
                    output.Add(I);
                    output.Add(P);
                }
                // Caso 4: ambos fuera → no añadimos nada

                S = P;
            }

            return output;
        }

        private static bool IsInside(PointF p, Rectangle clipRect, Edge edge)
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

        private static PointF ComputeIntersection(PointF s, PointF p, Rectangle clipRect, Edge edge)
        {
            float x = 0, y = 0;

            float dx = p.X - s.X;
            float dy = p.Y - s.Y;

            switch (edge)
            {
                case Edge.Left:
                    {
                        float xEdge = clipRect.Left;
                        float t = (xEdge - s.X) / dx;
                        x = xEdge;
                        y = s.Y + t * dy;
                        break;
                    }
                case Edge.Right:
                    {
                        float xEdge = clipRect.Right;
                        float t = (xEdge - s.X) / dx;
                        x = xEdge;
                        y = s.Y + t * dy;
                        break;
                    }
                case Edge.Top:
                    {
                        float yEdge = clipRect.Top;
                        float t = (yEdge - s.Y) / dy;
                        y = yEdge;
                        x = s.X + t * dx;
                        break;
                    }
                case Edge.Bottom:
                    {
                        float yEdge = clipRect.Bottom;
                        float t = (yEdge - s.Y) / dy;
                        y = yEdge;
                        x = s.X + t * dx;
                        break;
                    }
            }

            return new PointF(x, y);
        }
    }
}
