using ClownsProject.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using ClownsProject.Models;

namespace ClownsProject.Controllers
{
    public class TaskController
    {
        public static void ChangeStatus(string status, int taskId)
        {
            using (var db = new MortalkombatContext())
            {
                var task = db.Tasks.FirstOrDefault(t => t.IdTask == taskId);
                var selectedStatus = TaskService.GetStatuses().FirstOrDefault(s => s.Title.Equals(status));
                if (selectedStatus != null && task != null)
                {
                    task.IdStatus = selectedStatus.IdStatus;
                    db.SaveChanges();
                }
                else
                {
                    MessageBox.Show("Такого статуса или задачи не существует!", "Ошибка");
                }
            }                
        }

        public static void ChangeDescription(int taskID, string descr)
        {
            TaskService.ChangeTask(taskID, descr);
        }

        public static void AddTask(string title, string description, string login, DateOnly dateStart, DateOnly dateEnd, string status, string projectTitle)
        {
            int id = TaskService.GetIdForNewTask();
            int statusId = TaskService.GetStatuses().FirstOrDefault(s => s.Title.Equals(status)).IdStatus;
            int projectId = TaskService.GetProjects().FirstOrDefault(p => p.Title.Equals(projectTitle)).IdProject;
            
            if (!UserService.GetUsers().Any(u => u.Login.Equals(login)))
            {
                MessageBox.Show("Такого сотрудника не существует!", "Ошибка");
                return;
            }
            if (dateStart < DateOnly.FromDateTime(DateTime.Now))
            {
                MessageBox.Show("Дата страта задачи должна быть больше либо равна текущей дате!", "Ошибка");
                return;
            }
            if (dateEnd <= dateStart)
            {
                MessageBox.Show("Дедлайн не может настпить раньше постановки задачи или в этот же день!", "Ошибка");
                return;
            }
            if (statusId == 0)
            {
                MessageBox.Show("Такого статуса не существует!", "Ошибка");
                return;
            }
            if (projectId == 0)
            {
                MessageBox.Show("Такого проекта не существует!", "Ошибка");
                return;
            }
            if (title.Equals(""))
            {
                MessageBox.Show("Название задачи не может быть пустым!", "Ошибка");
                return;
            }
            Models.Task task = new() 
            { 
                IdTask = id,
                Title = title,
                Description = description,
                Login = login,
                DateStart = dateStart,
                DateEnd = dateEnd,
                IdStatus = statusId,
                IdProject = projectId
            };
            TaskService.AddTask(task);
            MessageBox.Show("Успех!");
        }
        public static void AddComment(string comment, Models.Task task)
        {
            using (var db = new MortalkombatContext())
            {
                string commentString = $"[{task.LoginNavigation.Login}]: {comment}\n";                                                                                      
                task.Description += commentString;
                db.SaveChanges();
            }
        }
        public static void ChangeExecutor(string executorLogin, Models.Task task)
        {
            using (var db = new MortalkombatContext())
            {
                task.Login = executorLogin;
                db.SaveChanges();
            }
        }
    }
}
