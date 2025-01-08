using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TaskSystem.Models;

namespace TaskSystem
{
    public partial class TaskDescriptionBox : UserControl
    {
        private TaskModel? task;

        public TaskDescriptionBox()
        {
            InitializeComponent();
            descriptionLabel.MaximumSize = new(Width, 0);
        }

        public TaskDescriptionBox(TaskModel task)
            : this() => FillData(task);

        public void FillData(TaskModel task)
        {
            this.task = task;
            createdByLabel.Text = task.CreatedBy;
            descriptionLabel.Text = task.Description;
        }

        public event EventHandler<ManItemEventArgs>? EditItem;
        public event EventHandler<ManItemEventArgs>? DeleteItem;

        public class ManItemEventArgs(TaskModel task)
        {
            public TaskModel Task { get; set; } = task;
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            if (task != null)
                EditItem?.Invoke(this, new(task));
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (task != null)
                DeleteItem?.Invoke(this, new(task));
        }

        private void TaskDescriptionBox_Resize(object sender, EventArgs e)
        {
            descriptionLabel.MaximumSize = new(Width, 0);
        }
    }
}
