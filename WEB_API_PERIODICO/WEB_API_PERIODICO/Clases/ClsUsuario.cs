using System.Data;
using System.Data.SqlClient;

namespace WEB_API_PERIODICO.Clases
{
    public class ClsUsuario
    {

        public static string getRole()
        {
            string Result = "";
            using (SqlConnection conn = new SqlConnection(ClsSqlServer.ConnectionString))
            {
                conn.Open();
                SqlDataAdapter da = new SqlDataAdapter();
                DataTable dt = new DataTable();
                da.SelectCommand = new SqlCommand("[USP_GET_ROLE]", conn);
                da.SelectCommand.CommandTimeout = 0;
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.Fill(dt);
                Result = ClsSqlServer.toJson(dt);
                conn.Dispose();
                conn.Close();
            }
            return Result;
        }

        public static string CrearUsuario(int ROLE_ID, int PAIS_ID, string USER_NAME, string PASSWORD,string NOMBRE, string APELLIDO, string TELEFONO, string CORREO, string CORREO_CONFIMACION, string DIRECCION, string NIT)
        {
            string Result = "";
            using (SqlConnection conn = new SqlConnection(ClsSqlServer.ConnectionString))
            {
                conn.Open();
                SqlDataAdapter da = new SqlDataAdapter();
                DataTable dt = new DataTable();
                da.SelectCommand = new SqlCommand("[USP_SET_USUARIO]", conn);
                da.SelectCommand.CommandTimeout = 0;
                da.SelectCommand.Parameters.AddWithValue("@TIPO", 1);
                da.SelectCommand.Parameters.AddWithValue("@ROLE_ID", ROLE_ID);
                da.SelectCommand.Parameters.AddWithValue("@PAIS_ID", PAIS_ID);
                da.SelectCommand.Parameters.AddWithValue("@USER_NAME", USER_NAME);
                da.SelectCommand.Parameters.AddWithValue("@PASSWORD", PASSWORD);
                da.SelectCommand.Parameters.AddWithValue("@NOMBRE", NOMBRE);
                da.SelectCommand.Parameters.AddWithValue("@APELLIDO", APELLIDO);
                da.SelectCommand.Parameters.AddWithValue("@TELEFONO", TELEFONO);
                da.SelectCommand.Parameters.AddWithValue("@CORREO", CORREO);
                da.SelectCommand.Parameters.AddWithValue("@CORREO_CONFIMACION", CORREO_CONFIMACION);
                da.SelectCommand.Parameters.AddWithValue("@DIRECCION", DIRECCION);
                da.SelectCommand.Parameters.AddWithValue("@NIT", NIT);
                da.SelectCommand.Parameters.AddWithValue("@ESTADO", 1);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.Fill(dt);
                Result = ClsSqlServer.toJson(dt);
                conn.Dispose();
                conn.Close();
            }
            return Result;
        }

        public static string ModificarUsuario(int ROLE_ID, int PAIS_ID, string USER_NAME, string PASSWORD, string NOMBRE, string APELLIDO, string TELEFONO, string CORREO, string CORREO_CONFIMACION, string DIRECCION, string NIT,Boolean ESTADO)
        {
            string Result = "";
            using (SqlConnection conn = new SqlConnection(ClsSqlServer.ConnectionString))
            {
                conn.Open();
                SqlDataAdapter da = new SqlDataAdapter();
                DataTable dt = new DataTable();
                da.SelectCommand = new SqlCommand("[USP_SET_USUARIO]", conn);
                da.SelectCommand.CommandTimeout = 0;
                da.SelectCommand.Parameters.AddWithValue("@TIPO", 2);
                da.SelectCommand.Parameters.AddWithValue("@ROLE_ID", ROLE_ID);
                da.SelectCommand.Parameters.AddWithValue("@PAIS_ID", PAIS_ID);
                da.SelectCommand.Parameters.AddWithValue("@USER_NAME", USER_NAME);
                da.SelectCommand.Parameters.AddWithValue("@PASSWORD", PASSWORD);
                da.SelectCommand.Parameters.AddWithValue("@NOMBRE", NOMBRE);
                da.SelectCommand.Parameters.AddWithValue("@APELLIDO", APELLIDO);
                da.SelectCommand.Parameters.AddWithValue("@TELEFONO", TELEFONO);
                da.SelectCommand.Parameters.AddWithValue("@CORREO", CORREO);
                da.SelectCommand.Parameters.AddWithValue("@CORREO_CONFIMACION", CORREO_CONFIMACION);
                da.SelectCommand.Parameters.AddWithValue("@DIRECCION", DIRECCION);
                da.SelectCommand.Parameters.AddWithValue("@NIT", NIT);
                da.SelectCommand.Parameters.AddWithValue("@ESTADO", ESTADO);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.Fill(dt);
                Result = ClsSqlServer.toJson(dt);
                conn.Dispose();
                conn.Close();
            }
            return Result;
        }

        public static string getAllUsuarios()
        {
            string Result = "";
            using (SqlConnection conn = new SqlConnection(ClsSqlServer.ConnectionString))
            {
                conn.Open();
                SqlDataAdapter da = new SqlDataAdapter();
                DataTable dt = new DataTable();
                da.SelectCommand = new SqlCommand("[USP_GET_USUARIO]", conn);
                da.SelectCommand.CommandTimeout = 0;
                da.SelectCommand.Parameters.AddWithValue("@TIPO", 1);
                da.SelectCommand.Parameters.AddWithValue("@ID_USUARIO", "");
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.Fill(dt);
                Result = ClsSqlServer.toJson(dt);
                conn.Dispose();
                conn.Close();
            }
            return Result;
        }

        public static string getUsuarioById(string Usuario)
        {
            string Result = "";
            using (SqlConnection conn = new SqlConnection(ClsSqlServer.ConnectionString))
            {
                conn.Open();
                SqlDataAdapter da = new SqlDataAdapter();
                DataTable dt = new DataTable();
                da.SelectCommand = new SqlCommand("[USP_GET_USUARIO]", conn);
                da.SelectCommand.CommandTimeout = 0;
                da.SelectCommand.Parameters.AddWithValue("@TIPO",2);
                da.SelectCommand.Parameters.AddWithValue("@ID_USUARIO", Usuario);
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
