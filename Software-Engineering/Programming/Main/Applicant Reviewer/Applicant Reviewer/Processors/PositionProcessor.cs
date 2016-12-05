using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Applicant_Reviewer.Processors
{
    using System.Linq;

    class PositionProcessor
    {

        //Unsure if needed seeing as i've made things static -Billy

        //private string positionTitle;
        //private string positionSalary;
        //private string positionStartDate;

        //public PositionProcessor(string positionTitle, string positionSalary, string positionStartDate)
        //{
        //    this.positionTitle = positionTitle;
        //    this.positionSalary = positionSalary;
        //    this.positionStartDate = positionStartDate;
        //}

        //public string PositionTitle
        //{
        //    get { return positionTitle; }
        //}

        //public string PositionSalary
        //{
        //    get { return positionSalary; }
        //}

        //public string PositionStartDate
        //{
        //    get { return positionStartDate; }
        //}

        internal static List<string> LoadFromDatabase()
        {
            var items = new List<string>();

            using (DbConnector.GetConnection)
            {
                DbConnector.OpenConnection();

                var adapter = new SqlDataAdapter("SELECT * FROM Template", DbConnector.GetConnection);

                var dt = new DataTable();

                adapter.Fill(dt);

                items.AddRange(from DataRow item in dt.Rows select item["TemplateName"].ToString());
            }

            DbConnector.CloseConnection();

            return items;
        }

        internal static void AddToDatabase(string positionTitle, string positionSalary, string positionStartDate)
        {
            using (DbConnector.GetConnection)
            {
                DbConnector.OpenConnection();
                var query = new SqlCommand(@"INSERT INTO Positions" +
                                                  @"(PosTitle, PosSalary, PosStartDate)" +
                                                  @"VALUES" +
                                                  @"(@PosTitle, @PosSalary, @PosStartDate)",
                                                  DbConnector.GetConnection);

                query.Parameters.AddWithValue("@PosTitle", positionTitle);
                query.Parameters.AddWithValue("@PosSalary", positionSalary);
                query.Parameters.AddWithValue("@PosStartDate", positionStartDate);

                try
                {
                    var rowsChanged = query.ExecuteNonQuery();

                    if (rowsChanged != 0)
                    {
                        MessageBox.Show(rowsChanged + @" Rows Changed");
                    }
                }
                catch (System.Exception e)
                {
                    MessageBox.Show(e.Message);
                }
                DbConnector.CloseConnection();
            }
        }
    }
}
