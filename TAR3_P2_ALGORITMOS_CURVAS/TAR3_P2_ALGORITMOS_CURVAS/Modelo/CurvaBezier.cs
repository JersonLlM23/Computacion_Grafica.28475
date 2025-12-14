using System.Drawing;

namespace TAR3_P2_ALGORITMOS_CURVAS.Modelo
{
    public class CurvaBezier
    {
        // Calcula el punto Q(t) para la curva Bézier de grado 2
        public static PointF CalcularCurvaBezier(PointF p0, PointF p1, PointF p2, float t)
        {
            // Calculamos Q0 y Q1 para grado 2
            PointF q0 = new PointF((1 - t) * p0.X + t * p1.X, (1 - t) * p0.Y + t * p1.Y);
            PointF q1 = new PointF((1 - t) * p1.X + t * p2.X, (1 - t) * p1.Y + t * p2.Y);

            // Calculamos el punto R(t) entre Q0 y Q1
            return new PointF((1 - t) * q0.X + t * q1.X, (1 - t) * q0.Y + t * q1.Y);
        }

        // Calcula el punto Q(t) para la curva Bézier de grado 1 (línea recta)
        public static PointF CalcularCurvaBezier(PointF p0, PointF p1, float t)
        {
            return new PointF((1 - t) * p0.X + t * p1.X, (1 - t) * p0.Y + t * p1.Y);
        }

        // Calcula el punto Q(t) para la curva Bézier de grado 3 (cúbica) usando De Casteljau
        public static PointF CalcularCurvaBezier(PointF p0, PointF p1, PointF p2, PointF p3, float t)
        {
            // Primera etapa
            var q0 = Lerp(p0, p1, t);
            var q1 = Lerp(p1, p2, t);
            var q2 = Lerp(p2, p3, t);

            // Segunda etapa
            var r0 = Lerp(q0, q1, t);
            var r1 = Lerp(q1, q2, t);

            // Tercera etapa (punto en la curva)
            return Lerp(r0, r1, t);
        }

        private static PointF Lerp(PointF a, PointF b, float t)
        {
            return new PointF((1 - t) * a.X + t * b.X, (1 - t) * a.Y + t * b.Y);
        }
    }
}
