using Applicant_Reviewer.Classes;
using MetroFramework.Forms;
using System;
using System.Windows.Forms;

namespace Applicant_Reviewer.Forms
{
    public partial class ApplicantInformation : MetroForm
    {
        private string cv;
        private string cl;

        //Displays the applicants information taken from the database. TO DO
        public ApplicantInformation()
        {
            this.InitializeComponent();
        }

        //Displays a message to the user telling them what to do.
        private void HelpButton(object sender, EventArgs e) => MessageBox.Show(@"TO DO",
            @"Applicant Information Help",
            MessageBoxButtons.OK,
            MessageBoxIcon.Information);

        //Takes the user back to the ViewApplications page.
        private void BackButton(object sender, EventArgs e)
        {
            var backToApplications = new ViewApplicants();
            backToApplications.Show();
            this.Hide();
        }

        //Takes the user to the create template page.
        private void CreateTemplate(object sender, EventArgs e)
        {
            var template = new CreateFeedback();
            template.Show();
            this.Hide();
        }

        private void ApplicantInformationLoad(object sender, EventArgs e)
        {
            this.LoadApplicantInfo(1);
        }

        private void LoadApplicantInfo(int applicantId)
        {
            var applicant = new Applicant();
            applicant.LoadApplicantInfo(applicantId);

            this.applicantName.Text = applicant.Name;
            this.applicantAddress1.Text = applicant.Address1;
            this.applicantAddress2.Text = applicant.Address2;
            this.applicantPostcode.Text = applicant.Postcode;
            this.applicantMobile.Text = applicant.Mobile;
            this.cv = applicant.Cv;
            this.cl = applicant.Cl;
        }

        private void CvBtnClick(object sender, EventArgs e)
        {
            MessageBox.Show(this.cv);
        }

        private void CoverLetterBtnClick(object sender, EventArgs e)
        {
            MessageBox.Show(this.cl);
        }
    }
}
