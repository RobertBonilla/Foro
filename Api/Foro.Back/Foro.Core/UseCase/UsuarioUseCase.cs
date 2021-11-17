using Foro.Core.Domain;
using Foro.Core.Interfaces;
using System;

namespace Foro.Core.UseCase
{
    public class UsuarioUseCase : IUsuarioUseCase
    {
        private readonly IUsuarioRepository _repository;

        public UsuarioUseCase(IUsuarioRepository repository)
        {
            _repository = (repository != null) ? repository : throw new ArgumentNullException(nameof(repository));
        }
        public Usuario IniciarSession(Usuario usuario)
        {
            if (usuario.username != null) usuario.username = usuario.username.Trim().ToUpper();
            return _repository.IniciarSession(usuario);
        }

        public string RegistrarUsuario(Usuario usuario)
        {
            if (usuario.username != null) usuario.username = usuario.username.Trim().ToUpper();
            return _repository.RegistrarUsuario(usuario);
        }
    }
}
