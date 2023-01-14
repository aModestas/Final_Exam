using Final_Exam.Entities;

namespace Final_Exam.DB
{
    public class UserDTO
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public Person Person { get; set; }
        public string Role { get; set; }
    }
}
