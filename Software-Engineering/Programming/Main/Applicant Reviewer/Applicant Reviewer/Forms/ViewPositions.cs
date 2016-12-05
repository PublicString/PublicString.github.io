namespace Applicant_Reviewer.Forms
{
    using System;

    using Applicant_Reviewer.Processors;

    using MetroFramework.Forms;

    public partial class ViewPositions : MetroForm
    {
        public ViewPositions()
        {
            this.InitializeComponent();
        }

        private void ViewPositionsFormLoad(object sender, EventArgs e)
        {
            foreach (var item in PositionProcessor.LoadFromDatabase())
            {
                this.PositionList.Items.Add(item);
            }
        }

        private void BackBtnClick(object sender, EventArgs e)
        {
            var previousWindow = new PositionOptions();
            previousWindow.LoadPreviousUser();
            previousWindow.Visible = true;
            this.Hide();
        }

        private void ViewApplicantBtnClick(object sender, EventArgs e)
        {
            this.PositionList.SelectedIndex = 2; //Debug
        }

        private void ViewPositionsFormFormClosing(object sender, System.Windows.Forms.FormClosingEventArgs e)
        {
            var posOptions = new PositionOptions();

            posOptions.LoadPreviousUser();
            posOptions.Show();
        }
    }
}
