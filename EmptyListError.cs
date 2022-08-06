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
    public partial class EmptyListError : Form
    {
        public EmptyListError()
        {
            InitializeComponent();
        }

        private void Okay_Button_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
