using TaskSystem.Models;

namespace TaskSystem
{
    public partial class TaskVisualBox : UserControl
    {
        public TaskVisualBox()
        {
            InitializeComponent();
        }

        public TaskVisualBox(TaskModel task)
            : this()
        { FillData(task); }

        public void FillData(TaskModel task)
        {
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
            deadlineLabel.Text = task.Deadline.ToString("f");
            titleLabel.Text = task.Title;
            if (task.IsDone)
            {
                statusLabel.Text = "Done";
                statusLabel.BackColor = Color.Green;
            }
            else if (task.Deadline >= DateTime.Now)
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
    }
}
