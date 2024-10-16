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
    /// Логика взаимодействия для projectPage.xaml
    /// </summary>
    public partial class projectPage : Page
    {
        public projectPage(Project project)
        {
            InitializeComponent();
            tasks.ItemsSource = TaskService.GetTasksInProject(project.IdProject);
            DataContext = project;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            PageController.ShowStatisticPage(((Project)DataContext).IdProject);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            PageController.ShowProjectsPage();
        }
    }
}
