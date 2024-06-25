using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class VetDataAccess : DatabaseConnection
    {
        public List<List<string>> vetData { get; set; }

        public VetDataAccess()
        {
            vetData = new List<List<string>>();
        }
        public DataTable LoadVetsData()
        {
            DataTable dt = new DataTable();
            using (SqlConnection connection = GetConnection())
            {
                connection.Open();
                string query = "SELECT * FROM vet_appointments";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        adapter.Fill(dt);
                    }
                }
                connection.Close();
            }
            return dt;
        }
        public void AddVetData(string vetName, string animalId, string dayOfWeek, string vetTime)
        {
            using (SqlConnection connection = GetConnection())
            {
                connection.Open();

                string insertQuery = "INSERT INTO vet_appointments (VetName, AnimalID, DayOfWeek, VetTime) VALUES (@VetName, @AnimalId, @DayOfWeek, @VetTime)";

                using (SqlCommand command = new SqlCommand(insertQuery, connection))
                {
                    command.Parameters.AddWithValue("@VetName", vetName);
                    command.Parameters.AddWithValue("@AnimalId", animalId);
                    command.Parameters.AddWithValue("@DayOfWeek", dayOfWeek);
                    command.Parameters.AddWithValue("@VetTime", vetTime);

                    command.ExecuteNonQuery();
                }
                connection.Close();
            }
        }
        public void DeleteVetData(int id)
        {
            using (SqlConnection connection = GetConnection())
            {
                connection.Open();

                string deleteQuery = "DELETE FROM vet_appointments WHERE Id = @Id";

                using (SqlCommand command = new SqlCommand(deleteQuery, connection))
                {
                    command.Parameters.AddWithValue("@Id", id);
                    command.ExecuteNonQuery();
                }
                connection.Close();
            }
        }
    }
}
