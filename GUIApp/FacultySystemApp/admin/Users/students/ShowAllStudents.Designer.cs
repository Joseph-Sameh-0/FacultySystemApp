﻿namespace FacultySystemApp.admin.students
{
    partial class ShowAllStudents
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            EntryYear = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            Major = new ComboBox();
            label3 = new Label();
            Course = new ComboBox();
            ShowButton = new Button();
            Students = new DataGridView();
            BackButton = new Button();
            ((System.ComponentModel.ISupportInitialize)Students).BeginInit();
            SuspendLayout();
            // 
            // EntryYear
            // 
            EntryYear.BackColor = Color.Black;
            EntryYear.DropDownStyle = ComboBoxStyle.DropDownList;
            EntryYear.Font = new Font("Segoe UI", 15F);
            EntryYear.ForeColor = Color.White;
            EntryYear.FormattingEnabled = true;
            EntryYear.Location = new Point(135, 92);
            EntryYear.Name = "EntryYear";
            EntryYear.Size = new Size(164, 36);
            EntryYear.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F);
            label1.Location = new Point(168, 39);
            label1.Name = "label1";
            label1.Size = new Size(98, 28);
            label1.TabIndex = 1;
            label1.Text = "Entry Year";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F);
            label2.Location = new Point(774, 39);
            label2.Name = "label2";
            label2.Size = new Size(64, 28);
            label2.TabIndex = 3;
            label2.Text = "Major";
            // 
            // Major
            // 
            Major.BackColor = Color.Black;
            Major.DropDownStyle = ComboBoxStyle.DropDownList;
            Major.Font = new Font("Segoe UI", 15F);
            Major.ForeColor = Color.White;
            Major.FormattingEnabled = true;
            Major.Location = new Point(724, 92);
            Major.Name = "Major";
            Major.Size = new Size(164, 36);
            Major.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15F);
            label3.Location = new Point(909, 119);
            label3.Name = "label3";
            label3.Size = new Size(72, 28);
            label3.TabIndex = 5;
            label3.Text = "Course";
            label3.Visible = false;
            // 
            // Course
            // 
            Course.BackColor = Color.Black;
            Course.DropDownStyle = ComboBoxStyle.DropDownList;
            Course.Font = new Font("Segoe UI", 15F);
            Course.ForeColor = Color.White;
            Course.FormattingEnabled = true;
            Course.Location = new Point(862, 172);
            Course.Name = "Course";
            Course.Size = new Size(164, 36);
            Course.TabIndex = 4;
            Course.Visible = false;
            // 
            // ShowButton
            // 
            ShowButton.Font = new Font("Segoe UI", 20F);
            ShowButton.ForeColor = Color.Black;
            ShowButton.Location = new Point(448, 119);
            ShowButton.Name = "ShowButton";
            ShowButton.Size = new Size(142, 46);
            ShowButton.TabIndex = 0;
            ShowButton.Text = "Show";
            ShowButton.UseVisualStyleBackColor = true;
            ShowButton.Click += ShowButton_Click;
            // 
            // Students
            // 
            Students.AllowUserToAddRows = false;
            Students.AllowUserToDeleteRows = false;
            Students.BackgroundColor = Color.Black;
            Students.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            Students.DefaultCellStyle = dataGridViewCellStyle1;
            Students.Location = new Point(12, 215);
            Students.Name = "Students";
            Students.ReadOnly = true;
            dataGridViewCellStyle2.ForeColor = Color.Black;
            Students.RowsDefaultCellStyle = dataGridViewCellStyle2;
            Students.RowTemplate.DefaultCellStyle.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Students.RowTemplate.DefaultCellStyle.ForeColor = Color.Black;
            Students.Size = new Size(1014, 387);
            Students.TabIndex = 10;
            // 
            // BackButton
            // 
            BackButton.BackColor = Color.Black;
            BackButton.FlatAppearance.BorderSize = 0;
            BackButton.FlatStyle = FlatStyle.Flat;
            BackButton.Font = new Font("Segoe UI", 20F);
            BackButton.ForeColor = Color.White;
            BackButton.Location = new Point(12, 20);
            BackButton.Name = "BackButton";
            BackButton.Size = new Size(115, 47);
            BackButton.TabIndex = 17;
            BackButton.Text = "⇐ back";
            BackButton.UseVisualStyleBackColor = false;
            BackButton.Click += BackButton_Click;
            // 
            // ShowAllStudents
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(1038, 614);
            Controls.Add(BackButton);
            Controls.Add(Students);
            Controls.Add(ShowButton);
            Controls.Add(label3);
            Controls.Add(Course);
            Controls.Add(label2);
            Controls.Add(Major);
            Controls.Add(label1);
            Controls.Add(EntryYear);
            ForeColor = Color.White;
            Name = "ShowAllStudents";
            Text = "ShowAllStudents";
            FormClosed += ShowAllStudents_close;
            Load += ShowAllStudents_Load;
            ((System.ComponentModel.ISupportInitialize)Students).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox EntryYear;
        private Label label1;
        private Label label2;
        private ComboBox Major;
        private Label label3;
        private ComboBox Course;
        private Button ShowButton;
        private DataGridView Students;
        private Button BackButton;
    }
}