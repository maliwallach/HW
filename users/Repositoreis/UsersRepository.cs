using Microsoft.EntityFrameworkCore;
using users.Models;

namespace users.Repositoreis
{
    public class UsersRepository : IUsersRepository
    {
        private readonly UsersContext _context;

        public UsersRepository(UsersContext context)
        {
            _context = context;
        }
        public List<User> GetUsers()
        {
            return _context.Users.ToList();
        }

        public User GetById(int id)
        {
            User? user = _context.Users.Find(id);
            return user;
        }
        public void Add(User user)
        {
            _context.Users.Add(user);
            _context.SaveChanges();
        }
        public void Update(User user)
        {
            _context.Users.Update(user);
            _context.SaveChanges();
        }
        public void Delete(int id)
        {
            User? user = _context.Users.Find(id);

            if (user != null)
            {
                _context.Users.Remove(user);
                _context.SaveChanges();
            }
        }
        public List<Models.Task> GetTasksByUserId(int userId)
        {
            return _context.Tasks
                  .Where(task => task.Id == userId)
                  .ToList();
        }
    }
}
