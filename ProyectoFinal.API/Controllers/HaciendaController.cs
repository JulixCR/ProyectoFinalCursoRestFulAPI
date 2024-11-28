using Microsoft.AspNetCore.Mvc;
using ProyectoFinal.API.Models;
using ProyectoFinal.API.Services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ProyectoFinal.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HaciendaController : ControllerBase
    {
        private readonly IHaciendaServices _servicioHacienda;

        public HaciendaController(IHaciendaServices servicioHacienda)
        {
            this._servicioHacienda = servicioHacienda;
        }

        // GET: api/<HaciendaController>
        [HttpGet("ConsultarSituacionTributaria")]
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

        // POST api/<HaciendaController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<HaciendaController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<HaciendaController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
