using Foro.Api.Commond.Responses;
using Foro.Core.Domain;
using Foro.Core.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Net;

namespace Foro.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UsuarioController : ControllerBase
    {
        private readonly IUsuarioUseCase _useCase;
        public UsuarioController(IUsuarioUseCase useCase)
        {
            _useCase = (useCase != null) ? useCase : throw new ArgumentNullException(nameof(useCase));
        }

        [HttpPost("RegistrarUsuario")]
        public GenericResponse<string> RegistrarUsuario(Usuario usuario)
        {
            GenericResponse<string> reponse;
            try
            {
                reponse = new GenericResponse<string>()
                {
                    Status = new ResponseStatus() { HttpCode = HttpStatusCode.OK, Message = "Proceso Ejecutado Correctamente" },
                    Item = _useCase.RegistrarUsuario(usuario)
                };
            }
            catch (Exception ex)
            {
                reponse = new GenericResponse<string>()
                {
                    Status = new ResponseStatus()
                    { HttpCode = HttpStatusCode.InternalServerError, Message = ex.Message }
                };
            }
            return reponse;
        }

        [HttpPost("IniciarSession")]
        public GenericResponse<Usuario> IniciarSession(Usuario usuario)
        {
            GenericResponse<Usuario> reponse;
            try
            {
                reponse = new GenericResponse<Usuario>()
                {
                    Status = new ResponseStatus() { HttpCode = HttpStatusCode.OK, Message = "Proceso Ejecutado Correctamente" },
                    Item = _useCase.IniciarSession(usuario)
                };
            }
            catch (Exception ex)
            {
                reponse = new GenericResponse<Usuario>()
                {
                    Status = new ResponseStatus()
                    { HttpCode = HttpStatusCode.InternalServerError, Message = ex.Message }
                };
            }
            return reponse;
        }
    }
}
