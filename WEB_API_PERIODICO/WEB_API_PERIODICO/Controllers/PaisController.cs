using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WEB_API_PERIODICO.Clases;

namespace WEB_API_PERIODICO.Controllers
{
    [Route("Region")]
    [ApiController]
    public class PaisController : Controller
    {
        [HttpGet]
        public ActionResult getPaises()
        {
            return this.Content(ClsPais.getPaises(), "application/json", System.Text.Encoding.UTF8);
        }
    }
}
