using Foro.Api.Commond.Responses;
using Foro.Api.Controllers;
using Foro.Core.Domain;
using Foro.Core.Interfaces;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NSubstitute;
using NSubstitute.ExceptionExtensions;
using System;

namespace Foro.Test.Api
{
    [TestClass]
    public class UsuarioControllerTest
    {

        [TestMethod, ExpectedException(typeof(ArgumentNullException))]
        public void Cuando_IUsuarioUseCase_DelConstructorDe_UsuarioController_EsNull()
        {
            //Arrange
            //Act
            var repository = new UsuarioController(null);
            //Assert
            //Attr: ExpectedException(typeof(ArgumentNullException))
        }

        [TestMethod]
        public void Cuando_RegistroUsuario()
        {
            //Arrange
            var useCase = Substitute.For<IUsuarioUseCase>();

            var controller = new UsuarioController(useCase);

            Usuario usuario = new Usuario();

            GenericResponse<string> response = new GenericResponse<string>()
            {
                Status = new ResponseStatus() { HttpCode = System.Net.HttpStatusCode.OK, Message = "OK" },
                Item = ""
            };

            useCase.RegistrarUsuario(usuario).Returns("");

            //Act
            GenericResponse<string> res = controller.RegistrarUsuario(usuario);

            //Assert
            Assert.AreEqual(System.Net.HttpStatusCode.OK, res.Status.HttpCode);
        }

        [TestMethod]
        public void CuandoFalla_RegistroUsuario()
        {
            //Arrange
           
            var useCase = Substitute.For<IUsuarioUseCase>();

            Usuario usuario = new Usuario();

            useCase.RegistrarUsuario(usuario).ThrowsForAnyArgs(t => { throw new ArgumentNullException(); });

            var controller = new UsuarioController(useCase);
            //Act
            var res = controller.RegistrarUsuario(usuario);

            //Assert
            Assert.AreEqual(System.Net.HttpStatusCode.InternalServerError, res.Status.HttpCode);
        }

        [TestMethod]
        public void Cuando_InicioSession()
        {
            //Arrange
            var useCase = Substitute.For<IUsuarioUseCase>();

            var controller = new UsuarioController(useCase);

            Usuario usuario = new Usuario();

            GenericResponse<string> response = new GenericResponse<string>()
            {
                Status = new ResponseStatus() { HttpCode = System.Net.HttpStatusCode.OK, Message = "OK" },
                Item = ""
            };

            useCase.IniciarSession(usuario).Returns(usuario);

            //Act
            GenericResponse<Usuario> res = controller.IniciarSession(usuario);

            //Assert
            Assert.AreEqual(System.Net.HttpStatusCode.OK, res.Status.HttpCode);
        }

        [TestMethod]
        public void CuandoFalla_InicioSession()
        {
            //Arrange
            var useCase = Substitute.For<IUsuarioUseCase>();

            var controller = new UsuarioController(useCase);

            Usuario usuario = new Usuario();

            GenericResponse<string> response = new GenericResponse<string>()
            {
                Status = new ResponseStatus() { HttpCode = System.Net.HttpStatusCode.OK, Message = "OK" },
                Item = ""
            };

            useCase.IniciarSession(usuario).ThrowsForAnyArgs(t => { throw new ArgumentNullException(); });

            //Act
            GenericResponse<Usuario> res = controller.IniciarSession(usuario);

            //Assert
            Assert.AreEqual(System.Net.HttpStatusCode.InternalServerError, res.Status.HttpCode);
        }

    }
}
