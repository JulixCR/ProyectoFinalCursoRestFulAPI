using ProyectoFinal.ET;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using System.Data.SqlClient;
using Dapper;

namespace ProyectoFinal.DS
{
    public class UsuarioRepository : IUsuarioRepository
    {
        private IConfiguration _config;

        public UsuarioRepository(IConfiguration config)
        {
            _config = config;
        }

        public Usuario ConsultarCredenciales(Usuario login)
        {
            SqlConnection db = new SqlConnection(_config.GetConnectionString("ProyectoConn"));

            var result = db.Query<Usuario>(
                sql: "SP_ConsultarUsuario",
                param: new { Id = login.Id, Pass = login.Password},
                commandType: System.Data.CommandType.StoredProcedure
            );
            return result.FirstOrDefault();
        }

        public bool InsertarCredenciales(Usuario login)
        {
            SqlConnection db = new SqlConnection(_config.GetConnectionString("ProyectoConn"));

            var result = db.Execute(
                sql: "SP_ConsultarUsuario",
                param: new { Id = login.Id, Nombre = login.Nombre, Pass = login.Password },
                commandType: System.Data.CommandType.StoredProcedure
            );
            return true;
        }
    }
}
