namespace Applicant_Reviewer.Forms
{
    using System;
    using System.Windows.Forms;

    using Applicant_Reviewer.Processors;

    using MetroFramework.Forms;

    public partial class CreatePosition : MetroForm
    {
        public CreatePosition()
        {
            this.InitializeComponent();
            this.InitializePlaceholders();
            this.PosTitleBox.Focus();
            this.CurrencyBox.Size = new System.Drawing.Size(46, 21);
        }
        
        private void InitializePlaceholders()
        {
            this.PosTitleBox.Text = @".";
            this.PosSalaryBox.Text = @".";
            this.PosTitleBox.Text = "";
            this.PosSalaryBox.Text = "";
        }

        private void BackBtnClick(object sender, EventArgs e)
        {
            var previousWindow = new PositionOptions();
            previousWindow.LoadPreviousUser();
            previousWindow.Visible = true;
            this.Hide();
        }

        private void CreateBtnClick(object sender, EventArgs e)
        {
            if ((this.PosTitleBox.Text != string.Empty) && (this.CurrencyBox.SelectedIndex != -1) && (this.PosSalaryBox.Text != string.Empty))
            {
                PositionProcessor.AddToDatabase(this.PosTitleBox.Text, (this.CurrencyBox.Text + this.PosSalaryBox.Text), this.StartDatePicker.Text);
            }
            else
            {
                MessageBox.Show(@"Please fill out all fields.", @"Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
            }
        }
    }
}
