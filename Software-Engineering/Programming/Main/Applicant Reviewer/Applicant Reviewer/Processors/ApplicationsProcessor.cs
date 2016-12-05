using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
namespace Applicant_Reviewer.Processors
{
    class ApplicationsProcessor
    {
        internal static List<string> LoadFromDatabase()
        {
            var items = new List<string>();

            using (DbConnector.GetConnection)
            {
                DbConnector.OpenConnection();

                var adapter = new SqlDataAdapter("SELECT * FROM Applicants", DbConnector.GetConnection);

                var dt = new DataTable();

                adapter.Fill(dt);

                items.AddRange(from DataRow item in dt.Rows select (item["ApplicantFirstName"] + " " + item["ApplicantLastName"]));
            }

            DbConnector.CloseConnection();

            return items;
        }
    }
}
