using ex2.Models;

namespace ex2.Repositories
{
    public interface ITasksRepository
    {
        public IEnumerable<Tasks> Get();
        public void add(Tasks task);
        public void update(Tasks task);
        public void delete(Tasks task);
        public List<Tasks> getByUserName(string Name);

    }
    
}
