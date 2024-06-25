using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class NoteDataAccess : DatabaseConnection
    {
        public List<List<string>> notesData { get; set; }

        public NoteDataAccess()
        {
            notesData = new List<List<string>>();
        }

        public void LoadNotesData()
        {
            notesData.Clear();

            using (SqlConnection connection = GetConnection())
            {
                connection.Open();

                string selectQuery = "SELECT * FROM [Note]";

                using (SqlCommand command = new SqlCommand(selectQuery, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {

                            while (reader.Read())
                            {
                                List<string> noteData = new List<string>();
                                for (int i = 0; i < reader.FieldCount; i++)
                                {
                                    noteData.Add(reader[i].ToString());
                                }
                                notesData.Add(noteData);


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

        public void AddNoteData(int animalId, int employeeId, string title, string noteContent)
        {
            using (SqlConnection connection = GetConnection())
            {
                connection.Open();

                string insertQuery = "INSERT INTO [Note] (EmployeeID, Title, NoteContent, DateCreated, AnimalID) VALUES (@EmployeeID, @Title, @NoteContent, @DateCreated, @AnimalID)";

                using (SqlCommand command = new SqlCommand(insertQuery, connection))
                {
                    command.Parameters.AddWithValue("@EmployeeID", employeeId);
                    command.Parameters.AddWithValue("@Title", title);
                    command.Parameters.AddWithValue("@NoteContent", noteContent);
                    command.Parameters.AddWithValue("@DateCreated", DateTime.Now);
                    command.Parameters.AddWithValue("@AnimalID", animalId);

                    command.ExecuteNonQuery();
                }

                connection.Close();
            }
        }

        public void DeleteNoteData(int noteId)
        {
            using (SqlConnection connection = GetConnection())
            {
                connection.Open();
                string deleteQuery = "DELETE FROM [Note] WHERE Id = @Id";
                using (SqlCommand command = new SqlCommand(deleteQuery, connection))
                {
                    command.Parameters.AddWithValue("@Id", noteId);
                    command.ExecuteNonQuery();
                }


                connection.Close();
            }
        }
    }
}
