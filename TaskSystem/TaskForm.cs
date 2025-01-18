using System.Data.SqlClient;
using TaskSystem.Models;
namespace TaskSystem
{
    public partial class TaskForm : Form
    {
        public TaskForm()
        {
            InitializeComponent();
        }
        public TaskModel? Task { get; set; }
        private void button1_Click_1(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(GlobalService.DbConnectionString);
            con.Open();
            if (Task == null)
            {
                string insertQuery = "INSERT INTO Tasks(Title,Description,Deadline,Priority,CreatedBy) VALUES (@Title, @Description, @Deadline, @Priority, @CreatedBy)";
                SqlCommand cmd = new SqlCommand(insertQuery, con);
                cmd.Parameters.AddWithValue("@Title", txtTitle.Text);
                cmd.Parameters.AddWithValue("@Description", txtDescription.Text);
                cmd.Parameters.AddWithValue("@Deadline", dtpDeadline.Value);
                cmd.Parameters.AddWithValue("@Priority", cmbPriority.SelectedIndex);
                cmd.Parameters.AddWithValue("@CreatedBy", GlobalService.LoggedInProfile?.UserName);
                cmd.ExecuteNonQuery();
            }
            else
            {
                string updateQuery = "UPDATE Tasks SET Title=@Title,Description=@Description,Deadline=@Deadline,Priority=@Priority,IsDone=@IsDone WHERE Id=@Id";
                SqlCommand cmd = new SqlCommand(updateQuery, con);
                cmd.Parameters.AddWithValue("@Title", txtTitle.Text);
                cmd.Parameters.AddWithValue("@Description", txtDescription.Text);
                cmd.Parameters.AddWithValue("@Deadline", dtpDeadline.Value);
                cmd.Parameters.AddWithValue("@Priority", cmbPriority.SelectedIndex);
                cmd.Parameters.AddWithValue("@IsDone", cbIsDone.Checked);
                cmd.Parameters.AddWithValue("@Id", Task.Id);
                cmd.ExecuteNonQuery();
            }
            con.Close();
            Close();
        }

        private void TaskForm_Shown(object sender, EventArgs e)
        {
            if (Task != null)
            {
                txtTitle.Text = Task.Title;
                txtDescription.Text = Task.Description;
                dtpDeadline.Value = Task.Deadline;
                cmbPriority.SelectedIndex = (int)Task.Priority;
                cbIsDone.Checked = Task.IsDone;
                cbIsDone.Visible = true;
            }
            else cbIsDone.Visible = false;
        }
    }
}
