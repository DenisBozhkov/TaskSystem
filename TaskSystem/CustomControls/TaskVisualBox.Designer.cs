namespace TaskSystem
{
    partial class TaskVisualBox
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
            tableLayoutPanel1 = new TableLayoutPanel();
            importancyLabel = new Label();
            descriptionButton = new Button();
            statusLabel = new Label();
            titleLabel = new Label();
            deadlineLabel = new Label();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 5;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 130F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 36F));
            tableLayoutPanel1.Controls.Add(importancyLabel, 0, 0);
            tableLayoutPanel1.Controls.Add(descriptionButton, 4, 0);
            tableLayoutPanel1.Controls.Add(statusLabel, 3, 0);
            tableLayoutPanel1.Controls.Add(titleLabel, 2, 0);
            tableLayoutPanel1.Controls.Add(deadlineLabel, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Top;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 36F));
            tableLayoutPanel1.Size = new Size(760, 36);
            tableLayoutPanel1.TabIndex = 5;
            // 
            // importancyLabel
            // 
            importancyLabel.BorderStyle = BorderStyle.FixedSingle;
            importancyLabel.Dock = DockStyle.Fill;
            importancyLabel.Location = new Point(0, 0);
            importancyLabel.Margin = new Padding(0);
            importancyLabel.Name = "importancyLabel";
            importancyLabel.Size = new Size(130, 36);
            importancyLabel.TabIndex = 7;
            importancyLabel.Text = "Importancy";
            importancyLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // descriptionButton
            // 
            descriptionButton.Dock = DockStyle.Fill;
            descriptionButton.FlatStyle = FlatStyle.Flat;
            descriptionButton.Location = new Point(722, 0);
            descriptionButton.Margin = new Padding(0);
            descriptionButton.Name = "descriptionButton";
            descriptionButton.Size = new Size(38, 36);
            descriptionButton.TabIndex = 0;
            descriptionButton.Text = "+";
            descriptionButton.UseVisualStyleBackColor = true;
            descriptionButton.Click += descriptionButton_Click;
            // 
            // statusLabel
            // 
            statusLabel.BorderStyle = BorderStyle.FixedSingle;
            statusLabel.Dock = DockStyle.Fill;
            statusLabel.Location = new Point(604, 0);
            statusLabel.Margin = new Padding(0);
            statusLabel.Name = "statusLabel";
            statusLabel.Size = new Size(118, 36);
            statusLabel.TabIndex = 6;
            statusLabel.Text = "Status";
            statusLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // titleLabel
            // 
            titleLabel.BorderStyle = BorderStyle.FixedSingle;
            titleLabel.Dock = DockStyle.Fill;
            titleLabel.Location = new Point(248, 0);
            titleLabel.Margin = new Padding(0);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(356, 36);
            titleLabel.TabIndex = 1;
            titleLabel.Text = "Title";
            titleLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // deadlineLabel
            // 
            deadlineLabel.BorderStyle = BorderStyle.FixedSingle;
            deadlineLabel.Dock = DockStyle.Fill;
            deadlineLabel.Location = new Point(130, 0);
            deadlineLabel.Margin = new Padding(0);
            deadlineLabel.Name = "deadlineLabel";
            deadlineLabel.Size = new Size(118, 36);
            deadlineLabel.TabIndex = 0;
            deadlineLabel.Text = "Deadline";
            deadlineLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // TaskVisualBox
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel1);
            Name = "TaskVisualBox";
            Size = new Size(760, 36);
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label deadlineLabel;
        private Button descriptionButton;
        private Label importancyLabel;
        private Label statusLabel;
        private Label titleLabel;
    }
}
