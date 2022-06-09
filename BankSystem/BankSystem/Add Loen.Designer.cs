namespace BankSystem
{
    partial class Add_loen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Add_loen));
            this.back = new System.Windows.Forms.Button();
            this.add = new System.Windows.Forms.Button();
            this.loen_offer = new System.Windows.Forms.ComboBox();
            this.lnum = new System.Windows.Forms.TextBox();
            this.ssn = new System.Windows.Forms.TextBox();
            this.amount = new System.Windows.Forms.TextBox();
            this.anum = new System.Windows.Forms.TextBox();
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
            this.back.Location = new System.Drawing.Point(928, 587);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(111, 43);
            this.back.TabIndex = 0;
            this.back.Text = "back";
            this.back.UseVisualStyleBackColor = false;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // add
            // 
            this.add.BackColor = System.Drawing.Color.Transparent;
            this.add.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("add.BackgroundImage")));
            this.add.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.add.FlatAppearance.BorderSize = 0;
            this.add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.add.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.add.Location = new System.Drawing.Point(151, 525);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(135, 54);
            this.add.TabIndex = 1;
            this.add.Text = "Add";
            this.add.UseVisualStyleBackColor = false;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // loen_offer
            // 
            this.loen_offer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(217)))), ((int)(((byte)(166)))));
            this.loen_offer.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.loen_offer.FormattingEnabled = true;
            this.loen_offer.Location = new System.Drawing.Point(356, 87);
            this.loen_offer.Name = "loen_offer";
            this.loen_offer.Size = new System.Drawing.Size(151, 36);
            this.loen_offer.TabIndex = 3;
            this.loen_offer.Text = "loen offer";
            // 
            // lnum
            // 
            this.lnum.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(217)))), ((int)(((byte)(166)))));
            this.lnum.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lnum.Location = new System.Drawing.Point(151, 200);
            this.lnum.Name = "lnum";
            this.lnum.Size = new System.Drawing.Size(156, 35);
            this.lnum.TabIndex = 4;
            this.lnum.Text = "Loen Number";
            // 
            // ssn
            // 
            this.ssn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(217)))), ((int)(((byte)(166)))));
            this.ssn.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ssn.Location = new System.Drawing.Point(151, 159);
            this.ssn.Name = "ssn";
            this.ssn.Size = new System.Drawing.Size(156, 35);
            this.ssn.TabIndex = 5;
            this.ssn.Text = "ssn";
            // 
            // amount
            // 
            this.amount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(217)))), ((int)(((byte)(166)))));
            this.amount.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.amount.Location = new System.Drawing.Point(151, 282);
            this.amount.Name = "amount";
            this.amount.Size = new System.Drawing.Size(156, 35);
            this.amount.TabIndex = 6;
            this.amount.Text = "Amount";
            // 
            // anum
            // 
            this.anum.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(217)))), ((int)(((byte)(166)))));
            this.anum.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.anum.Location = new System.Drawing.Point(151, 241);
            this.anum.Name = "anum";
            this.anum.Size = new System.Drawing.Size(156, 35);
            this.anum.TabIndex = 7;
            this.anum.Text = "Account number";
            // 
            // Add_loen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1086, 654);
            this.Controls.Add(this.anum);
            this.Controls.Add(this.amount);
            this.Controls.Add(this.ssn);
            this.Controls.Add(this.lnum);
            this.Controls.Add(this.loen_offer);
            this.Controls.Add(this.add);
            this.Controls.Add(this.back);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Add_loen";
            this.Text = "Add Loen";
            this.Load += new System.EventHandler(this.Add_loen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button back;
        private Button add;
        private ComboBox loen_offer;
        private TextBox lnum;
        private TextBox ssn;
        private TextBox amount;
        private TextBox anum;
    }
}