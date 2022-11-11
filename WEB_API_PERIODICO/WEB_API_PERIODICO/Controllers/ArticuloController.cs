using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WEB_API_PERIODICO.Clases;

namespace WEB_API_PERIODICO.Controllers
{
    [Route("Articulo")]
    [ApiController]
    
    public class ArticuloController : Controller
    {
        [Authorize(Roles = "PUBLICADOR,ADMINISTRADOR")]
        [HttpPost]
        public ActionResult NuevoArticulo([FromBody] ClsArticulo articulo)
        {
            return this.Content(ClsArticulo.NuevoArticulo(articulo), "application/json", System.Text.Encoding.UTF8);
        }
        [Authorize(Roles = "PUBLICADOR,ADMINISTRADOR")]
        [HttpPut]
        public ActionResult ModificarArticulo([FromBody] ClsArticulo articulo)
        {
            return this.Content(ClsArticulo.ModificarArticulo(articulo), "application/json", System.Text.Encoding.UTF8);
        }
        [Authorize(Roles = "ADMINISTRADOR")]
        [HttpDelete("{ID_ARTICULO}")]
        public ActionResult EliminarArticulo(int ID_ARTICULO)
        {
            return this.Content(ClsArticulo.EliminarArticulo(ID_ARTICULO), "application/json", System.Text.Encoding.UTF8);
        }
        [Authorize(Roles = "VISITANTE")]
        [HttpGet]
        public ActionResult getArticulos()
        {
            return this.Content(ClsArticulo.getArticulos(), "application/json", System.Text.Encoding.UTF8);
        }
        [Authorize(Roles = "VISITANTE")]
        [HttpGet("{ID_ARTICULO}")]
        public ActionResult getArticuloById(int ID_ARTICULO)
        {
            return this.Content(ClsArticulo.getArticuloById(ID_ARTICULO), "application/json", System.Text.Encoding.UTF8);
        }
        [Authorize(Roles = "VISITANTE")]
        [HttpGet("SubCategoria/{ID_SUB_CATEGORIA}")]
        public ActionResult getArticuloByIdSubcategoria(int ID_SUB_CATEGORIA)
        {
            return this.Content(ClsArticulo.getArticuloByIdSubCategoria(ID_SUB_CATEGORIA), "application/json", System.Text.Encoding.UTF8);
        }
        [Authorize(Roles = "VISITANTE")]
        [HttpGet("Categoria/{ID_CATEGORIA}")]
        public ActionResult getArticuloByIdcategoria(int ID_CATEGORIA)
        {
            return this.Content(ClsArticulo.getArticuloByIdCategoria(ID_CATEGORIA), "application/json", System.Text.Encoding.UTF8);
        }

        [Authorize(Roles = "VISITANTE")]
        [HttpGet("Visibilidad")]
        public ActionResult getArticuloVisibilidad()
        {
            return this.Content(ClsArticulo.getVisibilidad(), "application/json", System.Text.Encoding.UTF8);
        }

        [Authorize(Roles = "VISITANTE")]
        [HttpGet("Estados")]
        public ActionResult getEstadosArticulo()
        {
            return this.Content(ClsArticulo.getEstadosArticulo(), "application/json", System.Text.Encoding.UTF8);
        }

        [Authorize(Roles = "VISITANTE")]
        [HttpPost("Imagenes")]
        public ActionResult setNuevaImagen([FromBody] ClsArticuloImagen Imagen)
        {
            return this.Content(ClsArticuloImagen.AñadirImagen(Imagen), "application/json", System.Text.Encoding.UTF8);
        }

        [Authorize(Roles = "VISITANTE")]
        [HttpPut("Imagenes")]
        public ActionResult setModificarImagen([FromBody] ClsArticuloImagen Imagen)
        {
            return this.Content(ClsArticuloImagen.ModificarImagen(Imagen), "application/json", System.Text.Encoding.UTF8);
        }

        [Authorize(Roles = "VISITANTE")]
        [HttpGet("Imagenes/{ID_ARTICULO}")]
        public ActionResult getImagenes(int ID_ARTICULO)
        {
            return this.Content(ClsArticuloImagen.getImagenes(ID_ARTICULO), "application/json", System.Text.Encoding.UTF8);
        }
    }
}
