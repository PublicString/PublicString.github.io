namespace Applicant_Reviewer.Forms
{
    using System;
    using System.Drawing;
    using System.Linq;
    using System.Windows.Forms;

    using Classes;
    using Processors;

    using MetroFramework.Controls;
    using MetroFramework.Forms;

    public partial class CreateFeedback : MetroForm
    {
        internal string TemplateName;

        private int panelId = 1;

        private const int DistBetweenPanel = 51;

        private const int DistBetweenSkills = 29;

        private int skillId = 1;
        private int numOfSkills = 1;

        Point nextPanelLocation = new Point(3, 13);
        Random uniqueId;
        
        private void CreateFeedbackLoad(object sender, EventArgs e)
        {




            this.TemplateName = "test";

            this.Text += @" - " + this.TemplateName;
        }

        public CreateFeedback()
        {
            this.InitializeComponent();
        }

        private void AddCategory(object sender, EventArgs e)
        {
            this.CreateNewPanel();
        }

        private void AddSkills(object sender, EventArgs e)
        {
            this.AddSkillToPanel(sender, e);
        }

        /// <summary>
        /// Creates a new panel including base category and skill boxes
        /// </summary>
        private void CreateNewPanel()
        {
            var newPanel = new MetroPanel();
            var newDeleteBtn = new MetroButton();
            var newCatBox = new MetroTextBox();
            var newSkillBox = new MetroTextBox();
            var newResponseBox = new MetroTextBox();
            var addSkillBtn = new MetroButton();

            this.uniqueId = new Random();

            var id = this.uniqueId.Next(9000, 9999);
            this.panelId++;

            //Panel
            newPanel.Size = new Size(659, 45);
            newPanel.Location = new Point(this.nextPanelLocation.X, this.nextPanelLocation.Y + DistBetweenPanel);
            newPanel.Name = "panel" + id + this.panelId;
            //Debug
            newPanel.CustomBackground = true;
            newPanel.BackColor = Color.Red;

            //DeleteBtn
            newDeleteBtn.Size = new Size(26, 23);
            newDeleteBtn.Location = new Point(38, 12);
            newDeleteBtn.Name = "delbtn" + id + this.skillId;
            newDeleteBtn.Text = @"-";
            newDeleteBtn.Click += DeleteCategory;

            //CategoryBox
            newCatBox.Size = new Size(101, 23);
            newCatBox.Location = new Point(70, 12);
            newCatBox.Name = "catbox" + id + this.skillId;
            newCatBox.Text += @"Category";

            //SkillsBox
            newSkillBox.Size = new Size(121, 23);
            newSkillBox.Location = new Point(177, 12);
            newSkillBox.Name = "skillbox" + id + this.skillId;
            newSkillBox.Text = @"Skill";

            //ResponseBox
            newResponseBox.Size = new Size(286, 23);
            newResponseBox.Location = new Point(304, 12);
            newResponseBox.Name = "responsebox" + id + this.skillId;
            newResponseBox.Text = @"Response";

            //AddSkillBtn
            addSkillBtn.Size = new Size(26, 23);
            addSkillBtn.Location = new Point(596, 12);
            addSkillBtn.Name = "skillbtn" + id + this.skillId;
            addSkillBtn.Text = @"+";
            addSkillBtn.Click += this.AddSkillToPanel;

            this.CVTab.Controls.Add(newPanel);
            newPanel.Controls.Add(newDeleteBtn);
            newPanel.Controls.Add(newCatBox);
            newPanel.Controls.Add(newSkillBox);
            newPanel.Controls.Add(newResponseBox);
            newPanel.Controls.Add(addSkillBtn);

            this.nextPanelLocation = newPanel.Location;
            this.skillId++;


            //Debug
            Console.WriteLine(@"Panel: {0} | {1} | {2}", newPanel.Location, newPanel.Name.Substring(5, 4), newPanel.Name.Substring(9));
            Console.WriteLine(@"Delbtn: {0} | {1}", newDeleteBtn.Location, newDeleteBtn.Name.Substring(newDeleteBtn.Name.Length - 4));
            Console.WriteLine(@"CatBox: {0} | {1}", newCatBox.Location, newCatBox.Name.Substring(newCatBox.Name.Length - 4));
            Console.WriteLine(@"SkillBox: {0} | {1}", newSkillBox.Location, newSkillBox.Name.Substring(newSkillBox.Name.Length - 4));
            Console.WriteLine(@"ResponseBox: {0} | {1}", newResponseBox.Location, newResponseBox.Name.Substring(newResponseBox.Name.Length - 4));
            Console.WriteLine(@"SkillBtn: {0} | {1}", addSkillBtn.Location, addSkillBtn.Name.Substring(addSkillBtn.Name.Length - 4));
            Console.WriteLine(@"----------------------------------------------");
        }

        private void AddSkillToPanel(object sender, EventArgs e)
        {
            var addBtn = sender as Button;

            if (addBtn == null)
            {
                return;
            }
            var substring = addBtn.Name.Substring(addBtn.Name.Length - 5, 4);
            Console.WriteLine(@"AddSkillToPanel: addBtn = " + substring); //Debug

            var yCoord = addBtn.Location.Y + (DistBetweenSkills * this.numOfSkills);

            foreach (var item in this.CVTab.Controls.OfType<MetroPanel>())
            {
                if (!item.Name.Contains("panel" + substring))
                {
                    continue;
                }
                Console.WriteLine(@"PANEL FOUND @ " + item.Name); //Debug

                var newSkillBox = new MetroTextBox();
                var newResponseBox = new MetroTextBox();
                var newDeleteBtn = new MetroButton();

                //SkillBox
                newSkillBox.Size = new Size(121, 23);
                newSkillBox.Location = new Point(177, yCoord);
                newSkillBox.Name = "skillbox" + substring + this.skillId;
                newSkillBox.Text = @"Skill";
                Console.WriteLine(@"Created newSkillBox with the name: " + newSkillBox.Name);

                //ResponseBox
                newResponseBox.Size = new Size(286, 23);
                newResponseBox.Location = new Point(304, yCoord);
                newResponseBox.Name = "responsebox" + substring + this.skillId;
                newResponseBox.Text = @"Response";
                Console.WriteLine(@"Created newResponseBox with the name: " + newResponseBox.Name);

                //DeleteBtn
                newDeleteBtn.Size = new Size(26, 23);
                newDeleteBtn.Location = new Point(596, yCoord);
                newDeleteBtn.Name = "deletebtn" + substring + this.skillId;
                newDeleteBtn.Text = @"-";
                newDeleteBtn.Click += DeleteSkills;
                Console.WriteLine(@"Created newDeleteBtn with the name: " + newDeleteBtn.Name);

                item.Controls.Add(newSkillBox);
                item.Controls.Add(newResponseBox);
                item.Controls.Add(newDeleteBtn);
                this.numOfSkills++;
                this.skillId++;
                item.Height += DistBetweenSkills;
            }
        }

        private static void DeleteSkills(object sender, EventArgs e)
        {
            var deleteBtn = sender as MetroButton;
            if (deleteBtn != null)
            {
                var thisPanel = deleteBtn.Parent;

                var substring = deleteBtn.Name.Substring(9, 4);
                int id = Convert.ToInt16(deleteBtn.Name.Substring(13));
                Console.WriteLine(@"deleteBtn uID = {0} | skillID = {1}", substring, id);

                var deleteRowCheck = MessageBox.Show(@"Are you sure you want to delete this row?", @"Delete row", MessageBoxButtons.YesNo);

                if (deleteRowCheck != DialogResult.Yes)
                {
                    return;
                }
                foreach (var item in thisPanel.Controls.OfType<MetroTextBox>())
                {
                    int itemId = Convert.ToInt16(item.Name.Substring(item.Name.LastIndexOf("box", StringComparison.Ordinal) + 7));
                    //Console.WriteLine("ITEMID = " + itemID); //Debug

                    if (item.Name.Contains("box" + substring) && (itemId == id))
                    {
                        Console.WriteLine(@"PANEL FOUND @ " + item.Name);
                        thisPanel.Controls.Remove(item);
                    }

                    foreach (var item1 in from item1 in thisPanel.Controls.OfType<MetroTextBox>() let itemId1 = Convert.ToInt16(item1.Name.Substring(item1.Name.LastIndexOf("box", StringComparison.Ordinal) + 7)) where item1.Name.Contains("box" + substring) && (itemId1 == id) select item1)
                    {
                        Console.WriteLine(@"PANEL FOUND @ " + item1.Name);
                        thisPanel.Controls.Remove(item1);
                    }

                    foreach (var item2 in from item2 in thisPanel.Controls.OfType<MetroButton>() let itemId2 = Convert.ToInt16(item2.Name.Substring(item2.Name.LastIndexOf("btn", StringComparison.Ordinal) + 7)) where item2.Name.Contains("btn" + substring) && (itemId2 == id) select item2)
                    {
                        thisPanel.Controls.Remove(item2);
                    }
                }

                MoveSkills(deleteBtn, thisPanel, substring, id);
            }
        }

        /// <summary>
        /// Currently moves all Skill rows lower than the deleted to some random Y axis... //TODO
        /// </summary>
        /// <param name="deletedBtn"></param>
        /// <param name="thisPanel"></param>
        /// <param name="uniqueId"></param>
        /// <param name="skillId"></param>
        private static void MoveSkills(Control deletedBtn, Control thisPanel, string uniqueId, int skillId)
        {
            Console.WriteLine(@"deleteBtn uID = {0} | skillID = {1}", uniqueId, skillId);

            foreach (var item in thisPanel.Controls.OfType<MetroTextBox>())
            {
                int itemId = Convert.ToInt16(item.Name.Substring(item.Name.LastIndexOf("box", StringComparison.Ordinal) + 7));
                //Console.WriteLine("ITEMID = " + itemID); //Debug

                if (!item.Name.Contains("box" + uniqueId) || (itemId <= skillId))
                {
                    continue;
                }
                item.Location = new Point(item.Location.X, item.Location.Y - (deletedBtn.Height + (deletedBtn.Margin.Top * 2)));
                Console.WriteLine(@"new item location: {0}", item.Location.ToString());
            }

            foreach (var item2 in thisPanel.Controls.OfType<MetroButton>())
            {
                int itemId2 = Convert.ToInt16(item2.Name.Substring(item2.Name.LastIndexOf("btn", StringComparison.Ordinal) + 7));
                //Console.WriteLine("ITEMID = " + itemID2); //Debug

                if (item2.Name.Contains("btn" + uniqueId) && (itemId2 > skillId))
                {
                    item2.Location = new Point(item2.Location.X, item2.Location.Y - (deletedBtn.Height + (deletedBtn.Margin.Top * 2)));
                    Console.WriteLine(@"new item location: " + item2.Location.ToString());
                }
            }

            thisPanel.Height -= (deletedBtn.Height + (deletedBtn.Margin.Top * 2));



        }

        private static void DeleteCategory(object sender, EventArgs e)
        {

        }

        private void CreateFeedbackFormClosing(object sender, FormClosingEventArgs e)
        {
            var positionOptions = new PositionOptions();

            positionOptions.Show();
            positionOptions.LoadPreviousUser();
        }

        //Takes the user back to the Applicant Information page.
        private void BackButton(object sender, EventArgs e)
        {
            var backAppInfo = new ApplicantInformation();
            backAppInfo.Show();
            this.Hide();
        }

        //Displays a message box telling the user how to fill out the form.
        private void HelpButton(object sender, EventArgs e)
        {
            MessageBox.Show(@"Choose the type of application the applicant completed. The first box is the category. To add or remove a category you can click the plus and minus buttons to the right of the field.",
                @"Create Template Help",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information,
                MessageBoxDefaultButton.Button1); //To complete
        }

        //Saves the information imputed by the user to a table in the database to be called upon later if needed.
        private void SaveButton(object sender, EventArgs e)
        {
            var triple = new Triple();

            foreach (var panel in this.CVTab.Controls.OfType<MetroPanel>())
            {
                foreach (var textbox in panel.Controls.OfType<MetroTextBox>())
                {
                    switch (textbox.Name.Substring(0, textbox.Name.Length - 5))
                    {
                        case "catbox":
                            triple.AddToList(Triple.Tab.Cv, Triple.Type.Category, textbox.Text);
                            break;
                        case "skillbox":
                            triple.AddToList(Triple.Tab.Cv, Triple.Type.ShortComment, textbox.Text);
                            break;
                        case "responsebox":
                            triple.AddToList(Triple.Tab.Cv, Triple.Type.LongComment, textbox.Text);
                            break;
                    }
                }
            }

            //CHANGE NAMES
            TemplateProcessor.AddToDatabase("test4324", "test34535", triple.CvCategory, triple.CvShortComment, triple.CvLongComment);
        }
    }
}
