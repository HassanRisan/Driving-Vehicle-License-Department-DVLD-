﻿namespace DVLD
{
    partial class FormShowPersonDetails
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
            this.userControlShowPersonDetails1 = new DVLD.UserControlShowPersonDetails();
            this.SuspendLayout();
            // 
            // userControlShowPersonDetails1
            // 
            this.userControlShowPersonDetails1.AutoSize = true;
            this.userControlShowPersonDetails1.Location = new System.Drawing.Point(12, 12);
            this.userControlShowPersonDetails1.Name = "userControlShowPersonDetails1";
            this.userControlShowPersonDetails1.Size = new System.Drawing.Size(1406, 590);
            this.userControlShowPersonDetails1.TabIndex = 0;
            this.userControlShowPersonDetails1.Load += new System.EventHandler(this.userControlShowPersonDetails1_Load);
            // 
            // FormShowPersonDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ClientSize = new System.Drawing.Size(1430, 616);
            this.Controls.Add(this.userControlShowPersonDetails1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormShowPersonDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormShowPersonDetails";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UserControlShowPersonDetails userControlShowPersonDetails1;
    }
}