namespace Applicant_Reviewer.Forms
{
    partial class CreatePosition
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
            this.PosTitleBox = new MetroFramework.Controls.MetroTextBox();
            this.PosSalaryBox = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.CreateBtn = new MetroFramework.Controls.MetroButton();
            this.BackBtn = new MetroFramework.Controls.MetroButton();
            this.StartDatePicker = new System.Windows.Forms.DateTimePicker();
            this.CurrencyBox = new MetroFramework.Controls.MetroComboBox();
            this.SuspendLayout();
            // 
            // PosTitleBox
            // 
            this.PosTitleBox.Location = new System.Drawing.Point(149, 65);
            this.PosTitleBox.Name = "PosTitleBox";
            this.PosTitleBox.PromptText = "eg. Receptionist";
            this.PosTitleBox.Size = new System.Drawing.Size(244, 25);
            this.PosTitleBox.TabIndex = 0;
            this.PosTitleBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // PosSalaryBox
            // 
            this.PosSalaryBox.Location = new System.Drawing.Point(201, 96);
            this.PosSalaryBox.Name = "PosSalaryBox";
            this.PosSalaryBox.PromptText = "eg. 15000";
            this.PosSalaryBox.Size = new System.Drawing.Size(192, 25);
            this.PosSalaryBox.TabIndex = 1;
            this.PosSalaryBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(23, 71);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(82, 19);
            this.metroLabel1.TabIndex = 3;
            this.metroLabel1.Text = "Position Title";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(23, 102);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(94, 19);
            this.metroLabel2.TabIndex = 4;
            this.metroLabel2.Text = "Position Salary";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(23, 131);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(68, 19);
            this.metroLabel3.TabIndex = 5;
            this.metroLabel3.Text = "Start Date";
            // 
            // CreateBtn
            // 
            this.CreateBtn.Location = new System.Drawing.Point(235, 183);
            this.CreateBtn.Name = "CreateBtn";
            this.CreateBtn.Size = new System.Drawing.Size(75, 23);
            this.CreateBtn.TabIndex = 8;
            this.CreateBtn.Text = "Create";
            this.CreateBtn.Click += new System.EventHandler(this.CreateBtnClick);
            // 
            // BackBtn
            // 
            this.BackBtn.Location = new System.Drawing.Point(97, 183);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(75, 23);
            this.BackBtn.TabIndex = 9;
            this.BackBtn.Text = "Back";
            this.BackBtn.Click += new System.EventHandler(this.BackBtnClick);
            // 
            // StartDatePicker
            // 
            this.StartDatePicker.CalendarMonthBackground = System.Drawing.Color.DarkGray;
            this.StartDatePicker.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.StartDatePicker.Location = new System.Drawing.Point(149, 127);
            this.StartDatePicker.MinimumSize = new System.Drawing.Size(244, 23);
            this.StartDatePicker.Name = "StartDatePicker";
            this.StartDatePicker.Size = new System.Drawing.Size(244, 23);
            this.StartDatePicker.TabIndex = 10;
            // 
            // CurrencyBox
            // 
            this.CurrencyBox.FontSize = MetroFramework.MetroLinkSize.Small;
            this.CurrencyBox.FormattingEnabled = true;
            this.CurrencyBox.ItemHeight = 19;
            this.CurrencyBox.Items.AddRange(new object[] {
            "£",
            "$",
            "€",
            "‎¥"});
            this.CurrencyBox.Location = new System.Drawing.Point(149, 96);
            this.CurrencyBox.Name = "CurrencyBox";
            this.CurrencyBox.Size = new System.Drawing.Size(46, 25);
            this.CurrencyBox.TabIndex = 12;
            // 
            // CreatePositionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 226);
            this.Controls.Add(this.CurrencyBox);
            this.Controls.Add(this.StartDatePicker);
            this.Controls.Add(this.BackBtn);
            this.Controls.Add(this.CreateBtn);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.PosSalaryBox);
            this.Controls.Add(this.PosTitleBox);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CreatePositionForm";
            this.Resizable = false;
            this.Text = "Create Job Position";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox PosTitleBox;
        private MetroFramework.Controls.MetroTextBox PosSalaryBox;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroButton CreateBtn;
        private MetroFramework.Controls.MetroButton BackBtn;
        private System.Windows.Forms.DateTimePicker StartDatePicker;
        private MetroFramework.Controls.MetroComboBox CurrencyBox;
    }
}