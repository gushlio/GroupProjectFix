using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class TicketsDB : DatabaseConnection
    {
        public List<List<string>> ticketsData { get; set; }

        public TicketsDB()
        {
            ticketsData = new List<List<string>>();
        }

        public void LoadTicketsData()
        {
            ticketsData.Clear();

            using (SqlConnection connection = GetConnection())
            {
                connection.Open();

                string selectQuery = "SELECT * FROM [Ticket]";

                using (SqlCommand command = new SqlCommand(selectQuery, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {

                            while (reader.Read())
                            {
                                List<string> ticketData = new List<string>();
                                for (int i = 0; i < reader.FieldCount; i++)
                                {
                                    ticketData.Add(reader[i].ToString());
                                }
                                ticketsData.Add(ticketData);


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

        public void AddTicketData(string type, string time)
        {
            int rowCount;
            using (SqlConnection connection = GetConnection())
            {
                connection.Open();

                string insertQuery = "INSERT INTO [Ticket] (Date, Type, Time) VALUES (@Date, @Type, @Time)";

                using (SqlCommand command = new SqlCommand(insertQuery, connection))
                {
                    command.Parameters.AddWithValue("@Date", DateTime.Now);
                    command.Parameters.AddWithValue("@Type", type);
                    command.Parameters.AddWithValue("@Time", time);



                    command.ExecuteNonQuery();

                }

                connection.Close();
            }
        }

        public void DeleteTicketData(int ticketId)
        {
            using (SqlConnection connection = GetConnection())
            {
                connection.Open();
                string deleteQuery = "DELETE FROM [Ticket] WHERE Id = @Id";
                using (SqlCommand command = new SqlCommand(deleteQuery, connection))
                {
                    command.Parameters.AddWithValue("@Id", ticketId);
                    command.ExecuteNonQuery();
                }


                connection.Close();
            }
        }
    }
}
