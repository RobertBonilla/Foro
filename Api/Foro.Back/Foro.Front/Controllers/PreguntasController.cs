using Foro.Front.Models;
using Foro.Front.Models.Domain;
using Foro.Front.Models.Dto;
using Foro.Front.Rest.Interfaces;
using Foro.Front.Rest.Responses;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace Foro.Front.Controllers
{
    public class PreguntasController : Controller
    {
        private readonly ILogger<PreguntasController> _logger;
        private readonly IApiRest _apiRest;
        private Usuario userSession;

        public PreguntasController(ILogger<PreguntasController> logger, IApiRest apiRest)
        {
            _logger = (logger != null) ? logger : throw new ArgumentNullException(nameof(logger));
            _apiRest = (apiRest != null) ? apiRest : throw new ArgumentNullException(nameof(apiRest));
        }
        public IActionResult Index()
        {
            if (!VerificarSession()) return RedirectToAction("Index","Registro");
            try
            {
                GenericListResponse<PreguntaDto> result = _apiRest.GetPreguntas();
                ViewData["Lista"] = result.Items;
            }
            catch (Exception)
            {
            }            
            return View();
        }

        public IActionResult Detail(int id)
        {
            if (!VerificarSession()) return RedirectToAction("Index", "Registro");
            try
            {
                GenericResponse<DetallePregunta> result = _apiRest.GetPregunta(id);                
                if (!(result !=null && result.Item != null)) RedirectToAction("Index");
                ViewData["ListaModel"] = result.Item;
            }
            catch (Exception)
            {
                RedirectToAction("Index");
            }            
            return View();
        }

        public string CrearPregunta(string titulo, string descripcion)
        {
            GenericResponse<string> result;
            try
            {
                if (!VerificarSession()) throw new ArgumentException("Session Inactiva");
                result = _apiRest.RegistrarPregunta(new Pregunta()
                {
                    titulo = titulo,
                    descripcion = descripcion,
                    idUsuario = userSession.idUsuario
                });
            }
            catch (Exception)
            {
                result = new GenericResponse<string>
                {
                    Status = new ResponseStatus()
                    { HttpCode = HttpStatusCode.InternalServerError, Message = "Error en la Peticion" }
                };
            }
            return Newtonsoft.Json.JsonConvert.SerializeObject(result);
        }

        public string Responder(int idPregunta, string descripcion)
        {            
            GenericResponse<string> result;
            try
            {
                if (!VerificarSession()) throw new ArgumentException("Session Inactiva");
                result = _apiRest.RegistrarRespuesta(new Respuesta()
                {
                    idPregunta = idPregunta,
                    descripcion = descripcion,
                    idUsuario = userSession.idUsuario
                });
            }
            catch (Exception)
            {
                result = new GenericResponse<string>
                {
                    Status = new ResponseStatus()
                    { HttpCode = HttpStatusCode.InternalServerError, Message = "Error en la Peticion" }
                };
            }
            return Newtonsoft.Json.JsonConvert.SerializeObject(result);
        }

        public string CerrarPregunta(int idPregunta)
        {
            GenericResponse<string> result;
            try
            {
                result = _apiRest.CerrarPregunta(idPregunta);
            }
            catch (Exception)
            {
                result = new GenericResponse<string>
                {
                    Status = new ResponseStatus()
                    { HttpCode = HttpStatusCode.InternalServerError, Message = "Error en la Peticion" }
                };
            }            
            return Newtonsoft.Json.JsonConvert.SerializeObject(result);
        }

        private bool VerificarSession()
        {
            bool resp = false;
            try
            {
                Usuario user = Newtonsoft.Json.JsonConvert.DeserializeObject<Usuario>(HttpContext.Session.GetString("SessionUser"));
                if(user != null)
                {
                    resp = true;
                    userSession = user;
                    ViewData["UserModel"] = userSession;
                }
            }
            catch (Exception){}
            return resp;
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
