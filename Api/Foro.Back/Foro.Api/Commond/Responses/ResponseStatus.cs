using System.Net;

namespace Foro.Api.Commond.Responses
{
    public class ResponseStatus
    {
        public HttpStatusCode HttpCode { get; set; }
        public string Message { get; set; }
    }
}
