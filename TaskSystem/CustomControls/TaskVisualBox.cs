using Microsoft.Data.SqlClient;
using System.Globalization;
using TaskSystem.Models;

namespace TaskSystem
{
    public partial class TaskVisualBox : UserControl
    {
        private readonly ToolTip toolTip = new();

        private TaskModel task;

        public TaskVisualBox()
        {
            InitializeComponent();
            toolTip.SetToolTip(descriptionButton, "Details");
        }

        public TaskVisualBox(TaskModel task)
            : this()
        { FillData(task); }

        public TaskVisualBox(bool titleMode)
            : this()
        {
            if (titleMode)
            {
                Font font = new(Font, FontStyle.Bold);
                descriptionButton.Enabled = false;
                descriptionButton.Text = string.Empty;
                importancyLabel.Font = font;
                importancyLabel.TextAlign = ContentAlignment.MiddleCenter;
                importancyLabel.ForeColor = Color.White;
                deadlineLabel.Font = font;
                deadlineLabel.TextAlign = ContentAlignment.MiddleCenter;
                deadlineLabel.ForeColor = Color.White;
                titleLabel.Font = font;
                titleLabel.TextAlign = ContentAlignment.MiddleCenter;
                titleLabel.ForeColor = Color.White;
                statusLabel.Font = font;
                statusLabel.TextAlign = ContentAlignment.MiddleCenter;
                statusLabel.ForeColor = Color.White;
                tableLayoutPanel1.BackColor = SystemColors.WindowFrame;
            }
        }

        private bool canEdit;

        public bool CanEdit
        {
            get => canEdit;
            set
            {
                if (canEdit == value)
                    return;
                canEdit = value;
                if (canEdit)
                {
                    statusLabel.Cursor = Cursors.Hand;
                    toolTip.SetToolTip(statusLabel, "Change status");
                    statusLabel.Click += StatusLabel_Click;
                    statusLabel.MouseEnter += StatusLabel_MouseEnter;
                    statusLabel.MouseLeave += StatusLabel_MouseLeave;
                }
                else
                {
                    statusLabel.Cursor = Cursors.Default;
                    toolTip.SetToolTip(statusLabel, null);
                    statusLabel.MouseLeave -= StatusLabel_MouseLeave;
                    statusLabel.MouseEnter -= StatusLabel_MouseEnter;
                    statusLabel.Click -= StatusLabel_Click;
                }
            }
        }

        private void StatusLabel_MouseLeave(object? sender, EventArgs e)
        {
            statusLabel.Font = new(statusLabel.Font, FontStyle.Regular);
        }

        private void StatusLabel_MouseEnter(object? sender, EventArgs e)
        {
            statusLabel.Font = new(statusLabel.Font, FontStyle.Bold);
        }

        private void StatusLabel_Click(object? sender, EventArgs e)
        {
            StatusClicked?.Invoke(this, new(task));
        }

        public void FillData(TaskModel task)
        {
            this.task = task;
            switch (task.Priority)
            {
                case Priority.NotImportant:
                    importancyLabel.Text = "Not Important";
                    break;
                case Priority.LessImportant:
                    importancyLabel.Text = "Less Important";
                    importancyLabel.Font = new(importancyLabel.Font, FontStyle.Underline);
                    break;
                case Priority.Important:
                    importancyLabel.Text = "Important";
                    importancyLabel.Font = new(importancyLabel.Font, FontStyle.Italic);
                    break;
                case Priority.VeryImportant:
                    importancyLabel.Text = "Very Important!";
                    importancyLabel.Font = new(importancyLabel.Font, FontStyle.Bold);
                    break;
                case Priority.Urgent:
                    importancyLabel.Text = "Urgent!";
                    importancyLabel.Font = new(importancyLabel.Font, FontStyle.Bold);
                    importancyLabel.ForeColor = Color.Red;
                    break;
            }
            deadlineLabel.Text = task.Deadline.ToString("d MMMM, yyyy", new CultureInfo("en-us"));
            titleLabel.Text = task.Title;
            if (task.IsDone)
            {
                statusLabel.Text = "Done";
                statusLabel.BackColor = Color.Green;
            }
            else if (task.Deadline >= DateTime.Now.Date)
            {
                statusLabel.Text = "Waiting";
                statusLabel.BackColor = Color.Blue;
            }
            else
            {
                statusLabel.Text = "Missed";
                statusLabel.BackColor = Color.Red;
            }
        }

        public event EventHandler<StatusClickedEventArgs>? StatusClicked;

        public event EventHandler? ExpandDescription;
        public event EventHandler? CollapseDescription;

        private void descriptionButton_Click(object sender, EventArgs e)
        {
            if (descriptionButton.Text == "+")
            {
                descriptionButton.Text = "-";
                ExpandDescription?.Invoke(this, new EventArgs());
            }
            else
            {
                descriptionButton.Text = "+";
                CollapseDescription?.Invoke(this, new EventArgs());
            }
        }

        public class StatusClickedEventArgs(TaskModel task)
        {
            public TaskModel Task { get; set; } = task;
        }
    }
}
