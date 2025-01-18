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
            txtCreator = new TextBox();
            txtDescription = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // dtpDeadline
            // 
            dtpDeadline.Location = new Point(31, 142);
            dtpDeadline.Name = "dtpDeadline";
            dtpDeadline.Size = new Size(200, 23);
            dtpDeadline.TabIndex = 0;
            // 
            // cmbPriority
            // 
            cmbPriority.FormattingEnabled = true;
            cmbPriority.Items.AddRange(new object[] { "not important", "less important", "important", "very important", "urgent" });
            cmbPriority.Location = new Point(31, 68);
            cmbPriority.Name = "cmbPriority";
            cmbPriority.Size = new Size(121, 23);
            cmbPriority.TabIndex = 1;
            // 
            // txtTitle
            // 
            txtTitle.Location = new Point(31, 212);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(100, 23);
            txtTitle.TabIndex = 2;
            // 
            // txtCreator
            // 
            txtCreator.Location = new Point(215, 351);
            txtCreator.Name = "txtCreator";
            txtCreator.Size = new Size(100, 23);
            txtCreator.TabIndex = 3;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(31, 288);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(284, 23);
            txtDescription.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(31, 41);
            label1.Name = "label1";
            label1.Size = new Size(70, 15);
            label1.TabIndex = 5;
            label1.Text = "Task priority";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(31, 113);
            label2.Name = "label2";
            label2.Size = new Size(77, 15);
            label2.TabIndex = 6;
            label2.Text = "Task deadline";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(31, 184);
            label3.Name = "label3";
            label3.Size = new Size(52, 15);
            label3.TabIndex = 7;
            label3.Text = "Task title";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(31, 258);
            label4.Name = "label4";
            label4.Size = new Size(91, 15);
            label4.TabIndex = 8;
            label4.Text = "Task description";
            // 
            // button1
            // 
            button1.Location = new Point(33, 350);
            button1.Name = "button1";
            button1.RightToLeft = RightToLeft.Yes;
            button1.Size = new Size(75, 23);
            button1.TabIndex = 9;
            button1.Text = "Create task";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // TaskForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(350, 386);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtDescription);
            Controls.Add(txtCreator);
            Controls.Add(txtTitle);
            Controls.Add(cmbPriority);
            Controls.Add(dtpDeadline);
            Name = "TaskForm";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dtpDeadline;
        private ComboBox cmbPriority;
        private TextBox txtTitle;
        private TextBox txtCreator;
        private TextBox txtDescription;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button button1;
    }
}