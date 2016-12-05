using Applicant_Reviewer.Processors;
using System;
using System.Data;
using System.Data.SqlClient;

namespace Applicant_Reviewer.Classes
{
    class Applicant
    {
        public string Name { get; private set; }

        public string Address1 { get; private set; }

        public string Address2 { get; private set; }

        public string Postcode { get; private set; }

        public string Mobile { get; private set; }

        public string Cv { get; private set; }

        public string Cl { get; private set; }

        public void LoadApplicantInfo(int applicantId)
        {
            const string SqlCommand = "SELECT * FROM Applicants WHERE ApplicantID = @ApplicantID";

            using (var connection = new SqlConnection(DbConnector.GetConnection.ConnectionString))
            {
                var command = new SqlCommand(SqlCommand, connection);

                //Protection against SQL Injection (ie. "Robert '); DROP TABLE Users;--"
                command.Parameters.Add("@ApplicantID", SqlDbType.Int);
                command.Parameters["@ApplicantID"].Value = applicantId;

                try
                {
                    connection.Open();
                    var reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        if (reader["ApplicantID"].ToString() == applicantId.ToString())
                        {
                            this.Name = reader["ApplicantFirstName"] + " " + reader["ApplicantLastName"];
                            this.Address1 = reader["ApplicantAddress1"].ToString();
                            this.Address2 = reader["ApplicantAddress2"].ToString();
                            this.Postcode = reader["ApplicantPostcode"].ToString();
                            this.Mobile = reader["ApplicantMobile"].ToString();

                            this.Cv = reader["ApplicantCV"] != DBNull.Value ? reader["ApplicantCV"].ToString() : "No CV.";

                            this.Cl = reader["ApplicantCL"] != DBNull.Value ? reader["ApplicantCL"].ToString() : "No Cover Letter.";
                        }
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }

                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }
    }
}
