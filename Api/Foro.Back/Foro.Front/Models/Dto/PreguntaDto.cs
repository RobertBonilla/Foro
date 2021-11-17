using System;

namespace Foro.Front.Models.Dto
{
    public class PreguntaDto
    {
        public int idPregunta { get; set; }
        public int idUsuario { get; set; }
        public string username { get; set; }
        public string nombre { get; set; }
        public string titulo { get; set; }
        public string descripcion { get; set; }
        public DateTime fecha { get; set; }
        public bool activo { get; set; }
    }
}
