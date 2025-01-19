using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
