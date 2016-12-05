namespace Applicant_Reviewer.Forms
{
    using System;
    using System.Windows.Forms;

    using Classes;
    using Processors;

    using MetroFramework.Forms;

    public partial class Login : MetroForm
    {
        public Login()
        {
            this.InitializeComponent();
            this.RandomStyle();
            this.InitializePlaceholders();
        }

        private void InitializePlaceholders()
        {
            this.EmailBox.Text = @".";
            this.PasswordBox.Text = @".";
            this.EmailBox.Text = "";
            this.PasswordBox.Text = "";
        }

        /// <summary>
        /// Button click handler, if clicked, checks against LoginProcessor
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        internal void LoginButtonClick(object sender, EventArgs e)
        {
            this.NewLogin();
        }

        internal void NewLogin()
        {
            Userinfo.EmailAddress = this.EmailBox.Text;
            Userinfo.Password = this.PasswordBox.Text;

            var newLoginAttempt = new LoginProcessor();

            newLoginAttempt.Login(Userinfo.EmailAddress, Userinfo.Password);
        }

        /// <summary>
        /// If this form is closed, exits entire application
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LoginFormFormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void RandomStyle()
        {
            var rnd = new Random();

            var randomNumber = rnd.Next(1, 14);

            switch (randomNumber)
            {
                case 1:
                    this.Style = MetroFramework.MetroColorStyle.Black;
                    break;
                case 2:
                    this.Style = MetroFramework.MetroColorStyle.Blue;
                    break;
                case 3:
                    this.Style = MetroFramework.MetroColorStyle.Brown;
                    break;
                case 4:
                    this.Style = MetroFramework.MetroColorStyle.Green;
                    break;
                case 5:
                    this.Style = MetroFramework.MetroColorStyle.Lime;
                    break;
                case 6:
                    this.Style = MetroFramework.MetroColorStyle.Magenta;
                    break;
                case 7:
                    this.Style = MetroFramework.MetroColorStyle.Orange;
                    break;
                case 8:
                    this.Style = MetroFramework.MetroColorStyle.Pink;
                    break;
                case 9:
                    this.Style = MetroFramework.MetroColorStyle.Purple;
                    break;
                case 10:
                    this.Style = MetroFramework.MetroColorStyle.Red;
                    break;
                case 11:
                    this.Style = MetroFramework.MetroColorStyle.Silver;
                    break;
                case 12:
                    this.Style = MetroFramework.MetroColorStyle.Teal;
                    break;
                case 13:
                    this.Style = MetroFramework.MetroColorStyle.White;
                    break;
                case 14:
                    this.Style = MetroFramework.MetroColorStyle.Yellow;
                    break;
            }
        }

        //Help button tells the user what to do via message box.
        private void HelpButton(object sender, EventArgs e)
        {
            MessageBox.Show(@"Enter your Email Address in the top box and your password in the bottom box.After entering your login details click the login button to proceed.",
                @"Login Help",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

    }
}
