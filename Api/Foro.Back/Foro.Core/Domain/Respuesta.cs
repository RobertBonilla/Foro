using System;

namespace Foro.Core.Domain
{
    public class Respuesta
    {
        public int idRespuesta { get; set; }
        public int idPregunta { get; set; }
        public int idUsuario { get; set; }
        public string descripcion { get; set; }
        public DateTime fecha { get; set; }
    }
}
