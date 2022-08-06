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
    
    public partial class Form2 : Form
    {
        public static Form2 instance;
        public TextBox fdName;
        public Form2()
        {
            InitializeComponent();
            instance = this;
            fdName = textBox1;

        }



        // This is the Texbox to put new food items in on Click from the Add Item Button.
        public void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            //textBox1.Text = DinnerItem.name;
        }

        public void Submit_Click(object sender, EventArgs e)
        {
            // Working solution, but does not include tag elements. Or saved data.
            DinnerItem Di = new DinnerItem();
            Di.name = textBox1.Text;
            Di.tg_1 = Tag1Box.Text;
            Di.tg_2 = Tag2Box.Text;
            Di.tg_3 = Tag3Box.Text;
            Di.itemRank = 0;
            
            Form1.instance.TotalList.Items.Add(Di.name);
            Form1.instance.FoodSearch.Add(Form1.instance.Enumed, Di);
            Form1.instance.Enumed++;

            // MessageBox.Show(Form1.instance.Enumed.ToString()); Enumed is incrementing appropriately


            // Will hold a new object called Di in succeeding positions. Now have to think how to access names of the objects. 
            Form1.instance.FoodItems.Add(Di);

            //var mainForm = new Form1
            this.Close();

        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            this.Close();
        }
    }
}
