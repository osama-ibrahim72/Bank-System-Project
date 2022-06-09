namespace BankSystem
{
    partial class Log_cus
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Log_cus));
            this.log = new System.Windows.Forms.Button();
            this.pass = new System.Windows.Forms.TextBox();
            this.ssn = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // log
            // 
            this.log.BackColor = System.Drawing.Color.Transparent;
            this.log.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("log.BackgroundImage")));
            this.log.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.log.FlatAppearance.BorderSize = 0;
            this.log.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.log.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.log.ForeColor = System.Drawing.Color.Transparent;
            this.log.Location = new System.Drawing.Point(148, 378);
            this.log.Name = "log";
            this.log.Size = new System.Drawing.Size(169, 82);
            this.log.TabIndex = 0;
            this.log.Text = "Log in";
            this.log.UseVisualStyleBackColor = false;
            this.log.Click += new System.EventHandler(this.log_Click);
            // 
            // pass
            // 
            this.pass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(217)))), ((int)(((byte)(166)))));
            this.pass.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.pass.Location = new System.Drawing.Point(165, 227);
            this.pass.Name = "pass";
            this.pass.Size = new System.Drawing.Size(125, 35);
            this.pass.TabIndex = 1;
            this.pass.Text = "password";
            // 
            // ssn
            // 
            this.ssn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(217)))), ((int)(((byte)(166)))));
            this.ssn.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ssn.Location = new System.Drawing.Point(165, 157);
            this.ssn.Name = "ssn";
            this.ssn.Size = new System.Drawing.Size(125, 35);
            this.ssn.TabIndex = 2;
            this.ssn.Text = "SSN";
            // 
            // Log_cus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1073, 626);
            this.Controls.Add(this.ssn);
            this.Controls.Add(this.pass);
            this.Controls.Add(this.log);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Log_cus";
            this.Text = "log in ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button log;
        private TextBox pass;
        private TextBox ssn;
    }
}