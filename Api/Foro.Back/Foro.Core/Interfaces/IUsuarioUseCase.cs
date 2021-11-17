using Foro.Core.Domain;

namespace Foro.Core.Interfaces
{
    public interface IUsuarioUseCase
    {
        string RegistrarUsuario(Usuario usuario);
        Usuario IniciarSession(Usuario usuario);
    }
}
