using Foro.Api.Commond.Responses;
using Foro.Core.Domain;
using Foro.Core.Dto;
using Foro.Core.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace Foro.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PreguntaController : ControllerBase
    {

        private readonly IPreguntaUseCase _useCase;
        public PreguntaController(IPreguntaUseCase useCase)
        {
            _useCase = (useCase != null) ? useCase : throw new ArgumentNullException(nameof(useCase));
        }

        [HttpGet("GetListaPreguntas")]
        public GenericListResponse<PreguntaDto> GetPreguntas()
        {
            GenericListResponse<PreguntaDto> reponse;
            try
            {
                reponse = new GenericListResponse<PreguntaDto>()
                {
                    Status = new ResponseStatus() { HttpCode = HttpStatusCode.OK, Message = "Proceso Ejecutado Correctamente" },
                    Items = _useCase.GetListaPreguntas()
                };
            }
            catch (Exception ex)
            {
                reponse = new GenericListResponse<PreguntaDto>()
                {
                    Status = new ResponseStatus()
                    { HttpCode = HttpStatusCode.InternalServerError, Message = ex.Message }
                };
            }
            return reponse;
        }

        [HttpGet("GetPregunta")]
        public GenericResponse<DetallePregunta> GetPregunta(int codigoPregunta)
        {
            GenericResponse<DetallePregunta> reponse;
            try
            {
                reponse = new GenericResponse<DetallePregunta>()
                {
                    Status = new ResponseStatus() { HttpCode = HttpStatusCode.OK, Message = "Proceso Ejecutado Correctamente" },
                    Item = _useCase.GetPregunta(codigoPregunta)
                };
            }
            catch (Exception ex)
            {
                reponse = new GenericResponse<DetallePregunta>()
                {
                    Status = new ResponseStatus()
                    { HttpCode = HttpStatusCode.InternalServerError, Message = ex.Message }
                };
            }
            return reponse;
        }

        [HttpPost("RegistrarPregunta")]
        public GenericResponse<string> RegistrarPregunta(Pregunta pregunta)
        {
            GenericResponse<string> reponse;
            try
            {
                reponse = new GenericResponse<string>()
                {
                    Status = new ResponseStatus() { HttpCode = HttpStatusCode.OK, Message = "Proceso Ejecutado Correctamente" },
                    Item = _useCase.RegistrarPregunta(pregunta)
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

        [HttpPost("RegistrarRespuesta")]
        public GenericResponse<string> RegistrarRespuesta(Respuesta respuesta)
        {
            GenericResponse<string> reponse;
            try
            {
                reponse = new GenericResponse<string>()
                {
                    Status = new ResponseStatus() { HttpCode = HttpStatusCode.OK, Message = "Proceso Ejecutado Correctamente" },
                    Item = _useCase.RegistrarRespuesta(respuesta)
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

        [HttpPost("CerrarPregunta")]
        public GenericResponse<string> CerrarPregunta([FromBody] int codigoPregunta)
        {
            GenericResponse<string> reponse;
            try
            {
                reponse = new GenericResponse<string>()
                {
                    Status = new ResponseStatus() { HttpCode = HttpStatusCode.OK, Message = "Proceso Ejecutado Correctamente" },
                    Item = _useCase.CerrarPregunta(codigoPregunta)
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
    }
}
