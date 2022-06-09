namespace BankSystem
{
    partial class add_employe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(add_employe));
            this.back = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.insert_emp = new System.Windows.Forms.Button();
            this.name = new System.Windows.Forms.TextBox();
            this.eid = new System.Windows.Forms.TextBox();
            this.branch = new System.Windows.Forms.TextBox();
            this.pass = new System.Windows.Forms.TextBox();
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
            this.back.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.back.Location = new System.Drawing.Point(970, 588);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(119, 42);
            this.back.TabIndex = 0;
            this.back.Text = "back";
            this.back.UseVisualStyleBackColor = false;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Location = new System.Drawing.Point(142, 496);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(191, 59);
            this.button1.TabIndex = 1;
            this.button1.Text = "update";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // delete
            // 
            this.delete.BackColor = System.Drawing.Color.Transparent;
            this.delete.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("delete.BackgroundImage")));
            this.delete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.delete.FlatAppearance.BorderSize = 0;
            this.delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.delete.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.delete.ForeColor = System.Drawing.Color.Transparent;
            this.delete.Location = new System.Drawing.Point(142, 442);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(191, 48);
            this.delete.TabIndex = 2;
            this.delete.Text = "delete";
            this.delete.UseVisualStyleBackColor = false;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // insert_emp
            // 
            this.insert_emp.BackColor = System.Drawing.Color.Transparent;
            this.insert_emp.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("insert_emp.BackgroundImage")));
            this.insert_emp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.insert_emp.FlatAppearance.BorderSize = 0;
            this.insert_emp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.insert_emp.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.insert_emp.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.insert_emp.Location = new System.Drawing.Point(142, 388);
            this.insert_emp.Name = "insert_emp";
            this.insert_emp.Size = new System.Drawing.Size(191, 48);
            this.insert_emp.TabIndex = 3;
            this.insert_emp.Text = "Add";
            this.insert_emp.UseVisualStyleBackColor = false;
            this.insert_emp.Click += new System.EventHandler(this.insert_emp_Click);
            // 
            // name
            // 
            this.name.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(217)))), ((int)(((byte)(166)))));
            this.name.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.name.Location = new System.Drawing.Point(86, 110);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(125, 35);
            this.name.TabIndex = 4;
            this.name.Text = "Name";
            // 
            // eid
            // 
            this.eid.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(217)))), ((int)(((byte)(166)))));
            this.eid.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.eid.Location = new System.Drawing.Point(235, 110);
            this.eid.Name = "eid";
            this.eid.Size = new System.Drawing.Size(125, 35);
            this.eid.TabIndex = 5;
            this.eid.Text = "ID";
            // 
            // branch
            // 
            this.branch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(217)))), ((int)(((byte)(166)))));
            this.branch.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.branch.Location = new System.Drawing.Point(86, 166);
            this.branch.Name = "branch";
            this.branch.Size = new System.Drawing.Size(125, 35);
            this.branch.TabIndex = 6;
            this.branch.Text = "Branch Id";
            // 
            // pass
            // 
            this.pass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(217)))), ((int)(((byte)(166)))));
            this.pass.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.pass.Location = new System.Drawing.Point(235, 166);
            this.pass.Name = "pass";
            this.pass.Size = new System.Drawing.Size(125, 35);
            this.pass.TabIndex = 7;
            this.pass.Text = "Password";
            // 
            // add_employe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1142, 661);
            this.Controls.Add(this.pass);
            this.Controls.Add(this.branch);
            this.Controls.Add(this.eid);
            this.Controls.Add(this.name);
            this.Controls.Add(this.insert_emp);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.back);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "add_employe";
            this.Text = "Add Employee";
            this.Load += new System.EventHandler(this.add_employe_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button back;
        private Button button1;
        private Button delete;
        private Button insert_emp;
        private TextBox name;
        private TextBox eid;
        private TextBox branch;
        private TextBox pass;
    }
}