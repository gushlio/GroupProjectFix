using System.Data.SqlClient;

namespace DataAccessLayer
{
    public class DatabaseConnection
    {
        private string connectionString = "Server=mssqlstud.fhict.local;Database=dbi524069_zoobazar;User Id=dbi524069_zoobazar;Password=zoop;TrustServerCertificate=True;";

        public SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }
    }
}
