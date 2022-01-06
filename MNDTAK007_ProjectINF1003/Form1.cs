using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MNDTAK007_ProjectINF1003
{
    public partial class startingForm : Form
    {
        public startingForm()
        {
            InitializeComponent();
            
        }




        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AboutForm secondform = new AboutForm();
            secondform.ShowDialog();
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
          
            // The password character is an asterisk.
            passwordTxt.PasswordChar = '*';
            // Password can be no more than 4 characters.
            passwordTxt.MaxLength = 4;
        }

        private void txtEmpName_TextChanged(object sender, EventArgs e)
        {


        }

        private void empNameTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void passwordTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar)  && !char.IsLetterOrDigit(e.KeyChar)) // && 
      //(e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void startingForm_Load(object sender, EventArgs e)
        {

        }

        private void logoPic_Click(object sender, EventArgs e)
        {

        }
    }
}
