using DataAccess;
using Models;
using Models.Validation;

namespace BusinessLogic
{
    public class PersonBL
    {
        PersonDA da;
        PersonValidator validator;

        public PersonBL()
        {
            da = new PersonDA();
            validator = new PersonValidator();
        }

        public async Task<bool> CreateAsync(Person p)
        {
            // Continue with Create if person as valid attribute values
            return validator.ValidPerson(p) ? await da.CreateAsync(p) : false;
        }

        public async Task<List<Person>> GetAsync()
        {
            return await da.GetAsync();
        }

        public async Task<Person> GetAsync(int id)
        {
            // Allow id over 0
            return id > 0 ? await da.GetAsync(id) : new Person();
        }

        public async Task<bool> UpdateAsync(Person p)
        {
            // Continue with Update if person as valid attribute values
            return validator.ValidPerson(p) ? await da.UpdateAsync(p) : false;
        }

        public async Task<bool> DeleteAsync(int id)
        {
            // Allow id over 0
            return id > 0 ? await da.DeleteAsync(id) : false;
        }
    }
}
