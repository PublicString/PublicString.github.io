using System;
using System.Windows.Forms;

namespace Applicant_Reviewer.Classes
{
    class Cv
    {
        readonly Triple triple = new Triple();

        public void AddTriple(Control textbox)
        {
            switch (textbox.Name.Substring(0, textbox.Name.Length - 5))
            {
                case "catbox":
                    Console.WriteLine(@"Adding: {0} to cvCategory", textbox.Text);
                    this.triple.CvCategory.Add(textbox.Text);
                    break;
                case "skillbox":
                    this.triple.CvShortComment.Add(textbox.Text);
                    break;
                case "responsebox":
                    this.triple.CvLongComment.Add(textbox.Text);
                    break;
            }
        }
    }
}
