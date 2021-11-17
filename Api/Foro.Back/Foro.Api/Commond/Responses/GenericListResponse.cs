using System.Collections.Generic;

namespace Foro.Api.Commond.Responses
{
    public class GenericListResponse<T>
    {
        public ResponseStatus Status { get; set; }
        public IEnumerable<T> Items { get; set; }
    }
}
