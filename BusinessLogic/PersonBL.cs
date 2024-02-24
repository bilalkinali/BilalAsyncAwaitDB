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

        public async Task<List<Person>> GetAsync()
        {
            return await da.GetAsync();
        }
    }
}
