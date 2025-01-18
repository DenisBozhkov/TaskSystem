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
            panel1 = new Panel();
            nonLoggedPanel = new TableLayoutPanel();
            registerButton = new Button();
            logInButton = new Button();
            passwordTextBox = new TextBox();
            label3 = new Label();
            usernameTextBox = new TextBox();
            label2 = new Label();
            loggedInPanel = new TableLayoutPanel();
            label4 = new Label();
            userLabel = new Label();
            logOutButton = new Button();
            panel1.SuspendLayout();
            nonLoggedPanel.SuspendLayout();
            loggedInPanel.SuspendLayout();
            SuspendLayout();
            // 
            // taskList
            // 
            taskList.AutoScroll = true;
            taskList.BorderStyle = BorderStyle.Fixed3D;
            taskList.Dock = DockStyle.Fill;
            taskList.Location = new Point(7, 120);
            taskList.Margin = new Padding(3, 2, 3, 2);
            taskList.Name = "taskList";
            taskList.Size = new Size(960, 282);
            taskList.TabIndex = 6;
            taskList.EditItem += taskList_EditItem;
            taskList.DeleteItem += taskList_DeleteItem;
            // 
            // label1
            // 
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Segoe UI", 13F);
            label1.Location = new Point(7, 34);
            label1.Name = "label1";
            label1.Size = new Size(960, 50);
            label1.TabIndex = 1;
            label1.Text = "Task management system";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // createButton
            // 
            createButton.Dock = DockStyle.Top;
            createButton.Location = new Point(7, 84);
            createButton.Margin = new Padding(3, 2, 3, 2);
            createButton.Name = "createButton";
            createButton.Size = new Size(960, 36);
            createButton.TabIndex = 5;
            createButton.Text = "Create task";
            createButton.UseVisualStyleBackColor = true;
            createButton.Visible = false;
            createButton.Click += createButton_Click;
            // 
            // panel1
            // 
            panel1.AutoSize = true;
            panel1.Controls.Add(nonLoggedPanel);
            panel1.Controls.Add(loggedInPanel);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(7, 6);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(960, 28);
            panel1.TabIndex = 3;
            // 
            // nonLoggedPanel
            // 
            nonLoggedPanel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            nonLoggedPanel.ColumnCount = 8;
            nonLoggedPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            nonLoggedPanel.ColumnStyles.Add(new ColumnStyle());
            nonLoggedPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            nonLoggedPanel.ColumnStyles.Add(new ColumnStyle());
            nonLoggedPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            nonLoggedPanel.ColumnStyles.Add(new ColumnStyle());
            nonLoggedPanel.ColumnStyles.Add(new ColumnStyle());
            nonLoggedPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            nonLoggedPanel.Controls.Add(registerButton, 6, 0);
            nonLoggedPanel.Controls.Add(logInButton, 5, 0);
            nonLoggedPanel.Controls.Add(passwordTextBox, 4, 0);
            nonLoggedPanel.Controls.Add(label3, 3, 0);
            nonLoggedPanel.Controls.Add(usernameTextBox, 2, 0);
            nonLoggedPanel.Controls.Add(label2, 1, 0);
            nonLoggedPanel.Location = new Point(0, 0);
            nonLoggedPanel.Margin = new Padding(3, 2, 3, 2);
            nonLoggedPanel.Name = "nonLoggedPanel";
            nonLoggedPanel.RowCount = 1;
            nonLoggedPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            nonLoggedPanel.Size = new Size(960, 26);
            nonLoggedPanel.TabIndex = 0;
            // 
            // registerButton
            // 
            registerButton.Location = new Point(683, 2);
            registerButton.Margin = new Padding(3, 2, 3, 2);
            registerButton.Name = "registerButton";
            registerButton.Size = new Size(82, 22);
            registerButton.TabIndex = 4;
            registerButton.Text = "Register";
            registerButton.UseVisualStyleBackColor = true;
            registerButton.Click += registerButton_Click;
            // 
            // logInButton
            // 
            logInButton.Location = new Point(595, 2);
            logInButton.Margin = new Padding(3, 2, 3, 2);
            logInButton.Name = "logInButton";
            logInButton.Size = new Size(82, 22);
            logInButton.TabIndex = 3;
            logInButton.Text = "Log in";
            logInButton.UseVisualStyleBackColor = true;
            logInButton.Click += logInButton_Click;
            // 
            // passwordTextBox
            // 
            passwordTextBox.Dock = DockStyle.Fill;
            passwordTextBox.Location = new Point(469, 2);
            passwordTextBox.Margin = new Padding(3, 2, 3, 2);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.PasswordChar = '*';
            passwordTextBox.Size = new Size(120, 23);
            passwordTextBox.TabIndex = 2;
            // 
            // label3
            // 
            label3.Dock = DockStyle.Fill;
            label3.Location = new Point(396, 0);
            label3.Name = "label3";
            label3.Size = new Size(67, 26);
            label3.TabIndex = 1;
            label3.Text = "Password:";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // usernameTextBox
            // 
            usernameTextBox.Dock = DockStyle.Fill;
            usernameTextBox.Location = new Point(270, 2);
            usernameTextBox.Margin = new Padding(3, 2, 3, 2);
            usernameTextBox.Name = "usernameTextBox";
            usernameTextBox.Size = new Size(120, 23);
            usernameTextBox.TabIndex = 1;
            // 
            // label2
            // 
            label2.Dock = DockStyle.Fill;
            label2.Location = new Point(192, 0);
            label2.Name = "label2";
            label2.Size = new Size(72, 26);
            label2.TabIndex = 0;
            label2.Text = "Username:";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // loggedInPanel
            // 
            loggedInPanel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            loggedInPanel.ColumnCount = 5;
            loggedInPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            loggedInPanel.ColumnStyles.Add(new ColumnStyle());
            loggedInPanel.ColumnStyles.Add(new ColumnStyle());
            loggedInPanel.ColumnStyles.Add(new ColumnStyle());
            loggedInPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            loggedInPanel.Controls.Add(label4, 1, 0);
            loggedInPanel.Controls.Add(userLabel, 2, 0);
            loggedInPanel.Controls.Add(logOutButton, 3, 0);
            loggedInPanel.Location = new Point(0, 0);
            loggedInPanel.Margin = new Padding(3, 2, 3, 2);
            loggedInPanel.Name = "loggedInPanel";
            loggedInPanel.RowCount = 1;
            loggedInPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            loggedInPanel.Size = new Size(960, 26);
            loggedInPanel.TabIndex = 1;
            loggedInPanel.Visible = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Dock = DockStyle.Fill;
            label4.Location = new Point(385, 0);
            label4.Name = "label4";
            label4.Size = new Size(64, 26);
            label4.TabIndex = 0;
            label4.Text = "Logged as:";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // userLabel
            // 
            userLabel.AutoSize = true;
            userLabel.Dock = DockStyle.Fill;
            userLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            userLabel.Location = new Point(455, 0);
            userLabel.Name = "userLabel";
            userLabel.Size = new Size(31, 26);
            userLabel.TabIndex = 1;
            userLabel.Text = "user";
            userLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // logOutButton
            // 
            logOutButton.Location = new Point(492, 2);
            logOutButton.Margin = new Padding(3, 2, 3, 2);
            logOutButton.Name = "logOutButton";
            logOutButton.Size = new Size(82, 22);
            logOutButton.TabIndex = 2;
            logOutButton.Text = "Log out";
            logOutButton.UseVisualStyleBackColor = true;
            logOutButton.Click += logOutButton_Click;
            // 
            // TaskViewForm
            // 
            AcceptButton = logInButton;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(974, 408);
            Controls.Add(taskList);
            Controls.Add(createButton);
            Controls.Add(label1);
            Controls.Add(panel1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "TaskViewForm";
            Padding = new Padding(7, 6, 7, 6);
            Text = "Task System";
            panel1.ResumeLayout(false);
            nonLoggedPanel.ResumeLayout(false);
            nonLoggedPanel.PerformLayout();
            loggedInPanel.ResumeLayout(false);
            loggedInPanel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TaskListBox taskList;
        private Label label1;
        private Button createButton;
        private Panel panel1;
        private TableLayoutPanel loggedInPanel;
        private Label label4;
        private Label userLabel;
        private Button logOutButton;
        private TableLayoutPanel nonLoggedPanel;
        private Button registerButton;
        private Button logInButton;
        private TextBox passwordTextBox;
        private Label label3;
        private TextBox usernameTextBox;
        private Label label2;
    }
}
