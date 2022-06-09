namespace BankSystem
{
    partial class Add_branch
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Add_branch));
            this.back = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.inserrt_branch = new System.Windows.Forms.Button();
            this.bank = new System.Windows.Forms.TextBox();
            this.code = new System.Windows.Forms.TextBox();
            this.city = new System.Windows.Forms.TextBox();
            this.street = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // back
            // 
            this.back.BackColor = System.Drawing.Color.Transparent;
            this.back.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("back.BackgroundImage")));
            this.back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.back.FlatAppearance.BorderSize = 0;
            this.back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.back.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.back.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.back.Location = new System.Drawing.Point(979, 586);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(108, 34);
            this.back.TabIndex = 0;
            this.back.Text = "back";
            this.back.UseVisualStyleBackColor = false;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // delete
            // 
            this.delete.BackColor = System.Drawing.Color.Transparent;
            this.delete.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("delete.BackgroundImage")));
            this.delete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.delete.FlatAppearance.BorderSize = 0;
            this.delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.delete.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.delete.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.delete.Location = new System.Drawing.Point(75, 516);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(198, 60);
            this.delete.TabIndex = 2;
            this.delete.Text = "delete";
            this.delete.UseVisualStyleBackColor = false;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // inserrt_branch
            // 
            this.inserrt_branch.BackColor = System.Drawing.Color.Transparent;
            this.inserrt_branch.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("inserrt_branch.BackgroundImage")));
            this.inserrt_branch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.inserrt_branch.FlatAppearance.BorderSize = 0;
            this.inserrt_branch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.inserrt_branch.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.inserrt_branch.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.inserrt_branch.Location = new System.Drawing.Point(75, 430);
            this.inserrt_branch.Name = "inserrt_branch";
            this.inserrt_branch.Size = new System.Drawing.Size(198, 61);
            this.inserrt_branch.TabIndex = 3;
            this.inserrt_branch.Text = "add branche";
            this.inserrt_branch.UseVisualStyleBackColor = false;
            this.inserrt_branch.Click += new System.EventHandler(this.inserrt_branch_Click);
            // 
            // bank
            // 
            this.bank.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(217)))), ((int)(((byte)(166)))));
            this.bank.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bank.Location = new System.Drawing.Point(75, 115);
            this.bank.Name = "bank";
            this.bank.Size = new System.Drawing.Size(125, 35);
            this.bank.TabIndex = 4;
            this.bank.Text = "ID of Bank";
            // 
            // code
            // 
            this.code.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(217)))), ((int)(((byte)(166)))));
            this.code.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.code.Location = new System.Drawing.Point(232, 115);
            this.code.Name = "code";
            this.code.Size = new System.Drawing.Size(131, 35);
            this.code.TabIndex = 5;
            this.code.Text = "ID of branch";
            // 
            // city
            // 
            this.city.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(217)))), ((int)(((byte)(166)))));
            this.city.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.city.Location = new System.Drawing.Point(75, 189);
            this.city.Name = "city";
            this.city.Size = new System.Drawing.Size(125, 35);
            this.city.TabIndex = 6;
            this.city.Text = "City";
            // 
            // street
            // 
            this.street.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(217)))), ((int)(((byte)(166)))));
            this.street.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.street.Location = new System.Drawing.Point(232, 189);
            this.street.Name = "street";
            this.street.Size = new System.Drawing.Size(131, 35);
            this.street.TabIndex = 7;
            this.street.Text = "Street";
            // 
            // Add_branch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1130, 645);
            this.Controls.Add(this.street);
            this.Controls.Add(this.city);
            this.Controls.Add(this.code);
            this.Controls.Add(this.bank);
            this.Controls.Add(this.inserrt_branch);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.back);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Add_branch";
            this.Text = "Add Branch";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button back;
        private Button delete;
        private Button inserrt_branch;
        private TextBox bank;
        private TextBox code;
        private TextBox city;
        private TextBox street;
    }
}