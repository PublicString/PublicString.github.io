namespace Applicant_Reviewer.Processors
{
    using System;
    using System.Data;
    using System.Data.SqlClient;
    using System.Globalization;
    using System.Text.RegularExpressions;
    using System.Windows.Forms;

    using Forms;

    using Classes;

    class LoginProcessor
    {
        private bool invalid;

        /// <summary />
        /// <param name="email" />
        /// <param name="password" />
        internal void Login(string email, string password)
        {
            if (this.CheckDetails(email, password))
            {
                this.CheckPrivileges(email, Userinfo.UserRights);                
            }
        }

        /// <summary />
        /// <param name="email"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        internal bool CheckDetails(string email, string password)
        {
            var correctLogin = false;

            if ((!string.IsNullOrEmpty(email) || !string.IsNullOrEmpty(password)) && (this.IsValidEmail(email)))
            {
                try
                {
                    DbConnector.OpenConnection();

                    DataTable dt;
                    using (var adapter = new SqlDataAdapter("SELECT * FROM Users WHERE email = '" + email + "' AND password = '" + password + "'", DbConnector.GetConnection))
                    {
                        dt = new DataTable();
                    
                        adapter.Fill(dt);
                    }

                    if (dt.Rows.Count == 1)
                    {
                        foreach (DataRow rows in dt.Rows)
                        {
                            Userinfo.UserRights = Convert.ToInt16(rows["userRights"].ToString());
                            Userinfo.FirstName = rows["firstname"].ToString();
                            Userinfo.LastName = rows["lastname"].ToString();
                            Console.WriteLine(Userinfo.UserRights);
                            DbConnector.CloseConnection();
                            return correctLogin = true;
                        }
                    }
                    else MessageBox.Show(@"Invalid username or password");
                    DbConnector.CloseConnection();

                    return false;
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                }
            }
            else
                MessageBox.Show(@"Please enter both a valid email, and password");
            return correctLogin;
        }

        /// <summary>
        /// <para>Method to check if email is valid.</para>
        /// <para>&#160;</para>
        /// <para>Reference:</para>
        /// <para>Microsoft, Verify that Strings Are in Valid Email Format [Code].</para>
        /// <para>Available at https://msdn.microsoft.com/en-us/library/01escwtf(v=vs.110).aspx </para>
        /// <para>(Accessed 23 October 2016)</para>
        /// </summary>
        /// <param name="email"></param>
        /// <returns></returns>
        private bool IsValidEmail(string email)
        {
            this.invalid = false;
            if (String.IsNullOrEmpty(email))
                return false;

            try
            {
                email = Regex.Replace(email, @"(@)(.+)$", this.DomainMapper,
                                      RegexOptions.None, TimeSpan.FromMilliseconds(200));
            }
            catch (RegexMatchTimeoutException)
            {
                return false;
            }

            if (this.invalid)
                return false;
            
            try
            {
                //Regex expression that checks a match between entered username and the expression that has the following scheme (a-zA-Z0-9_-.@a-zA-Z0-9.a-zA-Z)
                return Regex.IsMatch(email,
                      @"^(?("")("".+?(?<!\\)""@)|(([0-9a-z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@))" +
                      @"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-\w]*[0-9a-z]*\.)+[a-z0-9][\-a-z0-9]{0,22}[a-z0-9]))$",
                      RegexOptions.IgnoreCase, TimeSpan.FromMilliseconds(250));
            }
            catch (RegexMatchTimeoutException)
            {
                return false;
            }
        }

        /// <summary>
        /// <para>&#160;</para>
        /// <para>Reference: </para>
        /// <para>Microsoft, Verify that Strings Are in Valid Email Format [Code].</para>
        /// <para>Available at https://msdn.microsoft.com/en-us/library/01escwtf(v=vs.110).aspx </para>
        /// <para>(Accessed 23 October 2016)</para>
        /// </summary>
        /// <param name="match"></param>
        /// <returns></returns>
        private string DomainMapper(Match match)
        {
            IdnMapping idn = new IdnMapping();

            string domainName = match.Groups[2].Value;
            try
            {
                domainName = idn.GetAscii(domainName);
            }
            catch (ArgumentException)
            {
                this.invalid = true;
            }
            return match.Groups[1].Value + domainName;
        }

        /// <summary>
        /// Changes PositionOptions.form layout depending on userRights
        /// </summary>
        /// <param name="email"></param>
        /// <param name="userRights"></param>
        internal void CheckPrivileges(string email, int userRights)
        {
            switch (userRights)
            {
                case 1:
                case 2:
                case 3:
                    var loginform = new Login();
                    loginform.Hide();
                    var newPositionOptions = new PositionOptions();
                    newPositionOptions.Show();
                    newPositionOptions.CheckVisible();
                    newPositionOptions.FillDetails(Userinfo.FirstName, Userinfo.LastName, Userinfo.UserRights);
                    break;
                default:
                    MessageBox.Show(@"You don't have permission to view this.");
                    break;
            }
        }
    }
}