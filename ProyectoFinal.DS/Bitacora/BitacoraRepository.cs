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
    public class BitacoraRepository : IBitacoraRepository
    {
        private IConfiguration _config;

        public BitacoraRepository(IConfiguration config)
        {
            _config = config;
        }

        public bool RegistrarPeticionAPI(PeticionAPI peticion)
        {
            try
            {
                SqlConnection db = new SqlConnection(_config.GetConnectionString("ProyectoConn"));

                var result = db.ExecuteAsync(
                    sql: "SP_RegistrarPeticionAPI",
                    param: new { IdUsuario = peticion.IdUsuario, Endpoint = peticion.Endpoint},
                    commandType: System.Data.CommandType.StoredProcedure
                );

                return true;

            }
            catch (Exception)
            {
                return false;
            }
        }

        public List<PeticionAPI> ConsultarPeticiones(string idUsuario)
        {
            try
            {
                SqlConnection db = new SqlConnection(_config.GetConnectionString("ProyectoConn"));

                var result = db.Query<PeticionAPI>(
                    sql: "SP_ConsultarPeticionesAPI",
                    param: new { IdUsuario = idUsuario},
                    commandType: System.Data.CommandType.StoredProcedure
                );
                return result.ToList();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
