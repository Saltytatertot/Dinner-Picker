using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Dinner_Picker
{
    // This form will be called from the edit button from Form1   
    public partial class EditForm : Form
    {
        public static EditForm instance;
        public TextBox fdName;
        public EditForm()
        {
            InitializeComponent();
            instance = this;
            fdName = textBox1;

        }

        // This is the Texbox to put new food items in on Click from the Add Item Button.
        // Really just keeping this around to remember what the textbox is called. Which is the generic name. 
        public void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void EditForm_Load(object sender, EventArgs e)
        {
            // How to prevent edit when there is not listbox selected entry?
            if (Form1.instance.TotalList.SelectedIndex != -1)
            {
                // Load in tag information from the tag Item from the listbox selection
                textBox1.Text = Form1.instance.FoodItems[Form1.instance.TotalList.SelectedIndex].name;
                Tag1Box.Text = Form1.instance.FoodItems[Form1.instance.TotalList.SelectedIndex].tg_1;
                Tag2Box.Text = Form1.instance.FoodItems[Form1.instance.TotalList.SelectedIndex].tg_2;
                Tag3Box.Text = Form1.instance.FoodItems[Form1.instance.TotalList.SelectedIndex].tg_3;
            }

        }

        public void Submit_Click(object sender, EventArgs e)
        {
            DinnerItem Di = new DinnerItem()
            {
                name = textBox1.Text,
                tg_1 = Tag1Box.Text,
                tg_2 = Tag2Box.Text,
                tg_3 = Tag3Box.Text,
            };
            Form1.instance.TotalList.Items[Form1.instance.TotalList.SelectedIndex] = Di.name;
            Form1.instance.FoodSearch.Add(Form1.instance.Enumed, Di);
            Form1.instance.Enumed++;



            // Will hold a new object called Di in succeeding positions. Now have to think how to access names of the objects. 
            Form1.instance.FoodItems[Form1.instance.TotalList.SelectedIndex] = Di;

            // Should save the information from the textboxs into the replaced item at the index. 

            //var mainForm = new Form1
            this.Close();

        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            //textBox1.Clear();
            this.Close();
        }
    }
}
