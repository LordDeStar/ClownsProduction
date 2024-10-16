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

namespace Viewsss
{
    /// <summary>
    /// Логика взаимодействия для createProject.xaml
    /// </summary>
    public partial class createProject : Page
    {
        public createProject()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            PageController.ShowProjectsPage();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            var name = title.Text;
            var companyName = UserController.CurrentUser.Brand;
            var login = UserController.CurrentUser.Login;
            ProjectController.AddProject(name, login, companyName);
        }
    }
}
