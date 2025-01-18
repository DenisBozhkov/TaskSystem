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
            tableLayoutPanel1.SuspendLayout();
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
            label1.Text = "Today's schedule";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // taskListBox1
            // 
            taskListBox1.AutoScroll = true;
            taskListBox1.BorderStyle = BorderStyle.Fixed3D;
            taskListBox1.Dock = DockStyle.Fill;
            taskListBox1.Location = new Point(0, 51);
            taskListBox1.Name = "taskListBox1";
            taskListBox1.Size = new Size(884, 443);
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
            // ScheduleForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(884, 530);
            Controls.Add(taskListBox1);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(label1);
            Name = "ScheduleForm";
            Text = "Schedule";
            Load += ScheduleForm_Load;
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private TaskListBox taskListBox1;
        private TableLayoutPanel tableLayoutPanel1;
        private Button closeButton;
    }
}