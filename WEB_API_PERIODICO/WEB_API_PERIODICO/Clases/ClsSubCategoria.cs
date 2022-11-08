using System.Data;
using System.Data.SqlClient;

namespace WEB_API_PERIODICO.Clases
{
    public class ClsSubCategoria
    {
        public static string NuevaSubCategoria(int IdCategoria, string NombreSubCategoria)
        {
            string Result = "";
            using (SqlConnection conn = new SqlConnection(ClsSqlServer.ConnectionString))
            {
                conn.Open();
                SqlDataAdapter da = new SqlDataAdapter();
                DataTable dt = new DataTable();
                da.SelectCommand = new SqlCommand("[USP_GET_SET_CREAR_SUB_CATEGORIA]", conn);
                da.SelectCommand.CommandTimeout = 0;
                da.SelectCommand.Parameters.AddWithValue("@IdCategoria", IdCategoria);
                da.SelectCommand.Parameters.AddWithValue("@NombreSubCategoria", NombreSubCategoria);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.Fill(dt);
                Result = ClsSqlServer.toJson(dt);
                conn.Dispose();
                conn.Close();
            }
            return Result;
        }
        public static string ModificarSubCategoria(int ID_SUB_CATEGORIA,string RENAME)
        {
            string Result = "";
            using (SqlConnection conn = new SqlConnection(ClsSqlServer.ConnectionString))
            {
                conn.Open();
                SqlDataAdapter da = new SqlDataAdapter();
                DataTable dt = new DataTable();
                da.SelectCommand = new SqlCommand("[USP_SET_MOD_SUB_CATEGORIAS]", conn);
                da.SelectCommand.CommandTimeout = 0;
                da.SelectCommand.Parameters.AddWithValue("@ID_SUB_CATEGORIA", ID_SUB_CATEGORIA);
                da.SelectCommand.Parameters.AddWithValue("@RENAME", RENAME);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.Fill(dt);
                Result = ClsSqlServer.toJson(dt);
                conn.Dispose();
                conn.Close();
            }
            return Result;
        }
        public static string getSubCategorias()
        {
            string Result = "";
            using (SqlConnection conn = new SqlConnection(ClsSqlServer.ConnectionString))
            {
                conn.Open();
                SqlDataAdapter da = new SqlDataAdapter();
                DataTable dt = new DataTable();
                da.SelectCommand = new SqlCommand("[USP_GET_SUB_CATEGORIAS]", conn);
                da.SelectCommand.CommandTimeout = 0;
                da.SelectCommand.Parameters.AddWithValue("@TIPO", 1);
                da.SelectCommand.Parameters.AddWithValue("@ID_CATEGORIA", -1);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.Fill(dt);
                Result = ClsSqlServer.toJson(dt);
                conn.Dispose();
                conn.Close();
            }
            return Result;
        }
        public static string getSubCategoriasByCategoria(int ID_CATEGORIA)
        {
            string Result = "";
            using (SqlConnection conn = new SqlConnection(ClsSqlServer.ConnectionString))
            {
                conn.Open();
                SqlDataAdapter da = new SqlDataAdapter();
                DataTable dt = new DataTable();
                da.SelectCommand = new SqlCommand("[USP_GET_SUB_CATEGORIAS]", conn);
                da.SelectCommand.CommandTimeout = 0;
                da.SelectCommand.Parameters.AddWithValue("@TIPO", 2);
                da.SelectCommand.Parameters.AddWithValue("@ID_CATEGORIA", ID_CATEGORIA);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.Fill(dt);
                Result = ClsSqlServer.toJson(dt);
                conn.Dispose();
                conn.Close();
            }
            return Result;
        }
        public static string EliminarSubCategorias(int ID_SUB_CATEGORIA)
        {
            string Result = "";
            using (SqlConnection conn = new SqlConnection(ClsSqlServer.ConnectionString))
            {
                conn.Open();
                SqlDataAdapter da = new SqlDataAdapter();
                DataTable dt = new DataTable();
                da.SelectCommand = new SqlCommand("[USP_GET_DELETE_SUB_CATEGORIAS]", conn);
                da.SelectCommand.CommandTimeout = 0;
                da.SelectCommand.Parameters.AddWithValue("@ID_SUB_CATEGORIA", ID_SUB_CATEGORIA);
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
