using Microsoft.AspNetCore.Mvc;
using WEB_API_PERIODICO.Clases.ConfigToken;

namespace WEB_API_PERIODICO.Controllers
{
    [Route("Login")]
    [ApiController]
    public class LoginController : Controller
    {
        [HttpPost]
        public ActionResult<object> Login([FromBody] ClsLogin login)
        {
            JWTHelper tks = new JWTHelper();
            ClsLogin use = new ClsLogin();
            string Token = tks.CrearToken(login.Usuario);
            use.Usuario = login.Usuario;
            use.Token = Token;
            return Ok(use);
        }
    }
}
