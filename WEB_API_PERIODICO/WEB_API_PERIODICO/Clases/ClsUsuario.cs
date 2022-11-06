using System.Data;
using System.Data.SqlClient;

namespace WEB_API_PERIODICO.Clases
{
    public class ClsUsuario
    {
        public int ROLE_ID { get; set; }
        public int PAIS_ID { get; set; }
        public string USER_NAME { get; set; }
        public string PASSWORD { get; set; }
        public string NOMBRE { get; set; }
        public string APELLIDO { get; set; }
        public string TELEFONO { get; set; }
        public string CORREO { get; set; }
        public string CORREO_CONFIMACION { get; set; }
        public string DIRECCION { get; set; }
        public string NIT { get; set; }
        public int ESTADO { get; set; }


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

        public static string CrearUsuario(ClsUsuario usuario)
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
                da.SelectCommand.Parameters.AddWithValue("@ROLE_ID", usuario.ROLE_ID);
                da.SelectCommand.Parameters.AddWithValue("@PAIS_ID", usuario.PAIS_ID);
                da.SelectCommand.Parameters.AddWithValue("@USER_NAME", usuario.USER_NAME);
                da.SelectCommand.Parameters.AddWithValue("@PASSWORD", usuario.PASSWORD);
                da.SelectCommand.Parameters.AddWithValue("@NOMBRE", usuario.NOMBRE);
                da.SelectCommand.Parameters.AddWithValue("@APELLIDO", usuario.APELLIDO);
                da.SelectCommand.Parameters.AddWithValue("@TELEFONO", usuario.TELEFONO);
                da.SelectCommand.Parameters.AddWithValue("@CORREO", usuario.CORREO);
                da.SelectCommand.Parameters.AddWithValue("@CORREO_CONFIMACION", usuario.CORREO_CONFIMACION);
                da.SelectCommand.Parameters.AddWithValue("@DIRECCION", usuario.DIRECCION);
                da.SelectCommand.Parameters.AddWithValue("@NIT", usuario.NIT);
                da.SelectCommand.Parameters.AddWithValue("@ESTADO", 1);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.Fill(dt);
                Result = ClsSqlServer.toJson(dt);
                conn.Dispose();
                conn.Close();
            }
            return Result;
        }

        public static string ModificarUsuario(ClsUsuario usuario)
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
                da.SelectCommand.Parameters.AddWithValue("@ROLE_ID", usuario.ROLE_ID);
                da.SelectCommand.Parameters.AddWithValue("@PAIS_ID", usuario.PAIS_ID);
                da.SelectCommand.Parameters.AddWithValue("@USER_NAME", usuario.USER_NAME);
                da.SelectCommand.Parameters.AddWithValue("@PASSWORD", usuario.PASSWORD);
                da.SelectCommand.Parameters.AddWithValue("@NOMBRE", usuario.NOMBRE);
                da.SelectCommand.Parameters.AddWithValue("@APELLIDO", usuario.APELLIDO);
                da.SelectCommand.Parameters.AddWithValue("@TELEFONO", usuario.TELEFONO);
                da.SelectCommand.Parameters.AddWithValue("@CORREO", usuario.CORREO);
                da.SelectCommand.Parameters.AddWithValue("@CORREO_CONFIMACION", usuario.CORREO_CONFIMACION);
                da.SelectCommand.Parameters.AddWithValue("@DIRECCION", usuario.DIRECCION);
                da.SelectCommand.Parameters.AddWithValue("@NIT", usuario.NIT);
                da.SelectCommand.Parameters.AddWithValue("@ESTADO", usuario.ESTADO);
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
                da.SelectCommand.Parameters.AddWithValue("@USER_NAME", "");
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.Fill(dt);
                Result = ClsSqlServer.toJson(dt);
                conn.Dispose();
                conn.Close();
            }
            return Result;
        }

        public static string getUsuarioById(ClsUsuario usuario)
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
                da.SelectCommand.Parameters.AddWithValue("@USER_NAME", usuario.USER_NAME);
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
