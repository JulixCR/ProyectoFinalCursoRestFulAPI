using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ProyectoFinal.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HaciendaController : ControllerBase
    {
        // GET: api/<HaciendaController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<HaciendaController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
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
