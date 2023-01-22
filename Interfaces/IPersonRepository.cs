using Final_Exam.DB;
using Final_Exam.Entities;

namespace Final_Exam.Interfaces
{
    public interface IPersonRepository
    {
        List<Person> GetAllPeople();
        Person AddNewPerson(PersonDTO person);
        Person FindByID(int id);
        Person RemovePerson(int id);
        Person UpdateName(int id, string name);
        Person UpdateLastName(int id, string lastName);
        Person UpdatePersonCode(int id, int personCode);
        Person UpdateTelNumber(int id, int telNumber);
        Person UpdateEmail(int id, string email);
        Person UpdatePicture(int id, byte[] picture);
        Person UpdateCity(int id, string city);
        Person UpdateStreet(int id, string street);
        Person UpdateHouseNumber(int id, int houseNumber);
        Person UpdateFlatNumber(int id, int flatNumber);
    }
}
