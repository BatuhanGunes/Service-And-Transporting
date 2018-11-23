namespace ServiceAndTransporting
{
    partial class LoginForm
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
            this.LogIn = new System.Windows.Forms.Button();
            this.Exits = new System.Windows.Forms.Button();
            this.StaffPassword = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.StaffName = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // LogIn
            // 
            this.LogIn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LogIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LogIn.Location = new System.Drawing.Point(233, 466);
            this.LogIn.Name = "LogIn";
            this.LogIn.Size = new System.Drawing.Size(306, 29);
            this.LogIn.TabIndex = 2;
            this.LogIn.Text = "Giriş Yap";
            this.LogIn.UseVisualStyleBackColor = true;
            this.LogIn.Click += new System.EventHandler(this.LogIn_Click);
            // 
            // Exits
            // 
            this.Exits.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Exits.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Exits.Location = new System.Drawing.Point(233, 501);
            this.Exits.Name = "Exits";
            this.Exits.Size = new System.Drawing.Size(306, 29);
            this.Exits.TabIndex = 3;
            this.Exits.Text = "Uygulamayı Kapat";
            this.Exits.UseVisualStyleBackColor = true;
            this.Exits.Click += new System.EventHandler(this.Exits_Click);
            // 
            // StaffPassword
            // 
            this.StaffPassword.AcceptsTab = true;
            this.StaffPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.StaffPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.StaffPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.StaffPassword.Location = new System.Drawing.Point(59, 18);
            this.StaffPassword.Name = "StaffPassword";
            this.StaffPassword.Size = new System.Drawing.Size(271, 19);
            this.StaffPassword.TabIndex = 1;
            this.StaffPassword.Tag = "";
            this.StaffPassword.UseSystemPasswordChar = true;
            // 
            // panel3
            // 
            this.panel3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel3.BackgroundImage = global::ServiceAndTransporting.Properties.Resources._31;
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel3.Controls.Add(this.StaffPassword);
            this.panel3.Location = new System.Drawing.Point(209, 363);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(358, 68);
            this.panel3.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel2.BackgroundImage = global::ServiceAndTransporting.Properties.Resources._21;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel2.Controls.Add(this.StaffName);
            this.panel2.Location = new System.Drawing.Point(209, 298);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(358, 59);
            this.panel2.TabIndex = 5;
            // 
            // StaffName
            // 
            this.StaffName.AcceptsTab = true;
            this.StaffName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.StaffName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.StaffName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.StaffName.Location = new System.Drawing.Point(59, 18);
            this.StaffName.Name = "StaffName";
            this.StaffName.Size = new System.Drawing.Size(271, 19);
            this.StaffName.TabIndex = 0;
            this.StaffName.Tag = "Personel İsmi";
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackgroundImage = global::ServiceAndTransporting.Properties.Resources.indir;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(760, 199);
            this.panel1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Calibri", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(108, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(574, 118);
            this.label1.TabIndex = 0;
            this.label1.Text = "SERVİS VE TAŞIMACILIK\r\nVERİTABANI OTOMASYONU";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(784, 584);
            this.ControlBox = false;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Exits);
            this.Controls.Add(this.LogIn);
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TopMost = true;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button LogIn;
        private System.Windows.Forms.Button Exits;
        private System.Windows.Forms.TextBox StaffPassword;
        private System.Windows.Forms.TextBox StaffName;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
    }
}

