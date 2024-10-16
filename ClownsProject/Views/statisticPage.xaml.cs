using ClownsProject.Controllers;
using ClownsProject.Data.Models;
using ClownsProject.Models;
using ClownsProject.Services;
using DevExpress.Mvvm.Native;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
    /// Логика взаимодействия для statisticPage.xaml
    /// </summary>
    public partial class statisticPage : Page
    {

        Project project;

        public statisticPage(int projectID)
        {
            InitializeComponent();
            DataContext = this;
            project = TaskService.GetProjects().First(p => p.IdProject == projectID);
            var list = TaskService.GetTasks().Where(t => t.IdProject == projectID);
            countInProgressTask.Text = list.Where(t => t.IdStatus == 1).Count().ToString();
            countInTestTask.Text = list.Where(t => t.IdStatus == 2).Count().ToString();
            countComplateTask.Text = list.Where(t => t.IdStatus == 3).Count().ToString();
        }

        private void backBut_Click(object sender, RoutedEventArgs e)
        {
            PageController.ShowProjectPage(project);
        }
    }
}
