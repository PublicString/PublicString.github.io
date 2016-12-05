namespace Applicant_Reviewer.Processors
{
    using System.Windows.Forms;

    using Applicant_Reviewer.Forms;

    class LogoutProcessor
    {
        internal void Logout()
        {
            var newDialog = MessageBox.Show(@"Are you sure you want to log out?", @"Logout", MessageBoxButtons.YesNo);
            if (newDialog != DialogResult.Yes)
            {
                return;
            }
            var loginForm = new Login();

            var positionOptions = new PositionOptions();
            positionOptions.Dispose();
            loginForm.BringToFront();
            loginForm.Show();
        }
    }
}
