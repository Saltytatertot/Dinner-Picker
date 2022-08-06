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
    public partial class SubmitConfirm : Form
    {
        public SubmitConfirm()
        {
            InitializeComponent();
        }

        private void SubmitConfirm_Load(object sender, EventArgs e)
        {
            if (Form1.instance.GenItems.SelectedIndex >= 0)
            {
                ConfirmLabel.Text = "Congratulations on picking " + Form1.instance.GenItems.SelectedItem.ToString() + " for dinner!";
            }
            else if(Form1.instance.TotalList.SelectedIndex >= 0)
            {
                ConfirmLabel.Text = "Congratulations on picking " + Form1.instance.TotalList.SelectedItem.ToString() + " for dinner!";
            }
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
