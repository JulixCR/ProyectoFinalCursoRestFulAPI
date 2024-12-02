using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ProyectoFinal.ET;
using ProyectoFinal.API.Services;
using ProyectoFinal.BL;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ProyectoFinal.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HaciendaController : ControllerBase
    {
        private readonly IHaciendaServices _servicioHacienda;
        private IBLBitacora _bitacora;

        public HaciendaController(IHaciendaServices servicioHacienda, IBLBitacora bitacora)
        {
            this._servicioHacienda = servicioHacienda;
            this._bitacora = bitacora;
        }

        [HttpGet("ConsultarSituacionTributaria")]
        [Authorize]
        public IActionResult ConsultarSituacionTributaria(string identificacion)
        {
            Task<SituacionTributaria> situacion = _servicioHacienda.ConsultarSituacionTributaria(identificacion);

            if (situacion.Result != null)
            {
                return Ok(situacion.Result);
            }
            else
            {
                return NotFound();
            }
        }

        [HttpGet("ConsultarIndicadorEconomico")]
        [Authorize]
        public IActionResult ConsultarIndicadorEconomico()
        {
            Task<Indicadores> situacion = _servicioHacienda.ConsultarIndicadorEconomico();

            if (situacion.Result != null)
            {
                return Ok(situacion.Result);
            }
            else
            {
                return NotFound();
            }
        }

        [HttpGet("ConsultarExoneracion")]
        [Authorize]
        public IActionResult ConsultarExoneracion(string exoneracion)
        {
            Task<Exoneracion> situacion = _servicioHacienda.ConsultarExoneracion(exoneracion);

            if (situacion.Result != null)
            {
                return Ok(situacion.Result);
            }
            else
            {
                return NotFound();
            }
        }

        [HttpGet("ConsultarProductorAgropecuario")]
        [Authorize]
        public IActionResult ConsultarProductorAgropecuario(string identificacion)
        {
            Task<Agropecuario> situacion = _servicioHacienda.ConsultarProductorAgropecuario(identificacion);

            if (situacion.Result != null)
            {
                return Ok(situacion.Result);
            }
            else
            {
                return NotFound();
            }
        }

        [HttpGet("ConsultarCabys")]
        [Authorize]
        public IActionResult ConsultarCabys(string codigoConsulta)
        {
            Task<CodigoCabys> situacion = _servicioHacienda.ConsultarCabys(codigoConsulta);

            if (situacion.Result != null)
            {
                return Ok(situacion.Result);
            }
            else
            {
                return NotFound();
            }
        }

        [HttpGet("ConsultarBitacora")]
        [Authorize]
        public IActionResult ConsultarBitacora(string idUsuario)
        {
            List<PeticionAPI> bitacoraAPI = _bitacora.ConsultarPeticionesUsuario(idUsuario);

            if (bitacoraAPI != null)
            {
                return Ok(bitacoraAPI);
            }
            else
            {
                return NotFound();
            }
        }
    }
}
