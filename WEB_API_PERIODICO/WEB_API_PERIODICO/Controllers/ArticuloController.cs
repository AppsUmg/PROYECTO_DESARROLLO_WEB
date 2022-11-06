﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WEB_API_PERIODICO.Clases;

namespace WEB_API_PERIODICO.Controllers
{
    [Route("Articulo")]
    [ApiController]
    [Authorize(Roles = "VISITANTE")]
    public class ArticuloController : Controller
    {
        [HttpPost]
        public ActionResult NuevoArticulo([FromBody] ClsArticulo articulo)
        {
            return this.Content(ClsArticulo.NuevoArticulo(articulo), "application/json", System.Text.Encoding.UTF8);
        }
        [HttpPut]
        public ActionResult ModificarArticulo([FromBody] ClsArticulo articulo)
        {
            return this.Content(ClsArticulo.ModificarArticulo(articulo), "application/json", System.Text.Encoding.UTF8);
        }
        [HttpDelete]
        public ActionResult EliminarArticulo([FromBody] ClsArticulo articulo)
        {
            return this.Content(ClsArticulo.EliminarArticulo(articulo), "application/json", System.Text.Encoding.UTF8);
        }
        [HttpGet("{ID_ARTICULO}")]
        public ActionResult getArticuloById(int ID_ARTICULO)
        {
            ClsArticulo articulo = new ClsArticulo();
            articulo.ID_ARTICULO = ID_ARTICULO;
            return this.Content(ClsArticulo.getArticuloById(articulo), "application/json", System.Text.Encoding.UTF8);
        }
        [HttpGet]
        public ActionResult getArticulos()
        {
            return this.Content(ClsArticulo.getArticulos(), "application/json", System.Text.Encoding.UTF8);
        }
    }
}
