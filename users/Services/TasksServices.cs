using users.Models;
using users.Repositoreis;

namespace users.Services
{
    public class TasksServices : ITasksServices
    {
        private readonly  ITasksRepository _tasksRepository;
        public TasksServices(ITasksRepository tasksRepository)
        {
            _tasksRepository = tasksRepository;
        }
        public void AddTask(Models.Task newTask)
        {
            _tasksRepository.Add(newTask);
        }
    }
}
