namespace TaskSystem
{
    partial class ScheduleForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            taskListBox1 = new TaskListBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            closeButton = new Button();
            panel1 = new Panel();
            checkBox1 = new CheckBox();
            dateTimePicker1 = new DateTimePicker();
            label2 = new Label();
            statusLabel = new Label();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(884, 51);
            label1.TabIndex = 0;
            label1.Text = "Schedule";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // taskListBox1
            // 
            taskListBox1.AutoScroll = true;
            taskListBox1.BorderStyle = BorderStyle.Fixed3D;
            taskListBox1.Dock = DockStyle.Fill;
            taskListBox1.Location = new Point(0, 121);
            taskListBox1.Name = "taskListBox1";
            taskListBox1.Size = new Size(884, 373);
            taskListBox1.TabIndex = 2;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(closeButton, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Bottom;
            tableLayoutPanel1.Location = new Point(0, 494);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.Size = new Size(884, 36);
            tableLayoutPanel1.TabIndex = 3;
            // 
            // closeButton
            // 
            closeButton.Location = new Point(395, 3);
            closeButton.Name = "closeButton";
            closeButton.Size = new Size(94, 29);
            closeButton.TabIndex = 0;
            closeButton.Text = "Close";
            closeButton.UseVisualStyleBackColor = true;
            closeButton.Click += closeButton_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(checkBox1);
            panel1.Controls.Add(dateTimePicker1);
            panel1.Controls.Add(label2);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 51);
            panel1.Name = "panel1";
            panel1.Size = new Size(884, 29);
            panel1.TabIndex = 4;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Dock = DockStyle.Right;
            checkBox1.Location = new Point(641, 0);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(243, 29);
            checkBox1.TabIndex = 2;
            checkBox1.Text = "Show only logged in user's tasks";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Dock = DockStyle.Left;
            dateTimePicker1.Location = new Point(44, 0);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(250, 27);
            dateTimePicker1.TabIndex = 1;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // label2
            // 
            label2.Dock = DockStyle.Left;
            label2.Location = new Point(0, 0);
            label2.Name = "label2";
            label2.Size = new Size(44, 29);
            label2.TabIndex = 0;
            label2.Text = "Date:";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // statusLabel
            // 
            statusLabel.Dock = DockStyle.Top;
            statusLabel.Location = new Point(0, 80);
            statusLabel.Name = "statusLabel";
            statusLabel.Size = new Size(884, 41);
            statusLabel.TabIndex = 5;
            statusLabel.Text = "Status label";
            statusLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ScheduleForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(884, 530);
            Controls.Add(taskListBox1);
            Controls.Add(statusLabel);
            Controls.Add(panel1);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(label1);
            Name = "ScheduleForm";
            Text = "Schedule";
            Load += ScheduleForm_Load;
            tableLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private TaskListBox taskListBox1;
        private TableLayoutPanel tableLayoutPanel1;
        private Button closeButton;
        private Panel panel1;
        private CheckBox checkBox1;
        private DateTimePicker dateTimePicker1;
        private Label label2;
        private Label statusLabel;
    }
}