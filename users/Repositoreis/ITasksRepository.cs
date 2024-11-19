using users.Models;

namespace users.Repositoreis
{
    public interface ITasksRepository
    {
        void Add(Models.Task task);
    }
}
