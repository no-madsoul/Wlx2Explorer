﻿namespace Wlx2Explorer.Forms
{
    partial class AboutForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutForm));
            this.lblProductName = new System.Windows.Forms.Label();
            this.lblCopyright = new System.Windows.Forms.Label();
            this.linkUrl = new System.Windows.Forms.LinkLabel();
            this.btnOk = new System.Windows.Forms.Button();
            this.pbImage = new System.Windows.Forms.PictureBox();
            this.lblProductTitle = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).BeginInit();
            this.SuspendLayout();
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.Location = new System.Drawing.Point(58, 21);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(75, 13);
            this.lblProductName.TabIndex = 0;
            this.lblProductName.Text = "Product Name";
            // 
            // lblCopyright
            // 
            this.lblCopyright.AutoSize = true;
            this.lblCopyright.Location = new System.Drawing.Point(58, 72);
            this.lblCopyright.Name = "lblCopyright";
            this.lblCopyright.Size = new System.Drawing.Size(51, 13);
            this.lblCopyright.TabIndex = 1;
            this.lblCopyright.Text = "Copyright";
            // 
            // linkUrl
            // 
            this.linkUrl.AutoSize = true;
            this.linkUrl.Location = new System.Drawing.Point(58, 95);
            this.linkUrl.Name = "linkUrl";
            this.linkUrl.Size = new System.Drawing.Size(29, 13);
            this.linkUrl.TabIndex = 2;
            this.linkUrl.TabStop = true;
            this.linkUrl.Text = "URL";
            this.linkUrl.Click += new System.EventHandler(this.LinkClick);
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(327, 16);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 3;
            this.btnOk.Text = "Ok";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.CloseClick);
            // 
            // pbImage
            // 
            this.pbImage.Image = ((System.Drawing.Image)(resources.GetObject("pbImage.Image")));
            this.pbImage.InitialImage = null;
            this.pbImage.Location = new System.Drawing.Point(4, 21);
            this.pbImage.Name = "pbImage";
            this.pbImage.Size = new System.Drawing.Size(48, 48);
            this.pbImage.TabIndex = 4;
            this.pbImage.TabStop = false;
            // 
            // lblProductTitle
            // 
            this.lblProductTitle.AutoSize = true;
            this.lblProductTitle.Location = new System.Drawing.Point(58, 47);
            this.lblProductTitle.Name = "lblProductTitle";
            this.lblProductTitle.Size = new System.Drawing.Size(67, 13);
            this.lblProductTitle.TabIndex = 5;
            this.lblProductTitle.Text = "Product Title";
            // 
            // AboutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 132);
            this.Controls.Add(this.lblProductTitle);
            this.Controls.Add(this.pbImage);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.linkUrl);
            this.Controls.Add(this.lblCopyright);
            this.Controls.Add(this.lblProductName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AboutForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "About";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormKeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.Label lblCopyright;
        private System.Windows.Forms.LinkLabel linkUrl;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.PictureBox pbImage;
        private System.Windows.Forms.Label lblProductTitle;
    }
}