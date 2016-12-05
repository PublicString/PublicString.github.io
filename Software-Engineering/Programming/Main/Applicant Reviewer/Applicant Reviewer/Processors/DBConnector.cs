using System.Data.SqlClient;

namespace Applicant_Reviewer.Processors
{
    class DbConnector
    {
        internal static void OpenConnection()
        {
            GetConnection.Open();
        }

        internal static void CloseConnection()
        {
            GetConnection.Close();
        }

        internal static SqlConnection GetConnection { get; } = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database\Database.mdf;Integrated Security=True;Connect Timeout=30");
    }
}
