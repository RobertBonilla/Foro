using Foro.Core.Domain;
using Foro.Core.Dto;
using System.Collections.Generic;

namespace Foro.Core.Interfaces
{
    public interface IPreguntaUseCase
    {        
        string RegistrarPregunta(Pregunta pregunta);
        string RegistrarRespuesta(Respuesta respuesta);
        List<PreguntaDto> GetListaPreguntas();
        DetallePregunta GetPregunta(int codigoPregunta);
        string CerrarPregunta(int codigoPregunta);
    }
}
