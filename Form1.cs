using System;
using System.Linq;
using System.Reflection;
using System.Security.Policy;

namespace Task_Management_Tool_2
{
    public partial class Form1 : Form
    {
        public static List<Task> tasks = new List<Task>();
        //A public list to hold all tasks whether default
        //or tasks inputted by the user. 
        public Form1()
        {
            InitializeComponent();
            //Calls the populateList() method.
            populateList();
            dtgTaskData.DataSource = tasks;
        }

        public static void populateList()
        {
            /*
             * The below code populates the list named tasks 
             * with default data.
             */
            string taskTitle1 = "Learn HTML";
            DateTime dueDate1 = Convert.ToDateTime("2023-08-11 00:00:00");
            string status1 = "Pending";
            Task task1 = new Task(taskTitle1, dueDate1, status1);
            tasks.Add(task1);

            string taskTitle2 = "Do PROG ICE 1";
            DateTime dueDate2 = Convert.ToDateTime("2023-08-14 00:00:00");
            string status2 = "Pending";
            Task task2 = new Task(taskTitle2, dueDate2, status2);
            tasks.Add(task2);

            string taskTitle3 = "Start SAND6222 POE";
            DateTime dueDate3 = Convert.ToDateTime("2023-08-13 00:00:00");
            string status3 = "Pending";
            Task task3 = new Task(taskTitle3, dueDate3, status3);
            tasks.Add(task3);

            string taskTitle4 = "Learn LINQ";
            DateTime dueDate4 = Convert.ToDateTime("2023-08-10 00:00:00");
            string status4 = "Pending";
            Task task4 = new Task(taskTitle4, dueDate4, status4);
            tasks.Add(task4);

            string taskTitle5 = "Watch Kill Bill Vol 1";
            DateTime dueDate5 = Convert.ToDateTime("2023-08-10 00:00:00");
            string status5 = "Done";
            Task task5 = new Task(taskTitle5, dueDate5, status5);
            tasks.Add(task5);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*
             * The below usage of LINQ(query syntax) selects all
             * tasks that are pending.
             */
            var myQuery = from t in tasks
                          where t.TaskStatus1.Equals("Pending")
                          orderby t.DueDate1
                          select t;

            //Displays the result of the above query
            //in a datagridview by calling the .ToList()
            //method.
            dtgTaskData.DataSource = myQuery.ToList();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int counter = 0;
            int selectedIndex = dtgTaskData.Rows.GetRowCount(DataGridViewElementStates.Selected);
            //Gets the index of the row that the user selected.
            foreach (Task task1 in tasks)
            {
                var task = dtgTaskData.DataSource as Task[];
                if (!task1.TaskStatus1.Equals("Done") && counter == selectedIndex)
                {
                    task1.TaskStatus1 = "Done";
                    break;
                }
                else
                {
                    counter++;
                }
            }
            /*
             * The above loop iterates through the tasks list until it finds the
             * task whose index in the list matches the value stored in selectedIndex
             * and changes its status to done. Once the task has been found the loop
             * is broken.
             */
            dtgTaskData.Refresh();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //Accepts all data needed to satisfy the Task classes constructor
            string title = txtTitle.Text;
            DateTime dueDate = Convert.ToDateTime(dtpDueDate.Text);
            string status = cmbStatus.SelectedItem.ToString();

            /*
             * The below usage of LINQ(method syntax) creates a new instance of
             * the Task class and stores it in the below query.
            */
            var query = tasks.Select(a => new Task(title, dueDate.Date, status));

            /*Adds the instance of task to the tasks list.
             *Because AddRange had to be used the number
             *of elements added has to be reduced using skip
             *as AddRange would add multiple instances of the 
             *new task
             */
            tasks.AddRange(query.ToList().Skip(tasks.Count - 1));
            dtgTaskData.DataSource = tasks;
            /*
             * note: after clicking add select the button that filters
             * by the status you gave the task, only then will the task
             * show up.
             */
            dtgTaskData.Refresh();

            txtTitle.Clear();
            cmbStatus.SelectedIndex = -1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            /*
            * The below usage of LINQ(query syntax) selects all
            * tasks that are done.
            */
            var myQuery = from t in tasks
                          where t.TaskStatus1.Equals("Done")
                          orderby t.DueDate1
                          select t;

            //Displays the result of the above query
            //in a datagridview by calling the .ToList()
            //method.
            dtgTaskData.DataSource = myQuery.ToList();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            dtgTaskData.DataSource = tasks;
            //Resets the datagridviews data source to
            //display all tasks.
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //A keyword used to filter the stored data.
            string filter = txtKeyword.Text;

            /*
             * The below usage of LINQ(query syntax) selects all
             * tasks that contain the filter data in their title.
            */
            var myQuery = from t in tasks
                          where t.TaskTitle1.Contains(filter)
                          select t;

            //Displays the result of the above query
            //in a datagridview by calling the .ToList()
            //method.
            dtgTaskData.DataSource = myQuery.ToList();

            //Clears txtKeyWord
            txtKeyword.Clear();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            DateTime date1 = Convert.ToDateTime(dtpStartDate.Text);
            DateTime date2 = Convert.ToDateTime(dtpEndDate.Text);

            /*
             * The below usage of LINQ(query syntax) selects all
             * tasks within a specified date range.
             */
            var myQuery = from t in tasks
                          where t.DueDate1.Date >= date1.Date &&
                          t.DueDate1.Date <= date2.Date
                          select t;

            //Displays the result of the above query
            //in a datagridview by calling the .ToList()
            //method.
            dtgTaskData.DataSource = myQuery.ToList();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            /*
             * The below usage of LINQ(method syntax) selects all
             * tasks but does not show all columns. This query 
             * results in only the tasks title and status being
             * shown
            */
            var myQuery = tasks.Select(t => new { t.TaskTitle1, t.TaskStatus1 });

            //Displays the result of the above query
            //in a datagridview by calling the .ToList()
            //method.
            dtgTaskData.DataSource = myQuery.ToList();

            //Refreshed the datagridview.
            dtgTaskData.Refresh();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            /*
             * The below usage of LINQ(query syntax) selects all
             * tasks within a specified date range.
            */
            var myQuery = from t in tasks
                          where t.TaskStatus1.Equals("Done")
                          select t;

            //Displays the number of completed tasks in a message box
            MessageBox.Show(Convert.ToString("Completed tasks: " + myQuery.Count()), "Task management tool", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            /*
            * The below usage of LINQ(query syntax) selects all
            * tasks within a specified date range.
            */
            var myQuery = from t in tasks
                          where t.TaskStatus1.Equals("Pending")
                          select t;

            //Displays the number of pending tasks in a message box
            MessageBox.Show("You have " + Convert.ToString(myQuery.Count()) + " pending tasks", "Task management tool", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            /*
             * The below usage of LINQ(query syntax) selects all
             * tasks but groups them based on their status(pending/done).
            */
            var grouping = tasks.GroupBy(t => t.TaskStatus1);

            //A list to store all grouped data.
            List<Task> groupedData = new List<Task>();
            foreach (var item in grouping)
            {
                foreach (var task in item)
                {
                    groupedData.Add(task);
                }
            }
            //Displays the result of the above query
            //in a datagridview by assigning its data source
            //to the groupedData list.
            dtgTaskData.DataSource = groupedData;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            /*
             * The below usage of LINQ(query syntax) selects all
             * tasks and orders them by date in descending order.
            */
            var myQuery = from t in tasks
                          orderby t.DueDate1 descending
                          select t;

            //Displays the result of the above query
            //in a datagridview by calling the .ToList()
            //method.
            dtgTaskData.DataSource = myQuery.ToList();
        }
    }
}