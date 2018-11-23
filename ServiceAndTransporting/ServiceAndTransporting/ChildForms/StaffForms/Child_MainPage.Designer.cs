namespace ServiceAndTransporting
{
    partial class Child_MainPage
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
            this.StaffName = new System.Windows.Forms.Label();
            this.Surname = new System.Windows.Forms.Label();
            this.Label = new System.Windows.Forms.Label();
            this.CompanyPozition = new System.Windows.Forms.Label();
            this.StaffPhoto = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.StaffPhoto)).BeginInit();
            this.SuspendLayout();
            // 
            // StaffName
            // 
            this.StaffName.AutoSize = true;
            this.StaffName.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.StaffName.Location = new System.Drawing.Point(584, 169);
            this.StaffName.Name = "StaffName";
            this.StaffName.Size = new System.Drawing.Size(153, 73);
            this.StaffName.TabIndex = 1;
            this.StaffName.Text = "İsim";
            // 
            // Surname
            // 
            this.Surname.AutoSize = true;
            this.Surname.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Surname.Location = new System.Drawing.Point(584, 274);
            this.Surname.Name = "Surname";
            this.Surname.Size = new System.Drawing.Size(263, 73);
            this.Surname.TabIndex = 2;
            this.Surname.Text = "Soyisim";
            // 
            // Label
            // 
            this.Label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Label.AutoSize = true;
            this.Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Label.Location = new System.Drawing.Point(703, 627);
            this.Label.Name = "Label";
            this.Label.Size = new System.Drawing.Size(229, 31);
            this.Label.TabIndex = 3;
            this.Label.Text = "Şirket pozisyonu :";
            // 
            // CompanyPozition
            // 
            this.CompanyPozition.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CompanyPozition.AutoSize = true;
            this.CompanyPozition.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.CompanyPozition.Location = new System.Drawing.Point(938, 627);
            this.CompanyPozition.Name = "CompanyPozition";
            this.CompanyPozition.Size = new System.Drawing.Size(94, 31);
            this.CompanyPozition.TabIndex = 4;
            this.CompanyPozition.Text = "Görevi";
            // 
            // StaffPhoto
            // 
            this.StaffPhoto.Image = global::ServiceAndTransporting.Properties.Resources.PhotoAdd1;
            this.StaffPhoto.Location = new System.Drawing.Point(100, 80);
            this.StaffPhoto.Name = "StaffPhoto";
            this.StaffPhoto.Size = new System.Drawing.Size(420, 340);
            this.StaffPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.StaffPhoto.TabIndex = 0;
            this.StaffPhoto.TabStop = false;
            this.StaffPhoto.Click += new System.EventHandler(this.StaffPhoto_Click);
            // 
            // Child_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1109, 692);
            this.Controls.Add(this.CompanyPozition);
            this.Controls.Add(this.Label);
            this.Controls.Add(this.Surname);
            this.Controls.Add(this.StaffName);
            this.Controls.Add(this.StaffPhoto);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Child_Main";
            this.Opacity = 0D;
            ((System.ComponentModel.ISupportInitialize)(this.StaffPhoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox StaffPhoto;
        private System.Windows.Forms.Label StaffName;
        private System.Windows.Forms.Label Surname;
        private System.Windows.Forms.Label Label;
        private System.Windows.Forms.Label CompanyPozition;
    }
}