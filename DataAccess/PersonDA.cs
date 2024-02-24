using Models;


namespace DataAccess
{
    public class PersonDA
    {
        List<Person> people;

        public PersonDA()
        {
            people = new List<Person>()
            {
                new Person { Id = 1, FirstName = "Natalie", LastName = "Richards", Address = "25322 Rivera Stream Suite 328", City = "New Nathan", PostalCode = 92537, Email = "tkelly@lawson.com", Phone = 49412066 },
                new Person { Id = 2, FirstName = "Natasha", LastName = "Stewart", Address = "25573 Anne Motorway", City = "Thomasshire", PostalCode = 42390, Email = "fgentry@yahoo.com", Phone = 97135562 },
                new Person { Id = 3, FirstName = "Rachel", LastName = "Brooks", Address = "1819 Gregory Street", City = "South Amberland", PostalCode = 63098, Email = "jordan02@stokes-webb.net", Phone = 92870117 },
                new Person { Id = 4, FirstName = "Andrew", LastName = "Oconnor", Address = "21038 Michelle Trail", City = "East Gregoryville", PostalCode = 20559, Email = "ldaniels@moore.info", Phone = 67980075 },
                new Person { Id = 5, FirstName = "April", LastName = "Mendoza", Address = "6498 Jennifer Keys Apt. 785", City = "Lake Caroline", PostalCode = 39358, Email = "lance80@yahoo.com", Phone = 87896283 },
                new Person { Id = 6, FirstName = "Vanessa", LastName = "Nelson", Address = "237 Miller Inlet", City = "Port Erin", PostalCode = 74852, Email = "dgriffin@yahoo.com", Phone = 29589553 },
                new Person { Id = 7, FirstName = "Deborah", LastName = "Frey", Address = "2432 Jennifer Crescent Suite 938", City = "Raymondton", PostalCode = 35235, Email = "lwalker@yahoo.com", Phone = 93287558 },
                new Person { Id = 8, FirstName = "Kimberly", LastName = "Ferrell", Address = "055 Matthew Course Suite 152", City = "South Michael", PostalCode = 94656, Email = "hansenrobert@king.info", Phone = 98095925 },
                new Person { Id = 9, FirstName = "Robert", LastName = "Tyler", Address = "25490 Barbara Extensions Suite 521", City = "Lake Jasonport", PostalCode = 89678, Email = "david09@yahoo.com", Phone = 52334412 },
                new Person { Id = 10, FirstName = "Tony", LastName = "Fletcher", Address = "38388 Sanchez River", City = "Lake Michaelside", PostalCode = 36352, Email = "westyvonne@hotmail.com", Phone = 61472543 }
            };
        }
        
        public async Task<List<Person>> GetAsync()
        {
            await Task.Delay(1000);

            return people;
        }

       public async Task<Person> GetAsync(int id)
        {
            await Task.Delay(1000);

            Person? person = people.SingleOrDefault(p => p.Id == id);

            // Return person or new person if null
            return person ?? new Person();
        }
    }
}
