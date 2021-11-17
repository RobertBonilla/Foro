using Foro.Core.Domain;
using Foro.Core.Interfaces;
using Foro.Core.UseCase;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NSubstitute;
using NSubstitute.ExceptionExtensions;
using System;

namespace Foro.Test.Core
{
    [TestClass]
    public class UsuarioUseCaseTest
    {
        [TestMethod, ExpectedException(typeof(ArgumentNullException))]
        public void CuandoIUsuarioRepositoryDelConstructorDeUsuarioUseCaseEsNull()
        {
            //Arrange
            //Act
            var repository = new UsuarioUseCase(null);
            //Assert
            //Attr: ExpectedException(typeof(ArgumentNullException))
        }

        [TestMethod]
        public void Cuando_RegistroUsuario_UseCase()
        {
            //Arrange
            var repository = Substitute.For<IUsuarioRepository>();

            var useCase = new UsuarioUseCase(repository);

            Usuario usuario = new Usuario();

            repository.RegistrarUsuario(usuario).Returns("");

            //Act
            var res = useCase.RegistrarUsuario(usuario);

            //Assert
            Assert.AreEqual("", res);
        }

        [TestMethod, ExpectedException(typeof(ArgumentNullException))]
        public void CuandoFalla_RegistroUsuario_UseCase()
        {
            //Arrange
            var repository = Substitute.For<IUsuarioRepository>();

            var useCase = new UsuarioUseCase(repository);

            Usuario usuario = new Usuario();

            repository.RegistrarUsuario(usuario).ThrowsForAnyArgs(t => { throw new ArgumentNullException(); });

            //Act
            var res = useCase.RegistrarUsuario(usuario);

            //Assert
            Assert.AreEqual("", res);
        }

        [TestMethod]
        public void Cuando_IniciarSession_UseCase()
        {
            //Arrange
            var repository = Substitute.For<IUsuarioRepository>();

            var useCase = new UsuarioUseCase(repository);

            Usuario usuario = new Usuario();

            repository.IniciarSession(usuario).Returns(usuario);

            //Act
            var res = useCase.IniciarSession(usuario);

            //Assert
            Assert.IsNotNull(res);
        }

        [TestMethod, ExpectedException(typeof(ArgumentNullException))]
        public void CuandoFalla_IniciarSession_UseCase()
        {
            //Arrange
            var repository = Substitute.For<IUsuarioRepository>();

            var useCase = new UsuarioUseCase(repository);

            Usuario usuario = new Usuario();

            repository.IniciarSession(usuario).ThrowsForAnyArgs(t => { throw new ArgumentNullException(); });

            //Act
            var res = useCase.IniciarSession(usuario);

            //Assert
            Assert.IsNotNull(res);
        }

    }
}
