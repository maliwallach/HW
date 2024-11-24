using ex2.Repositories;
using ex2.Models;
using Microsoft.EntityFrameworkCore;
using static System.Reflection.Metadata.BlobBuilder;

namespace ex2.Repositories
{
    public class TasksRepository:ITasksRepository
    {
        private readonly TasksContext _context;

        public TasksRepository(TasksContext context)
        {
            _context = context;
        }

        public void add(Tasks task)
        {
            //// בדיקת קיום המשתמש בטבלת Users
            //var user = _context.Users.FirstOrDefault(x => x.Id == task.UserId);
            //if (user != null)
            //{
            //    // מקשרים את המשתמש למשימה
            //    task.User = user;

            //    // בדיקת קיום הפרויקט בטבלת Projects
            //    var project = _context.Projects.FirstOrDefault(p => p.Id == task.ProjectId);
            //    if (project != null)
            //    {
            //        // מקשרים את הפרויקט למשימה
            //        task.Project = project;

                    // הוספת המשימה לטבלת המשימות
                    _context.Tasks.Add(task);
                    _context.SaveChanges();
                }
            //    else
            //    {
            //        throw new Exception("The specified project does not exist.");
            //    }
            //}
            //else
            //{
            //    throw new Exception("The specified user does not exist.");
            //}
        //}

        public void delete(Tasks task)
        {
            _context.Tasks.Remove(task);
            _context.SaveChanges();
        }

        public IEnumerable<Tasks> Get()
        {
            return _context.Tasks.ToList();
        }

        public void update(Tasks task)
        {
            _context.Tasks.Update(task);
            _context.SaveChanges();
        }

        public List<Tasks> getByUserName(string Name)
        {
            return _context.Tasks
                .Where(x=>x.User.Name==Name)
                .Include(x => x.User)
                .Include(x => x.Project)
                .ToList();
        }
    }
}
