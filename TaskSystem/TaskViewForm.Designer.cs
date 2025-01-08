namespace TaskSystem
{
    partial class TaskViewForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            taskList = new TaskListBox();
            label1 = new Label();
            createButton = new Button();
            SuspendLayout();
            // 
            // taskList
            // 
            taskList.AutoScroll = true;
            taskList.BorderStyle = BorderStyle.Fixed3D;
            taskList.Dock = DockStyle.Fill;
            taskList.Location = new Point(8, 122);
            taskList.Name = "taskList";
            taskList.Size = new Size(1097, 414);
            taskList.TabIndex = 0;
            taskList.EditItem += taskList_EditItem;
            taskList.DeleteItem += taskList_DeleteItem;
            // 
            // label1
            // 
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Segoe UI", 13F);
            label1.Location = new Point(8, 8);
            label1.Name = "label1";
            label1.Size = new Size(1097, 66);
            label1.TabIndex = 1;
            label1.Text = "Task management system";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // createButton
            // 
            createButton.Dock = DockStyle.Top;
            createButton.Location = new Point(8, 74);
            createButton.Name = "createButton";
            createButton.Size = new Size(1097, 48);
            createButton.TabIndex = 2;
            createButton.Text = "Create task";
            createButton.UseVisualStyleBackColor = true;
            // 
            // TaskViewForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1113, 544);
            Controls.Add(taskList);
            Controls.Add(createButton);
            Controls.Add(label1);
            Name = "TaskViewForm";
            Padding = new Padding(8);
            Text = "Task System";
            ResumeLayout(false);
        }

        #endregion

        private TaskListBox taskList;
        private Label label1;
        private Button createButton;
    }
}
