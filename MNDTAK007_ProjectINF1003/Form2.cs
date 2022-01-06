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
    public partial class AboutForm : Form
    {

        public AboutForm()
        {
            InitializeComponent();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {

        }

        private void aboutUsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Owner : Mr. Suleiman Thandaza", "About", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void theCompanyToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void telephoneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Landline: 021-901-6642" + Environment.NewLine + "Mobile: 082-757-9298" , "Contact Details", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void staffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            staffForm secondform = new staffForm();
            secondform.ShowDialog();
        }

        private void orderFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
             orderForm secondform = new orderForm();
             secondform.ShowDialog();
        }

        private void contactToolStripMenuItem_Click(object sender, EventArgs e)
        {
            

        }

        private void addressToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Our physical address is:" + Environment.NewLine + "82 Menlyn Avenue" + Environment.NewLine + "Mowbray" + Environment.NewLine + "Cape Town" + Environment.NewLine + "7195", "Contact Details", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void emailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("We are availble via email:" + Environment.NewLine + "Suleiman Thandaza: sthandaza@netplace.co.za" + Environment.NewLine + " George Lebese : glebese@netplace.co.za" + Environment.NewLine + " Gareth Cliff : gcliff@netcafe.co.za", "Email Addresses ", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void companyVisionToolStripMenuItem_Click(object sender, EventArgs e)
        {

            MessageBox.Show(" The Net Café -also known as the finest cybercafé Mowbray has to offer- is a café / convenience store with fully dedicated Internet access business that provides Internet access to the public right here in Cape Town.", "Company Vision", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}
