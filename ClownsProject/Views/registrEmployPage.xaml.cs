﻿using ClownsProject.Controllers;
using ClownsProject.Services;
using DevExpress.Mvvm.UI.Native;
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
    /// Логика взаимодействия для registrEmployPage.xaml
    /// </summary>
    public partial class registrEmployPage : Page
    {
        public registrEmployPage()
        {
            InitializeComponent();
            var companies = ProjectService.GetCompanies().Select(s => s.TradeMark).ToList();
            var roles = RoleService.GetRoles().Select(s => s.Title).ToList();
            companyCB.ItemsSource = companies;
            roleCB.ItemsSource = roles;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var login = Login.Text;
            var pass = Password.Text;
            var companyPass = passForCompany.Text;

            string companyName = companyCB.SelectedValue.ToString();
            string roleName = roleCB.SelectedValue.ToString();
            AdministratorController.RegistrEmploy(login, pass, companyName, companyPass, roleName);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            PageController.ShowAdminPage();
        }
    }
}