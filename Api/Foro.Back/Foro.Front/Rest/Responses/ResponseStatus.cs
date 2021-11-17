using System.Net;

namespace Foro.Front.Rest.Responses
{
    public class ResponseStatus
    {
        public HttpStatusCode HttpCode { get; set; }
        public string Message { get; set; }
    }
}
