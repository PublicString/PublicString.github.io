using System;

namespace Applicant_Reviewer.Forms
{
    partial class ApplicantInformation
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
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.metroButton3 = new MetroFramework.Controls.MetroButton();
            this.metroButton4 = new MetroFramework.Controls.MetroButton();
            this.metroButton5 = new MetroFramework.Controls.MetroButton();
            this.cvBtn = new MetroFramework.Controls.MetroButton();
            this.coverLetterBtn = new MetroFramework.Controls.MetroButton();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.applicantName = new MetroFramework.Controls.MetroLabel();
            this.applicantAddress1 = new MetroFramework.Controls.MetroLabel();
            this.applicantAddress2 = new MetroFramework.Controls.MetroLabel();
            this.applicantPostcode = new MetroFramework.Controls.MetroLabel();
            this.acceptRadio = new MetroFramework.Controls.MetroRadioButton();
            this.declineRadio = new MetroFramework.Controls.MetroRadioButton();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.applicantMobile = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(24, 269);
            this.metroButton1.Margin = new System.Windows.Forms.Padding(2);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(104, 32);
            this.metroButton1.TabIndex = 3;
            this.metroButton1.Text = "Create Feedback";
            this.metroButton1.Click += new System.EventHandler(this.CreateTemplate);
            // 
            // metroButton2
            // 
            this.metroButton2.Location = new System.Drawing.Point(140, 269);
            this.metroButton2.Margin = new System.Windows.Forms.Padding(2);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(50, 32);
            this.metroButton2.TabIndex = 4;
            this.metroButton2.Text = "Edit";
            // 
            // metroButton3
            // 
            this.metroButton3.Location = new System.Drawing.Point(202, 269);
            this.metroButton3.Margin = new System.Windows.Forms.Padding(2);
            this.metroButton3.Name = "metroButton3";
            this.metroButton3.Size = new System.Drawing.Size(106, 32);
            this.metroButton3.TabIndex = 5;
            this.metroButton3.Text = "View Preview";
            // 
            // metroButton4
            // 
            this.metroButton4.Location = new System.Drawing.Point(24, 329);
            this.metroButton4.Margin = new System.Windows.Forms.Padding(2);
            this.metroButton4.Name = "metroButton4";
            this.metroButton4.Size = new System.Drawing.Size(68, 23);
            this.metroButton4.TabIndex = 7;
            this.metroButton4.Text = "Back";
            this.metroButton4.Click += new System.EventHandler(this.BackButton);
            // 
            // metroButton5
            // 
            this.metroButton5.Location = new System.Drawing.Point(242, 329);
            this.metroButton5.Margin = new System.Windows.Forms.Padding(2);
            this.metroButton5.Name = "metroButton5";
            this.metroButton5.Size = new System.Drawing.Size(68, 23);
            this.metroButton5.TabIndex = 8;
            this.metroButton5.Text = "Help";
            this.metroButton5.Click += new System.EventHandler(this.HelpButton);
            // 
            // cvBtn
            // 
            this.cvBtn.Location = new System.Drawing.Point(24, 200);
            this.cvBtn.Name = "cvBtn";
            this.cvBtn.Size = new System.Drawing.Size(104, 23);
            this.cvBtn.TabIndex = 9;
            this.cvBtn.Text = "View CV";
            this.cvBtn.Click += new System.EventHandler(this.CvBtnClick);
            // 
            // coverLetterBtn
            // 
            this.coverLetterBtn.Location = new System.Drawing.Point(202, 200);
            this.coverLetterBtn.Name = "coverLetterBtn";
            this.coverLetterBtn.Size = new System.Drawing.Size(106, 23);
            this.coverLetterBtn.TabIndex = 10;
            this.coverLetterBtn.Text = "View Cover Letter";
            this.coverLetterBtn.Click += new System.EventHandler(this.CoverLetterBtnClick);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(24, 71);
            this.metroLabel1.Margin = new System.Windows.Forms.Padding(0);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(107, 19);
            this.metroLabel1.TabIndex = 11;
            this.metroLabel1.Text = "Applicant Name:";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(24, 90);
            this.metroLabel2.Margin = new System.Windows.Forms.Padding(0);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(115, 19);
            this.metroLabel2.TabIndex = 12;
            this.metroLabel2.Text = "Address Line One:";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(24, 109);
            this.metroLabel3.Margin = new System.Windows.Forms.Padding(0);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(113, 19);
            this.metroLabel3.TabIndex = 13;
            this.metroLabel3.Text = "Address Line Two:";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(24, 128);
            this.metroLabel4.Margin = new System.Windows.Forms.Padding(0);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(65, 19);
            this.metroLabel4.TabIndex = 14;
            this.metroLabel4.Text = "Postcode:";
            // 
            // applicantName
            // 
            this.applicantName.AutoSize = true;
            this.applicantName.Location = new System.Drawing.Point(165, 71);
            this.applicantName.Name = "applicantName";
            this.applicantName.Size = new System.Drawing.Size(0, 0);
            this.applicantName.TabIndex = 15;
            // 
            // applicantAddress1
            // 
            this.applicantAddress1.AutoSize = true;
            this.applicantAddress1.Location = new System.Drawing.Point(165, 90);
            this.applicantAddress1.Name = "applicantAddress1";
            this.applicantAddress1.Size = new System.Drawing.Size(0, 0);
            this.applicantAddress1.TabIndex = 16;
            // 
            // applicantAddress2
            // 
            this.applicantAddress2.AutoSize = true;
            this.applicantAddress2.Location = new System.Drawing.Point(165, 109);
            this.applicantAddress2.Name = "applicantAddress2";
            this.applicantAddress2.Size = new System.Drawing.Size(0, 0);
            this.applicantAddress2.TabIndex = 17;
            // 
            // applicantPostcode
            // 
            this.applicantPostcode.AutoSize = true;
            this.applicantPostcode.Location = new System.Drawing.Point(165, 128);
            this.applicantPostcode.Name = "applicantPostcode";
            this.applicantPostcode.Size = new System.Drawing.Size(0, 0);
            this.applicantPostcode.TabIndex = 18;
            // 
            // acceptRadio
            // 
            this.acceptRadio.AutoSize = true;
            this.acceptRadio.Location = new System.Drawing.Point(68, 239);
            this.acceptRadio.Name = "acceptRadio";
            this.acceptRadio.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.acceptRadio.Size = new System.Drawing.Size(60, 15);
            this.acceptRadio.TabIndex = 19;
            this.acceptRadio.TabStop = true;
            this.acceptRadio.Text = "Accept";
            this.acceptRadio.UseVisualStyleBackColor = true;
            // 
            // declineRadio
            // 
            this.declineRadio.AutoSize = true;
            this.declineRadio.Location = new System.Drawing.Point(202, 239);
            this.declineRadio.Name = "declineRadio";
            this.declineRadio.Size = new System.Drawing.Size(62, 15);
            this.declineRadio.TabIndex = 19;
            this.declineRadio.TabStop = true;
            this.declineRadio.Text = "Decline";
            this.declineRadio.UseVisualStyleBackColor = true;
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(24, 147);
            this.metroLabel5.Margin = new System.Windows.Forms.Padding(0);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(53, 19);
            this.metroLabel5.TabIndex = 14;
            this.metroLabel5.Text = "Mobile:";
            // 
            // applicantMobile
            // 
            this.applicantMobile.AutoSize = true;
            this.applicantMobile.Location = new System.Drawing.Point(165, 147);
            this.applicantMobile.Name = "applicantMobile";
            this.applicantMobile.Size = new System.Drawing.Size(0, 0);
            this.applicantMobile.TabIndex = 18;
            // 
            // ApplicantInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 374);
            this.Controls.Add(this.acceptRadio);
            this.Controls.Add(this.applicantMobile);
            this.Controls.Add(this.applicantPostcode);
            this.Controls.Add(this.applicantAddress2);
            this.Controls.Add(this.applicantAddress1);
            this.Controls.Add(this.applicantName);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.coverLetterBtn);
            this.Controls.Add(this.cvBtn);
            this.Controls.Add(this.metroButton5);
            this.Controls.Add(this.metroButton4);
            this.Controls.Add(this.metroButton3);
            this.Controls.Add(this.metroButton2);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.declineRadio);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "ApplicantInformation";
            this.Padding = new System.Windows.Forms.Padding(15, 60, 15, 16);
            this.Resizable = false;
            this.Text = "Applicant Information";
            this.Load += new System.EventHandler(this.ApplicantInformationLoad);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroButton metroButton2;
        private MetroFramework.Controls.MetroButton metroButton3;
        private MetroFramework.Controls.MetroButton metroButton4;
        private MetroFramework.Controls.MetroButton metroButton5;
        private MetroFramework.Controls.MetroButton cvBtn;
        private MetroFramework.Controls.MetroButton coverLetterBtn;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel applicantName;
        private MetroFramework.Controls.MetroLabel applicantAddress1;
        private MetroFramework.Controls.MetroLabel applicantAddress2;
        private MetroFramework.Controls.MetroLabel applicantPostcode;
        private MetroFramework.Controls.MetroRadioButton acceptRadio;
        private MetroFramework.Controls.MetroRadioButton declineRadio;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel applicantMobile;
    }
}