using users.Models;

namespace users.Repositoreis
{
    public class ProjectRepository : IProjectRepository
    {
        private readonly UsersContext _context;

        public ProjectRepository(UsersContext context)
        {
            _context = context;
        }

        public void Update(Models.Project project)
        {
            _context.Projects.Update(project);
            _context.SaveChanges();
        }
        public Project GetById(int id)
        {
            Project? project = _context.Projects.Find(id);
            return project;
        }
    }
}
