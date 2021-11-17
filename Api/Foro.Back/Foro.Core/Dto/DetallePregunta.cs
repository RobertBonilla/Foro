using System.Collections.Generic;

namespace Foro.Core.Dto
{
    public class DetallePregunta
    {
        public PreguntaDto Pregunta { get; set; }
        public List<RespuestaDto> ListaRespuesta { get; set; }

        public DetallePregunta()
        {
            Pregunta = new PreguntaDto();
            ListaRespuesta = new List<RespuestaDto>();
        }
    }
}
