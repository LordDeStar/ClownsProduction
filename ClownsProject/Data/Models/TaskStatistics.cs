using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClownsProject.Data.Models
{
    public class TaskStatistics
    {
        public DateTime Date { get; set; }
        public int Completed { get; set; }
        public int NotCompleted { get; set; }
    }
}
