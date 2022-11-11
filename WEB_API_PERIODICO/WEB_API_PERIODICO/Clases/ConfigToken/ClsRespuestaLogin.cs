namespace WEB_API_PERIODICO.Clases.ConfigToken
{
    public class ClsRespuestaLogin
    {
        public int Id_Usuario { get; set; }
        public string Usuario { get; set; }
        public string Rol { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int Estado { get; set; }
        public string Msg { get; set; }
        public string Token { get; set; }
        public string JsonResult { get; set; }

    }
}
