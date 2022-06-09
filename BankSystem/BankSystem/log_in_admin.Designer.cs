namespace BankSystem
{
    partial class log_in_admin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(log_in_admin));
            this.log_in = new System.Windows.Forms.Button();
            this.user = new System.Windows.Forms.TextBox();
            this.pass = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // log_in
            // 
            this.log_in.BackColor = System.Drawing.Color.Transparent;
            this.log_in.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("log_in.BackgroundImage")));
            this.log_in.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.log_in.FlatAppearance.BorderSize = 0;
            this.log_in.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.log_in.Font = new System.Drawing.Font("Comic Sans MS", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.log_in.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.log_in.Location = new System.Drawing.Point(172, 467);
            this.log_in.Margin = new System.Windows.Forms.Padding(0);
            this.log_in.Name = "log_in";
            this.log_in.Size = new System.Drawing.Size(188, 56);
            this.log_in.TabIndex = 0;
            this.log_in.Text = "log in";
            this.log_in.UseVisualStyleBackColor = false;
            this.log_in.Click += new System.EventHandler(this.button1_Click);
            // 
            // user
            // 
            this.user.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(217)))), ((int)(((byte)(166)))));
            this.user.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.user.Location = new System.Drawing.Point(182, 240);
            this.user.Name = "user";
            this.user.Size = new System.Drawing.Size(153, 35);
            this.user.TabIndex = 1;
            this.user.Text = "username";
            this.user.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pass
            // 
            this.pass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(217)))), ((int)(((byte)(166)))));
            this.pass.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.pass.Location = new System.Drawing.Point(182, 304);
            this.pass.Name = "pass";
            this.pass.Size = new System.Drawing.Size(153, 35);
            this.pass.TabIndex = 2;
            this.pass.Text = "password";
            this.pass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // log_in_admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1160, 695);
            this.Controls.Add(this.pass);
            this.Controls.Add(this.user);
            this.Controls.Add(this.log_in);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "log_in_admin";
            this.Text = "log in  Admin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button log_in;
        private TextBox user;
        private TextBox pass;
    }
}