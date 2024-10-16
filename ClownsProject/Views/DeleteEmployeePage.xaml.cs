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

namespace ClownsProject.Views
{
    /// <summary>
    /// Логика взаимодействия для DeleteEmployeePage.xaml
    /// </summary>
    public partial class DeleteEmployeePage : Page
    {
        public DeleteEmployeePage()
        {
            InitializeComponent();
            foreach(var employee in Services.UserService.GetUsers().Where(v => v.IdRole == 2))
            {
                employeeCB.Items.Add(employee.Login.ToString());
            }
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            PageController.ShowAdminPage();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            UserController.Delete(employeeCB.SelectedValue.ToString());
        }
    }
}
