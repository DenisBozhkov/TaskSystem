namespace TaskSystem
{
    partial class TaskDescriptionBox
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            editButtons = new TableLayoutPanel();
            editButton = new Button();
            deleteButton = new Button();
            label2 = new Label();
            createdByLabel = new Label();
            panel1 = new Panel();
            descriptionLabel = new Label();
            editButtons.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // editButtons
            // 
            editButtons.AutoSize = true;
            editButtons.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            editButtons.ColumnCount = 2;
            editButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            editButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            editButtons.Controls.Add(editButton, 0, 0);
            editButtons.Controls.Add(deleteButton, 1, 0);
            editButtons.Dock = DockStyle.Top;
            editButtons.Location = new Point(0, 40);
            editButtons.Name = "editButtons";
            editButtons.RowCount = 1;
            editButtons.RowStyles.Add(new RowStyle());
            editButtons.Size = new Size(467, 32);
            editButtons.TabIndex = 0;
            // 
            // editButton
            // 
            editButton.Dock = DockStyle.Right;
            editButton.FlatStyle = FlatStyle.Flat;
            editButton.Location = new Point(139, 0);
            editButton.Margin = new Padding(0, 0, 0, 3);
            editButton.Name = "editButton";
            editButton.Size = new Size(94, 29);
            editButton.TabIndex = 3;
            editButton.Text = "Edit";
            editButton.UseVisualStyleBackColor = true;
            editButton.Click += editButton_Click;
            // 
            // deleteButton
            // 
            deleteButton.FlatStyle = FlatStyle.Flat;
            deleteButton.Location = new Point(233, 0);
            deleteButton.Margin = new Padding(0, 0, 0, 3);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(94, 29);
            deleteButton.TabIndex = 4;
            deleteButton.Text = "Delete";
            deleteButton.UseVisualStyleBackColor = true;
            deleteButton.Click += deleteButton_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.Location = new Point(0, 0);
            label2.Margin = new Padding(0);
            label2.Name = "label2";
            label2.Size = new Size(88, 20);
            label2.TabIndex = 1;
            label2.Text = "Created by:";
            // 
            // createdByLabel
            // 
            createdByLabel.AutoSize = true;
            createdByLabel.Location = new Point(84, 0);
            createdByLabel.Margin = new Padding(0);
            createdByLabel.Name = "createdByLabel";
            createdByLabel.Size = new Size(38, 20);
            createdByLabel.TabIndex = 2;
            createdByLabel.TabStop = true;
            createdByLabel.Text = "User";
            // 
            // panel1
            // 
            panel1.AutoSize = true;
            panel1.Controls.Add(label2);
            panel1.Controls.Add(createdByLabel);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(467, 20);
            panel1.TabIndex = 3;
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Dock = DockStyle.Top;
            descriptionLabel.Location = new Point(0, 20);
            descriptionLabel.Margin = new Padding(3);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new Size(85, 20);
            descriptionLabel.TabIndex = 4;
            descriptionLabel.Text = "Description";
            // 
            // TaskDescriptionBox
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(editButtons);
            Controls.Add(descriptionLabel);
            Controls.Add(panel1);
            Name = "TaskDescriptionBox";
            Size = new Size(467, 196);
            Resize += TaskDescriptionBox_Resize;
            editButtons.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TableLayoutPanel editButtons;
        private Label label2;
        private Label createdByLabel;
        private Button editButton;
        private Button deleteButton;
        private Panel panel1;
        private Label descriptionLabel;
    }
}
