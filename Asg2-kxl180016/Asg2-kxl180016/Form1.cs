using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Asg2_kxl180016
{
    public partial class Form1 : Form
    {
        int backCount = 0;
        DTO dto = new DTO();
        public Form1()
        {
            InitializeComponent();
        }

        private void FNameBox_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(FNameBox.Text)){
                displayWarning("First Name");
            }
            else
            {
                Warning.Visible = false;
            }
        }

        private void MiddleBox_TextChanged(object sender, EventArgs e)
        {
            char m = ' ';
            if (!string.IsNullOrEmpty(MiddleBox.Text))
            {
                m = MiddleBox.Text.ToCharArray()[0];
            }
            dto.MiddleName = m;
        }
        private void displayWarning(string name)
        {
             Warning.Text =  name += " Can Not Be Empty";
             Warning.Visible = true;           
        }
        private void BackCount(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)Keys.Back)
            {
                backCount += 1;
                dto.BackCount = backCount;
            }

        }
    }
}
