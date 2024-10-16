using Microsoft.EntityFrameworkCore.Storage.ValueConversion.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using Viewsss;
using ClownsProject.Models;
using System.Windows;
using ClownsProject.Services;
using ClownsProject.Views;

namespace ClownsProject.Controllers
{
    public class PageController
    {
        private static Page authPage = new authPage(); // полностью готово
        private static Page tasksPage = new TaskPage(); // полностью готово
        private static Page registrCompanysPage = new registrCompanyPage(); // полностью готово
        private static Page addPostPage = new addPostPage(); // полностью готово
        private static Page registrEmploysPage = new registrEmployPage(); // полностью готово
        private static Page createProjectPage = new createProject();// полностью готово
        private static Page createTaskPage; // полностью готово
        private static Page addStatusPage; // полностью готово
        private static Page registrPage = new registrPage(); // полностью готово
        private static Page showAllInfoPage; // полностью готово
        private static Page adminPage = new adminPage(); // доделать
        private static Page showProjectPage = new showProjectsPage(); // полностью готово
        private static Page showProject; // полностью готово
        private static Page deleteEmployeePage = new DeleteEmployeePage(); // полностью готово
        private static Page editTask; // полностью готово


        public static void ShowEditTaskPage(int taskID)
        {
            bool isEmploy = false;
            if (UserController.CurrentUser.IdRole == 2)
            {
                isEmploy = true;
            }
            MainWindow.Frame.Navigate(new editTaskPage(taskID, isEmploy));
        }
        public static void ShowProjectPage(Project project)
        {
            MainWindow.Frame.Navigate(new projectPage(project));
        }
        public static void ShowProjectsPage()
        {
            showProjectsPage.Projects.Items.Clear();
            var result = new List<Viewsss.ProjectUserControl>();
            var projects = ProjectService.GetProjects().Where(p => p.Login == UserController.CurrentUser.Login);
            foreach (var project in projects)
            {
                showProjectsPage.Projects.Items.Add(new Viewsss.ProjectUserControl(project));
            }
            MainWindow.Frame.Navigate(showProjectPage);
        }
        public static void ShowAuthPage()
        {
            authPage.DataContext = null;
            MainWindow.Frame.Navigate(authPage);
        }
        public static void ShowTasksPage(List<Models.Task> tasks = null)
        {
            tasks = TaskService.GetTasks();
            var tasksInProgress = tasks.Where(t => t.IdStatusNavigation.Title.Equals("в работе")).ToList();
            var tasksInTesting = tasks.Where(t => t.IdStatusNavigation.Title.Equals("в тестировании")).ToList();
            var tasksAllready = tasks.Where(t => t.IdStatusNavigation.Title.Equals("готово")).ToList();

            if (!UserController.CurrentUser.IdRoleNavigation.Title.Equals("менеджер"))
            {
                tasksInProgress = tasksInProgress.Where(t => t.Login.Equals(UserController.CurrentUser.Login)).ToList();
                tasksInTesting = tasksInTesting.Where(t => t.Login.Equals(UserController.CurrentUser.Login)).ToList();
                tasksAllready = tasksAllready.Where(t => t.Login.Equals(UserController.CurrentUser.Login)).ToList();
            }
            TaskPage.InProgress.ItemsSource = tasksInProgress;
            TaskPage.InTesting.ItemsSource = tasksInTesting;
            TaskPage.Allready.ItemsSource = tasksAllready;
            MainWindow.Frame.Navigate(tasksPage);
        }
        public static void ShowRegistrCompanyPage()
        {
            registrCompanysPage.DataContext = null;
            MainWindow.Frame.Navigate(registrCompanysPage);
        }
        public static void ShowRegistrEmployPage()
        {
            MainWindow.Frame.Navigate(new registrEmployPage());
        }
        public static void ShowAddPostPage()
        {
            addPostPage.DataContext = null;
            MainWindow.Frame.Navigate(addPostPage);
        }
        public static void ShowCreateProjectPage()
        {
            createProjectPage.DataContext = null;
            MainWindow.Frame.Navigate(new createProject());
        }
        public static void ShowCreateTaskPage()
        {
            MainWindow.Frame.Navigate(new createTaskPage());
        }
        public static void ShowStatisticPage(int projectID)
        {
            MainWindow.Frame.Navigate(new statisticPage(projectID));
        }
        public static void ShowAddStatusPage()
        {
            addStatusPage.DataContext = null;
            MainWindow.Frame.Navigate(addStatusPage);
        }
        public static void ShowRegistrPage()
        {
            registrPage.DataContext = null;
            MainWindow.Frame.Navigate(registrPage);
        }
        public static void ShowTaskPage(Models.Task task)
        {
            MainWindow.Frame.Navigate(new showAllInfoTaskPage(task));
        }
        public static void ShowAdminPage()
        {
            MainWindow.Frame.Navigate(adminPage);
        }
        public static void ShowDeleteEmployeePage()
        {
            MainWindow.Frame.Navigate(deleteEmployeePage);
        }


    }
}