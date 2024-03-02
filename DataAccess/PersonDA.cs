using Models;
using System;
using System.Configuration;
using System.Data.SqlClient;


namespace DataAccess
{
    public class PersonDA
    {
        string path;

        public PersonDA()
        {
            path = ConfigurationManager.ConnectionStrings["default"].ToString();
        }

        public async Task<bool> CreateAsync(Person p)
        {
            await Task.Delay(3000);

            string command = "INSERT PERSON VALUES (@FN, @LN, @AD, @CT, @PC, @EM, @PH)"; //          <<<--- SQL Query --*

            try
            {
                // IDisposable, instead calling Dispose() in finally{} get's rid of the data hence closing the connection when done using
                using SqlConnection dbConn = new(path); 
                {
                    using SqlCommand sqlCommand = new(command, dbConn);
                    {
                        sqlCommand.Parameters.AddWithValue("@FN", p.FirstName);
                        sqlCommand.Parameters.AddWithValue("@LN", p.LastName);
                        sqlCommand.Parameters.AddWithValue("@AD", p.Address);
                        sqlCommand.Parameters.AddWithValue("@CT", p.City);
                        sqlCommand.Parameters.AddWithValue("@PC", p.PostalCode);
                        sqlCommand.Parameters.AddWithValue("@EM", p.Email);
                        sqlCommand.Parameters.AddWithValue("@PH", p.Phone);

                        await dbConn.OpenAsync();

                        return await sqlCommand.ExecuteNonQueryAsync() > 0;
                    }
                }
            }
            catch (Exception)
            {
                return false;
            }
        }
        
        public async Task<List<Person>> GetAsync()
        {
            await Task.Delay(3000);

            List<Person> people = new List<Person>();

            string command = "SELECT * FROM PERSON"; //          <<<--- SQL Query --*

            try
            {
                using SqlConnection dbConn = new(path);
                {
                    using SqlCommand sqlCommand = new(command, dbConn);
                    {
                        await dbConn.OpenAsync();

                        SqlDataReader reader = await sqlCommand.ExecuteReaderAsync();

                        while (await reader.ReadAsync())
                        {
                            Person person = new Person();
                            person.Id = (int)reader["ID"];
                            person.FirstName = (string)reader["FirstName"];
                            person.LastName = (string)reader["LastName"];
                            person.Address = (string)reader["Address"];
                            person.City = (string)reader["City"];
                            person.PostalCode = (int)reader["PostalCode"];
                            person.Email = (string)reader["Email"];
                            person.Phone = (int)reader["Phone"];
                            people.Add(person);
                        }
                        return people;
                    }
                }
            }
            catch (Exception)
            {
                return people;
            }
        }

        public async Task<Person> GetAsync(int id)
        {
            await Task.Delay(3000);

            Person person = new Person();

            string command = "SELECT * FROM PERSON WHERE ID = @ID"; //           <<<--- SQL Query --*

            try
            {
                using SqlConnection dbConn = new(path);
                {
                    using SqlCommand sqlCommand = new(command, dbConn);
                    {
                        sqlCommand.Parameters.AddWithValue("@ID", id);

                        await dbConn.OpenAsync();

                        SqlDataReader reader = await sqlCommand.ExecuteReaderAsync();

                        await reader.ReadAsync();

                        person.Id = (int)reader["ID"];
                        person.FirstName = (string)reader["FirstName"];
                        person.LastName = (string)reader["LastName"];
                        person.Address = (string)reader["Address"];
                        person.City = (string)reader["City"];
                        person.PostalCode = (int)reader["PostalCode"];
                        person.Email = (string)reader["Email"];
                        person.Phone = (int)reader["Phone"];

                        await dbConn.CloseAsync();
                        return person;
                    }
                }
            }
            catch (Exception)
            {
                return person;
            }
        }

        public async Task<bool> UpdateAsync(Person p)
        {
            await Task.Delay(3000);

            string command = "UPDATE PERSON SET FirstName = @FN, LastName = @LN, Address = @AD, City = @CT, " + //           <<<--- SQL Query --*
                "PostalCode = @PC, Email = @EM, Phone = @PH WHERE ID = @ID";

            try
            {
                using SqlConnection dbConn = new(path);
                {
                    using SqlCommand sqlCommand = new(command, dbConn);
                    {
                        sqlCommand.Parameters.AddWithValue("@FN", p.FirstName);
                        sqlCommand.Parameters.AddWithValue("@LN", p.LastName);
                        sqlCommand.Parameters.AddWithValue("@AD", p.Address);
                        sqlCommand.Parameters.AddWithValue("@CT", p.City);
                        sqlCommand.Parameters.AddWithValue("@PC", p.PostalCode);
                        sqlCommand.Parameters.AddWithValue("@EM", p.Email);
                        sqlCommand.Parameters.AddWithValue("@PH", p.Phone);
                        sqlCommand.Parameters.AddWithValue("@ID", p.Id);

                        await dbConn.OpenAsync();

                        return await sqlCommand.ExecuteNonQueryAsync() > 0;
                    }
                }
            }
            catch (Exception)
            {
                return false;
            }
        }

        public async Task<bool> DeleteAsync(int id)
        {
            await Task.Delay(3000);

            string command = "DELETE FROM PERSON WHERE ID = @ID"; //             <<<--- SQL Query --*

            try
            {
                using SqlConnection dbConn = new(path);
                {
                    using SqlCommand sqlCommand = new(command, dbConn);
                    {
                        sqlCommand.Parameters.AddWithValue("@ID", id);

                        await dbConn.OpenAsync();

                        return await sqlCommand.ExecuteNonQueryAsync() > 0;
                    }
                }
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
