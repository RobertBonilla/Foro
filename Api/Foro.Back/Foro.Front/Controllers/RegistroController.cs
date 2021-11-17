using Foro.Front.Models;
using Foro.Front.Models.Domain;
using Foro.Front.Rest.Interfaces;
using Foro.Front.Rest.Responses;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Diagnostics;
using System.Net;

namespace Foro.Front.Controllers
{
    public class RegistroController : Controller
    {
        private readonly ILogger<RegistroController> _logger;
        private readonly IApiRest _apiRest;

        public RegistroController(ILogger<RegistroController> logger, IApiRest apiRest)
        {
            _logger = (logger != null) ? logger : throw new ArgumentNullException(nameof(logger));
            _apiRest = (apiRest != null) ? apiRest : throw new ArgumentNullException(nameof(apiRest));
        }
        public IActionResult Index()
        {
            if (VerificarSession()) return RedirectToAction("Index", "Preguntas");
            return View();
        }

        public IActionResult CerrarSession()
        {
            HttpContext.Session.Remove("SessionUser");
            return RedirectToAction("Index");
        }

        public string Registrar(string nombre, string correo, string username, string contra)
        {
            GenericResponse<string> result;
            try
            {
                result = _apiRest.RegistrarUsuario(new Usuario()
                {
                    nombre = nombre,
                    correo = correo,
                    username = username,
                    contra = contra
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

        public string IniciarSession(string username, string contra)
        {
            GenericResponse<Usuario> result;
            try
            {
                result = _apiRest.IniciarSession(new Usuario()
                {
                    username = username,
                    contra = contra
                });
                if(result != null && result.Item != null && result.Status.HttpCode == HttpStatusCode.OK)
                {
                    HttpContext.Session.SetString("SessionUser", Newtonsoft.Json.JsonConvert.SerializeObject(result.Item));
                }
            }
            catch (Exception)
            {
                result = new GenericResponse<Usuario>
                {
                    Status = new ResponseStatus()
                    { HttpCode = HttpStatusCode.InternalServerError, Message = "Error en la Peticion" }
                };
            }
            return Newtonsoft.Json.JsonConvert.SerializeObject(result);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        private bool VerificarSession()
        {
            bool resp = false;
            try
            {
                var user = Newtonsoft.Json.JsonConvert.DeserializeObject(HttpContext.Session.GetString("SessionUser"));
                if (user != null)
                {
                    resp = true;
                }
            }
            catch (Exception)
            {
            }
            return resp;
        }
    }
}
