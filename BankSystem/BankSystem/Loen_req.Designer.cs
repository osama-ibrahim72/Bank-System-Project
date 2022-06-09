namespace BankSystem
{
    partial class Loen_req
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Loen_req));
            this.req = new System.Windows.Forms.ComboBox();
            this.accept = new System.Windows.Forms.Button();
            this.reject = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // req
            // 
            this.req.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.req.FormattingEnabled = true;
            this.req.Location = new System.Drawing.Point(116, 129);
            this.req.Name = "req";
            this.req.Size = new System.Drawing.Size(366, 36);
            this.req.TabIndex = 0;
            this.req.Text = "Requests";
            // 
            // accept
            // 
            this.accept.BackColor = System.Drawing.Color.Transparent;
            this.accept.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("accept.BackgroundImage")));
            this.accept.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.accept.FlatAppearance.BorderSize = 0;
            this.accept.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.accept.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.accept.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.accept.Location = new System.Drawing.Point(88, 435);
            this.accept.Name = "accept";
            this.accept.Size = new System.Drawing.Size(140, 59);
            this.accept.TabIndex = 1;
            this.accept.Text = "Accept";
            this.accept.UseVisualStyleBackColor = false;
            this.accept.Click += new System.EventHandler(this.accept_Click);
            // 
            // reject
            // 
            this.reject.BackColor = System.Drawing.Color.Transparent;
            this.reject.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("reject.BackgroundImage")));
            this.reject.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.reject.FlatAppearance.BorderSize = 0;
            this.reject.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reject.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.reject.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.reject.Location = new System.Drawing.Point(256, 435);
            this.reject.Name = "reject";
            this.reject.Size = new System.Drawing.Size(148, 59);
            this.reject.TabIndex = 2;
            this.reject.Text = "Reject";
            this.reject.UseVisualStyleBackColor = false;
            this.reject.Click += new System.EventHandler(this.reject_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Location = new System.Drawing.Point(928, 553);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 37);
            this.button1.TabIndex = 3;
            this.button1.Text = "back";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Loen_req
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1074, 623);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.reject);
            this.Controls.Add(this.accept);
            this.Controls.Add(this.req);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Loen_req";
            this.Text = "loen req";
            this.Load += new System.EventHandler(this.Loen_req_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private ComboBox req;
        private Button accept;
        private Button reject;
        private Button button1;
    }
}