using Final_Exam.DB;
using Final_Exam.Entities;
using Final_Exam.Interfaces;

namespace Final_Exam.Repositories
{
    public class PersonRepository : IPersonRepository
    {
        private readonly ApplicationDBContext _context;
        private readonly List<Person> _people = new List<Person>();
        public PersonRepository(ApplicationDBContext context)
        {
            _context = context;
        }

        public Person AddNewPerson(PersonDTO person)
        {
            var newPerson = new Person
            {
                Name = person.Name,
                Lastname = person.Lastname,
                PersonCode = person.PersonCode,
                TelNumber = person.TelNumber,
                Email = person.Email,
                Picture = person.Picture,
            };
            _context.People.Add(newPerson);
            _context.SaveChanges();
            return newPerson;
        }

        public Person FindByID(int id)
        {
            throw new NotImplementedException();
        }

        public List<Person> GetAllPeople()
        {
            return _context.People.ToList();
        }
    }
}
