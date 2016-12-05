namespace Applicant_Reviewer.Forms
{
    using System;

    using MetroFramework.Forms;

    public partial class BackgroundForm : MetroForm
    {
        public BackgroundForm()
        {
            this.InitializeComponent();
        }

        private void BackgroundFormLoad(object sender, EventArgs e)
        {
            var loginForm = new Login();
            loginForm.Show();
            this.Visible = false;
        }

        private void BackgroundFormVisibleChanged(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
