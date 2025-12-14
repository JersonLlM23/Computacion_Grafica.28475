using System;
using System.Collections.Generic;
using System.Drawing;

namespace TAR2_P2_ALGORITMOS_GRAFICA.Controlador
{
    public static class WeilerAthertonClipper
    {
        public static List<PointF> ClipPolygon(Rectangle clipRect, List<PointF> subject)
        {
            if (subject == null || subject.Count < 3)
                return new List<PointF>();

            List<PointF> output = new List<PointF>(subject);
            List<PointF> clippedPolygon = new List<PointF>();

            // Recorte de polígono contra los bordes de la ventana
            clippedPolygon = ClipAgainstEdge(output, clipRect, Edge.Left);
            clippedPolygon = ClipAgainstEdge(clippedPolygon, clipRect, Edge.Right);
            clippedPolygon = ClipAgainstEdge(clippedPolygon, clipRect, Edge.Top);
            clippedPolygon = ClipAgainstEdge(clippedPolygon, clipRect, Edge.Bottom);

            return clippedPolygon;
        }

        private enum Edge
        {
            Left,
            Right,
            Top,
            Bottom
        }

        // Método para recortar contra un borde de la ventana
        private static List<PointF> ClipAgainstEdge(List<PointF> input, Rectangle clipRect, Edge edge)
        {
            List<PointF> output = new List<PointF>();

            if (input.Count == 0)
                return output;

            PointF S = input[input.Count - 1]; // El último punto

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
