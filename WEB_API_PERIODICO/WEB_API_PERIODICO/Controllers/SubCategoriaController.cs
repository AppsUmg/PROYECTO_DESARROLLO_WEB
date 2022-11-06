using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WEB_API_PERIODICO.Clases;

namespace WEB_API_PERIODICO.Controllers
{
    [Route("SubCategorias")]
    [ApiController]
    [Authorize(Roles = "VISITANTE")]
    public class SubCategoriaController : Controller
    {
        [HttpPost]
        public ActionResult NuevaSubCategoria(int IdCategoria, string NombreSubCategoria)
        {
            return this.Content(ClsSubCategoria.NuevaSubCategoria(IdCategoria,NombreSubCategoria), "application/json", System.Text.Encoding.UTF8);
        }
        [HttpPut]
        public ActionResult ModificarSubCategoria(int ID_SUB_CATEGORIA, string RENAME)
        {
            return this.Content(ClsSubCategoria.ModificarSubCategoria(ID_SUB_CATEGORIA, RENAME), "application/json", System.Text.Encoding.UTF8);
        }
        [HttpDelete]
        public ActionResult EliminarSubCategoria(int ID_CATEGORIA)
        {
            return this.Content(ClsSubCategoria.EliminarSubCategorias(ID_CATEGORIA), "application/json", System.Text.Encoding.UTF8);
        }
        [HttpGet]
        public ActionResult getSubCategorias()
        {
            return this.Content(ClsSubCategoria.getSubCategorias(), "application/json", System.Text.Encoding.UTF8);
        }

    }
}
