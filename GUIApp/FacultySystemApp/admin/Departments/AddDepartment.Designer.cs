﻿namespace FacultySystemApp.admin.Departments
{
    partial class AddDepartment
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
            textBox3 = new TextBox();
            label2 = new Label();
            BackButton = new Button();
            AddDepartmentButton = new Button();
            label5 = new Label();
            username = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Segoe UI", 20F);
            textBox3.Location = new Point(374, 129);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(402, 43);
            textBox3.TabIndex = 90;
            textBox3.TextAlign = HorizontalAlignment.Center;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Black;
            label2.Font = new Font("Segoe UI", 30F);
            label2.ForeColor = Color.White;
            label2.Location = new Point(43, 119);
            label2.Name = "label2";
            label2.Size = new Size(286, 54);
            label2.TabIndex = 85;
            label2.Text = "Department ID";
            // 
            // BackButton
            // 
            BackButton.BackColor = Color.Black;
            BackButton.FlatAppearance.BorderSize = 0;
            BackButton.FlatStyle = FlatStyle.Flat;
            BackButton.Font = new Font("Segoe UI", 20F);
            BackButton.ForeColor = Color.White;
            BackButton.Location = new Point(25, 10);
            BackButton.Name = "BackButton";
            BackButton.Size = new Size(115, 47);
            BackButton.TabIndex = 84;
            BackButton.Text = "⇐ back";
            BackButton.UseVisualStyleBackColor = false;
            BackButton.Click += BackButton_Click;
            // 
            // AddDepartmentButton
            // 
            AddDepartmentButton.Font = new Font("Segoe UI", 20F);
            AddDepartmentButton.ForeColor = Color.Black;
            AddDepartmentButton.Location = new Point(288, 360);
            AddDepartmentButton.Name = "AddDepartmentButton";
            AddDepartmentButton.Size = new Size(142, 46);
            AddDepartmentButton.TabIndex = 83;
            AddDepartmentButton.Text = "Add";
            AddDepartmentButton.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Black;
            label5.Font = new Font("Segoe UI", 30F);
            label5.ForeColor = Color.White;
            label5.Location = new Point(67, 223);
            label5.Name = "label5";
            label5.Size = new Size(262, 54);
            label5.TabIndex = 82;
            label5.Text = "Course Name";
            // 
            // username
            // 
            username.Font = new Font("Segoe UI", 20F);
            username.Location = new Point(374, 223);
            username.Name = "username";
            username.Size = new Size(402, 43);
            username.TabIndex = 81;
            username.TextAlign = HorizontalAlignment.Center;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 25F);
            label1.Location = new Point(262, 11);
            label1.Name = "label1";
            label1.Size = new Size(272, 46);
            label1.TabIndex = 80;
            label1.Text = "Add Department";
            // 
            // AddDepartment
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox3);
            Controls.Add(label2);
            Controls.Add(BackButton);
            Controls.Add(AddDepartmentButton);
            Controls.Add(label5);
            Controls.Add(username);
            Controls.Add(label1);
            ForeColor = Color.White;
            Name = "AddDepartment";
            Text = "AddDepartment";
            FormClosed += AddDepartment_FormClosed;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox3;
        private Label label2;
        private Button BackButton;
        private Button AddDepartmentButton;
        private Label label5;
        private TextBox username;
        private Label label1;
    }
}