using System.Data;
using System.Data.SqlClient;

namespace WEB_API_PERIODICO.Clases
{
    public class ClsArticuloImagen
    {
        public int ID_ARTICULO { get;set; }
        public string URL { get;set; }
        public bool ESTADO { get; set; }

        public static string AñadirImagen(ClsArticuloImagen Imagen)
        {
            string Result = "";
            using (SqlConnection conn = new SqlConnection(ClsSqlServer.ConnectionString))
            {
                conn.Open();
                SqlDataAdapter da = new SqlDataAdapter();
                DataTable dt = new DataTable();
                da.SelectCommand = new SqlCommand("[USP_SET_ARTICULO_IMAGEN]", conn);
                da.SelectCommand.CommandTimeout = 0;
                da.SelectCommand.Parameters.AddWithValue("@TIPO", 1);
                da.SelectCommand.Parameters.AddWithValue("@ID_ARTICULO", Imagen.ID_ARTICULO);
                da.SelectCommand.Parameters.AddWithValue("@URL", Imagen.URL);
                da.SelectCommand.Parameters.AddWithValue("@ESTADO", Imagen.ESTADO);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.Fill(dt);
                Result = ClsSqlServer.toJson(dt);
                conn.Dispose();
                conn.Close();
            }
            return Result;
        }


        public static string ModificarImagen(ClsArticuloImagen Imagen)
        {
            string Result = "";
            using (SqlConnection conn = new SqlConnection(ClsSqlServer.ConnectionString))
            {
                conn.Open();
                SqlDataAdapter da = new SqlDataAdapter();
                DataTable dt = new DataTable();
                da.SelectCommand = new SqlCommand("[USP_SET_ARTICULO_IMAGEN]", conn);
                da.SelectCommand.CommandTimeout = 0;
                da.SelectCommand.Parameters.AddWithValue("@TIPO", 2);
                da.SelectCommand.Parameters.AddWithValue("@ID_ARTICULO", Imagen.ID_ARTICULO);
                da.SelectCommand.Parameters.AddWithValue("@URL", Imagen.URL);
                da.SelectCommand.Parameters.AddWithValue("@ESTADO", Imagen.ESTADO);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.Fill(dt);
                Result = ClsSqlServer.toJson(dt);
                conn.Dispose();
                conn.Close();
            }
            return Result;
        }

        public static string getImagenes(int ID_ARTICULO)
        {
            string Result = "";
            using (SqlConnection conn = new SqlConnection(ClsSqlServer.ConnectionString))
            {
                conn.Open();
                SqlDataAdapter da = new SqlDataAdapter();
                DataTable dt = new DataTable();
                da.SelectCommand = new SqlCommand("[USP_GET_ARTICULO_IMAGEN]", conn);
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

    }
}
