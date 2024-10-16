using ClownsProject.Controllers;
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
    /// Логика взаимодействия для addPostPage.xaml
    /// </summary>
    public partial class addPostPage : Page
    {
        public addPostPage()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            PageController.ShowAdminPage();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            var title = namepost.Text;
            AdministratorController.AddRole(title);
        }
    }
}
