using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace TaskSystem
{
    public partial class ScheduleForm : Form
    {
        public ScheduleForm()
        {
            InitializeComponent();
        }

        private bool ofLoggedInUser = false;

        void UpdateStatusLabel(int tasksCount, int undoneTasksCount)
        {
            statusLabel.Text = $"Tasks: {tasksCount}; Undone tasks: {undoneTasksCount}";
        }

        void Rebind()
        {
            var tasks = TasksService.GetTasks(dateTimePicker1.Value.Date, ofLoggedInUser);
            UpdateStatusLabel(tasks.Count, tasks.Count(x => !x.IsDone));
            taskListBox1.Rebind(tasks);
            foreach (Control control in taskListBox1.Controls)
                if (control is TaskVisualBox box && box.Tag is TaskDescriptionBox descriptionBox1)
                    box.CanEdit = descriptionBox1.TaskAuthor?.CompareTo(GlobalService.LoggedInProfile?.UserName) == 0;
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ScheduleForm_Load(object sender, EventArgs e)
        {
            Rebind();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            Rebind();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            ofLoggedInUser = checkBox1.Checked;
            Rebind();
        }

        private void taskListBox1_SwitchStatus(object sender, TaskSystem.TaskListBox.ChangeItemEventArgs e)
        {
            TasksService.UpdateStatus(e.Item.Id, !e.Item.IsDone);
            Rebind();
        }

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;  // Turn on WS_EX_COMPOSITED
                return cp;
            }
        }
    }
}
