using Microsoft.AspNetCore.Mvc;
using WEB_API_PERIODICO.Clases;

namespace WEB_API_PERIODICO.Controllers
{
    [Route("Roles")]
    [ApiController]
    public class RoleController : Controller
    {
        [HttpGet]
        public ActionResult getRoles()
        {
            return this.Content(ClsUsuario.getRole(), "application/json", System.Text.Encoding.UTF8);
        }
    }
}
