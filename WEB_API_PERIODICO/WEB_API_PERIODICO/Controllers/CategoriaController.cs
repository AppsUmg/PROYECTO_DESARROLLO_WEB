using Microsoft.AspNetCore.Mvc;
using WEB_API_PERIODICO.Clases;

namespace WEB_API_PERIODICO.Controllers
{
    [Route("Categorias")]
    [ApiController]
    public class CategoriaController : Controller
    {
        [HttpPost]
        public ActionResult NuevaCategoria(string NuevaCategoria)
        {
            return this.Content(ClsCategoria.NuevaCategoria(NuevaCategoria), "application/json", System.Text.Encoding.UTF8);
        }
        [HttpPut]
        public ActionResult ModificarCategoria(int ID_CATEGORIA,string RENAME)
        {
            return this.Content(ClsCategoria.ModificarCategoria(ID_CATEGORIA, RENAME), "application/json", System.Text.Encoding.UTF8);
        }
        [HttpDelete]
        public ActionResult EliminarCategoria(int ID_CATEGORIA)
        {
            return this.Content(ClsCategoria.EliminarCategoria(ID_CATEGORIA), "application/json", System.Text.Encoding.UTF8);
        }
        [HttpGet]
        public ActionResult getCategorias()
        {
            return this.Content(ClsCategoria.getCategorias(), "application/json", System.Text.Encoding.UTF8);
        }
    }
}
