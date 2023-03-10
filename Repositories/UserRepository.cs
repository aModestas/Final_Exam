using Azure;
using Final_Exam.DB;
using Final_Exam.Entities;
using Final_Exam.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Final_Exam.Repositories
{
    public class UserRepository : IUserrepository
    {
        private readonly ApplicationDBContext _context;
        private readonly List<User> _users = new List<User>();
        public UserRepository(ApplicationDBContext context)
        {
            _context = context;
        }
        public User AddNewUser(UserDTO user)
        {
            var newUser = new User
            {
                Username = user.Username,
                Password = user.Password,
            };
            _context.Users.Add(newUser);
            _context.SaveChanges();
            return newUser;
        }

        public List<User> GetAllUsers()
        {
            return _context.Users.ToList();
        }

        public User GetById(int id)
        {
            var user = _context.Users.Where(x => x.Id == id).FirstOrDefault();
            return user;
        }

        public User UpdateUserRole(int id)
        {
            var userToUpdate = _context.Users.SingleOrDefault(x => x.Id == id);
            userToUpdate.Role = "admin";
            _context.SaveChanges();
            return userToUpdate;
        }
    }
}
