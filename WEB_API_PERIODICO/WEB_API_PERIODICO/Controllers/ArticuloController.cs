using Microsoft.AspNetCore.Mvc;
using WEB_API_PERIODICO.Clases;

namespace WEB_API_PERIODICO.Controllers
{
    [Route("Articulo")]
    [ApiController]
    public class ArticuloController : Controller
    {
        [HttpPost]
        public ActionResult NuevoArticulo(string TITULO, int ID_SUB_CATEGORIA, int ID_VISIBILIDAD, int ID_USUARIO_PUBLICADOR, int ID_ESTADO, string CONTENIDO)
        {
            return this.Content(ClsArticulo.NuevoArticulo(TITULO, ID_SUB_CATEGORIA, ID_VISIBILIDAD, ID_USUARIO_PUBLICADOR, ID_ESTADO, CONTENIDO), "application/json", System.Text.Encoding.UTF8);
        }
        [HttpPut]
        public ActionResult ModificarArticulo(int ID_ARTICULO, string TITULO, int ID_SUB_CATEGORIA, int ID_VISIBILIDAD, int ID_USUARIO_PUBLICADOR, int ID_ESTADO, string CONTENIDO)
        {
            return this.Content(ClsArticulo.ModificarArticulo(ID_ARTICULO, TITULO, ID_SUB_CATEGORIA, ID_VISIBILIDAD, ID_USUARIO_PUBLICADOR, ID_ESTADO, CONTENIDO), "application/json", System.Text.Encoding.UTF8);
        }
        [HttpDelete]
        public ActionResult EliminarArticulo(int ID_ARTICULO)
        {
            return this.Content(ClsArticulo.EliminarArticulo(ID_ARTICULO), "application/json", System.Text.Encoding.UTF8);
        }
        [HttpGet("{ID_ARTICULO}")]
        public ActionResult getArticuloById(int ID_ARTICULO)
        {
            return this.Content(ClsArticulo.getArticuloById(ID_ARTICULO), "application/json", System.Text.Encoding.UTF8);
        }
        [HttpGet]
        public ActionResult getArticulos()
        {
            return this.Content(ClsArticulo.getArticulos(), "application/json", System.Text.Encoding.UTF8);
        }
    }
}
