using System.Data;
using System.Data.SqlClient;

namespace WEB_API_PERIODICO.Clases.ConfigToken
{
    public class ClsLogin
    {
        public string Usuario { get; set; }
        public string Password { get; set; }
        public string Token { get; set; }

        public static ClsRespuestaLogin LoginDb(ClsLogin Login)
        {
            ClsRespuestaLogin ClsRespuestaLogin;
            using (SqlConnection conn = new SqlConnection(ClsSqlServer.ConnectionString))
            {
                conn.Open();
                SqlDataAdapter da = new SqlDataAdapter();
                DataTable dt = new DataTable();
                da.SelectCommand = new SqlCommand("[USP_GET_USUARIO_LOGIN]", conn);
                da.SelectCommand.CommandTimeout = 0;
                da.SelectCommand.Parameters.AddWithValue("@USUARIO", Login.Usuario);
                da.SelectCommand.Parameters.AddWithValue("@PASSWORD", Login.Password);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.Fill(dt);
                ClsRespuestaLogin = new ClsRespuestaLogin();
                ClsRespuestaLogin.Id_Usuario = Convert.ToInt32(dt.Rows[0][0].ToString());
                ClsRespuestaLogin.Usuario = dt.Rows[0][1].ToString();
                ClsRespuestaLogin.Rol = dt.Rows[0][2].ToString();
                ClsRespuestaLogin.Nombre = dt.Rows[0][3].ToString();
                ClsRespuestaLogin.Apellido = dt.Rows[0][4].ToString();
                ClsRespuestaLogin.Estado = Convert.ToInt32(dt.Rows[0][5].ToString());
                ClsRespuestaLogin.Msg = dt.Rows[0][6].ToString();
                ClsRespuestaLogin.JsonResult = ClsSqlServer.toJson(dt);
                conn.Dispose();
                conn.Close();
            }
            return ClsRespuestaLogin;
        }

    }
}
