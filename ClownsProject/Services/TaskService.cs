using ClownsProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using Viewsss;

namespace ClownsProject.Services
{
    public class TaskService
    {
        public static int GetIdForNewTask()
        {
            using (var db = new MortalkombatContext())
            {
                try
                {
                    return db.Tasks.OrderBy(t => t.IdTask).Last().IdTask + 1;
                }
                catch (Exception ex)
                {
                    return 1;
                }
            }
        }
        public static List<Models.Task> GetTasks()
        {
            using (var db = new MortalkombatContext())
            {
                
                db.Statuses.ToList();
                db.Projects.ToList();
                return db.Tasks.ToList();
            }
        }

        public static void ChangeTask(int taskID, string descr)
        {
            using (var db = new MortalkombatContext())
            {
                var task = db.Tasks.FirstOrDefault(t => t.IdTask == taskID);
                if (task == null)
                {
                    MessageBox.Show("Такой задачи нет в базе");
                    return;
                }
                task.Description = descr;
                db.SaveChanges();
            }

        }
        public static List<TaskControll> GetTaskControls()
        {
            using (var db = new MortalkombatContext())
            {
                db.Statuses.ToList();
                db.Projects.ToList();
                var result = new List<TaskControll>();
                foreach (var task in db.Tasks)
                {
                    result.Add(new TaskControll(task));

                }
                return result;
            }
        }

        public static List<TaskControll> GetTasksInProject(int project)
        {
            using (var db = new MortalkombatContext())
            {
                db.Statuses.ToList();
                db.Projects.ToList();
                var result = new List<TaskControll>();
                var tasks = db.Tasks.Where(t => t.IdProject == project);
                foreach (var task in tasks)
                {
                    result.Add(new TaskControll(task));

                }
                return result;
            }
        }
        public static List<Task> GetOverdueTasks()
        {
            using (var db = new MortalkombatContext())
            {
                return db.Tasks.Where(t => Convert.ToDateTime(t.DateEnd) < DateTime.Now && !t.IdStatusNavigation.Title.Equals("Готово")).ToList();
            }
        }
        public static List<Status> GetStatuses()
        {
            using (var db = new MortalkombatContext())
            {
                return db.Statuses.ToList();
            }
        }
        public static List<Project> GetProjects()
        {
            using (var db = new MortalkombatContext())
            {
                return db.Projects.ToList();
            }
        }
        public static void AddTask(Task task)
        {
            using (var db = new MortalkombatContext())
            {
                db.Tasks.Add(task);
                db.SaveChanges();
            }
        }
    }
}
