namespace Applicant_Reviewer.Forms
{
    using System;
    using System.Drawing;
    using System.Windows.Forms;

    using Classes;
    using Processors;

    using MetroFramework.Forms;

    public partial class PositionOptions : MetroForm
    {
        public PositionOptions()
        {
            this.InitializeComponent();
        }

        internal void FillDetails(string firstname, string lastname, int rights)
        {
            //email = email.Split('@')[0];
            //email = email.First().ToString().ToUpper() + email.Substring(1);
            this.showUser.Text += firstname + @" " + lastname;

            switch (rights)
            {
                case 1:
                    this.showRole.Text += @"Staff Member";
                    break;
                case 2:
                    this.showRole.Text += @"HR Member";
                    break;
                case 3:
                    this.showRole.Text += @"Admin";
                    break;
            }

            this.SavePreviousUser();
        }

        internal void CheckVisible()
        {
            switch (Userinfo.UserRights)
            {
                case 1:
                case 2:
                    this.CreatePositionsBtn.Hide();
                    this.ViewPositionsBtn.Size = new Size(398, 117);
                    this.ViewPositionsBtn.Location = new Point(23, 149);
                    break;
            }
        }

        private void CreatePositionsBtnClick(object sender, EventArgs e)
        {
            var newCreate = new CreatePosition();
            newCreate.Show();
            this.Visible = false;
        }

        private void ViewPositionsBtnClick(object sender, EventArgs e)
        {
            var newView = new ViewPositions();
            newView.Show();
            this.Visible = false;
        }

        private void PositionOptionsFormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void LogoutBtnClick(object sender, EventArgs e)
        {
            var newLogout = new LogoutProcessor();

            newLogout.Logout();
        }

        private void PositionOptionsLoad(object sender, EventArgs e)
        {
        }

        internal void SavePreviousUser()
        {
            Userinfo.UserRole = this.showRole.Text.Substring(6);
        }

        internal void LoadPreviousUser()
        {
            this.showUser.Text += Userinfo.FirstName + @" " + Userinfo.LastName;
            this.showRole.Text += Userinfo.UserRole;
        }

        //Displays a message box telling the user how to complete the form.
        private void HelpButton(object sender, EventArgs e)
        {
            MessageBox.Show(@"Your username and role is displayed at the top of the page. If you are not that user, click the logout button. If you wish to use the application review you must first decide if you are going to create a new position or view possitions that already exist and click the corresponding button to be taken to that chosen page.");//To check
        }
    }
}
