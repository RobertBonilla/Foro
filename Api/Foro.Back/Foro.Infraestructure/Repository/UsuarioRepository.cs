using Foro.Core.Domain;
using Foro.Core.Interfaces;
using Microsoft.Extensions.Configuration;
using System;
using System.Data;
using System.Data.SqlClient;

namespace Foro.Infraestructure.Repository
{
    public class UsuarioRepository : IUsuarioRepository
    {

        private readonly IConfiguration _configuration;
        public UsuarioRepository(IConfiguration configuration)
        {
            _configuration = (configuration != null) ? configuration : throw new ArgumentNullException(nameof(configuration));
        }

        public Usuario IniciarSession(Usuario usuario)
        {
            Usuario newModel = null;
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
                            cmd.CommandText = "dbo.usuario_login";
                            cmd.Parameters.AddWithValue("username", usuario.username);
                            cmd.Parameters.AddWithValue("contra", usuario.contra);
                            cmd.Transaction = sqlTran;
                            cmd.Connection = con;
                            using (SqlDataReader sdr = cmd.ExecuteReader())
                            {
                                while (sdr.Read())
                                {
                                    newModel = new Usuario()
                                    {
                                        idUsuario = (sdr["idUsuario"] != null) ? int.Parse(sdr["idUsuario"].ToString()) : 0,
                                        nombre = sdr["nombre"].ToString(),
                                        correo = sdr["correo"].ToString(),
                                        username = sdr["username"].ToString(),
                                        activo = (sdr["activo"] != null) ? bool.Parse(sdr["activo"].ToString()) : false,
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

        public string RegistrarUsuario(Usuario usuario)
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
                            cmd.CommandText = "dbo.usuario_registrar";
                            cmd.Transaction = sqlTran;
                            cmd.Connection = con;
                            cmd.Parameters.AddWithValue("username", usuario.username);
                            cmd.Parameters.AddWithValue("nombre", usuario.nombre);
                            cmd.Parameters.AddWithValue("correo", usuario.correo);
                            cmd.Parameters.AddWithValue("contra", usuario.contra);
                            int result = cmd.ExecuteNonQuery();
                            sqlTran.Commit();
                            retorno = "Usuario Guardado con Exito";
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
