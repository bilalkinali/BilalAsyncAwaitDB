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

            using SqlConnection dbConn = new SqlConnection(path);

            string command = "INSERT PERSON VALUES (@FN, @LN, @AD, @CT, @PC, @EM, @PH)";

            using SqlCommand sqlCommand = new SqlCommand(command, dbConn);

            sqlCommand.Parameters.AddWithValue("@FN", p.FirstName);
            sqlCommand.Parameters.AddWithValue("@LN", p.LastName);
            sqlCommand.Parameters.AddWithValue("@AD", p.Address);
            sqlCommand.Parameters.AddWithValue("@CT", p.City);
            sqlCommand.Parameters.AddWithValue("@PC", p.PostalCode);
            sqlCommand.Parameters.AddWithValue("@EM", p.Email);
            sqlCommand.Parameters.AddWithValue("@PH", p.Phone);

            try
            {
                await dbConn.OpenAsync();

                return await sqlCommand.ExecuteNonQueryAsync() > 0;
            }
            catch (Exception)
            {
                return false;
            }
            finally
            {
                await dbConn.CloseAsync();
            }
        }
        
        public async Task<List<Person>> GetAsync()
        {
            await Task.Delay(3000);

            List<Person> people = new List<Person>();

            using SqlConnection dbConn = new SqlConnection(path);

            string command = "SELECT * FROM PERSON";

            using SqlCommand sqlCommand = new SqlCommand(command, dbConn);

            try
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
            }
            catch (Exception)
            {
                return people;
            }
            finally
            {
                await dbConn.CloseAsync();
            }
            return people;
        }

        public async Task<Person> GetAsync(int id)
        {
            await Task.Delay(3000);

            Person person = new Person();

            SqlConnection dbConn = new SqlConnection(path);

            string command = "SELECT * FROM PERSON WHERE ID = @ID";

            using SqlCommand sqlCommand = new SqlCommand(command, dbConn);

            sqlCommand.Parameters.AddWithValue("@ID", id);

            try
            {
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

            }
            catch (Exception)
            {
                return person;
            }
            finally
            {
                await dbConn.CloseAsync();
            }
            return person;
        }

        public async Task<bool> UpdateAsync(Person p)
        {
            //await Task.Delay(3000);

            //int index = people.FindIndex(x => x.Id == p.Id);

            //if (index >= 0)
            //{
            //    people[index] = p;
            //    return true;
            //}
            return false;
        }

        public async Task<bool> DeleteAsync(int id)
        {
            //await Task.Delay(3000);
            //return people.RemoveAll(p => p.Id == id) > 0;
            return true;
        }
    }
}
