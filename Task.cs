using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_Management_Tool_2
{
    public class Task
    {
        /*
         * The below class simply contains the private 
         * properties of a task as well as a constructor
         * and get and set methods.
         */
        private string TaskTitle;
        private DateTime DueDate;
        private string TaskStatus;

        public Task(string taskTitle, DateTime dueDate, string taskStatus)
        {
            TaskTitle = taskTitle;
            DueDate = dueDate;
            TaskStatus = taskStatus;
        }

        public string TaskTitle1 { get => TaskTitle; set => TaskTitle = value; }
        public DateTime DueDate1 { get => DueDate; set => DueDate = value; }
        public string TaskStatus1 { get => TaskStatus; set => TaskStatus = value; }
    }
}
