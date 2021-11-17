using Foro.Core.Domain;
using Foro.Core.Dto;
using Foro.Core.Interfaces;
using System;
using System.Collections.Generic;

namespace Foro.Core.UseCase
{
    public class PreguntaUseCase : IPreguntaUseCase
    {
        private readonly IPreguntaRepository _repository;

        public PreguntaUseCase(IPreguntaRepository repository)
        {
            _repository = (repository != null) ? repository : throw new ArgumentException(nameof(repository));
        }
        public string CerrarPregunta(int codigoPregunta)
        {
            return _repository.CerrarPregunta(codigoPregunta);
        }

        public List<PreguntaDto> GetListaPreguntas()
        {
            return _repository.GetListaPreguntas();
        }

        public DetallePregunta GetPregunta(int codigoPregunta)
        {
            DetallePregunta detalle = new DetallePregunta();
            detalle.Pregunta = _repository.GetPregunta(codigoPregunta);
            detalle.ListaRespuesta = _repository.GetListaRespuesta(codigoPregunta);
            return detalle;
        }

        public string RegistrarPregunta(Pregunta pregunta)
        {
            return _repository.RegistrarPregunta(pregunta);
        }

        public string RegistrarRespuesta(Respuesta respuesta)
        {
            return _repository.RegistrarRespuesta(respuesta);
        }
    }
}
