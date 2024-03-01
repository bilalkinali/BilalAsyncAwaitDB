using Models;
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
            int id = people.Max(x => x.Id) + 1;

            p.Id = id;

            people.Add(p);

            return true;
        }
        
        public async Task<List<Person>> GetAsync()
        {
            await Task.Delay(3000);

            List<Person> people = new List<Person>();

            string command = "SELECT * FROM PERSON";

            using SqlConnection dbConn = new SqlConnection(path);

            await dbConn.OpenAsync();

            using SqlCommand sqlCommand = new SqlCommand(command, dbConn);

            SqlDataReader reader = await sqlCommand.ExecuteReaderAsync();

            while (await reader.ReadAsync())
            {
                Person p = new Person();
                p.Id = (int)reader["ID"];
                p.FirstName = (string)reader["FirstName"];
                p.LastName = (string)reader["LastName"];
                p.Address = (string)reader["Address"];
                p.City = (string)reader["City"];
                p.PostalCode = (int)reader["PostalCode"];
                p.Email = (string)reader["Email"];
                p.Phone = (int)reader["Phone"];
                people.Add(p);
            }

            await dbConn.CloseAsync();

            return people;
        }

        public async Task<Person> GetAsync(int id)
        {
            await Task.Delay(3000);

            Person? person = people.SingleOrDefault(p => p.Id == id);
            
            // Return person or new person if null
            return person ?? new Person();
        }

        public async Task<bool> UpdateAsync(Person p)
        {
            await Task.Delay(3000);

            int index = people.FindIndex(x => x.Id == p.Id);

            if (index >= 0)
            {
                people[index] = p;
                return true;
            }
            return false;
        }

        public async Task<bool> DeleteAsync(int id)
        {
            await Task.Delay(3000);
            return people.RemoveAll(p => p.Id == id) > 0;
        }
    }
}
