using ClownsProject.Controllers;
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

namespace ClownsProject.Views
{
    /// <summary>
    /// Логика взаимодействия для showAllInfoTaskPage.xaml
    /// </summary>
    public partial class showAllInfoTaskPage : Page
    {
        int projectID;
        public showAllInfoTaskPage(Models.Task task)
        {
            InitializeComponent();
            title.Text = task.Title;
            description.Text = task.Description;
            executor.Text = task.Login;
            dateStart.Text = task.DateStart.ToShortDateString();
            DateOnly temp = (DateOnly)task.DateEnd;
            dateEnd.Text = temp.ToShortDateString();
            status.Text = task.IdStatusNavigation.Title;
            project.Text = task.IdProjectNavigation.Title;
            projectID = task.IdProject;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var projectObj = TaskService.GetProjects().First(p => p.IdProject == projectID);
            PageController.ShowProjectPage(projectObj);
        }
    }
}
