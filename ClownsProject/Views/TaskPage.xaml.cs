using DevExpress.Mvvm;
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
using ClownsProject.Services;
using ClownsProject.Controllers;

namespace Viewsss
{
    /// <summary>
    /// Логика взаимодействия для TaskPage.xaml
    /// </summary>
    public partial class TaskPage : Page
    {
        public static ListView InProgress;
        public static ListView InTesting;
        public static ListView Allready;
        public TaskPage()
        {
            InitializeComponent();
            //foreach (var task in TaskService.GetTasks())
            //{
            //    listView1.Items.Add(task);
            //}
            //foreach (var task in TaskService.GetTasks())
            //{
            //    listView2.Items.Add(task);
            //}
            //foreach (var task in TaskService.GetTasks())
            //{
            //    listView3.Items.Add(task);
            //}
            InProgress = listView1;
            InTesting = listView2;
            Allready = listView3;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var s = sender as Button;
            PageController.ShowEditTaskPage((int)s.Tag);
        }
    }
}
