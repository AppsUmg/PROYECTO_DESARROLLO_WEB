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
            ClsRespuestaLogin ClsRespuestaLogin = ClsLogin.LoginDb(login);
            if (ClsRespuestaLogin.Estado == 1)
            {
                JWTHelper tks = new JWTHelper();
                string Token = tks.CrearToken(ClsRespuestaLogin);
                //ClsRespuestaLogin.Usuario = login.Usuario;
                ClsRespuestaLogin.Token = Token;
                return Ok(ClsRespuestaLogin);

            }
            else {
                return this.Content(ClsRespuestaLogin.JsonResult, "application/json", System.Text.Encoding.UTF8);
            }
 
        }
    }
}


