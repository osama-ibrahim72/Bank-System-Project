namespace BankSystem
{
    partial class Add_bank
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Add_bank));
            this.back = new System.Windows.Forms.Button();
            this.code = new System.Windows.Forms.TextBox();
            this.name = new System.Windows.Forms.TextBox();
            this.state = new System.Windows.Forms.TextBox();
            this.insert_bank = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.update = new System.Windows.Forms.Button();
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
            this.back.Location = new System.Drawing.Point(974, 624);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(115, 40);
            this.back.TabIndex = 5;
            this.back.Text = "Back";
            this.back.UseVisualStyleBackColor = false;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // code
            // 
            this.code.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(217)))), ((int)(((byte)(166)))));
            this.code.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.code.Location = new System.Drawing.Point(218, 180);
            this.code.Name = "code";
            this.code.Size = new System.Drawing.Size(125, 35);
            this.code.TabIndex = 6;
            this.code.Text = "code";
            // 
            // name
            // 
            this.name.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(217)))), ((int)(((byte)(166)))));
            this.name.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.name.Location = new System.Drawing.Point(218, 239);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(125, 35);
            this.name.TabIndex = 7;
            this.name.Text = "name";
            // 
            // state
            // 
            this.state.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(217)))), ((int)(((byte)(166)))));
            this.state.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.state.Location = new System.Drawing.Point(218, 295);
            this.state.Name = "state";
            this.state.Size = new System.Drawing.Size(125, 35);
            this.state.TabIndex = 9;
            this.state.Text = "state";
            // 
            // insert_bank
            // 
            this.insert_bank.BackColor = System.Drawing.Color.Transparent;
            this.insert_bank.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("insert_bank.BackgroundImage")));
            this.insert_bank.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.insert_bank.FlatAppearance.BorderSize = 0;
            this.insert_bank.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.insert_bank.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.insert_bank.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.insert_bank.Location = new System.Drawing.Point(164, 410);
            this.insert_bank.Name = "insert_bank";
            this.insert_bank.Size = new System.Drawing.Size(130, 48);
            this.insert_bank.TabIndex = 11;
            this.insert_bank.Text = "Add";
            this.insert_bank.UseVisualStyleBackColor = false;
            this.insert_bank.Click += new System.EventHandler(this.insert_bank_Click);
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
            this.delete.Location = new System.Drawing.Point(164, 476);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(130, 52);
            this.delete.TabIndex = 13;
            this.delete.Text = "delete";
            this.delete.UseVisualStyleBackColor = false;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // update
            // 
            this.update.BackColor = System.Drawing.Color.Transparent;
            this.update.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("update.BackgroundImage")));
            this.update.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.update.FlatAppearance.BorderSize = 0;
            this.update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.update.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.update.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.update.Location = new System.Drawing.Point(164, 543);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(130, 59);
            this.update.TabIndex = 14;
            this.update.Text = "update";
            this.update.UseVisualStyleBackColor = false;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // Add_bank
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1128, 692);
            this.Controls.Add(this.update);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.insert_bank);
            this.Controls.Add(this.state);
            this.Controls.Add(this.name);
            this.Controls.Add(this.code);
            this.Controls.Add(this.back);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Add_bank";
            this.Text = "Add Bank";
            this.Load += new System.EventHandler(this.Add_bank_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button back;
        private TextBox code;
        private TextBox name;
        private TextBox state;
        private Button insert_bank;
        private Button delete;
        private Button update;
    }
}