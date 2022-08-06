using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace Dinner_Picker
{
    // The Dinner Item Object
    // Bugs out the reading and writing if it becomes a class
     public struct DinnerItem
    {
        public string name;
        public string tg_1;
        public string tg_2;
        public string tg_3;
        public int itemRank;
    }


    public partial class Form1 : Form
    {
        public static Form1 instance;
        public ListBox TotalList, GenItems;
        // Important to note, the more Items added to the list, the more memory the program takes up. As well as how many functions the program has performed.
        public List<DinnerItem> FoodItems = new List<DinnerItem>();
        public Dictionary<int, DinnerItem> FoodSearch = new Dictionary<int, DinnerItem>();
        public int Enumed;

        public Form1()
        {
            InitializeComponent();
            instance = this;
            TotalList = FoodValues;
            GenItems = GeneratedItems;


        }
        // Form1_Load (Event)
        private void DinnerOperations_Load(object sender, EventArgs e)
        {
            // Feature for v1.2 release
            // Set Desktop Location.
            // Form1.Location = Screen.AllScreens[1].WorkingArea.Location;

            SelectButton.Enabled = false;
            Edit.Enabled = false;
            Delete.Enabled = false;



            // Would need to load in the linked list Items too. 
            string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string filepath = path + "\\FoodValues.txt";
            string tagPath = path + "\\DinnerJournal\\DinnerValues.txt";


            // Reads in Food item values and loads them into a list and dictionary
            if (File.Exists(tagPath))
            {
                StreamReader readFile = new StreamReader(tagPath);
                DinnerItem Di = new DinnerItem();
                string line;
                while ((line = readFile.ReadLine()) != null)
                {
                    var lineArray = (line.Split(','));
                    Di.name = lineArray[0];
                    Di.tg_1 = lineArray[1];
                    Di.tg_2 = lineArray[2];
                    Di.tg_3 = lineArray[3];
                    Di.itemRank = int.Parse(lineArray[4]);
                    FoodItems.Add(Di);
                    FoodSearch.Add(Enumed, Di);
                    Enumed++;

                    Form1.instance.TotalList.Items.Add(Di.name);
                }
                FoodItems.Sort((x, y) => string.Compare(x.name, y.name));
                readFile.Close();
            }
            else if (Directory.Exists(path + "\\DinnerJournal") == false)
            {
                Directory.CreateDirectory(path + "\\DinnerJournal");
            }

            if (TotalList.Items.Count == 0)
            {
                button1.Enabled = false;
                Random_Button.Enabled = false;
            }
            else
            {

                button1.Enabled = true;
                Random_Button.Enabled = true;
            }
        }

        private void DinnerOperations_CLosing(object sender, FormClosingEventArgs e)
        {
            // Saving item information to files.
            string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string tagFilepath = path + "\\DinnerJournal\\DinnerValues.txt";



            StreamWriter tagFile = new StreamWriter(tagFilepath);
            foreach (var item in FoodItems) {
                tagFile.WriteLine(item.name.ToString() + "," + item.tg_1.ToString() + "," + item.tg_2.ToString() + "," + item.tg_3.ToString() + "," + item.itemRank.ToString()); // Deliminated by commas to save item info.
            }
            tagFile.Close();
        }

        // Returns the of the least used 10 items, a random selection of 5 items. Should be the least used in the laundry list of items. 
        // There might be some always returing values becuase just don't want to have an item all the time. Might want to increase the reach of the items as well. Last 15 or so?
        private void GenItem_Click(object sender, EventArgs e)
        {

            // This button will generate a list of 5 or so items that will be good matches for dinner. 
             

            /* Current Idea for Gen Item
             * Least Used Food Item.
             * Every Item has a numerical rank, food items with lower ranks should be chosen as priority.
             * When an Item is chosen, it increases its rank, Currently at about 10.
             * Every other item is then decremented by 1 or so, as they are least recently used. Might change 10 to 14 to indicate its been a couple of weeks. 
             * Or decrement all first then add 10. Don't want to get too caught up in semeantics. Should really not decrement the one being chosen.
             * Should user be able to check item rank from edit menu? Cap of like 50, if you get to 50 you are having it too much and shouldn't even be considered.
             * Then how flexible should generate be?
        
             * 
             * Also gets Items deleted from the list.
             */

            List<DinnerItem> unReturnedList = new List<DinnerItem>(FoodItems);
           
            // Bug testing for generated items
           // foreach (DinnerItem item in FoodItems)
           //     MessageBox.Show(item.name);

            unReturnedList = unReturnedList.OrderBy(x => x.itemRank).ToList(); // Must be working.
            // TODO - Note Decrement in select means that the values sometimes get to the same amount? should it work this way? Not really but it doesn't hurt anythihg

            Form1.instance.GenItems.Items.Clear();
            Random r = new Random();

            // Less than 5
            int lTF = TotalList.Items.Count - 1;
            // Less than Ten
            int lTTen = TotalList.Items.Count;
            List<int> randomList = new List<int>(); 
            if (lTF > 4) {
                lTF = 4;
            }
            if (lTTen > 15)
            {
                lTTen = 15;
            }
            
            // want to return a random 5 elements from the first 10 of the unReturnedList
            for (int i = 0; i <= lTF; i++)
            {
                int rInt = r.Next(0, lTTen);
                if (!randomList.Contains(rInt))
                {
                    randomList.Add(rInt);
                    GenItems.Items.Add(unReturnedList[rInt].name.ToString());
                }
                else
                    i--;
            }
            unReturnedList.Clear();
        }
        public void AddItem_Click(object sender, EventArgs e)
        {
            // This is the Add Item Box Will prompt to add a Dinner Item
            Form2 userInputItem = new Form2();
            userInputItem.ShowDialog();
           
            FoodItems.Sort((x,y) => string.Compare(x.name, y.name));
            if (TotalList.Items.Count != 0)
            {
                Random_Button.Enabled = true;
                button1.Enabled = true;
            }
            else
            {
                Random_Button.Enabled = false;
                button1.Enabled = false;
            }
        }



        // Deletes a selected item from Total List
        private void Delete_Click(object sender, EventArgs e)
        {
            // Simple error handeling
            if (TotalList.SelectedIndex != -1)
            {
                // Could change the dispaly message?
                Delete_Item Ditem = new Delete_Item();
                Ditem.ShowDialog();
            }
            else {
                EmptyListError ELE = new EmptyListError();
                ELE.ShowDialog();
                TotalList.SelectedIndex.Equals(TotalList.SelectedItem);
            }

            if (TotalList.Items.Count == 0) {
                button1.Enabled = false;
                Random_Button.Enabled = false;
            }

        }



        // Random Button for when just want something. with no rigamarole.
        // Taken from the TotalList, generates 3 items. Why 3? I dunno. 5 seems like a lot for some reason. But
        // not a lot when generating handpicked results. 
        private void Random_Button_Click(object sender, EventArgs e)
        {
            Form1.instance.GenItems.Items.Clear();
            Random r = new Random();

            if (Form1.instance.TotalList.Items.Count == 0)
            {
                EmptyListError ELE = new EmptyListError();
                // ShowDialog, will prevent access to parent. Show will allow access to parent.
                ELE.ShowDialog();
            }

            else { 
                // use this list to prevent random from getting a duplicate value. Looping a dictionary is not as efficient apparently. Need more sources for this. 
                List<int> randomList = new List<int>();
                
                // Less Than Three.
                int lTT;

                if (Form1.instance.TotalList.Items.Count < 3)
                {
                    lTT = Form1.instance.TotalList.Items.Count - 1;
                }
                else {
                    lTT = 2;
                }

                for (int i = 0; i <= lTT; i++)
                { 
                    int rInt = r.Next(0, Form1.instance.TotalList.Items.Count);
                    if (!randomList.Contains(rInt))
                    {
                        randomList.Add(rInt);
                        Form1.instance.GenItems.Items.Add(Form1.instance.TotalList.Items[rInt].ToString());
                    }
                    else {
                        i--;
                    }
                }
            }
        }

        // Selects an item from either Genitems or TotalList; Either way 
        private void SelectButton_Click(object sender, EventArgs e)
        {
            // The value to prevent picking the same item over and over again, i.e. how long should it be before the item should be chosen again. 
            int IRValue = 14;

            for (int i = 0; i < FoodItems.Count; i++)
            {
                // decrements each item, have to rewrite stuff cuz using a struct instead of a class probably.  but eh can't be bothered right now to fix it. Keep in mind when doing this over. 
                // UPDATE: Making it a class makes the valules in the list overwrite themseleves the way its implemented now. By having it as a struct the values are constants sure, but they don't overwrite themselves
                // when adding a new item. Its sad that this needs to be done this way but tis already done.
                if (FoodItems[i].itemRank != 0)
                {
                    DinnerItem Di = new DinnerItem();
                    Di.name = FoodItems[i].name;
                    Di.tg_1 = FoodItems[i].tg_1;
                    Di.tg_2 = FoodItems[i].tg_2;
                    Di.tg_3 = FoodItems[i].tg_3;
                    Di.itemRank = FoodItems[i].itemRank - 1;
                    FoodItems[i] = Di;
                }
            }

            if (TotalList.SelectedIndex >= 0)
            {
                DinnerItem Di = new DinnerItem();
                Di.name = FoodItems[TotalList.SelectedIndex].name;
                Di.tg_1 = FoodItems[TotalList.SelectedIndex].tg_1;
                Di.tg_2 = FoodItems[TotalList.SelectedIndex].tg_2;
                Di.tg_3 = FoodItems[TotalList.SelectedIndex].tg_3;
                Di.itemRank = FoodItems[TotalList.SelectedIndex].itemRank + IRValue;

                FoodItems[TotalList.SelectedIndex] = Di;

                SubmitConfirm SC = new SubmitConfirm();
                SC.ShowDialog();
            }
            else if (GenItems.SelectedIndex >= 0)
            {
                DinnerItem Di = new DinnerItem();
                Di.name = FoodItems[GenItems.SelectedIndex].name;
                Di.tg_1 = FoodItems[GenItems.SelectedIndex].tg_1;
                Di.tg_2 = FoodItems[GenItems.SelectedIndex].tg_2;
                Di.tg_3 = FoodItems[GenItems.SelectedIndex].tg_3;
                Di.itemRank = FoodItems[GenItems.SelectedIndex].itemRank + IRValue;

                FoodItems[GenItems.SelectedIndex] = Di;

                SubmitConfirm SC = new SubmitConfirm();
                SC.ShowDialog();
            }
            else {
                EmptyListError ElE = new EmptyListError();
                ElE.ShowDialog();
            }

        }

        private void FoodValues_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Buttons that are enabled once a selection is chosen 
            if (TotalList.SelectedIndex >= 0)
            {
                SelectButton.Enabled = true;
                Edit.Enabled = true;
                Delete.Enabled = true;
                button1.Enabled = true; 
            }

            else {
                SelectButton.Enabled = false;
                Edit.Enabled = false;
                Delete.Enabled = false;
            }
        }


        private void Suggestion_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (GenItems.SelectedIndex >= 0){ 
                SelectButton.Enabled = true;
            }
            else
            {
                SelectButton.Enabled = false;
            }
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            TotalList.ClearSelected();
            if (SearchBox.Text.Length == 0)
            {
                SearchBox.Select(0,0);
                SearchBox.Text = "Search...";
            }
        }

        private void SearchBox_AcceptsTabChanged(object sender, EventArgs e)
        {
            SearchBox.SelectAll();
        }
        
        private void SearchBox_MouseClick(object sender, MouseEventArgs e)
        {
            SearchBox.SelectAll();
        }
        
        // This will be where the function To search will be.
        private void SearchBox_TextChanged(object sender, EventArgs e)
        {

            // Works as intended for a search function.
            // Finds values in the tags or the names of items. 
            var fooDict = FoodSearch.Where(a => a.Value.name.ToLower().Contains(SearchBox.Text.ToLower()) ||
                                               a.Value.tg_1.ToLower().Contains(SearchBox.Text.ToLower()) ||
                                               a.Value.tg_2.ToLower().Contains(SearchBox.Text.ToLower()) ||
                                               a.Value.tg_3.ToLower().Contains(SearchBox.Text.ToLower())) ;
            
            GenItems.Items.Clear();
            foreach (var key in fooDict.ToDictionary(kvp => kvp.Key, kvp => kvp.Value).Keys)
            {
                GenItems.Items.Add(FoodSearch[key].name.ToString());
            }
        }

        private void Edit_Click(object sender, EventArgs e)
        {
            // In here, get the selected index, and allow user to Chnage the Name/Tags of that Entry.
            if (TotalList.SelectedIndex != -1)
            {
                EditForm Ef = new EditForm();
                Ef.ShowDialog();
            }
            else {
                EmptyListError ELE = new EmptyListError();
                ELE.ShowDialog();
            }

        }
    }
}
