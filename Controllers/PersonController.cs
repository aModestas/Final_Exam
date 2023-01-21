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

        [HttpDelete("id")]
        public Person RemovePerson(int id)
        {
            return _personRepository.RemovePerson(id);
        }
    }
}
