using Final_Exam.DB;
using Final_Exam.Entities;

namespace Final_Exam.Interfaces
{
    public interface IPersonRepository
    {
        List<Person> GetAllPeople();
        Person AddNewPerson(PersonDTO person);
        Person FindByID(int id);
    }
}
