using System.Collections.Generic;

namespace Foro.Front.Rest.Responses
{
    public class GenericListResponse<T>
    {
        public ResponseStatus Status { get; set; }
        public IEnumerable<T> Items { get; set; }
    }
}
