using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;

namespace Applicant_Reviewer.Processors
{
    class TemplateProcessor
    {
        internal static void AddToDatabase(string cvName, string templateName, List<string> categoryList, List<string> shortCommentList, List<string> longCommentList)
        {
            var category = String.Join(", ", categoryList.ToArray());
            var shortComment = String.Join(", ", shortCommentList.ToArray());
            var longComment = String.Join(", ", longCommentList.ToArray());

            using (DbConnector.GetConnection)
            {
                DbConnector.OpenConnection();
                SqlCommand query = new SqlCommand(@"INSERT INTO CV" +
                                                  @"(CVName, TemplateName, categorySelection, skillComment, responseComment)" +
                                                  @"VALUES" +
                                                  @"(@CVName, @TemplateName, @categorySelection, @skillComment, @responseComment)",
                                                  DbConnector.GetConnection);
                query.Parameters.Add("@CVName", SqlDbType.VarChar).Value = cvName;
                query.Parameters.Add("@TemplateName", SqlDbType.VarChar).Value = templateName;
                query.Parameters.Add("@categorySelection", SqlDbType.VarChar).Value = category;
                query.Parameters.Add("@skillComment", SqlDbType.VarChar).Value = shortComment;
                query.Parameters.Add("@responseComment", SqlDbType.VarChar).Value = longComment;

                try
                {
                    int rowsChanged = query.ExecuteNonQuery(); //CONSTRAINT[FK_CV_TemplateName] FOREIGN KEY ([TemplateName]) REFERENCES[dbo].[Template]([TemplateName]) //ADD ME TO CV Table

                    if (rowsChanged != 0)
                    {
                        MessageBox.Show(rowsChanged + @" Rows Changed");
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                }
                DbConnector.CloseConnection();
            }
        }
    }
}
