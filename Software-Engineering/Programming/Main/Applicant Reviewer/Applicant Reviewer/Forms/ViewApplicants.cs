using Applicant_Reviewer.Processors;
using MetroFramework.Forms;
using System;
using System.Windows.Forms;

namespace Applicant_Reviewer.Forms
{
    public partial class ViewApplicants : MetroForm
    {
        //Text box which shows the applicans information taken from the database.
        public ViewApplicants()
        {
            this.InitializeComponent();
        }

        //Takes user to the applicant information page of the name selected.
        private void ViewApplicantInfo(object sender, EventArgs e)
        {
            var viewAppInfo = new ApplicantInformation { Text = this.ApplicantList.SelectedItem.ToString() };
            viewAppInfo.Show();
            this.Hide();
        }

        private void ViewApplicationsLoad(object sender, EventArgs e)
        {
            foreach (var item in ApplicationsProcessor.LoadFromDatabase())
            {
                this.ApplicantList.Items.Add(item);
            }
        }

        private void HelpButton(object sender, EventArgs e)
        {
            MessageBox.Show(@"Select the applicant you wish to view the information of. Then click the button 'View Applicant Info'");
        }
    }
}
