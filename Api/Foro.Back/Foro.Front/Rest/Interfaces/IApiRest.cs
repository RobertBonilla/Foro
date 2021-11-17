using Foro.Front.Models.Domain;
using Foro.Front.Models.Dto;
using Foro.Front.Rest.Responses;

namespace Foro.Front.Rest.Interfaces
{
    public interface IApiRest
    {
        GenericListResponse<PreguntaDto> GetPreguntas();
        GenericResponse<DetallePregunta> GetPregunta(int codigoPregunta);
        GenericResponse<string> RegistrarPregunta(Pregunta pregunta);
        GenericResponse<string> RegistrarRespuesta(Respuesta respuesta);
        GenericResponse<string> CerrarPregunta(int codigoPregunta);
        GenericResponse<string> RegistrarUsuario(Usuario usuario);
        GenericResponse<Usuario> IniciarSession(Usuario usuario);
    }
}
