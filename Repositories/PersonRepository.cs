using Final_Exam.DB;
using Final_Exam.Entities;
using Final_Exam.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;

namespace Final_Exam.Repositories
{
    public class PersonRepository : IPersonRepository
    {
        private readonly ApplicationDBContext _context;
        private readonly List<Person> _people = new List<Person>();
        private readonly IUserrepository _userrepository;
        public PersonRepository(ApplicationDBContext context, IUserrepository userrepository)
        {
            _context = context;
            _userrepository = userrepository;
        }

        public Person AddNewPerson(PersonDTO person)
        {
            var newAddress = new Address
            {
                City = person.City,
                Street = person.Street,
                HouseNumber = person.HouseNumber,
                FlatNumber = person.FlatNumber,
            };
            _context.Addresses.Add(newAddress);

            var newPerson = new Person
            {
                Name = person.Name,
                Lastname = person.Lastname,
                PersonCode = person.PersonCode,
                TelNumber = person.TelNumber,
                Email = person.Email,
                Picture = person.Picture,
                Address = newAddress,
                User = _userrepository.GetById(person.UserId),
            };
            _context.People.Add(newPerson);
            _context.SaveChanges();
            return newPerson;
        }

        public Person FindByID(int id)
        {
            var person = _context.People.Include(x => x.Address).Include(p => p.User).Where(m => m.Id == id).FirstOrDefault();
            return person;
        }

        public List<Person> GetAllPeople()
        {
            var people = _context.People.Include(x => x.Address).Include(p => p.User).ToList();
            return people;
        }

        public Person RemovePerson(int id)
        {
            var person = _context.People.Include(x => x.Address).Include(p => p.User).Where(m => m.Id == id).FirstOrDefault();
            var address = _context.Addresses.Where(x => x.Id == person.AddressId).FirstOrDefault();
            var user = _context.Users.Where(x => x.Id == person.UserId).FirstOrDefault();
            _context.People.Remove(person);
            _context.Addresses.Remove(address);
            _context.Users.Remove(user);
            _context.SaveChanges();
            return person;
        }

        public Person UpdateCity(int id, string city)
        {
            var personToUpdate = _context.People.Include(x => x.Address).Include(p => p.User).Where(m => m.Id == id).FirstOrDefault();
            personToUpdate.Address.City = city;
            _context.SaveChanges();
            return personToUpdate;
        }

        public Person UpdateEmail(int id, string email)
        {
            var personToUpdate = _context.People.Include(x => x.Address).Include(p => p.User).Where(m => m.Id == id).FirstOrDefault();
            personToUpdate.Email = email;
            _context.SaveChanges();
            return personToUpdate;
        }

        public Person UpdateFlatNumber(int id, int flatNumber)
        {
            var personToUpdate = _context.People.Include(x => x.Address).Include(p => p.User).Where(m => m.Id == id).FirstOrDefault();
            personToUpdate.Address.FlatNumber = flatNumber;
            _context.SaveChanges();
            return personToUpdate;
        }

        public Person UpdateHouseNumber(int id, int houseNumber)
        {
            var personToUpdate = _context.People.Include(x => x.Address).Include(p => p.User).Where(m => m.Id == id).FirstOrDefault();
            personToUpdate.Address.HouseNumber = houseNumber;
            _context.SaveChanges();
            return personToUpdate;
        }

        public Person UpdateLastName(int id, string lastName)
        {
            var personToUpdate = _context.People.Include(x => x.Address).Include(p => p.User).Where(m => m.Id == id).FirstOrDefault();
            personToUpdate.Lastname = lastName;
            _context.SaveChanges();
            return personToUpdate;
        }

        public Person UpdateName(int id, string name)
        {
            var personToUpdate = _context.People.Include(x => x.Address).Include(p => p.User).Where(m => m.Id == id).FirstOrDefault();
            personToUpdate.Name = name;
            _context.SaveChanges();
            return personToUpdate;
        }

        public Person UpdatePersonCode(int id, int personCode)
        {
            var personToUpdate = _context.People.Include(x => x.Address).Include(p => p.User).Where(m => m.Id == id).FirstOrDefault();
            personToUpdate.PersonCode = personCode;
            _context.SaveChanges();
            return personToUpdate;
        }

        public Person UpdatePicture(int id, byte[] picture)
        {
            var personToUpdate = _context.People.Include(x => x.Address).Include(p => p.User).Where(m => m.Id == id).FirstOrDefault();
            personToUpdate.Picture = picture;
            _context.SaveChanges();
            return personToUpdate;
        }

        public Person UpdateStreet(int id, string street)
        {
            var personToUpdate = _context.People.Include(x => x.Address).Include(p => p.User).Where(m => m.Id == id).FirstOrDefault();
            personToUpdate.Address.Street = street;
            _context.SaveChanges();
            return personToUpdate;
        }

        public Person UpdateTelNumber(int id, int telNumber)
        {
            var personToUpdate = _context.People.Include(x => x.Address).Include(p => p.User).Where(m => m.Id == id).FirstOrDefault();
            personToUpdate.TelNumber = telNumber;
            _context.SaveChanges();
            return personToUpdate;
        }
    }
}
