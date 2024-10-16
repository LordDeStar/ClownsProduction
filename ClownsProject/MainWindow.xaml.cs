using ClownsProject.Controllers;
using ClownsProject.Models;
using ClownsProject.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Reflection;
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
using Viewsss;
using WPFUIKitProfessional.Themes;

namespace ClownsProject
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int count = 0;
        private bool isAdminPage = false;
        private bool isManagerPage = false;
        private bool isEmployeePage = false;
        public static User CurrentUser { get; set; }
        public static Frame Frame { get; set; }
        public MainWindow()
        {
            InitializeComponent();
            Frame = frameContent;
            PageController.ShowRegistrPage();
            rdCreateProject.Visibility = Visibility.Collapsed;

            rdCreateTask.Visibility = Visibility.Collapsed;
            rdProject.Visibility = Visibility.Collapsed;
            rdTask.Visibility = Visibility.Collapsed;
            rdAdmin.Visibility = Visibility.Collapsed;
            //if (CurrentUser.ToString() == "администратор")
            //{
            //    rdCreateProject.Visibility = Visibility.Collapsed;
            //    rdAddStatus.Visibility = Visibility.Collapsed;
            //    rdCreateTask.Visibility = Visibility.Collapsed;
            //    rdProject.Visibility = Visibility.Collapsed;
            //    rdTask.Visibility = Visibility.Collapsed;
            //    PageController.ShowAdminPage();
            //}
            //else if (CurrentUser.ToString() == "менеджер")
            //{
            //    rdAdmin.Visibility = Visibility.Collapsed;
            //}
            //else
            //{
            //    rdCreateProject.Visibility = Visibility.Collapsed;
            //    rdAddStatus.Visibility = Visibility.Collapsed;
            //    rdCreateTask.Visibility = Visibility.Collapsed;
            //    rdProject.Visibility = Visibility.Collapsed;
            //    rdAdmin.Visibility = Visibility.Collapsed;
            //}
        }
        private void btnRestore_Click(object sender, RoutedEventArgs e)
        {
            if (WindowState == WindowState.Normal)
                WindowState = WindowState.Maximized;
            else
                WindowState = WindowState.Normal;
        }

        private void btnMinimize_Click(object sender, RoutedEventArgs e)
        {
            WindowState = WindowState.Minimized;
        }

        private void Themes_Click(object sender, RoutedEventArgs e)
        {
            if (Themes.IsChecked == true)
                ThemesController.SetTheme(ThemesController.ThemeTypes.Dark);
            else
                ThemesController.SetTheme(ThemesController.ThemeTypes.Light);
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void rdCreateProject_Checked(object sender, RoutedEventArgs e)
        {
            PageController.ShowCreateProjectPage();
            //frameContent.Navigate(new statisticPage());
        }
        private void rdTask_Checked(object sender, RoutedEventArgs e)
        {
            PageController.ShowTasksPage();
        }

        private void rdProject_Checked(object sender, RoutedEventArgs e)
        {
            PageController.ShowProjectsPage();
        }

        private void Path_MouseEnter(object sender, MouseEventArgs e)
        {
            MessageBox.Show("Данная программа разработана с целью автоматизации рабочего времени");
        }

        private void rdAdmin_Checked(object sender, RoutedEventArgs e)
        {
            frameContent.Navigate(new adminPage());
        }

        private void home_Loaded(object sender, RoutedEventArgs e)
        {
            count = 0;
        }
        private void UpdateButtonVisibility()
        {
            if (CurrentUser.ToString() == "администратор")
            {
                rdCreateProject.Visibility = Visibility.Collapsed;
                
                rdCreateTask.Visibility = Visibility.Collapsed;
                rdProject.Visibility = Visibility.Collapsed;
                rdTask.Visibility = Visibility.Collapsed;
                PageController.ShowAdminPage();
            }
            else if (CurrentUser.ToString() == "менеджер")
            {
                rdAdmin.Visibility = Visibility.Collapsed;
            }
            else
            {
                rdCreateProject.Visibility = Visibility.Collapsed;
                
                rdCreateTask.Visibility = Visibility.Collapsed;
                rdProject.Visibility = Visibility.Collapsed;
                rdAdmin.Visibility = Visibility.Collapsed;
            }
        }

        private void frameContent_Navigated(object sender, NavigationEventArgs e)
        {
            
            if(count == 0)
            {
                int counttwo = 0;
                if(counttwo == 0)
                {
                    isAdminPage = e.Content is adminPage;
                    isManagerPage = e.Content is showProjectsPage;
                    isEmployeePage = e.Content is TaskPage;
                    counttwo = 1;
                }
              
                if (isAdminPage)
                {
                    rdAdmin.Visibility = Visibility.Visible;
                    rdCreateProject.Visibility = Visibility.Collapsed;
                    
                    rdCreateTask.Visibility = Visibility.Collapsed;
                    rdProject.Visibility = Visibility.Collapsed;
                    rdTask.Visibility = Visibility.Collapsed;

                }
                if (isManagerPage)
                {
                    rdAdmin.Visibility = Visibility.Collapsed;

                    rdCreateProject.Visibility = Visibility.Visible;
                    
                    rdCreateTask.Visibility = Visibility.Visible;
                    rdProject.Visibility = Visibility.Visible;
                    rdTask.Visibility = Visibility.Collapsed;
                }
                if (isEmployeePage)
                {
                    rdTask.Visibility= Visibility.Visible;
                    rdCreateProject.Visibility = Visibility.Collapsed;
                    
                    rdCreateTask.Visibility = Visibility.Collapsed;
                    rdProject.Visibility = Visibility.Collapsed;
                    rdAdmin.Visibility = Visibility.Collapsed;
                }
                count = 1;
            }
            count = 0;
           

        }

        private void rdExit_Click(object sender, RoutedEventArgs e)
        {
            PageController.ShowRegistrPage();
            rdCreateProject.Visibility = Visibility.Collapsed;
            
            rdCreateTask.Visibility = Visibility.Collapsed;
            rdProject.Visibility = Visibility.Collapsed;
            rdTask.Visibility = Visibility.Collapsed;
            rdAdmin.Visibility = Visibility.Collapsed;

            count = 0;

            //if (CurrentUser.ToString() == "администратор")
            //{
            //    rdCreateProject.Visibility = Visibility.Collapsed;
            //    rdAddStatus.Visibility = Visibility.Collapsed;
            //    rdCreateTask.Visibility = Visibility.Collapsed;
            //    rdProject.Visibility = Visibility.Collapsed;
            //    rdTask.Visibility = Visibility.Collapsed;
            //    PageController.ShowAdminPage();
            //}
            //else if (CurrentUser.ToString() == "менеджер")
            //{
            //    rdAdmin.Visibility = Visibility.Collapsed;
            //}
            //else
            //{
            //    rdCreateProject.Visibility = Visibility.Collapsed;
            //    rdAddStatus.Visibility = Visibility.Collapsed;
            //    rdCreateTask.Visibility = Visibility.Collapsed;
            //    rdProject.Visibility = Visibility.Collapsed;
            //    rdAdmin.Visibility = Visibility.Collapsed;
            //}
        }

        private void rdCreateTask_Checked(object sender, RoutedEventArgs e)
        {
            PageController.ShowCreateTaskPage();
        }
    }
}
