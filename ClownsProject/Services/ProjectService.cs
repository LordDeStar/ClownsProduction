using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClownsProject.Models;

namespace ClownsProject.Services
{
    public class ProjectService
    {
        public static List<Project> GetProjects()
        {
            using (var db = new MortalkombatContext())
            {
                db.Companies.ToList();
                db.Users.ToList();
                db.Tasks.ToList();
                return db.Projects.ToList();
            }
        }
        public static List<Company> GetCompanies()
        {
            using (var db = new MortalkombatContext())
            {
                return db.Companies.ToList();
            }
        }

        public static int GetIdForNewProject()
        {
            using (var db = new MortalkombatContext())
            {
                return db.Projects.OrderBy(c => c.IdProject).Last().IdProject + 1;
            }
        }
        public static void AddProject(Project project)
        {
            using (var db = new MortalkombatContext())
            {
                db.Projects.Add(project);
                db.SaveChanges();
            }
        }
    }
}
