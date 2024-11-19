using users.Models;

namespace users.Repositoreis
{
    public interface IProjectRepository
    {
        Project GetById(int id);
        void Update(Models.Project project);
    }
}
