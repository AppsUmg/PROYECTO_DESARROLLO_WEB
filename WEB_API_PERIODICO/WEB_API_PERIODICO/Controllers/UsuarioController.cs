using Microsoft.AspNetCore.Mvc;
using WEB_API_PERIODICO.Clases;

namespace WEB_API_PERIODICO.Controllers
{
    [Route("Usuario")]
    [ApiController]
    public class UsuarioController : Controller
    {
        [HttpPost]
        public ActionResult CrearUsuario(
                int ROLE_ID
               ,int PAIS_ID
               ,string USER_NAME
               ,string PASSWORD
               ,string NOMBRE
               ,string APELLIDO
               ,string TELEFONO
               ,string CORREO
               ,string CORREO_CONFIMACION
               ,string DIRECCION
               ,string NIT)
        {
            return this.Content(ClsUsuario.CrearUsuario(ROLE_ID,PAIS_ID,USER_NAME,PASSWORD,NOMBRE,APELLIDO,TELEFONO,CORREO,CORREO_CONFIMACION,DIRECCION,NIT), "application/json", System.Text.Encoding.UTF8);
        }

        [HttpPut]
        public ActionResult ModificarUsuario(
                 int ROLE_ID
                ,int PAIS_ID
                ,string USER_NAME
                ,string PASSWORD
                ,string NOMBRE
                ,string APELLIDO
                ,string TELEFONO
                ,string CORREO
                ,string CORREO_CONFIMACION
                ,string DIRECCION
                ,string NIT
                ,Boolean ESTADO)
        {
            return this.Content(ClsUsuario.ModificarUsuario(ROLE_ID, PAIS_ID, USER_NAME, PASSWORD, NOMBRE, APELLIDO, TELEFONO, CORREO, CORREO_CONFIMACION, DIRECCION, NIT,ESTADO), "application/json", System.Text.Encoding.UTF8);
        }
        [HttpGet("{USER_NAME}")]
        public ActionResult getUsuarioByUserName(string USER_NAME)
        {
            return this.Content(ClsUsuario.getUsuarioById(USER_NAME), "application/json", System.Text.Encoding.UTF8);
        }
        [HttpGet]
        public ActionResult getAllUsuarios()
        {
            return this.Content(ClsUsuario.getAllUsuarios(), "application/json", System.Text.Encoding.UTF8);
        }
    }
}
