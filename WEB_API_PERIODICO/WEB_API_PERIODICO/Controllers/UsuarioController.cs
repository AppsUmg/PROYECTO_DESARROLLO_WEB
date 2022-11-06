using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WEB_API_PERIODICO.Clases;

namespace WEB_API_PERIODICO.Controllers
{
    [Route("Usuario")]
    [ApiController]

    public class UsuarioController : Controller
    {
        [HttpPost]
        public ActionResult CrearUsuario([FromBody] ClsUsuario usuario)
        {
            return this.Content(ClsUsuario.CrearUsuario(usuario), "application/json", System.Text.Encoding.UTF8);
        }

        [HttpPut]
        public ActionResult ModificarUsuario(ClsUsuario usuario)
        {
            return this.Content(ClsUsuario.ModificarUsuario(usuario), "application/json", System.Text.Encoding.UTF8);
        }
        [HttpGet("{USER_NAME}")]
        public ActionResult getUsuarioByUserName(ClsUsuario usuario)
        {
            return this.Content(ClsUsuario.getUsuarioById(usuario), "application/json", System.Text.Encoding.UTF8);
        }
        [Authorize(Roles = "VISITANTE")]
        [HttpGet]
        public ActionResult getAllUsuarios()
        {
            return this.Content(ClsUsuario.getAllUsuarios(), "application/json", System.Text.Encoding.UTF8);
        }
    }
}
