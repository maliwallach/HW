using users.Models;

namespace users.Repositoreis
{
    public class TasksRepository:ITasksRepository
    {
        private readonly UsersContext _context;

        public TasksRepository(UsersContext context)
        {
            _context = context;
        }
        public void Add(Models.Task task)
        {
            _context.Tasks.Add(task);
            _context.SaveChanges();
        }
    }
}
