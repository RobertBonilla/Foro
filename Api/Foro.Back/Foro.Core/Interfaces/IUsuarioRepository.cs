using Foro.Core.Domain;

namespace Foro.Core.Interfaces
{
    public interface IUsuarioRepository
    {
        string RegistrarUsuario(Usuario usuario);
        Usuario IniciarSession(Usuario usuario);
    }
}
