using System.Data;
using System.Data.SqlClient;

namespace WEB_API_PERIODICO.Clases
{
    public class ClsArticulo
    {

        public static string NuevoArticulo(string TITULO, int ID_SUB_CATEGORIA,int ID_VISIBILIDAD,int ID_USUARIO_PUBLICADOR, int ID_ESTADO,string CONTENIDO)
        {
            string Result = "";
            using (SqlConnection conn = new SqlConnection(ClsSqlServer.ConnectionString))
            {
                conn.Open();
                SqlDataAdapter da = new SqlDataAdapter();
                DataTable dt = new DataTable();
                da.SelectCommand = new SqlCommand("[USP_SET_ARTICULO]", conn);
                da.SelectCommand.CommandTimeout = 0;
                da.SelectCommand.Parameters.AddWithValue("@TIPO", 1);
                da.SelectCommand.Parameters.AddWithValue("@ID_ARTICULO", -1);
                da.SelectCommand.Parameters.AddWithValue("@TITULO", TITULO);
                da.SelectCommand.Parameters.AddWithValue("@ID_SUB_CATEGORIA", ID_SUB_CATEGORIA);
                da.SelectCommand.Parameters.AddWithValue("@ID_VISIBILIDAD", ID_VISIBILIDAD);
                da.SelectCommand.Parameters.AddWithValue("@ID_USUARIO_PUBLICADOR", ID_USUARIO_PUBLICADOR);
                da.SelectCommand.Parameters.AddWithValue("@ID_ESTADO", ID_ESTADO);
                da.SelectCommand.Parameters.AddWithValue("@CONTENIDO", CONTENIDO);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.Fill(dt);
                Result = ClsSqlServer.toJson(dt);
                conn.Dispose();
                conn.Close();
            }
            return Result;
        }
        public static string ModificarArticulo(int ID_ARTICULO, string TITULO, int ID_SUB_CATEGORIA, int ID_VISIBILIDAD, int ID_USUARIO_PUBLICADOR, int ID_ESTADO, string CONTENIDO)
        {
            string Result = "";
            using (SqlConnection conn = new SqlConnection(ClsSqlServer.ConnectionString))
            {
                conn.Open();
                SqlDataAdapter da = new SqlDataAdapter();
                DataTable dt = new DataTable();
                da.SelectCommand = new SqlCommand("[USP_SET_ARTICULO]", conn);
                da.SelectCommand.CommandTimeout = 0;
                da.SelectCommand.Parameters.AddWithValue("@TIPO", 2);
                da.SelectCommand.Parameters.AddWithValue("@ID_ARTICULO", ID_ARTICULO);
                da.SelectCommand.Parameters.AddWithValue("@TITULO", TITULO);
                da.SelectCommand.Parameters.AddWithValue("@ID_SUB_CATEGORIA", ID_SUB_CATEGORIA);
                da.SelectCommand.Parameters.AddWithValue("@ID_VISIBILIDAD", ID_VISIBILIDAD);
                da.SelectCommand.Parameters.AddWithValue("@ID_USUARIO_PUBLICADOR", ID_USUARIO_PUBLICADOR);
                da.SelectCommand.Parameters.AddWithValue("@ID_ESTADO", ID_ESTADO);
                da.SelectCommand.Parameters.AddWithValue("@CONTENIDO", CONTENIDO);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.Fill(dt);
                Result = ClsSqlServer.toJson(dt);
                conn.Dispose();
                conn.Close();
            }
            return Result;
        }
        public static string EliminarArticulo(int ID_ARTICULO)
        {
            string Result = "";
            using (SqlConnection conn = new SqlConnection(ClsSqlServer.ConnectionString))
            {
                conn.Open();
                SqlDataAdapter da = new SqlDataAdapter();
                DataTable dt = new DataTable();
                da.SelectCommand = new SqlCommand("[USP_GET_DELETE_ARTICULO]", conn);
                da.SelectCommand.CommandTimeout = 0;
                da.SelectCommand.Parameters.AddWithValue("@ID_ARTICULO", ID_ARTICULO);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.Fill(dt);
                Result = ClsSqlServer.toJson(dt);
                conn.Dispose();
                conn.Close();
            }
            return Result;
        }
        public static string getArticulos()
        {
            string Result = "";
            using (SqlConnection conn = new SqlConnection(ClsSqlServer.ConnectionString))
            {
                conn.Open();
                SqlDataAdapter da = new SqlDataAdapter();
                DataTable dt = new DataTable();
                da.SelectCommand = new SqlCommand("[USP_GET_ARTICULO]", conn);
                da.SelectCommand.CommandTimeout = 0;
                da.SelectCommand.Parameters.AddWithValue("@TIPO", 1);
                da.SelectCommand.Parameters.AddWithValue("@ID_ARTICULO", -1);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.Fill(dt);
                Result = ClsSqlServer.toJson(dt);
                conn.Dispose();
                conn.Close();
            }
            return Result;
        }
        public static string getArticuloById(int ID_ARTICULO)
        {
            string Result = "";
            using (SqlConnection conn = new SqlConnection(ClsSqlServer.ConnectionString))
            {
                conn.Open();
                SqlDataAdapter da = new SqlDataAdapter();
                DataTable dt = new DataTable();
                da.SelectCommand = new SqlCommand("[USP_GET_ARTICULO]", conn);
                da.SelectCommand.CommandTimeout = 0;
                da.SelectCommand.Parameters.AddWithValue("@TIPO", 2);
                da.SelectCommand.Parameters.AddWithValue("@ID_ARTICULO", ID_ARTICULO);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.Fill(dt);
                Result = ClsSqlServer.toJson(dt);
                conn.Dispose();
                conn.Close();
            }
            return Result;
        }
    }
}
