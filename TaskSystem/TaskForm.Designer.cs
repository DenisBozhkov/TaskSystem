namespace TaskSystem
{
    partial class TaskForm
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
            dtpDeadline = new DateTimePicker();
            cmbPriority = new ComboBox();
            txtTitle = new TextBox();
            txtDescription = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            button1 = new Button();
            cbIsDone = new CheckBox();
            SuspendLayout();
            // 
            // dtpDeadline
            // 
            dtpDeadline.Location = new Point(139, 107);
            dtpDeadline.Margin = new Padding(3, 4, 3, 4);
            dtpDeadline.Name = "dtpDeadline";
            dtpDeadline.Size = new Size(220, 27);
            dtpDeadline.TabIndex = 2;
            // 
            // cmbPriority
            // 
            cmbPriority.FormattingEnabled = true;
            cmbPriority.Items.AddRange(new object[] { "Not important", "Less important", "Important", "Very important", "Urgent" });
            cmbPriority.Location = new Point(139, 52);
            cmbPriority.Margin = new Padding(3, 4, 3, 4);
            cmbPriority.Name = "cmbPriority";
            cmbPriority.Size = new Size(138, 28);
            cmbPriority.TabIndex = 1;
            // 
            // txtTitle
            // 
            txtTitle.Location = new Point(142, 165);
            txtTitle.Margin = new Padding(3, 4, 3, 4);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(220, 27);
            txtTitle.TabIndex = 3;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(38, 265);
            txtDescription.Margin = new Padding(3, 4, 3, 4);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(324, 78);
            txtDescription.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(35, 55);
            label1.Name = "label1";
            label1.Size = new Size(88, 20);
            label1.TabIndex = 5;
            label1.Text = "Task priority";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(35, 107);
            label2.Name = "label2";
            label2.Size = new Size(98, 20);
            label2.TabIndex = 6;
            label2.Text = "Task deadline";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(38, 165);
            label3.Name = "label3";
            label3.Size = new Size(66, 20);
            label3.TabIndex = 7;
            label3.Text = "Task title";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(38, 221);
            label4.Name = "label4";
            label4.Size = new Size(114, 20);
            label4.TabIndex = 8;
            label4.Text = "Task description";
            // 
            // button1
            // 
            button1.DialogResult = DialogResult.OK;
            button1.Location = new Point(142, 382);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.RightToLeft = RightToLeft.Yes;
            button1.Size = new Size(86, 31);
            button1.TabIndex = 5;
            button1.Text = "Confirm";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // cbIsDone
            // 
            cbIsDone.AutoSize = true;
            cbIsDone.Location = new Point(38, 12);
            cbIsDone.Name = "cbIsDone";
            cbIsDone.Size = new Size(67, 24);
            cbIsDone.TabIndex = 0;
            cbIsDone.Text = "Done";
            cbIsDone.UseVisualStyleBackColor = true;
            // 
            // TaskForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(400, 428);
            Controls.Add(cbIsDone);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtDescription);
            Controls.Add(txtTitle);
            Controls.Add(cmbPriority);
            Controls.Add(dtpDeadline);
            Margin = new Padding(3, 4, 3, 4);
            Name = "TaskForm";
            Text = "Task editor";
            Shown += TaskForm_Shown;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dtpDeadline;
        private ComboBox cmbPriority;
        private TextBox txtTitle;
        private TextBox txtDescription;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button button1;
        private CheckBox cbIsDone;
    }
}