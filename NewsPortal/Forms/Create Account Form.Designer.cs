using System;
using System.Windows.Forms;

namespace NewsPortal.Forms
{
    partial class Create_Account_Form
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonSwatch = new System.Windows.Forms.Button();
            this.userControlLogin1 = new NewsPortal.UserControlLogin();
            this.userControl2Register1 = new NewsPortal.UserControl2Register();
            this.SuspendLayout();
            // 
            // buttonSwatch
            // 
            this.buttonSwatch.Font = new System.Drawing.Font("Constantia", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSwatch.Location = new System.Drawing.Point(426, 569);
            this.buttonSwatch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonSwatch.Name = "buttonSwatch";
            this.buttonSwatch.Size = new System.Drawing.Size(244, 69);
            this.buttonSwatch.TabIndex = 10;
            this.buttonSwatch.Text = "Register";
            this.buttonSwatch.UseVisualStyleBackColor = true;
            this.buttonSwatch.Click += new System.EventHandler(this.buttonSwatch_Click);
            // 
            // userControlLogin1
            // 
            this.userControlLogin1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.userControlLogin1.Location = new System.Drawing.Point(-6, 2);
            this.userControlLogin1.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.userControlLogin1.Name = "userControlLogin1";
            this.userControlLogin1.Size = new System.Drawing.Size(1215, 527);
            this.userControlLogin1.TabIndex = 12;
            // 
            // userControl2Register1
            // 
            this.userControl2Register1.Location = new System.Drawing.Point(-6, 2);
            this.userControl2Register1.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.userControl2Register1.Name = "userControl2Register1";
            this.userControl2Register1.Size = new System.Drawing.Size(1215, 692);
            this.userControl2Register1.TabIndex = 13;
            this.userControl2Register1.Load += new System.EventHandler(this.userControl2Register1_Load);
            // 
            // Create_Account_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1196, 688);
            this.Controls.Add(this.userControl2Register1);
            this.Controls.Add(this.userControlLogin1);
            this.Controls.Add(this.buttonSwatch);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Create_Account_Form";
            this.Text = "Create Account";
            this.Load += new System.EventHandler(this.Create_Account_Form_Load);
            this.ResumeLayout(false);

        }

       

        #endregion
        private Button buttonSwatch;
        private UserControlLogin userControlLogin1;
        private UserControl2Register userControl2Register1;
    }
    }
