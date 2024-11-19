using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using users.Models;
using users.Repositoreis;
namespace users.Services
{
    public class UsersServices : IUsersServices
    {
        private readonly IUsersRepository _usersRepository;
        public UsersServices(IUsersRepository usersRepository)
        {
            _usersRepository = usersRepository;
        }

        public List<User> GetUsers()
        {
            var allUsers = _usersRepository.GetUsers();
            return allUsers;
        }
        public User GetUserById(int id)
        {
            return _usersRepository.GetById(id);
        }
        public void AddUser(User newUser)
        {
            _usersRepository.Add(newUser);
        }
        public void UpdateUser(User user)
        {
            _usersRepository.Update(user);
        }
        public void DeleteUser(int id)
        {
            _usersRepository.Delete(id);
        }
        public List<Models.Task> GetTasksByUserId(int userId)
        {
            return _usersRepository.GetTasksByUserId(userId);
        }

    }
}

