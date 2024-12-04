using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProyectoFinal.API.Services;
using ProyectoFinal.BL;
using ProyectoFinal.ET;

namespace ProyectoFinal.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GoMetaController : ControllerBase
    {
        private readonly IGoMetaServices _servicioGoMeta;

        public GoMetaController(IGoMetaServices servicioGoMeta)
        {
            this._servicioGoMeta = servicioGoMeta;
        }

        [HttpGet("StatusAPIHacienda")]
        [Authorize]
        public IActionResult StatusAPIHacienda()
        {
            Task<StatusAPI?> estado = _servicioGoMeta.StatusAPIHacienda();

            if (estado.Result != null)
            {
                return Ok(estado.Result);
            }
            else
            {
                return NotFound();
            }
        }
    }
}
