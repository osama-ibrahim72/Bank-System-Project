namespace BankSystem
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.Admin = new System.Windows.Forms.Button();
            this.Employee = new System.Windows.Forms.Button();
            this.customer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Admin
            // 
            this.Admin.BackColor = System.Drawing.Color.Transparent;
            this.Admin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Admin.BackgroundImage")));
            this.Admin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Admin.FlatAppearance.BorderSize = 0;
            this.Admin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Admin.Location = new System.Drawing.Point(48, 257);
            this.Admin.Name = "Admin";
            this.Admin.Size = new System.Drawing.Size(167, 217);
            this.Admin.TabIndex = 0;
            this.Admin.UseVisualStyleBackColor = false;
            this.Admin.Click += new System.EventHandler(this.Admin_Click);
            // 
            // Employee
            // 
            this.Employee.BackColor = System.Drawing.Color.Transparent;
            this.Employee.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Employee.BackgroundImage")));
            this.Employee.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Employee.FlatAppearance.BorderSize = 0;
            this.Employee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Employee.Location = new System.Drawing.Point(225, 259);
            this.Employee.Name = "Employee";
            this.Employee.Size = new System.Drawing.Size(167, 213);
            this.Employee.TabIndex = 1;
            this.Employee.UseVisualStyleBackColor = false;
            this.Employee.Click += new System.EventHandler(this.Employee_Click);
            // 
            // customer
            // 
            this.customer.BackColor = System.Drawing.Color.Transparent;
            this.customer.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("customer.BackgroundImage")));
            this.customer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.customer.FlatAppearance.BorderSize = 0;
            this.customer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customer.Location = new System.Drawing.Point(409, 261);
            this.customer.Name = "customer";
            this.customer.Size = new System.Drawing.Size(175, 213);
            this.customer.TabIndex = 2;
            this.customer.UseVisualStyleBackColor = false;
            this.customer.Click += new System.EventHandler(this.customer_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1182, 743);
            this.Controls.Add(this.customer);
            this.Controls.Add(this.Employee);
            this.Controls.Add(this.Admin);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Button Admin;
        private Button Employee;
        private Button customer;
    }
}