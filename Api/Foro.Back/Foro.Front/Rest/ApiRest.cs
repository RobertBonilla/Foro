using Foro.Front.Models.Domain;
using Foro.Front.Models.Dto;
using Foro.Front.Rest.Interfaces;
using Foro.Front.Rest.Responses;
using Microsoft.Extensions.Configuration;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Foro.Front.Rest
{
    public class ApiRest:IApiRest
    {
        private readonly IConfiguration _configuration;
        private readonly string UrlBase;

        public ApiRest(IConfiguration configuration)
        {
            _configuration = (configuration != null) ? configuration : throw new ArgumentNullException(nameof(configuration));
            UrlBase = _configuration.GetConnectionString("ApiBack");
        }       

        public GenericListResponse<PreguntaDto> GetPreguntas()
        {
            RestClient rest = new RestClient(UrlBase);
            var restRequest = new RestRequest($"Pregunta/GetListaPreguntas", Method.GET);
            restRequest.Timeout = 600000;
            var restResponse = rest.Execute<GenericListResponse<PreguntaDto>>(restRequest);
            if (restResponse.ErrorException != null)
                throw new Exception(restResponse.ErrorMessage, restResponse.ErrorException);
            return restResponse.Data;
        }

        public GenericResponse<DetallePregunta> GetPregunta(int codigoPregunta)
        {
            RestClient rest = new RestClient(UrlBase);
            var restRequest = new RestRequest($"Pregunta/GetPregunta?codigoPregunta=" + codigoPregunta, Method.GET);
            restRequest.Timeout = 600000;
            var restResponse = rest.Execute<GenericResponse<DetallePregunta>>(restRequest);
            if (restResponse.ErrorException != null)
                throw new Exception(restResponse.ErrorMessage, restResponse.ErrorException);
            return restResponse.Data;
        }

        public GenericResponse<string> RegistrarRespuesta(Respuesta respuesta)
        {
            RestClient rest = new RestClient(UrlBase);
            var restRequest = new RestRequest($"/Pregunta/RegistrarRespuesta", Method.POST);
            restRequest.Timeout = 600000;
            restRequest.RequestFormat = DataFormat.Json;
            restRequest.AddJsonBody(respuesta);
            var restResponse = rest.Execute<GenericResponse<string>>(restRequest);
            if (restResponse.ErrorException != null)
                throw new Exception(restResponse.ErrorMessage, restResponse.ErrorException);
            return restResponse.Data;
        }

        public GenericResponse<string> CerrarPregunta(int codigoPregunta)
        {
            RestClient rest = new RestClient(UrlBase);
            var restRequest = new RestRequest($"/Pregunta/CerrarPregunta", Method.POST);
            restRequest.Timeout = 600000;
            restRequest.RequestFormat = DataFormat.Json;
            restRequest.AddJsonBody(codigoPregunta);
            var restResponse = rest.Execute<GenericResponse<string>>(restRequest);
            if (restResponse.ErrorException != null)
                throw new Exception(restResponse.ErrorMessage, restResponse.ErrorException);
            return restResponse.Data;
        }

        public GenericResponse<string> RegistrarPregunta(Pregunta pregunta)
        {
            RestClient rest = new RestClient(UrlBase);
            var restRequest = new RestRequest($"/Pregunta/RegistrarPregunta", Method.POST);
            restRequest.Timeout = 600000;
            restRequest.RequestFormat = DataFormat.Json;
            restRequest.AddJsonBody(pregunta);
            var restResponse = rest.Execute<GenericResponse<string>>(restRequest);
            if (restResponse.ErrorException != null)
                throw new Exception(restResponse.ErrorMessage, restResponse.ErrorException);
            return restResponse.Data;
        }

        public GenericResponse<string> RegistrarUsuario(Usuario usuario)
        {
            RestClient rest = new RestClient(UrlBase);
            var restRequest = new RestRequest($"/Usuario/RegistrarUsuario", Method.POST);
            restRequest.Timeout = 600000;
            restRequest.RequestFormat = DataFormat.Json;
            restRequest.AddJsonBody(usuario);
            var restResponse = rest.Execute<GenericResponse<string>>(restRequest);
            if (restResponse.ErrorException != null)
                throw new Exception(restResponse.ErrorMessage, restResponse.ErrorException);
            return restResponse.Data;
        }

        public GenericResponse<Usuario> IniciarSession(Usuario usuario)
        {
            RestClient rest = new RestClient(UrlBase);
            var restRequest = new RestRequest($"/Usuario/IniciarSession", Method.POST);
            restRequest.Timeout = 600000;
            restRequest.RequestFormat = DataFormat.Json;
            restRequest.AddJsonBody(usuario);
            var restResponse = rest.Execute<GenericResponse<Usuario>>(restRequest);
            if (restResponse.ErrorException != null)
                throw new Exception(restResponse.ErrorMessage, restResponse.ErrorException);
            return restResponse.Data;
        }
    }
}
