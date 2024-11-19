using users.Models;

namespace users.Services
{
    public interface IProjectServices
    {
        void UpdateProject(Models.Project project);
        Project GetprojectById(int id);
    }
}
