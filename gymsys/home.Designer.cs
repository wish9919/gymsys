namespace WindowsFormsApplication1
{
    partial class home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(home));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.member = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.logoutButton = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(871, 33);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(186, 81);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // member
            // 
            this.member.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("member.BackgroundImage")));
            this.member.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.member.Cursor = System.Windows.Forms.Cursors.Hand;
            this.member.DialogResult = System.Windows.Forms.DialogResult.No;
            this.member.FlatAppearance.BorderSize = 0;
            this.member.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.member.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.member.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.member.Location = new System.Drawing.Point(165, 221);
            this.member.Name = "member";
            this.member.Size = new System.Drawing.Size(204, 209);
            this.member.TabIndex = 14;
            this.member.UseVisualStyleBackColor = false;
            this.member.Click += new System.EventHandler(this.member_Click);
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.DialogResult = System.Windows.Forms.DialogResult.No;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(435, 221);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(204, 209);
            this.button1.TabIndex = 15;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.DialogResult = System.Windows.Forms.DialogResult.No;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(705, 221);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(204, 209);
            this.button2.TabIndex = 16;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // logoutButton
            // 
            this.logoutButton.BackColor = System.Drawing.Color.DarkOrange;
            this.logoutButton.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.logoutButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.logoutButton.Location = new System.Drawing.Point(38, 33);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(133, 43);
            this.logoutButton.TabIndex = 17;
            this.logoutButton.Text = "LOGOUT";
            this.logoutButton.UseCustomBackColor = true;
            this.logoutButton.UseCustomForeColor = true;
            this.logoutButton.UseSelectable = true;
            this.logoutButton.Click += new System.EventHandler(this.logoutButton_Click);
            // 
            // home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1080, 800);
            this.Controls.Add(this.logoutButton);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.member);
            this.Controls.Add(this.pictureBox1);
            this.DisplayHeader = false;
            this.MaximizeBox = false;
            this.Movable = false;
            this.Name = "home";
            this.Padding = new System.Windows.Forms.Padding(20, 30, 20, 20);
            this.Resizable = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Style = MetroFramework.MetroColorStyle.Orange;
            this.Text = "Gym Management System - GYMSYS";
            this.TopMost = true;
            this.Activated += new System.EventHandler(this.home_Activated);
          
            this.Load += new System.EventHandler(this.home_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button member;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private MetroFramework.Controls.MetroButton logoutButton;


    }
}

