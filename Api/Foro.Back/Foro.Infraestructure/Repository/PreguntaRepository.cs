using Foro.Core.Domain;
using Foro.Core.Dto;
using Foro.Core.Interfaces;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace Foro.Infraestructure.Repository
{
    public class PreguntaRepository : IPreguntaRepository
    {
        private readonly IConfiguration _configuration;
        public PreguntaRepository(IConfiguration configuration)
        {
            _configuration = (configuration != null) ? configuration : throw new ArgumentNullException(nameof(configuration));
        }
        public string CerrarPregunta(int codigoPregunta)
        {
            string retorno = "";
            try
            {
                using (SqlConnection con = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
                {
                    con.Open();
                    using (SqlTransaction sqlTran = con.BeginTransaction())
                    {
                        using (SqlCommand cmd = new SqlCommand())
                        {
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.CommandText = "dbo.pregunta_cerrar";
                            cmd.Transaction = sqlTran;
                            cmd.Connection = con;
                            cmd.Parameters.AddWithValue("idPregunta", codigoPregunta);
                            int result = cmd.ExecuteNonQuery();
                            sqlTran.Commit();
                            retorno = "Pregunta Cerrada con Exito";
                        }
                    }
                    con.Close();
                }
            }
            catch (Exception ex)
            {
                throw new ArgumentException(ex.Message);
            }
            return retorno;
        }

        public List<PreguntaDto> GetListaPreguntas()
        {
            List<PreguntaDto> list = new List<PreguntaDto>();
            try
            {
                using (SqlConnection con = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
                {
                    con.Open();
                    using (SqlTransaction sqlTran = con.BeginTransaction())
                    {
                        using (SqlCommand cmd = new SqlCommand())
                        {
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.CommandText = "dbo.pregunta_get_lista";
                            cmd.Transaction = sqlTran;
                            cmd.Connection = con;
                            using (SqlDataReader sdr = cmd.ExecuteReader())
                            {
                                while (sdr.Read())
                                {
                                    list.Add(new PreguntaDto()
                                    {
                                        idPregunta = (sdr["idPregunta"] != null) ? int.Parse(sdr["idPregunta"].ToString()) : 0,
                                        idUsuario = (sdr["idUsuario"] != null) ? int.Parse(sdr["idUsuario"].ToString()) : 0,
                                        titulo = sdr["titulo"].ToString(),
                                        descripcion = sdr["descripcion"].ToString(),
                                        username = sdr["username"].ToString(),
                                        nombre = sdr["nombre"].ToString(),
                                        activo = (sdr["activo"] != null) ? bool.Parse(sdr["activo"].ToString()) : false,
                                        fecha = (sdr["fecha"] != null) ? DateTime.Parse(sdr["fecha"].ToString()) : DateTime.Now,
                                    });
                                }
                            }
                            sqlTran.Commit();
                        }
                    }
                    con.Close();
                }
            }
            catch (Exception ex)
            {
                throw new ArgumentException(ex.Message);
            }
            return list;
        }

        public List<RespuestaDto> GetListaRespuesta(int codigoPregunta)
        {
            List<RespuestaDto> list = new List<RespuestaDto>();
            try
            {
                using (SqlConnection con = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
                {
                    con.Open();
                    using (SqlTransaction sqlTran = con.BeginTransaction())
                    {
                        using (SqlCommand cmd = new SqlCommand())
                        {
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.CommandText = "dbo.respuesta_get_lista";
                            cmd.Parameters.AddWithValue("idPregunta", codigoPregunta);
                            cmd.Transaction = sqlTran;
                            cmd.Connection = con;
                            using (SqlDataReader sdr = cmd.ExecuteReader())
                            {
                                while (sdr.Read())
                                {
                                    list.Add(new RespuestaDto()
                                    {
                                        idRespuesta = (sdr["idRespuesta"] != null) ? int.Parse(sdr["idRespuesta"].ToString()) : 0,
                                        idPregunta = (sdr["idPregunta"] != null) ? int.Parse(sdr["idPregunta"].ToString()) : 0,
                                        idUsuario = (sdr["idUsuario"] != null) ? int.Parse(sdr["idUsuario"].ToString()) : 0,
                                        descripcion = sdr["descripcion"].ToString(),
                                        username = sdr["username"].ToString(),
                                        nombre = sdr["nombre"].ToString(),
                                        fecha = (sdr["fecha"] != null) ? DateTime.Parse(sdr["fecha"].ToString()) : DateTime.Now,
                                    });
                                }
                            }
                            sqlTran.Commit();
                        }
                    }
                    con.Close();
                }
            }
            catch (Exception ex)
            {
                throw new ArgumentException(ex.Message);
            }
            return list;
        }

        public PreguntaDto GetPregunta(int codigoPregunta)
        {
            PreguntaDto newModel = null;
            try
            {
                using (SqlConnection con = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
                {
                    con.Open();
                    using (SqlTransaction sqlTran = con.BeginTransaction())
                    {
                        using (SqlCommand cmd = new SqlCommand())
                        {
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.CommandText = "dbo.pregunta_get";
                            cmd.Parameters.AddWithValue("idPregunta", codigoPregunta);
                            cmd.Transaction = sqlTran;
                            cmd.Connection = con;
                            using (SqlDataReader sdr = cmd.ExecuteReader())
                            {
                                while (sdr.Read())
                                {
                                    newModel = new PreguntaDto()
                                    {
                                        idPregunta = (sdr["idPregunta"] != null) ? int.Parse(sdr["idPregunta"].ToString()) : 0,
                                        idUsuario = (sdr["idUsuario"] != null) ? int.Parse(sdr["idUsuario"].ToString()) : 0,
                                        titulo = sdr["titulo"].ToString(),
                                        descripcion = sdr["descripcion"].ToString(),
                                        username = sdr["username"].ToString(),
                                        nombre = sdr["nombre"].ToString(),
                                        activo = (sdr["activo"] != null) ? bool.Parse(sdr["activo"].ToString()) : false,
                                        fecha = (sdr["fecha"] != null) ? DateTime.Parse(sdr["fecha"].ToString()) : DateTime.Now,
                                    };
                                }
                            }
                            sqlTran.Commit();
                        }
                    }
                    con.Close();
                }
            }
            catch (Exception ex)
            {
                throw new ArgumentException(ex.Message);
            }
            return newModel;
        }

        public string RegistrarPregunta(Pregunta pregunta)
        {
            string retorno = "";
            try
            {
                using (SqlConnection con = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
                {
                    con.Open();
                    using (SqlTransaction sqlTran = con.BeginTransaction())
                    {
                        using (SqlCommand cmd = new SqlCommand())
                        {
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.CommandText = "dbo.pregunta_registrar";
                            cmd.Transaction = sqlTran;
                            cmd.Connection = con;
                            cmd.Parameters.AddWithValue("idUsuario", pregunta.idUsuario);
                            cmd.Parameters.AddWithValue("titulo", pregunta.titulo);
                            cmd.Parameters.AddWithValue("descripcion", pregunta.descripcion);
                            int result = cmd.ExecuteNonQuery();
                            sqlTran.Commit();
                            retorno = "Pregunta Guardada con Exito";
                        }
                    }
                    con.Close();
                }
            }
            catch (Exception ex)
            {
                throw new ArgumentException(ex.Message);
            }
            return retorno;
        }

        public string RegistrarRespuesta(Respuesta respuesta)
        {
            string retorno = "";
            try
            {
                using (SqlConnection con = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
                {
                    con.Open();
                    using (SqlTransaction sqlTran = con.BeginTransaction())
                    {
                        using (SqlCommand cmd = new SqlCommand())
                        {
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.CommandText = "dbo.respuesta_registrar";
                            cmd.Transaction = sqlTran;
                            cmd.Connection = con;
                            cmd.Parameters.AddWithValue("idPregunta", respuesta.idPregunta);
                            cmd.Parameters.AddWithValue("idUsuario", respuesta.idUsuario);
                            cmd.Parameters.AddWithValue("descripcion", respuesta.descripcion);
                            int result = cmd.ExecuteNonQuery();
                            sqlTran.Commit();
                            retorno = "Respuesta Guardada con Exito";
                        }
                    }
                    con.Close();
                }
            }
            catch (Exception ex)
            {
                throw new ArgumentException(ex.Message);
            }
            return retorno;
        }

    }
}
