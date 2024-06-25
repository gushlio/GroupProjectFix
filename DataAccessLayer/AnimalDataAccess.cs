using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class AnimalDataAccess : DatabaseConnection
    {
        public List<List<string>> animalsData { get; set; }

        public AnimalDataAccess()
        {
            animalsData = new List<List<string>>();
        }

        public void LoadAnimalsData()
        {
            animalsData.Clear();

            using (SqlConnection connection = GetConnection())
            {
                connection.Open();

                string selectQuery = "SELECT * FROM [Animal]";

                using (SqlCommand command = new SqlCommand(selectQuery, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {

                            while (reader.Read())
                            {
                                List<string> animalData = new List<string>();
                                for (int i = 0; i < reader.FieldCount; i++)
                                {
                                    animalData.Add(reader[i].ToString());
                                }
                                animalsData.Add(animalData);


                            }
                        }
                        else
                        {
                            Console.WriteLine("No data found for the specified ID.");
                        }
                    }
                }
                connection.Close();
            }
        }

        public void AddAnimalData(string species, string locationName, string dateOfBirth, string reasonForEntry, string? reasonForLeave, string? imgURL, DateTime dateOfEntry, DateTime? dateOfLeave, int? motherId, int? fatherId)
        {
            using (SqlConnection connection = GetConnection())
            {
                connection.Open();

                string insertQuery = "INSERT INTO [Animal] (Species, LocationName, DateOfBirth, ReasonForEntry, ReasonForLeave, ImgURL, DateOfEntry, DateOfLeave, MotherId, FatherId) VALUES (@Species, @LocationName, @DateOfBirth, @ReasonForEntry, @ReasonForLeave, @ImgURL, @DateOfEntry, @DateOfLeave, @MotherId, @FatherId)";

                using (SqlCommand command = new SqlCommand(insertQuery, connection))
                {
                    command.Parameters.AddWithValue("@Species", species);
                    command.Parameters.AddWithValue("@LocationName", locationName);
                    command.Parameters.AddWithValue("@DateOfBirth", dateOfBirth);
                    command.Parameters.AddWithValue("@ReasonForEntry", reasonForEntry);
                    command.Parameters.AddWithValue("@ReasonForLeave", reasonForLeave);
                    command.Parameters.AddWithValue("@ImgURL", imgURL);
                    command.Parameters.AddWithValue("@DateOfEntry", dateOfEntry);
                    command.Parameters.AddWithValue("@DateOfLeave", (object)dateOfLeave ?? DBNull.Value);
                    command.Parameters.AddWithValue("@MotherId", motherId);
                    command.Parameters.AddWithValue("@FatherId", fatherId);

                    command.ExecuteNonQuery();
                }

                connection.Close();
            }
        }

        public void UpdateMotherId(int animalId, int motherId)
        {
            using (SqlConnection connection = GetConnection())
            {
                connection.Open();

                string updateUserQuery = "UPDATE [Animal] SET MotherId=@MotherId WHERE Id = @Id";
                using (SqlCommand command = new SqlCommand(updateUserQuery, connection))
                {
                    command.Parameters.AddWithValue("@Id", animalId);
                    command.Parameters.AddWithValue("@MotherId", motherId);

                    command.ExecuteNonQuery();

                }

                connection.Close();
            }
        }

        public void UpdateFatherId(int animalId, int fatherId)
        {
            using (SqlConnection connection = GetConnection())
            {
                connection.Open();

                string updateUserQuery = "UPDATE [Animal] SET FatherId=@FatherId WHERE Id = @Id";
                using (SqlCommand command = new SqlCommand(updateUserQuery, connection))
                {
                    command.Parameters.AddWithValue("@Id", animalId);
                    command.Parameters.AddWithValue("@FatherId", fatherId);

                    command.ExecuteNonQuery();

                }

                connection.Close();
            }
        }

        public void DeleteAnimalData(int animalId)
        {
            using (SqlConnection connection = GetConnection())
            {
                connection.Open();
                string deleteQuery = "DELETE FROM [Animal] WHERE Id = @Id";
                using (SqlCommand command = new SqlCommand(deleteQuery, connection))
                {
                    command.Parameters.AddWithValue("@Id", animalId);
                    command.ExecuteNonQuery();
                }


                connection.Close();
            }
        }

        public void UpdateReasonForLeave(int animalId, string reasonForLeave, DateTime dateOfLeave)
        {
            using (SqlConnection connection = GetConnection())
            {
                connection.Open();

                string updateUserQuery = "UPDATE [Animal] SET ReasonForLeave=@ReasonForLeave, DateOfLeave=@DateofLeave WHERE Id = @Id";
                using (SqlCommand command = new SqlCommand(updateUserQuery, connection))
                {
                    command.Parameters.AddWithValue("@Id", animalId);
                    command.Parameters.AddWithValue("@ReasonForLeave", reasonForLeave);
                    command.Parameters.AddWithValue("@DateOfLeave", dateOfLeave);

                    command.ExecuteNonQuery();

                }

                connection.Close();
            }
        }

        public void UpdateImgURL(int animalId, string imgURl)
        {
            using (SqlConnection connection = GetConnection())
            {
                connection.Open();

                string updateUserQuery = "UPDATE [Animal] SET ImgURL=@ImgURL WHERE Id = @Id";
                using (SqlCommand command = new SqlCommand(updateUserQuery, connection))
                {
                    command.Parameters.AddWithValue("@Id", animalId);
                    command.Parameters.AddWithValue("@ImgURL", imgURl);

                    command.ExecuteNonQuery();

                }

                connection.Close();
            }
        }
        public void UpdateSpecies(int animalId, string species)
        {
            using (SqlConnection connection = GetConnection())
            {
                connection.Open();

                string updateUserQuery = "UPDATE [Animal] SET Species=@Species WHERE Id = @Id";
                using (SqlCommand command = new SqlCommand(updateUserQuery, connection))
                {
                    command.Parameters.AddWithValue("@Id", animalId);
                    command.Parameters.AddWithValue("@Species", species);

                    command.ExecuteNonQuery();

                }

                connection.Close();
            }
        }
        public void UpdateReasonForEntry(int animalId, string reasonForEntry, DateTime dateOfEntry)
        {
            using (SqlConnection connection = GetConnection())
            {
                connection.Open();

                string updateUserQuery = "UPDATE [Animal] SET ReasonForEntry=@ReasonForEntry, DateOfEntry=@DateOfEntry WHERE Id = @Id";
                using (SqlCommand command = new SqlCommand(updateUserQuery, connection))
                {
                    command.Parameters.AddWithValue("@Id", animalId);
                    command.Parameters.AddWithValue("@ReasonForEntry", reasonForEntry);
                    command.Parameters.AddWithValue("@DateOfEntry", dateOfEntry);

                    command.ExecuteNonQuery();

                }

                connection.Close();
            }
        }
    }
}
