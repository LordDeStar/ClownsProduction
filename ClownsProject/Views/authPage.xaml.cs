﻿using ClownsProject.Controllers;
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
    /// Логика взаимодействия для authPage.xaml
    /// </summary>
    public partial class authPage : Page
    {
        public authPage()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string login = username.Text;
            string pass = password.Text;

            UserController.Authorization(login, pass);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            PageController.ShowRegistrPage();
        }
    }
}
