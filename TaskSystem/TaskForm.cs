using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Net.Http.Headers;
using Microsoft.VisualBasic;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;
namespace TaskSystem
{
    public partial class TaskForm : Form
    {
        public TaskForm()
        {
            InitializeComponent();
        }
   
        private void button1_Click_1(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-2U4DRLK;Initial Catalog=Tasks;Integrated Security=True;Encrypt=True;TrustServerCertificate=True");
            con.Open();
            string insertQuery = "INSERT INTO Tasks VALUES (@Title, @Description, @Deadline, @Priority, @CreatedBy)";
            SqlCommand cmd = new SqlCommand(insertQuery, con);
            cmd.Parameters.AddWithValue("@Title", txtTitle.Text);
            cmd.Parameters.AddWithValue("@Description", txtDescription.Text);
            cmd.Parameters.AddWithValue("@Deadline", dtpDeadline.Value);
            cmd.Parameters.AddWithValue("@Priority", cmbPriority.SelectedItem.ToString());
            cmd.Parameters.AddWithValue("@CreatedBy", txtCreator.Text);
            cmd.ExecuteNonQuery();
            Close();
        }
    }
}
