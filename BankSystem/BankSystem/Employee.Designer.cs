namespace BankSystem
{
    partial class Employee
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Employee));
            this.back = new System.Windows.Forms.Button();
            this.leon_req = new System.Windows.Forms.Button();
            this.add_coust = new System.Windows.Forms.Button();
            this.loens = new System.Windows.Forms.ListView();
            this.cus = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // back
            // 
            this.back.BackColor = System.Drawing.Color.Transparent;
            this.back.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("back.BackgroundImage")));
            this.back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.back.FlatAppearance.BorderSize = 0;
            this.back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.back.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.back.ForeColor = System.Drawing.Color.Transparent;
            this.back.Location = new System.Drawing.Point(990, 593);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(112, 46);
            this.back.TabIndex = 0;
            this.back.Text = "back";
            this.back.UseVisualStyleBackColor = false;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // leon_req
            // 
            this.leon_req.BackColor = System.Drawing.Color.Transparent;
            this.leon_req.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("leon_req.BackgroundImage")));
            this.leon_req.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.leon_req.FlatAppearance.BorderSize = 0;
            this.leon_req.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.leon_req.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.leon_req.ForeColor = System.Drawing.Color.Transparent;
            this.leon_req.Location = new System.Drawing.Point(82, 501);
            this.leon_req.Name = "leon_req";
            this.leon_req.Size = new System.Drawing.Size(253, 79);
            this.leon_req.TabIndex = 1;
            this.leon_req.Text = "loen requests";
            this.leon_req.UseVisualStyleBackColor = false;
            this.leon_req.Click += new System.EventHandler(this.leon_req_Click);
            // 
            // add_coust
            // 
            this.add_coust.BackColor = System.Drawing.Color.Transparent;
            this.add_coust.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("add_coust.BackgroundImage")));
            this.add_coust.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.add_coust.FlatAppearance.BorderSize = 0;
            this.add_coust.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.add_coust.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.add_coust.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.add_coust.Location = new System.Drawing.Point(364, 501);
            this.add_coust.Name = "add_coust";
            this.add_coust.Size = new System.Drawing.Size(249, 79);
            this.add_coust.TabIndex = 3;
            this.add_coust.Text = "Add Coustomer";
            this.add_coust.UseVisualStyleBackColor = false;
            this.add_coust.Click += new System.EventHandler(this.add_coust_Click);
            // 
            // loens
            // 
            this.loens.Location = new System.Drawing.Point(82, 271);
            this.loens.Name = "loens";
            this.loens.Size = new System.Drawing.Size(535, 205);
            this.loens.TabIndex = 4;
            this.loens.UseCompatibleStateImageBehavior = false;
            // 
            // cus
            // 
            this.cus.Location = new System.Drawing.Point(82, 112);
            this.cus.Name = "cus";
            this.cus.Size = new System.Drawing.Size(535, 138);
            this.cus.TabIndex = 5;
            this.cus.UseCompatibleStateImageBehavior = false;
            // 
            // Employee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1151, 667);
            this.Controls.Add(this.cus);
            this.Controls.Add(this.loens);
            this.Controls.Add(this.add_coust);
            this.Controls.Add(this.leon_req);
            this.Controls.Add(this.back);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Employee";
            this.Text = "Employee";
            this.Load += new System.EventHandler(this.Employee_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Button back;
        private Button leon_req;
        private Button add_coust;
        private ListView loens;
        private ListView cus;
    }
}