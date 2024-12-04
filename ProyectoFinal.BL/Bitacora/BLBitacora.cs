using ProyectoFinal.ET;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using ProyectoFinal.DS;

namespace ProyectoFinal.BL
{
    public class BLBitacora : IBLBitacora
    {
        private IConfiguration _config;
        private IBitacoraRepository _bitacora;

        public BLBitacora(IBitacoraRepository usuario, IConfiguration config)
        {
            _config = config;
            _bitacora = usuario;
        }

        public bool RegistrarEvento(PeticionAPI peticion)
        {
            return _bitacora.RegistrarPeticionAPI(peticion);
        }

        public List<PeticionAPI> ConsultarPeticiones(DateTime fechaDesde, DateTime fechaHasta)
        {
            List<PeticionAPI> peticiones = null;

            peticiones = _bitacora.ConsultarPeticiones(fechaDesde, fechaHasta);

            return peticiones;
        }
    }
}
