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
    /// Логика взаимодействия для TaskControll.xaml
    /// </summary>
    public partial class TaskControll : UserControl
    {
        public TaskControll(ClownsProject.Models.Task task)
        {
            InitializeComponent();
            DataContext = task;

        }

        private void UserControl_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            PageController.ShowTaskPage((ClownsProject.Models.Task)DataContext);
        }
    }
}
