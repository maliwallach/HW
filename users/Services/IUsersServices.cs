using users.Models;

namespace users.Services
{
    public interface IUsersServices
    {
        List<User> GetUsers();
        User GetUserById(int id);
        void AddUser(User user);
        void UpdateUser(User user);
        void DeleteUser(int id);

        List<Models.Task> GetTasksByUserId(int userId);
    }
}
