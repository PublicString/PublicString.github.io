using System.Windows.Forms;

namespace Applicant_Reviewer.Classes
{
    class Interview
    {
        readonly Triple triple = new Triple();

        public void AddTriple(Control textbox)
        {
            switch (textbox.Name.Substring(0, textbox.Name.Length - 5))
            {
                case "catbox":
                    this.triple.IntCategory.Add(textbox.Text);
                    break;
                case "skillbox":
                    this.triple.IntShortComment.Add(textbox.Text);
                    break;
                case "responsebox":
                    this.triple.IntLongComment.Add(textbox.Text);
                    break;
            }
        }
    }
}
