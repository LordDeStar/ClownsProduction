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

namespace ClownsProject.Views
{
    /// <summary>
    /// Логика взаимодействия для editTaskPage.xaml
    /// </summary>
    public partial class editTaskPage : Page
    {
        private int id;
        public editTaskPage(int taskID, bool isEmploy = true)
        {
            InitializeComponent();
            id = taskID;
            foreach (var status in Services.TaskService.GetStatuses())
            {
                statusCB.Items.Add(status.Title.ToString());
            }
            foreach (var executor in Services.UserService.GetUsers().Where(v => v.IdRole == 2))
            {
                executorCB.Items.Add(executor.Login.ToString());
            }
            if (isEmploy)
            {
                statusCB.Visibility = Visibility.Visible;
                executorCB.Visibility = Visibility.Collapsed;
                editTB.Text = "Статус";
            }
            else
            {
                editTB.Text = "Исполнитель";
                executorCB.Visibility = Visibility.Visible;
                statusCB.Visibility = Visibility.Collapsed;
            }
            
        }

        private void saveChangesBut_Click(object sender, RoutedEventArgs e)
        {
            TaskController.ChangeDescription(id, descriptionTB.Text);
            TaskController.ChangeStatus(statusCB.Text,id);

            MessageBox.Show("Изменения сохранены");
            PageController.ShowTasksPage();
        }

        private void backBut_Click(object sender, RoutedEventArgs e)
        {
            PageController.ShowTasksPage();
        }
    }
}
