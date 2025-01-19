using Microsoft.Data.SqlClient;
using TaskSystem.Models;

namespace TaskSystem
{
    public partial class TaskViewForm : Form
    {
        private readonly CreateProfileDialog createProfileDialog = new();

        public TaskViewForm()
        {
            InitializeComponent();
            taskList.Rebind(TasksService.Tasks);
        }

        private void taskList_DeleteItem(object sender, TaskSystem.TaskListBox.ChangeItemEventArgs e)
        {
            if (MessageBox.Show("Deleted tasks cannot be recovered! Are you sure you want to delete this task?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                SqlConnection conn = new(GlobalService.DbConnectionString);
                conn.Open();
                SqlCommand comm = conn.CreateCommand();
                comm.CommandText = "DELETE FROM Tasks WHERE Id=@Id";
                comm.Parameters.AddWithValue("@Id", e.Item.Id);
                comm.ExecuteNonQuery();
                conn.Close();
                taskList.Rebind(TasksService.Tasks);
            }
        }

        private void taskList_EditItem(object sender, TaskSystem.TaskListBox.ChangeItemEventArgs e)
        {
            TaskForm taskForm = new()
            {
                Task = e.Item
            };
            if (taskForm.ShowDialog(this) == DialogResult.OK)
                taskList.Rebind(TasksService.Tasks);
        }

        private void logInButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (usernameTextBox.Text.Length == 0 || passwordTextBox.Text.Length == 0)
                    throw new InvalidDataException("Enter both username and password!");
                ProfileModel profile = new()
                {
                    UserName = usernameTextBox.Text,
                    Password = ProfilesService.HashPassword(passwordTextBox.Text)
                };
                if (ProfilesService.CheckProfilePassword(profile))
                    LogIn(ProfilesService.GetProfile(profile.UserName));
                else throw new InvalidDataException("The username and the password do not match!");
            }
            catch (InvalidDataException ex)
            {
                MessageBox.Show(ex.Message, "Invalid log in attempt", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LogIn(ProfileModel profile)
        {
            userLabel.Text = profile.UserName;
            loggedInPanel.Visible = true;
            nonLoggedPanel.Visible = false;
            passwordTextBox.Text = string.Empty;
            createButton.Visible = true;
            scheduleButton.Visible = true;
            taskList.SetLoggedInProfile(ProfilesService.GetProfile(profile.UserName));
        }

        private void logOutButton_Click(object sender, EventArgs e)
        {
            nonLoggedPanel.Visible = true;
            loggedInPanel.Visible = false;
            createButton.Visible = false;
            scheduleButton.Visible = false;
            taskList.SetLoggedInProfile(null);
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            if (createProfileDialog.ShowDialog(this) == DialogResult.OK && createProfileDialog.Profile != null)
                ProfilesService.CreateProfile(createProfileDialog.Profile);
        }

        private void createButton_Click(object sender, EventArgs e)
        {
            TaskForm taskForm = new();
            if (taskForm.ShowDialog(this) == DialogResult.OK)
                taskList.Rebind(TasksService.Tasks);
        }

        private void startDateCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            startDatePicker.Enabled = startDateCheckBox.Checked;
        }

        private void endDateCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            endDatePicker.Enabled = endDateCheckbox.Checked;
        }

        private void filterButton_Click(object sender, EventArgs e)
        {
            if (filterButton.Font.Bold)
            {
                splitContainer1.Panel1Collapsed = true;
                filterButton.Font = new Font(filterButton.Font, FontStyle.Regular);
            }
            else
            {
                splitContainer1.Panel1Collapsed = false;
                filterButton.Font = new Font(filterButton.Font, FontStyle.Bold);
            }
        }

        private void orderByPriorirtyButton_Click(object sender, EventArgs e)
        {
            if (orderByPriorirtyButton.Font.Bold)
            {
                TasksService.OrderByPriority = false;
                orderByPriorirtyButton.Font = new Font(orderByPriorirtyButton.Font, FontStyle.Regular);
            }
            else
            {
                TasksService.OrderByPriority = true;
                orderByPriorirtyButton.Font = new Font(orderByPriorirtyButton.Font, FontStyle.Bold);
            }
            taskList.Rebind(TasksService.Tasks);
        }

        private void goFilterButton_Click(object sender, EventArgs e)
        {
            if (startDateCheckBox.Checked)
                TasksService.StartAfter = startDatePicker.Value;
            else TasksService.StartAfter = null;
            if (endDateCheckbox.Checked)
                TasksService.EndBefore = endDatePicker.Value;
            else TasksService.EndBefore = null;
            taskList.Rebind(TasksService.Tasks);
        }

        private void clearFilterButton_Click(object sender, EventArgs e)
        {
            startDateCheckBox.Checked = false;
            endDateCheckbox.Checked = false;
            startDatePicker.Value = endDatePicker.Value = DateTime.Now;
            TasksService.StartAfter = null;
            TasksService.EndBefore = null;
            taskList.Rebind(TasksService.Tasks);
        }

        private void scheduleButton_Click(object sender, EventArgs e)
        {
            new ScheduleForm().ShowDialog(this);
        }

        private void taskListBox1_SwitchStatus(object sender, TaskSystem.TaskListBox.ChangeItemEventArgs e)
        {
            SqlConnection conn = new(GlobalService.DbConnectionString);
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "UPDATE Tasks SET IsDone=@IsDone WHERE Id=@Id";
            cmd.Parameters.AddWithValue("@IsDone", !e.Item.IsDone);
            cmd.Parameters.AddWithValue("@Id", e.Item.Id);
            cmd.ExecuteNonQuery();
            conn.Close();
            taskList.Rebind(TasksService.Tasks);
        }

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;
                return cp;
            }
        }
    }
}
