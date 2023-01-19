using Final_Exam.DB;
using Final_Exam.Entities;

namespace Final_Exam.Interfaces
{
    public interface IUserrepository
    {
        List<User> GetAllUsers();
        User AddNewUser(UserDTO user);
        User GetLogin (string username, string password);
        User GetById(int id);
        User RemoveUser(int id);
    }
}
