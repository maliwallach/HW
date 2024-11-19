using users.Models;
using users.Repositoreis;

namespace users.Services
{
    public class ProjectServices : IProjectServices
    {
        private readonly IProjectRepository _projectRepository;
        public ProjectServices(IProjectRepository projectRepository)
        {
            _projectRepository = projectRepository;
        }

        public void UpdateProject(Models.Project project)
        {
            _projectRepository.Update(project);
        }
        public Project GetprojectById(int id)
        {
            return _projectRepository.GetById(id);
        }
    }
}
