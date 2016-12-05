namespace Applicant_Reviewer.Forms
{
    partial class ViewApplicants
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
            this.ApplicantList = new System.Windows.Forms.ListBox();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(17, 184);
            this.metroButton1.Margin = new System.Windows.Forms.Padding(2);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(118, 28);
            this.metroButton1.TabIndex = 0;
            this.metroButton1.Text = "View Applicant Info";
            this.metroButton1.Click += new System.EventHandler(this.ViewApplicantInfo);
            // 
            // ApplicantList
            // 
            this.ApplicantList.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ApplicantList.FormattingEnabled = true;
            this.ApplicantList.ItemHeight = 19;
            this.ApplicantList.Location = new System.Drawing.Point(17, 51);
            this.ApplicantList.Margin = new System.Windows.Forms.Padding(2);
            this.ApplicantList.Name = "ApplicantList";
            this.ApplicantList.Size = new System.Drawing.Size(260, 99);
            this.ApplicantList.TabIndex = 2;
            // 
            // metroButton2
            // 
            this.metroButton2.Location = new System.Drawing.Point(219, 184);
            this.metroButton2.Margin = new System.Windows.Forms.Padding(2);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(58, 28);
            this.metroButton2.TabIndex = 3;
            this.metroButton2.Text = "Help";
            this.metroButton2.Click += new System.EventHandler(this.HelpButton);
            // 
            // ViewApplications
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(294, 230);
            this.Controls.Add(this.metroButton2);
            this.Controls.Add(this.ApplicantList);
            this.Controls.Add(this.metroButton1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ViewApplications";
            this.Padding = new System.Windows.Forms.Padding(15, 60, 15, 16);
            this.Resizable = false;
            this.Text = "View Applications";
            this.Load += new System.EventHandler(this.ViewApplicationsLoad);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroButton metroButton1;
        private System.Windows.Forms.ListBox ApplicantList;
        private MetroFramework.Controls.MetroButton metroButton2;
    }
}