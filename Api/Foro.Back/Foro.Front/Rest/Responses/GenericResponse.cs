namespace Foro.Front.Rest.Responses
{
    public class GenericResponse<T>
    {
        public ResponseStatus Status { get; set; }
        public T Item { get; set; }
    }
}
