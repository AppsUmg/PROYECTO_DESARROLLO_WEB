using System.Data;
using System.Data.SqlClient;

namespace WEB_API_PERIODICO.Clases
{
    public class ClsArticulo
    {
        public int ID_ARTICULO { get; set; }
        public string TITULO { get; set; }
        public int ID_SUB_CATEGORIA { get; set; }
        public int ID_VISIBILIDAD { get; set; }
        public int ID_USUARIO_PUBLICADOR { get; set; }
        public int ID_ESTADO { get; set; }
        public string CONTENIDO { get; set; }


        public static string NuevoArticulo(ClsArticulo articulo)
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
                da.SelectCommand.Parameters.AddWithValue("@TITULO", articulo.TITULO);
                da.SelectCommand.Parameters.AddWithValue("@ID_SUB_CATEGORIA", articulo.ID_SUB_CATEGORIA);
                da.SelectCommand.Parameters.AddWithValue("@ID_VISIBILIDAD", articulo.ID_VISIBILIDAD);
                da.SelectCommand.Parameters.AddWithValue("@ID_USUARIO_PUBLICADOR", articulo.ID_USUARIO_PUBLICADOR);
                da.SelectCommand.Parameters.AddWithValue("@ID_ESTADO", articulo.ID_ESTADO);
                da.SelectCommand.Parameters.AddWithValue("@CONTENIDO", articulo.CONTENIDO);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.Fill(dt);
                Result = ClsSqlServer.toJson(dt);
                conn.Dispose();
                conn.Close();
            }
            return Result;
        }
        public static string ModificarArticulo(ClsArticulo articulo)
        {
            string Result = "";
            using (SqlConnection conn = new SqlConnection(ClsSqlServer.ConnectionString))
            {
                conn.Open();
                SqlDataAdapter da = new SqlDataAdapter();
                DataTable dt = new DataTable();
                da.SelectCommand = new SqlCommand("[USP_SET_ARTICULO]", conn);
                da.SelectCommand.CommandTimeout = 0;
                da.SelectCommand.Parameters.AddWithValue("@TIPO",2);
                da.SelectCommand.Parameters.AddWithValue("@ID_ARTICULO",articulo.ID_ARTICULO);
                da.SelectCommand.Parameters.AddWithValue("@TITULO", articulo.TITULO);
                da.SelectCommand.Parameters.AddWithValue("@ID_SUB_CATEGORIA", articulo.ID_SUB_CATEGORIA);
                da.SelectCommand.Parameters.AddWithValue("@ID_VISIBILIDAD", articulo.ID_VISIBILIDAD);
                da.SelectCommand.Parameters.AddWithValue("@ID_USUARIO_PUBLICADOR", articulo.ID_USUARIO_PUBLICADOR);
                da.SelectCommand.Parameters.AddWithValue("@ID_ESTADO", articulo.ID_ESTADO);
                da.SelectCommand.Parameters.AddWithValue("@CONTENIDO", articulo.CONTENIDO);
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
                da.SelectCommand.Parameters.AddWithValue("@ID", -1);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.Fill(dt);
                Result = ClsSqlServer.toJson(dt);
                conn.Dispose();
                conn.Close();
            }
            return Result;
        }
        public static string getVisibilidad()
        {
            string Result = "";
            using (SqlConnection conn = new SqlConnection(ClsSqlServer.ConnectionString))
            {
                conn.Open();
                SqlDataAdapter da = new SqlDataAdapter();
                DataTable dt = new DataTable();
                da.SelectCommand = new SqlCommand("[USP_GET_ARTICULO_TIPO_VISIBILIDAD]", conn);
                da.SelectCommand.CommandTimeout = 0;
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.Fill(dt);
                Result = ClsSqlServer.toJson(dt);
                conn.Dispose();
                conn.Close();
            }
            return Result;
        }
        public static string getEstadosArticulo()
        {
            string Result = "";
            using (SqlConnection conn = new SqlConnection(ClsSqlServer.ConnectionString))
            {
                conn.Open();
                SqlDataAdapter da = new SqlDataAdapter();
                DataTable dt = new DataTable();
                da.SelectCommand = new SqlCommand("[USP_GET_ARTICULO_ESTADOS]", conn);
                da.SelectCommand.CommandTimeout = 0;
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
                da.SelectCommand.Parameters.AddWithValue("@ID", ID_ARTICULO);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.Fill(dt);
                Result = ClsSqlServer.toJson(dt);
                conn.Dispose();
                conn.Close();
            }
            return Result;
        }

        public static string getArticuloByIdSubCategoria(int ID_SUB_CATEGORIA)
        {
            string Result = "";
            using (SqlConnection conn = new SqlConnection(ClsSqlServer.ConnectionString))
            {
                conn.Open();
                SqlDataAdapter da = new SqlDataAdapter();
                DataTable dt = new DataTable();
                da.SelectCommand = new SqlCommand("[USP_GET_ARTICULO]", conn);
                da.SelectCommand.CommandTimeout = 0;
                da.SelectCommand.Parameters.AddWithValue("@TIPO", 3);
                da.SelectCommand.Parameters.AddWithValue("@ID", ID_SUB_CATEGORIA);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.Fill(dt);
                Result = ClsSqlServer.toJson(dt);
                conn.Dispose();
                conn.Close();
            }
            return Result;
        }
        public static string getArticuloByIdCategoria(int ID_CATEGORIA)
        {
            string Result = "";
            using (SqlConnection conn = new SqlConnection(ClsSqlServer.ConnectionString))
            {
                conn.Open();
                SqlDataAdapter da = new SqlDataAdapter();
                DataTable dt = new DataTable();
                da.SelectCommand = new SqlCommand("[USP_GET_ARTICULO]", conn);
                da.SelectCommand.CommandTimeout = 0;
                da.SelectCommand.Parameters.AddWithValue("@TIPO", 3);
                da.SelectCommand.Parameters.AddWithValue("@ID", ID_CATEGORIA);
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
