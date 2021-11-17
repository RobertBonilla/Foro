using System;

namespace Foro.Core.Domain
{
    public class Pregunta
    {
        public int idPregunta { get; set; }
        public int idUsuario { get; set; }
        public string titulo { get; set; }
        public string descripcion { get; set; }
        public DateTime fecha { get; set; }
        public bool activo { get; set; }
    }
}
