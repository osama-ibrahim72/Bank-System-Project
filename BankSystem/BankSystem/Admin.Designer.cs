namespace BankSystem
{
    partial class Admin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin));
            this.Back = new System.Windows.Forms.Button();
            this.add_emp = new System.Windows.Forms.Button();
            this.add_bank = new System.Windows.Forms.Button();
            this.add_branch = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Back
            // 
            this.Back.BackColor = System.Drawing.Color.Transparent;
            this.Back.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Back.BackgroundImage")));
            this.Back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Back.FlatAppearance.BorderSize = 0;
            this.Back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Back.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Back.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Back.Location = new System.Drawing.Point(953, 600);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(128, 41);
            this.Back.TabIndex = 0;
            this.Back.Text = "Back";
            this.Back.UseVisualStyleBackColor = false;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // add_emp
            // 
            this.add_emp.BackColor = System.Drawing.Color.Transparent;
            this.add_emp.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("add_emp.BackgroundImage")));
            this.add_emp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.add_emp.FlatAppearance.BorderSize = 0;
            this.add_emp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add_emp.Location = new System.Drawing.Point(193, 131);
            this.add_emp.Name = "add_emp";
            this.add_emp.Size = new System.Drawing.Size(220, 210);
            this.add_emp.TabIndex = 1;
            this.add_emp.UseVisualStyleBackColor = false;
            this.add_emp.Click += new System.EventHandler(this.add_emp_Click);
            // 
            // add_bank
            // 
            this.add_bank.BackColor = System.Drawing.Color.Transparent;
            this.add_bank.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("add_bank.BackgroundImage")));
            this.add_bank.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.add_bank.FlatAppearance.BorderSize = 0;
            this.add_bank.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add_bank.Location = new System.Drawing.Point(86, 396);
            this.add_bank.Name = "add_bank";
            this.add_bank.Size = new System.Drawing.Size(200, 213);
            this.add_bank.TabIndex = 2;
            this.add_bank.UseVisualStyleBackColor = false;
            this.add_bank.Click += new System.EventHandler(this.add_bank_Click);
            // 
            // add_branch
            // 
            this.add_branch.BackColor = System.Drawing.Color.Transparent;
            this.add_branch.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("add_branch.BackgroundImage")));
            this.add_branch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.add_branch.FlatAppearance.BorderSize = 0;
            this.add_branch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add_branch.Location = new System.Drawing.Point(324, 401);
            this.add_branch.Name = "add_branch";
            this.add_branch.Size = new System.Drawing.Size(201, 202);
            this.add_branch.TabIndex = 3;
            this.add_branch.UseVisualStyleBackColor = false;
            this.add_branch.Click += new System.EventHandler(this.add_branch_Click);
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1152, 669);
            this.Controls.Add(this.add_branch);
            this.Controls.Add(this.add_bank);
            this.Controls.Add(this.add_emp);
            this.Controls.Add(this.Back);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Admin";
            this.Text = "Admin";
            this.Load += new System.EventHandler(this.Admin_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Button Back;
        private Button add_emp;
        private Button add_bank;
        private Button add_branch;
    }
}