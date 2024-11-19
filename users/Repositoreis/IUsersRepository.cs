using users.Models;
using System.Collections.Generic;
namespace users.Repositoreis
{
    public interface IUsersRepository
    {
        List<User> GetUsers();
        User GetById(int id);
        void Add(User user);
        void Update(User user);
        void Delete(int id);
        List<Models.Task> GetTasksByUserId(int userId);
        

    }
}
