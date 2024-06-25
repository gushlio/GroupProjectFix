using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;

namespace DataAccessLayer.Repository
{
    public class AnimalRepository
    {
        private DatabaseConnection _databaseConnection;
        public AnimalRepository()
        {
            _databaseConnection = new DatabaseConnection();
        }

        // Method to add the species to the database
        public void AddSpecies(string species)
        {
            if (SpeciesExists(species))
            {
                // Handle the case where the species already exists
                Console.WriteLine("Species already exists. Please choose a different species name.");
                return; // Exit the method
            }

            using (SqlConnection connection = _databaseConnection.GetConnection())
            {
                try
                {
                    connection.Open();

                    // SQL command to insert the species into the Species table
                    string query = "INSERT INTO Species (SpeciesName) VALUES (@SpeciesName)";

                    // Create a SqlCommand object with the query and connection
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Add parameters to the SQL command
                        command.Parameters.AddWithValue("@SpeciesName", species);

                        // Execute the SQL command
                        command.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    // Handle exceptions (e.g., log, display error message)
                    Console.WriteLine("Error adding species: " + ex.Message);
                }
            }
        }

        // Method to add a new animal to the database
        public void AddAnimal(string name, string species, string color, decimal weight, DateTime dateOfBirth)
        {
            using (SqlConnection connection = _databaseConnection.GetConnection())
            {
                try
                {
                    connection.Open();

                    // SQL command to insert the animal into the Animals table
                    string query = @"INSERT INTO Animals (Name, SpeciesId, Color, Weight, DateOfBirth) 
                                     VALUES (@Name, (SELECT SpeciesId FROM Species WHERE SpeciesName = @SpeciesName), @Color, @Weight, @DateOfBirth)";

                    // Create a SqlCommand object with the query and connection
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Add parameters to the SQL command
                        command.Parameters.AddWithValue("@Name", name);
                        command.Parameters.AddWithValue("@SpeciesName", species);
                        command.Parameters.AddWithValue("@Color", color);
                        command.Parameters.AddWithValue("@Weight", weight);
                        command.Parameters.AddWithValue("@DateOfBirth", dateOfBirth);

                        // Execute the SQL command
                        command.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    // Handle exceptions (e.g., log, display error message)
                    Console.WriteLine("Error adding animal: " + ex.Message);
                }
            }
        }
        // Method to retrieve all locations from the database
        public List<string> GetAllLocations()
        {
            List<string> locations = new List<string>();

            using (SqlConnection connection = _databaseConnection.GetConnection())
            {
                try
                {
                    connection.Open();

                    // SQL command to select all locations from the Locations table
                    string query = "SELECT LocationName FROM Locations";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                string location = reader.GetString(0);
                                locations.Add(location);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    // Handle exceptions
                    Console.WriteLine("Error retrieving locations: " + ex.Message);
                }
            }

            return locations;
        }
        // Method to retrieve all species from the database
        public List<string> GetAllSpecies()
        {
            List<string> speciesList = new List<string>();

            using (SqlConnection connection = _databaseConnection.GetConnection())
            {
                try
                {
                    connection.Open();

                    // SQL command to select all species from the Species table
                    string query = "SELECT SpeciesName FROM Species";

                    // Create a SqlCommand object with the query and connection
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Execute the SQL command and read the result
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            // Iterate through the result set and add species names to the list
                            while (reader.Read())
                            {
                                string speciesName = reader.GetString(0); // Assuming SpeciesName is in the first column
                                speciesList.Add(speciesName);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    // Handle exceptions (e.g., log, display error message)
                    Console.WriteLine("Error retrieving species: " + ex.Message);
                }
            }

            return speciesList;
        }
        public bool SpeciesExists(string species)
        {
            bool exists = false;
            using (SqlConnection connection = _databaseConnection.GetConnection())
            {
                try
                {
                    connection.Open();
                    string query = "SELECT COUNT(*) FROM Species WHERE SpeciesName = @SpeciesName";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@SpeciesName", species);
                        int count = (int)command.ExecuteScalar();
                        exists = (count > 0);
                    }
                }
                catch (Exception ex)
                {
                    // Handle exceptions
                    Console.WriteLine("Error checking species existence: " + ex.Message);
                }
            }
            return exists;
        }
        // Method to retrieve all animals from the database
        public DataTable GetAllAnimals()
        {
            DataTable dataTable = new DataTable();
            using (SqlConnection connection = _databaseConnection.GetConnection())
            {
                try
                {
                    connection.Open();
                    string query = @"SELECT Animals.Name AS AnimalName, 
                            Species.SpeciesName AS SpeciesName, 
                            Animals.Color, 
                            Animals.Weight, 
                            Animals.DateOfBirth,
                          
                            Locations.LocationName AS LocationName
                     FROM Animals
                     JOIN Species ON Animals.SpeciesId = Species.SpeciesId
                     LEFT JOIN Locations ON Animals.LocationId = Locations.LocationId";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            adapter.Fill(dataTable);
                        }
                    }
                }
                catch (Exception ex)
                {
                    // Handle exceptions
                    Console.WriteLine("Error retrieving animals with details: " + ex.Message);
                }
            }
            return dataTable;
        }
        // Method to add a new location to the database
        public void AddLocation(string location)
        {
            if (LocationExists(location))
            {
                // Handle the case where the location already exists
                Console.WriteLine("Location already exists. Please choose a different location name.");
                return; // Exit the method
            }

            using (SqlConnection connection = _databaseConnection.GetConnection())
            {
                try
                {
                    connection.Open();

                    // SQL command to insert the location into the Locations table
                    string query = "INSERT INTO Locations (LocationName) VALUES (@LocationName)";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@LocationName", location);
                        command.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    // Handle exceptions
                    Console.WriteLine("Error adding location: " + ex.Message);
                }
            }
        }

        // Method to update the location of an animal in the Animals table
        public void UpdateAnimalLocation(string animalName, string location)
        {

            using (SqlConnection connection = _databaseConnection.GetConnection())
            {
                try
                {
                    connection.Open();

                    // SQL command to update the location of the animal
                    string query = @"UPDATE Animals 
                             SET LocationId = (SELECT LocationId FROM Locations WHERE LocationName = @Location) 
                             WHERE Name = @AnimalName";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Location", location);
                        command.Parameters.AddWithValue("@AnimalName", animalName);
                        command.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    // Handle exceptions
                    Console.WriteLine("Error updating animal location: " + ex.Message);
                }
            }
        }
        // Method to insert data into AnimalClinic table
        public void InsertIntoAnimalClinicTable(string animalName, string clinicUpdate, string location)
        {
            using (SqlConnection connection = _databaseConnection.GetConnection())
            {
                try
                {
                    connection.Open();

                    // SQL command to insert data into AnimalClinic table
                    string query = @"INSERT INTO AnimalClinic (AnimalName, ClinicUpdate, LocationId) 
                    VALUES (@AnimalName, @ClinicUpdate, 
                    (SELECT LocationId FROM Locations WHERE LocationName = @Location))"
                    ;

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Add parameters to the SQL command
                        command.Parameters.AddWithValue("@AnimalName", animalName);
                        command.Parameters.AddWithValue("@ClinicUpdate", clinicUpdate);
                        command.Parameters.AddWithValue("@Location", location);

                        // Execute the SQL command
                        command.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    // Handle exceptions
                    Console.WriteLine("Error inserting data into AnimalClinic table: " + ex.Message);
                }
            }
        }


        // Method to insert data into AnimalUpdates table
        public void InsertIntoAnimalUpdatesTable(string animalName, string updateText)
        {
            using (SqlConnection connection = _databaseConnection.GetConnection())
            {
                try
                {
                    connection.Open();

                    // SQL command to insert data into AnimalUpdates table
                    string query = @"INSERT INTO AnimalUpdates (AnimalName, Updatetxt) 
                                 VALUES (@AnimalName, @UpdateText)";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Add parameters to the SQL command
                        command.Parameters.AddWithValue("@AnimalName", animalName);
                        command.Parameters.AddWithValue("@UpdateText", updateText);

                        // Execute the SQL command
                        command.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    // Handle exceptions
                    Console.WriteLine("Error inserting data into AnimalUpdates table: " + ex.Message);
                }
            }
        }
        // Method to retrieve all animal care records from the database
        public DataTable GetAllAnimalCareRecords()
        {
            DataTable dataTable = new DataTable();
            using (SqlConnection connection = _databaseConnection.GetConnection())
            {
                try
                {
                    connection.Open();
                    string query = @"SELECT AnimalClinic.ClinicId,
                                    AnimalClinic.AnimalName,
                                    AnimalClinic.ClinicUpdate,
                                    AnimalClinic.VetAction,
                                    Locations.LocationName AS Location,
                                    AnimalClinic.UpdateDate
                             FROM AnimalClinic
                             JOIN Locations ON AnimalClinic.LocationId = Locations.LocationId";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            adapter.Fill(dataTable);
                        }
                    }
                }
                catch (Exception ex)
                {
                    // Handle exceptions
                    Console.WriteLine("Error retrieving animal care records: " + ex.Message);
                }
            }
            return dataTable;
        }
        public void UpdateVetActionInAnimalClinicTable(string animalName, string remedy)
        {
            using (SqlConnection connection = _databaseConnection.GetConnection())
            {
                try
                {
                    connection.Open();

                    // SQL command to update VetAction for the specific animal in the AnimalClinic table
                    string query = @"UPDATE AnimalClinic 
                             SET VetAction = @VetAction
                             WHERE AnimalName = @AnimalName";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Add parameters to the SQL command
                        command.Parameters.AddWithValue("@VetAction", remedy);
                        command.Parameters.AddWithValue("@AnimalName", animalName);

                        // Execute the SQL command
                        command.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    // Handle exceptions
                    Console.WriteLine("Error updating VetAction in AnimalClinic table: " + ex.Message);
                }
            }
        }
        public bool LocationExists(string location)
        {
            bool exists = false;
            using (SqlConnection connection = _databaseConnection.GetConnection())
            {
                try
                {
                    connection.Open();
                    string query = "SELECT COUNT(*) FROM Locations WHERE LocationName = @LocationName";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@LocationName", location);
                        int count = (int)command.ExecuteScalar();
                        exists = (count > 0);
                    }
                }
                catch (Exception ex)
                {
                    // Handle exceptions
                    Console.WriteLine("Error checking location existence: " + ex.Message);
                }
            }
            return exists;
        }

        // Method to insert data into DeportedAnimals table
        public void InsertIntoDeportedAnimalsTable(string animalName, string species, string color, decimal weight, DateTime dateOfBirth, string location, DateTime dateOfRegister)
        {
            using (SqlConnection connection = _databaseConnection.GetConnection())
            {
                try
                {
                    connection.Open();

                    // SQL command to insert data into DeportedAnimals table
                    string query = @"INSERT INTO DeportedAnimals (AnimalName, Species, Color, Weight, DateOfBirth, Location, DateOfRegister) 
                             VALUES (@AnimalName, @Species, @Color, @Weight, @DateOfBirth, @Location, @DateOfRegister)";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@AnimalName", animalName);
                        command.Parameters.AddWithValue("@Species", species);
                        command.Parameters.AddWithValue("@Color", color);
                        command.Parameters.AddWithValue("@Weight", weight);
                        command.Parameters.AddWithValue("@DateOfBirth", dateOfBirth);
                        command.Parameters.AddWithValue("@Location", location);
                        command.Parameters.AddWithValue("@DateOfRegister", dateOfRegister);

                        command.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    // Handle exceptions
                    Console.WriteLine("Error inserting data into DeportedAnimals table: " + ex.Message);
                }
            }
        }


        // Method to remove an animal from the Animals table
        public void RemoveAnimal(string animalName)
        {
            using (SqlConnection connection = _databaseConnection.GetConnection())
            {
                try
                {
                    connection.Open();

                    // SQL command to delete the animal from the Animals table
                    string query = @"DELETE FROM Animals WHERE Name = @AnimalName";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@AnimalName", animalName);
                        command.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    // Handle exceptions
                    Console.WriteLine("Error removing animal from Animals table: " + ex.Message);
                }
            }
        }
        // Method to retrieve all animals from the database excluding deported animals
        public DataTable GetAllAnimalsExcludingDeported()
        {
            DataTable dataTable = new DataTable();
            using (SqlConnection connection = _databaseConnection.GetConnection())
            {
                try
                {
                    connection.Open();
                    string query = @"SELECT 
                                Animals.Name AS AnimalName, 
                                Species.SpeciesName AS SpeciesName, 
                                Animals.Color, 
                                Animals.Weight, 
                                Animals.DateOfBirth,
                                Animals.DateOfRegister, 
                                Locations.LocationName AS LocationName
                             FROM Animals
                             JOIN Species ON Animals.SpeciesId = Species.SpeciesId
                             LEFT JOIN Locations ON Animals.LocationId = Locations.LocationId
                             LEFT JOIN DeportedAnimals ON Animals.Name = DeportedAnimals.AnimalName
                             WHERE DeportedAnimals.AnimalName IS NULL";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            adapter.Fill(dataTable);
                        }
                    }
                }
                catch (Exception ex)
                {
                    // Handle exceptions
                    Console.WriteLine("Error retrieving animals with details: " + ex.Message);
                }
            }
            return dataTable;
        }

        // Method to retrieve all records from the DeportedAnimals table
        public DataTable GetAllDeportedAnimals()
        {
            DataTable dataTable = new DataTable();
            using (SqlConnection connection = _databaseConnection.GetConnection())
            {
                try
                {
                    connection.Open();
                    string query = @"SELECT * FROM DeportedAnimals";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            adapter.Fill(dataTable);
                        }
                    }
                }
                catch (Exception ex)
                {
                    // Handle exceptions
                    Console.WriteLine("Error retrieving deported animals: " + ex.Message);
                }
            }
            return dataTable;
        }





    }
}
