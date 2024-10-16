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
using System.Windows.Shapes;

namespace ClownsProject
{
    /// <summary>
    /// Логика взаимодействия для RegistrationWindow.xaml
    /// </summary>
    public partial class RegistrationWindow : Window
    {
        public RegistrationWindow()
        {
            InitializeComponent();
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            AuthWindow authWindow = new AuthWindow();

            this.Close();

            authWindow.Show();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            var phone = phonenumber.Text;
            var name = login.Text;
            var pass = password.Text;

            UserController.Registration(name, pass, phone);
        }
    }
}
