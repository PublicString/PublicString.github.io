namespace Applicant_Reviewer.Forms
{
    partial class ViewPositions
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
            if (disposing && (this.components != null))
            {
                this.components.Dispose();
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
            this.ViewApplicantBtn = new MetroFramework.Controls.MetroButton();
            this.PositionList = new System.Windows.Forms.ListBox();
            this.BackBtn = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // ViewApplicantBtn
            // 
            this.ViewApplicantBtn.Location = new System.Drawing.Point(153, 226);
            this.ViewApplicantBtn.Name = "ViewApplicantBtn";
            this.ViewApplicantBtn.Size = new System.Drawing.Size(124, 23);
            this.ViewApplicantBtn.TabIndex = 1;
            this.ViewApplicantBtn.Text = "View Applicant Info";
            this.ViewApplicantBtn.Click += new System.EventHandler(this.ViewApplicantBtnClick);
            // 
            // PositionList
            // 
            this.PositionList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PositionList.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PositionList.FormattingEnabled = true;
            this.PositionList.ItemHeight = 17;
            this.PositionList.Location = new System.Drawing.Point(24, 64);
            this.PositionList.Name = "PositionList";
            this.PositionList.Size = new System.Drawing.Size(253, 155);
            this.PositionList.TabIndex = 2;
            // 
            // BackBtn
            // 
            this.BackBtn.Location = new System.Drawing.Point(24, 226);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(75, 23);
            this.BackBtn.TabIndex = 3;
            this.BackBtn.Text = "Back";
            this.BackBtn.Click += new System.EventHandler(this.BackBtnClick);
            // 
            // ViewPositions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 272);
            this.Controls.Add(this.BackBtn);
            this.Controls.Add(this.PositionList);
            this.Controls.Add(this.ViewApplicantBtn);
            this.Name = "ViewPositions";
            this.Resizable = false;
            this.Text = "View Positions";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ViewPositionsFormFormClosing);
            this.Load += new System.EventHandler(this.ViewPositionsFormLoad);
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Controls.MetroButton ViewApplicantBtn;
        private System.Windows.Forms.ListBox PositionList;
        private MetroFramework.Controls.MetroButton BackBtn;
    }
}