using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WEB_API_PERIODICO.Clases;

namespace WEB_API_PERIODICO.Controllers
{
    [Route("Suscripcion")]
    [ApiController]
    public class SuscripcionController : Controller
    {
        [HttpGet("Tipos")]
        public ActionResult getTipoSuscripcion()
        {
            return this.Content(ClsSuscripcion.getTipoSuscripcion(), "application/json", System.Text.Encoding.UTF8);
        }
    }
}
