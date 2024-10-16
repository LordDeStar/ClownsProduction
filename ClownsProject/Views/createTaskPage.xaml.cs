using ClownsProject.Controllers;
using ClownsProject.Models;
using ClownsProject.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Viewsss
{
    /// <summary>
    /// Логика взаимодействия для createPage.xaml
    /// </summary>
    public partial class createTaskPage : Page
    {
        public createTaskPage()
        {
            InitializeComponent();
            var projects = TaskService.GetProjects().Where(p => p.Login == UserController.CurrentUser.Login);
            projectCb.ItemsSource = projects.Select(p => p.Title);
            Executor.ItemsSource = UserService.GetUsers().Where(u => u.IdRole != 1 && u.IdRole != 3).Select(u => u.Login).ToList();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            PageController.ShowProjectPage((Project)DataContext);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            var name = Title.Text;
            var descr = Description.Text;
            var login = Executor.SelectedValue.ToString();
            var project = projectCb.SelectedValue.ToString();
            DateOnly start = DateOnly.FromDateTime(DateTime.Now);
            DateOnly end = DateOnly.FromDateTime(DateEnd.SelectedDate.Value);
            var status = "в работе";
            var projectName = project;

            TaskController.AddTask(name, descr, login, start, end, status, projectName);
        }
    }
}
