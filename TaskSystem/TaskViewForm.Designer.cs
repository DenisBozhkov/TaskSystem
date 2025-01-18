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
            tableLayoutPanel1 = new TableLayoutPanel();
            filterButton = new Button();
            orderByPriorirtyButton = new Button();
            scheduleButton = new Button();
            splitContainer1 = new SplitContainer();
            tableLayoutPanel2 = new TableLayoutPanel();
            startDatePicker = new DateTimePicker();
            startDateCheckBox = new CheckBox();
            endDatePicker = new DateTimePicker();
            endDateCheckbox = new CheckBox();
            goFilterButton = new Button();
            clearFilterButton = new Button();
            panel1.SuspendLayout();
            nonLoggedPanel.SuspendLayout();
            loggedInPanel.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // taskList
            // 
            taskList.AutoScroll = true;
            taskList.BorderStyle = BorderStyle.Fixed3D;
            taskList.Dock = DockStyle.Fill;
            taskList.Location = new Point(0, 0);
            taskList.Name = "taskList";
            taskList.Size = new Size(1097, 369);
            taskList.TabIndex = 6;
            taskList.EditItem += taskList_EditItem;
            taskList.DeleteItem += taskList_DeleteItem;
            // 
            // label1
            // 
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Segoe UI", 13F);
            label1.Location = new Point(8, 46);
            label1.Name = "label1";
            label1.Size = new Size(1097, 67);
            label1.TabIndex = 1;
            label1.Text = "Task management system";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // createButton
            // 
            createButton.Dock = DockStyle.Fill;
            createButton.Location = new Point(3, 3);
            createButton.Name = "createButton";
            createButton.Size = new Size(122, 48);
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
            panel1.Location = new Point(8, 8);
            panel1.Name = "panel1";
            panel1.Size = new Size(1097, 38);
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
            nonLoggedPanel.Name = "nonLoggedPanel";
            nonLoggedPanel.RowCount = 1;
            nonLoggedPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            nonLoggedPanel.Size = new Size(1097, 35);
            nonLoggedPanel.TabIndex = 0;
            // 
            // registerButton
            // 
            registerButton.Location = new Point(781, 3);
            registerButton.Name = "registerButton";
            registerButton.Size = new Size(94, 29);
            registerButton.TabIndex = 4;
            registerButton.Text = "Register";
            registerButton.UseVisualStyleBackColor = true;
            registerButton.Click += registerButton_Click;
            // 
            // logInButton
            // 
            logInButton.Location = new Point(681, 3);
            logInButton.Name = "logInButton";
            logInButton.Size = new Size(94, 29);
            logInButton.TabIndex = 3;
            logInButton.Text = "Log in";
            logInButton.UseVisualStyleBackColor = true;
            logInButton.Click += logInButton_Click;
            // 
            // passwordTextBox
            // 
            passwordTextBox.Dock = DockStyle.Fill;
            passwordTextBox.Location = new Point(536, 3);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.PasswordChar = '*';
            passwordTextBox.Size = new Size(139, 27);
            passwordTextBox.TabIndex = 2;
            // 
            // label3
            // 
            label3.Dock = DockStyle.Fill;
            label3.Location = new Point(453, 0);
            label3.Name = "label3";
            label3.Size = new Size(77, 35);
            label3.TabIndex = 1;
            label3.Text = "Password:";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // usernameTextBox
            // 
            usernameTextBox.Dock = DockStyle.Fill;
            usernameTextBox.Location = new Point(308, 3);
            usernameTextBox.Name = "usernameTextBox";
            usernameTextBox.Size = new Size(139, 27);
            usernameTextBox.TabIndex = 1;
            // 
            // label2
            // 
            label2.Dock = DockStyle.Fill;
            label2.Location = new Point(220, 0);
            label2.Name = "label2";
            label2.Size = new Size(82, 35);
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
            loggedInPanel.Name = "loggedInPanel";
            loggedInPanel.RowCount = 1;
            loggedInPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            loggedInPanel.Size = new Size(1097, 35);
            loggedInPanel.TabIndex = 1;
            loggedInPanel.Visible = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Dock = DockStyle.Fill;
            label4.Location = new Point(435, 0);
            label4.Name = "label4";
            label4.Size = new Size(81, 35);
            label4.TabIndex = 0;
            label4.Text = "Logged as:";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // userLabel
            // 
            userLabel.AutoSize = true;
            userLabel.Dock = DockStyle.Fill;
            userLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            userLabel.Location = new Point(522, 0);
            userLabel.Name = "userLabel";
            userLabel.Size = new Size(39, 35);
            userLabel.TabIndex = 1;
            userLabel.Text = "user";
            userLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // logOutButton
            // 
            logOutButton.Location = new Point(567, 3);
            logOutButton.Name = "logOutButton";
            logOutButton.Size = new Size(94, 29);
            logOutButton.TabIndex = 2;
            logOutButton.Text = "Log out";
            logOutButton.UseVisualStyleBackColor = true;
            logOutButton.Click += logOutButton_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 5;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.Controls.Add(createButton, 0, 0);
            tableLayoutPanel1.Controls.Add(filterButton, 4, 0);
            tableLayoutPanel1.Controls.Add(orderByPriorirtyButton, 3, 0);
            tableLayoutPanel1.Controls.Add(scheduleButton, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Top;
            tableLayoutPanel1.Location = new Point(8, 113);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.Size = new Size(1097, 54);
            tableLayoutPanel1.TabIndex = 7;
            // 
            // filterButton
            // 
            filterButton.Dock = DockStyle.Fill;
            filterButton.Location = new Point(1000, 3);
            filterButton.Name = "filterButton";
            filterButton.Size = new Size(94, 48);
            filterButton.TabIndex = 6;
            filterButton.Text = "Filtration";
            filterButton.UseVisualStyleBackColor = true;
            filterButton.Click += filterButton_Click;
            // 
            // orderByPriorirtyButton
            // 
            orderByPriorirtyButton.Dock = DockStyle.Fill;
            orderByPriorirtyButton.Location = new Point(900, 3);
            orderByPriorirtyButton.Name = "orderByPriorirtyButton";
            orderByPriorirtyButton.Size = new Size(94, 48);
            orderByPriorirtyButton.TabIndex = 7;
            orderByPriorirtyButton.Text = "Order by priorirty";
            orderByPriorirtyButton.UseVisualStyleBackColor = true;
            orderByPriorirtyButton.Click += orderByPriorirtyButton_Click;
            // 
            // scheduleButton
            // 
            scheduleButton.Location = new Point(131, 3);
            scheduleButton.Name = "scheduleButton";
            scheduleButton.Size = new Size(109, 48);
            scheduleButton.TabIndex = 8;
            scheduleButton.Text = "Today's schedule";
            scheduleButton.UseVisualStyleBackColor = true;
            scheduleButton.Visible = false;
            scheduleButton.Click += scheduleButton_Click;
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.FixedPanel = FixedPanel.Panel1;
            splitContainer1.IsSplitterFixed = true;
            splitContainer1.Location = new Point(8, 167);
            splitContainer1.Name = "splitContainer1";
            splitContainer1.Orientation = Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(tableLayoutPanel2);
            splitContainer1.Panel1Collapsed = true;
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(taskList);
            splitContainer1.Size = new Size(1097, 369);
            splitContainer1.SplitterDistance = 34;
            splitContainer1.TabIndex = 8;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 7;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 240F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 240F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel2.Controls.Add(startDatePicker, 1, 0);
            tableLayoutPanel2.Controls.Add(startDateCheckBox, 0, 0);
            tableLayoutPanel2.Controls.Add(endDatePicker, 4, 0);
            tableLayoutPanel2.Controls.Add(endDateCheckbox, 3, 0);
            tableLayoutPanel2.Controls.Add(goFilterButton, 5, 0);
            tableLayoutPanel2.Controls.Add(clearFilterButton, 6, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(0, 0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(150, 34);
            tableLayoutPanel2.TabIndex = 4;
            // 
            // startDatePicker
            // 
            startDatePicker.Dock = DockStyle.Fill;
            startDatePicker.Enabled = false;
            startDatePicker.Location = new Point(109, 3);
            startDatePicker.Name = "startDatePicker";
            startDatePicker.Size = new Size(234, 27);
            startDatePicker.TabIndex = 2;
            // 
            // startDateCheckBox
            // 
            startDateCheckBox.AutoSize = true;
            startDateCheckBox.Dock = DockStyle.Fill;
            startDateCheckBox.Location = new Point(3, 3);
            startDateCheckBox.Name = "startDateCheckBox";
            startDateCheckBox.Size = new Size(100, 28);
            startDateCheckBox.TabIndex = 4;
            startDateCheckBox.Text = "Start after:";
            startDateCheckBox.UseVisualStyleBackColor = true;
            startDateCheckBox.CheckedChanged += startDateCheckBox_CheckedChanged;
            // 
            // endDatePicker
            // 
            endDatePicker.Dock = DockStyle.Fill;
            endDatePicker.Enabled = false;
            endDatePicker.Location = new Point(138, 3);
            endDatePicker.Name = "endDatePicker";
            endDatePicker.Size = new Size(234, 27);
            endDatePicker.TabIndex = 3;
            // 
            // endDateCheckbox
            // 
            endDateCheckbox.AutoSize = true;
            endDateCheckbox.Dock = DockStyle.Fill;
            endDateCheckbox.Location = new Point(25, 3);
            endDateCheckbox.Name = "endDateCheckbox";
            endDateCheckbox.Size = new Size(107, 28);
            endDateCheckbox.TabIndex = 5;
            endDateCheckbox.Text = "End before:";
            endDateCheckbox.UseVisualStyleBackColor = true;
            endDateCheckbox.CheckedChanged += endDateCheckbox_CheckedChanged;
            // 
            // goFilterButton
            // 
            goFilterButton.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            goFilterButton.Location = new Point(378, 3);
            goFilterButton.Name = "goFilterButton";
            goFilterButton.Size = new Size(1, 28);
            goFilterButton.TabIndex = 6;
            goFilterButton.Text = "Filter";
            goFilterButton.UseVisualStyleBackColor = true;
            goFilterButton.Click += goFilterButton_Click;
            // 
            // clearFilterButton
            // 
            clearFilterButton.Location = new Point(54, 3);
            clearFilterButton.Name = "clearFilterButton";
            clearFilterButton.Size = new Size(94, 28);
            clearFilterButton.TabIndex = 7;
            clearFilterButton.Text = "Clear filter";
            clearFilterButton.UseVisualStyleBackColor = true;
            clearFilterButton.Click += clearFilterButton_Click;
            // 
            // TaskViewForm
            // 
            AcceptButton = logInButton;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1113, 544);
            Controls.Add(splitContainer1);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(label1);
            Controls.Add(panel1);
            Name = "TaskViewForm";
            Padding = new Padding(8);
            Text = "Task System";
            panel1.ResumeLayout(false);
            nonLoggedPanel.ResumeLayout(false);
            nonLoggedPanel.PerformLayout();
            loggedInPanel.ResumeLayout(false);
            loggedInPanel.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
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
        private TableLayoutPanel tableLayoutPanel1;
        private Button filterButton;
        private SplitContainer splitContainer1;
        private DateTimePicker endDatePicker;
        private DateTimePicker startDatePicker;
        private TableLayoutPanel tableLayoutPanel2;
        private CheckBox startDateCheckBox;
        private CheckBox endDateCheckbox;
        private Button orderByPriorirtyButton;
        private Button goFilterButton;
        private Button clearFilterButton;
        private Button scheduleButton;
    }
}
