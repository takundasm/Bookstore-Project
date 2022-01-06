using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MNDTAK007_ProjectINF1003
{
    public partial class orderForm : Form
    {
        // int hoursReq;
        // string nameTxt;
        const decimal vat = 0.14m; 
        const decimal cost0to1hours = 20m;
        const decimal cost1to2hours = 15m;
        const decimal cost2to4hours = 10m;
        const decimal cost4to8hours = 07.5m;

        string message;
        int hours;
        decimal vatCost = 0, totPrice = 0, Price = 0, totVat = 0, endPrice = 0, discAmt = 0;

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void hoursTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void nameTxt_TextChanged(object sender, EventArgs e)
        {

        }

        decimal hourlyPrice = 0, discDeci = 0, couponNum = 0;
        string MessageString = "";
        int totHours, custNo; 




        public orderForm()
        {
            InitializeComponent();
            // int chargeTotal(int chargeTotal)
            

                //return hoursTxt * length;
            
        }

        private void calculations()
        {
            hours = int.Parse(hoursTxt.Text);

            if ((hours > 0) && (hours <= 1))
            {
                hourlyPrice = cost0to1hours;
            }
            else if ((hours > 1) && (hours <= 2))
            {
                hourlyPrice = cost1to2hours;
            }
            else if ((hours >= 2) && (hours <= 4))
            {
                hourlyPrice = cost2to4hours;
            }
            else if ((hours >= 4) && (hours <= 8))
            {
                hourlyPrice = cost4to8hours;
            }
            else if (hours > 8)
            {
                MessageBox.Show("Too many hours. Enter a number 8 or below");
                // MessageBoxButtons., MessageBoxIcon.Error);;
            }

                if (yesOption.Checked)
                {
                    discDeci = 0.2m;
                }
                else
                {
                    discDeci = 0m;
                }

                totPrice = hourlyPrice * hours;
                vatCost = totPrice * vat;
                Price = (totPrice + vatCost);
                couponNum = (Price * discDeci);
                endPrice = Price - couponNum;

                totHours += hours;
                totVat += vatCost;
                discAmt = couponNum;
                custNo += 1;
                Price += endPrice;

                grossTxt.Text = totPrice.ToString("C");
                vatTxt.Text = vatCost.ToString("C");
                totalTxt.Text = endPrice.ToString("C");


            }
        }
    }


    private void textBox1_TextChanged(object sender, EventArgs e)
        {
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageString == " ")
            {
                MessageBox.Show("Select what to print.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            else
            {
                if (printPreviewDialog1.ShowDialog() == DialogResult.OK)
                {
                    printDocument1.Print();
                }
            }
        }

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            //e.Graphics.DrawString(MessageString, new Font("Time New Romans", 10, FontStyle.Regular);
                
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripLabel3_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void fontToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            fontDialog1.ShowDialog();
            nameTxt.Font = fontDialog1.Font;
            hoursTxt.Font = fontDialog1.Font; 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (custNo > 0)
            {
                try
                {
                    MessageString = "Vat charged :" + totVat.ToString("C") +
                        Environment.NewLine + Environment.NewLine +
                        "Discounts :" + discAmt.ToString("C") + Environment.NewLine + Environment.NewLine +
                        "Amount paid:" + Price.ToString("C") + Environment.NewLine + Environment.NewLine +
                        "No. of customer:" + custNo.ToString("N0");

                    MessageBox.Show(MessageString, "Customer summary",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    // QuantityTextBox.Focus();
                }
                catch // (FormatException QuantityException) ric
                {
                    MessageString = "Please try the calculation again.";
                    MessageBox.Show(MessageString, "Input Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    // QuantityTextBox.Focus();
                    //hoursTxt.Focus();
                }

                hoursTxt.Focus();
                }
                else
                {
                MessageString = "Please enter an employee name.";
                MessageBox.Show(MessageString, "Missing Data",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
                nameTxt.Focus();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {                
            
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            yesOption.Checked = false;
            noOption.Checked = false;
            hoursTxt.Clear();
            vatTxt.Clear();
            totalTxt.Clear();
            grossTxt.Clear();
            nameTxt.Clear();



        }

        private void orderForm_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            int hours = int.Parse(hoursTxt.Text);

            if (hours > 8)
            {
                MessageBox.Show("Please enter a number below 8.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void textBox1_TextChanged_2(object sender, EventArgs e)
        {
            string name = nameTxt.Text;

            try
            {
                name = "Takunda";                           // HAVE THE USER PUT THEIR NAME HERE
            }

            catch
            {
                MessageBox.Show("Please enter your name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    private void enterBtn_Click(object sender, EventArgs e)
    {
        string name = nameTxt.Text;

        if (nameTxt.Text != "")
        {
            try
            {
                hours = int.Parse(hoursTxt.Text);

                if (hours <= 0)
                {
                    message = "Please enter a time bigger than 0.";
                    MessageBox.Show(message, "Missing Data",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    // NameTextBox.Focus();
                    //hoursTxt.Focus();
                }
                else
                {
                    calculations();
                }
            }
            catch (FormatException QuantityException) //Quantity must be numeric
            {
                message = "Please input the number of pieces." + QuantityException;
                MessageBox.Show(message, "Input Error found",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                // hoursTxt.Focus();
            }

            catch (Exception AnException)
            {

                MessageBox.Show("Error found: " + AnException.Message);
            }
        }
        else
        {            //No entry in name field
            message = "Please enter a name.";
            MessageBox.Show(message, "Data missing",
            MessageBoxButtons.OK, MessageBoxIcon.Information);
            //nameTxt.Focus();
        }

        if (endPrice > 100)
        {
            listBox1.Items.Add(name);
        }
    }

        

    
 

