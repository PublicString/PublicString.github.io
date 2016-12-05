using System.Collections.Generic;
using System.Windows.Forms;

namespace Applicant_Reviewer.Classes
{
    class Triple
    {
        public List<string> CvCategory = new List<string>();
        public List<string> CvShortComment = new List<string>();
        public List<string> CvLongComment = new List<string>();

        public List<string> IntCategory = new List<string>();
        public List<string> IntShortComment = new List<string>();
        public List<string> IntLongComment = new List<string>();

        public List<string> GenCategory = new List<string>();
        public List<string> GenShortComment = new List<string>();
        public List<string> GenLongComment = new List<string>();

        public enum Tab
        {
            Cv, Int, Gen
        }

        public enum Type
        {
            Category, ShortComment, LongComment
        }

        public void AddToList(Tab tab, Type type, string text)
        {
            switch (tab.ToString().ToLower() + type)
            {
                case "cvCategory":
                    this.CvCategory.Add(text);
                    break;
                case "cvShortComment":
                    this.CvShortComment.Add(text);
                    break;
                case "cvLongComment":
                    this.CvLongComment.Add(text);
                    break;

                case "intCategory":
                    this.IntCategory.Add(text);
                    break;
                case "intShortComment":
                    this.IntShortComment.Add(text);
                    break;
                case "intLongComment":
                    this.IntLongComment.Add(text);
                    break;

                case "genCategory":
                    this.GenCategory.Add(text);
                    break;
                case "genShortComment":
                    this.GenShortComment.Add(text);
                    break;
                case "genLongComment":
                    this.GenLongComment.Add(text);
                    break;

                default:
                    MessageBox.Show(@"error");
                    break;
            }
        }
    }
}
