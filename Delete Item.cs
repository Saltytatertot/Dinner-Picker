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
    public partial class Delete_Item : Form
    {
        public Delete_Item()
        {
            InitializeComponent();
        }
        // Get Selected Item to remain relative to where an item was deleted. 
        private void Delete_Button_Click(object sender, EventArgs e)
        {
            int tempValue = Form1.instance.TotalList.SelectedIndex;
            bool SetSelect = true;
            if (Form1.instance.FoodItems.Count != 0)
            {
                MessageBox.Show(Form1.instance.TotalList.SelectedIndex.ToString());
                Form1.instance.FoodItems.RemoveAt(Form1.instance.TotalList.SelectedIndex); // Was an order of operations issue causing wrong item being deleted.
                Form1.instance.TotalList.Items.Remove(Form1.instance.TotalList.SelectedItem);
                Form1.instance.FoodSearch.Remove(Form1.instance.TotalList.SelectedIndex);
                // Works only when not empty
                if ((tempValue >= Form1.instance.TotalList.Items.Count || tempValue > 0))
                {
                    tempValue--;
                    if (tempValue >= 0)
                    {
                        Form1.instance.TotalList.SetSelected(tempValue, SetSelect);
                    }
                }
                // Needs to be here to continually set item as selected.
                else if (tempValue == 0 && Form1.instance.TotalList.Items.Count > 0)
                {
                    Form1.instance.TotalList.SetSelected(0, true);
                }
            }

            // Value to get the selected index from the listbox. Tags are behind the scenes while the listbox is front end. 
            // How to sort
            // Form1.instance.TotalList.SelectedIndex;
            this.Close();
        }

        private void Cancel_Button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Delete_Item_Load(object sender, EventArgs e)
        {
            areYouSureDelete.AutoSize = false;
            areYouSureDelete.Text = "Are you sure you want to delete \n\"" + (Form1.instance.TotalList.SelectedItem.ToString()) + "\"?" ;
        }
    }
}
