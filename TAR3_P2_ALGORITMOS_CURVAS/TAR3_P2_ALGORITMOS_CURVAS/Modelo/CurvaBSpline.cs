using System;
using System.Collections.Generic;
using System.Drawing;

namespace TAR3_P2_ALGORITMOS_CURVAS.Modelo
{
    public class CurvaBSpline
    {
        // Calcula un punto en la curva B-Spline uniforme cúbica
        // usando los puntos de control y el parámetro t global
        public static PointF CalcularPuntoBSpline(List<PointF> puntosControl, float t)
        {
            int n = puntosControl.Count;
            if (n < 4) return PointF.Empty; // Necesitamos al menos 4 puntos para B-Spline cúbica

            // Para B-Spline cúbica uniforme, dividimos en segmentos
            // Cada segmento usa 4 puntos de control consecutivos
            int numSegmentos = n - 3;

            // Escalar t al rango de segmentos
            float tGlobal = t * numSegmentos;
            int segmento = Math.Min((int)Math.Floor(tGlobal), numSegmentos - 1);
            float u = tGlobal - segmento; // parámetro local en [0, 1] para este segmento

            // Obtener los 4 puntos de control para este segmento
            PointF p0 = puntosControl[segmento];
            PointF p1 = puntosControl[segmento + 1];
            PointF p2 = puntosControl[segmento + 2];
            PointF p3 = puntosControl[segmento + 3];

            // Funciones base B-Spline cúbicas uniformes usando matriz de Cox-de Boor
            // B(u) = (1/6) * M * [u³ u² u 1]ᵀ donde M es la matriz B-Spline
            float u2 = u * u;
            float u3 = u2 * u;

            // Aplicar matriz B-Spline uniforme directamente:
            // [-1  3 -3  1]
            // [ 3 -6  3  0]  
            // [-3  0  3  0]
            // [ 1  4  1  0]
            float b0 = (-u3 + 3*u2 - 3*u + 1) / 6.0f;
            float b1 = (3*u3 - 6*u2 + 4) / 6.0f;
            float b2 = (-3*u3 + 3*u2 + 3*u + 1) / 6.0f;
            float b3 = u3 / 6.0f;

            // Calcular el punto resultante
            float x = b0 * p0.X + b1 * p1.X + b2 * p2.X + b3 * p3.X;
            float y = b0 * p0.Y + b1 * p1.Y + b2 * p2.Y + b3 * p3.Y;

            return new PointF(x, y);
        }

        // Genera una lista de puntos para dibujar la curva completa
        public static List<PointF> GenerarCurvaBSpline(List<PointF> puntosControl, int numPuntos = 100)
        {
            var puntosCurva = new List<PointF>();

            if (puntosControl.Count < 4)
                return puntosCurva;

            for (int i = 0; i <= numPuntos; i++)
            {
                float tParam = i / (float)numPuntos;
                PointF punto = CalcularPuntoBSpline(puntosControl, tParam);
                if (punto != PointF.Empty)
                    puntosCurva.Add(punto);
            }

            return puntosCurva;
        }
    }
}
