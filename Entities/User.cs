namespace Final_Exam.Entities
{
    public class User
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public Person Person { get; set; }
        public string Role { get; set; }
        public User() { }
        public User(string username, string password, string role, Person person)
        {
            Username = username;
            Password = password;
            Role = role;
            Person = person;
        }
    }
}
