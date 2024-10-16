using ClownsProject.Models;
using ClownsProject.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace ClownsProject.Controllers
{
    public class ProjectController
    {
        public static void AddProject(string title, string login, string tradeMark)
        {
            if (!ProjectService.GetCompanies().Any(c => c.TradeMark.Equals(tradeMark)))
            {
                MessageBox.Show("Такой компании не существует!", "Ошибка");
                return;
            }
            if (TaskService.GetProjects().Any(p => p.Title.Equals(title) && p.TradeMark.Equals(tradeMark)))
            {
                MessageBox.Show("В компании уже существует проект с таким названием!", "Ошибка");
                return;
            }
            if (!UserService.GetUsers().Any(u => u.Login.Equals(login)))
            {
                MessageBox.Show("Такого менеджера не существует!", "Ошибка");
                return;
            }
            int id = ProjectService.GetIdForNewProject();
            Project project = new() { Login = login, Title = title, TradeMark = tradeMark, IdProject = id};
            using (var db = new MortalkombatContext())
            {
                db.Projects.Add(project);
                db.SaveChanges();
            }
            MessageBox.Show("Успешно!");
            PageController.ShowProjectsPage();
        }
    }
}
