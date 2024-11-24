using ex2.Models;

using ex2.Repositories;
using System.Collections.Generic;
using System.Net.NetworkInformation;
using System.Threading.Tasks;
using static System.Reflection.Metadata.BlobBuilder;
namespace ex2.Services
{
    public class TasksServices : ITasksServices
    {
        private readonly ITasksRepository _TasksRepository;
        public TasksServices(ITasksRepository TasksRepository)
        {
            _TasksRepository = TasksRepository;
        }

        public void Add(Tasks task)
        {
             _TasksRepository.add(task);
        }

        public void Delete(int id)
        {
            var Tasks = Get();
            Tasks Task = Tasks.FirstOrDefault(i => i.Id == id);
             _TasksRepository.delete(Task);
        }

        public IEnumerable<Tasks> Get()
        {
            return _TasksRepository.Get();
        }

        public void Update(Tasks task)
        {
            _TasksRepository.update(task);
        }
        public List<Tasks> getByUserName(string Name)
        {
            return _TasksRepository.getByUserName(Name);
        }
   
    }
}
