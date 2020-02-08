using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace Asg2_kxl180016
{
    public partial class Form1 : Form
    {
        int backCount = 0;
        DTO dto = new DTO();
        AddressDTO adto = new AddressDTO();

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

        private void ProofCheck(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)13)
            {
                if (ProofBox.Checked)
                {
                    ProofBox.Checked = false;
                }
                else
                {
                    ProofBox.Checked = true;
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //expandScreen();
        }

        private void Add_Click(object sender, EventArgs e)
        {
            dto.FirstName = FNameBox.Text;
            dto.LastName = LNameBox.Text;
            dto.Gender = GenderBox.Text;
            dto.Phone = PhoneBox.Text;
            dto.Email = EmailBox.Text;
            dto.Proof = ProofBox.Checked;
            adto.StreetName = streetNameBox.Text;
            adto.ApartemntName = string.IsNullOrEmpty(streetNameBox2.Text) ? null : streetNameBox2.Text;
            adto.City = CityBox.Text;
            adto.State = StateBox.Text;
            adto.PostCode = ZipBox.Text;
            dto.Address = adto;
            try
            {
                StreamWriter sw = new StreamWriter("CS6326Asg2.txt");
                sw.WriteLine(dto.ToString());
                sw.Close();
            }
            catch(Exception ex)
            {
                Warning.Text = ("Exception:" + ex.Message);
            }
            ClearForm();
        }

        private void ClearForm()
        {
            Action<Control.ControlCollection> func = null;
            func = (controls) =>
            {
                foreach (Control control in controls)
                    if (control is TextBox)
                        (control as TextBox).Clear();
                    else
                        func(control.Controls);
            };
            func(Controls);
            ProofBox.Checked = false;
        }
    }
}
