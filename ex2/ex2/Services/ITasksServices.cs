using static System.Reflection.Metadata.BlobBuilder;
using ex2.Models;

namespace ex2.Services
{
    public interface ITasksServices
    {
        public IEnumerable<Tasks> Get();
        public void Add(Tasks task);
        public void Update(Tasks task);
        public void Delete(int id);
        public List<Tasks> getByUserName(string Name);

    }
}

