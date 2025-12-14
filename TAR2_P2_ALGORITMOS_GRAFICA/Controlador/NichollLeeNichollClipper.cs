using System;
using System.Drawing;

namespace TAR2_P2_ALGORITMOS_GRAFICA.Algoritmos
{
    public class NichollLeeNichollClipper
    {
        public Rectangle ClipWindow { get; }

        // Aquí reutilizamos un recortador rectangular básico.
        // Puedes cambiarlo luego por una implementación NLN completa.
        private readonly CohenSutherlandClipper _baseClipper;

        public NichollLeeNichollClipper(Rectangle window)
        {
            ClipWindow = window;
            _baseClipper = new CohenSutherlandClipper(window);
        }

        /// <summary>
        /// Recorta una línea contra ClipWindow. 
        /// Actualmente delega en Cohen–Sutherland (recorte correcto sobre ventana rectangular).
        /// </summary>
        public bool ClipLine(ref PointF p0, ref PointF p1)
        {
            // Aquí podrías sustituir la llamada por la lógica NLN completa
            return _baseClipper.ClipLine(ref p0, ref p1);
        }
    }
}
