using System.Windows.Forms;

namespace Applicant_Reviewer.Classes
{
    class General
    {
        readonly Triple triple = new Triple();

        public void AddTriple(Control textbox)
        {
            switch (textbox.Name.Substring(0, textbox.Name.Length - 5))
            {
                case "catbox":
                    this.triple.GenCategory.Add(textbox.Text);
                    break;
                case "skillbox":
                    this.triple.GenShortComment.Add(textbox.Text);
                    break;
                case "responsebox":
                    this.triple.GenLongComment.Add(textbox.Text);
                    break;
            }
        }
    }
}
