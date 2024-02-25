using DataAccess;
using Models;

namespace BusinessLogic
{
    public class PersonBL
    {
        PersonDA da;

        public PersonBL()
        {
            da = new PersonDA();
        }

        public async Task<bool> CreateAsync(Person p)
        {
            // Validate
            return await da.CreateAsync(p);
        }

        public async Task<List<Person>> GetAsync()
        {
            return await da.GetAsync();
        }

        public async Task<Person> GetAsync(int id)
        {
            return id > 0 ? await da.GetAsync(id) : new Person();
        }

        public async Task<bool> DeleteAsync(int id)
        {
            return await da.DeleteAsync(id);
        }
    }
}
