using Foro.Core.Domain;
using Foro.Core.Dto;
using System.Collections.Generic;

namespace Foro.Core.Interfaces
{
    public interface IPreguntaRepository
    {
        string RegistrarPregunta(Pregunta pregunta);
        string RegistrarRespuesta(Respuesta respuesta);
        List<PreguntaDto> GetListaPreguntas();
        List<RespuestaDto> GetListaRespuesta(int codigoPregunta);
        PreguntaDto GetPregunta(int codigoPregunta);
        string CerrarPregunta(int codigoPregunta);
    }
}
