namespace BankSystem
{
    partial class Customer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Customer));
            this.add_loen = new System.Windows.Forms.Button();
            this.add_acc = new System.Windows.Forms.Button();
            this.back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // add_loen
            // 
            this.add_loen.BackColor = System.Drawing.Color.Transparent;
            this.add_loen.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("add_loen.BackgroundImage")));
            this.add_loen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.add_loen.FlatAppearance.BorderSize = 0;
            this.add_loen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add_loen.Location = new System.Drawing.Point(149, 383);
            this.add_loen.Name = "add_loen";
            this.add_loen.Size = new System.Drawing.Size(195, 229);
            this.add_loen.TabIndex = 0;
            this.add_loen.UseVisualStyleBackColor = false;
            this.add_loen.Click += new System.EventHandler(this.add_loen_Click);
            // 
            // add_acc
            // 
            this.add_acc.BackColor = System.Drawing.Color.Transparent;
            this.add_acc.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("add_acc.BackgroundImage")));
            this.add_acc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.add_acc.FlatAppearance.BorderSize = 0;
            this.add_acc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add_acc.Location = new System.Drawing.Point(149, 113);
            this.add_acc.Name = "add_acc";
            this.add_acc.Size = new System.Drawing.Size(195, 225);
            this.add_acc.TabIndex = 1;
            this.add_acc.UseVisualStyleBackColor = false;
            this.add_acc.Click += new System.EventHandler(this.add_acc_Click);
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
            this.back.Location = new System.Drawing.Point(941, 626);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(131, 42);
            this.back.TabIndex = 2;
            this.back.Text = "back";
            this.back.UseVisualStyleBackColor = false;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // Customer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlText;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1133, 698);
            this.Controls.Add(this.back);
            this.Controls.Add(this.add_acc);
            this.Controls.Add(this.add_loen);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Customer";
            this.Text = "Customer";
            this.ResumeLayout(false);

        }

        #endregion

        private Button add_loen;
        private Button add_acc;
        private Button back;
    }
}