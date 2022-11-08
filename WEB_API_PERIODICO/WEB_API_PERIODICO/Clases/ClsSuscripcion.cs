using System.Data;
using System.Data.SqlClient;

namespace WEB_API_PERIODICO.Clases
{
    public class ClsSuscripcion
    {
        public static string getTipoSuscripcion()
        {
            string Result = "";
            using (SqlConnection conn = new SqlConnection(ClsSqlServer.ConnectionString))
            {
                conn.Open();
                SqlDataAdapter da = new SqlDataAdapter();
                DataTable dt = new DataTable();
                da.SelectCommand = new SqlCommand("[USP_GET_TIPO_SUSCRIPCION]", conn);
                da.SelectCommand.CommandTimeout = 0;
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
