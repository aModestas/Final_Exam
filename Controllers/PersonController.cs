using Final_Exam.DB;
using Final_Exam.Entities;
using Final_Exam.Interfaces;
using Final_Exam.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace Final_Exam.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PersonController : Controller
    {
        private readonly IPersonRepository _personRepository;
        public PersonController(IPersonRepository personRepository)
        {
            _personRepository = personRepository;
        }
        [HttpGet]
        public List<Person> GetPeople()
        {
            return _personRepository.GetAllPeople();
        }

        [HttpGet("id")]
        public Person GetPerson(int id)
        {
            return _personRepository.FindByID(id);
        }

        [HttpPost]
        public Person Add([FromBody] PersonDTO person)
        {
            return _personRepository.AddNewPerson(person);
        }

        [HttpPut("name")]
        public Person UpdateName([FromQuery] int id, [FromBody] string name)
        {
            return _personRepository.UpdateName(id, name);
        }           
        
        [HttpPut("lastname")]
        public Person UpdateLastName([FromQuery] int id, [FromBody] string lastName)
        {
            return _personRepository.UpdateLastName(id, lastName);
        }         
        
        [HttpPut("personCode")]
        public Person UpdatePersonCode([FromQuery] int id, [FromBody] int personCode)
        {
            return _personRepository.UpdatePersonCode(id, personCode);
        }          
        
        [HttpPut("telNumber")]
        public Person UpdateTelNumber([FromQuery] int id, [FromBody] int telNumber)
        {
            return _personRepository.UpdateTelNumber(id, telNumber);
        }          
        
        [HttpPut("email")]
        public Person UpdateEmail([FromQuery] int id, [FromBody] string email)
        {
            return _personRepository.UpdateEmail(id, email);
        }         
        
        [HttpPut("picture")]
        public Person UpdatePicture([FromQuery] int id, [FromBody] byte[] picture)
        {
            return _personRepository.UpdatePicture(id, picture);
        }        

        [HttpPut("street")]
        public Person UpdateStreet([FromQuery] int id, [FromBody] string street)
        {
            return _personRepository.UpdateStreet(id, street);
        }        
        
        [HttpPut("city")]
        public Person UpdateCity([FromQuery] int id, [FromBody] string city)
        {
            return _personRepository.UpdateCity(id, city);
        }        
        
        [HttpPut("houseNumber")]
        public Person UpdateHouseNumber([FromQuery] int id, [FromBody] int houseNumber)
        {
            return _personRepository.UpdateHouseNumber(id, houseNumber);
        }        
        
        [HttpPut("flatNumber")]
        public Person UpdateFlatNumber([FromQuery] int id, [FromBody] int flatNumber)
        {
            return _personRepository.UpdateFlatNumber(id, flatNumber);
        }

        [HttpDelete("id")]
        public Person RemovePerson(int id)
        {
            return _personRepository.RemovePerson(id);
        }
    }
}
