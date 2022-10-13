using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExtensionTask
{
    public partial class Form1 : Form
    {
        class Global
        {
            public const decimal INTEREST_RATE = 0.005M;
        }
        public Form1()
        {
            InitializeComponent();
        }


        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void overMonths_CheckedChanged(object sender, EventArgs e)
        {
            if(overMonths.Checked) {
                numberMonthsSpinner.Enabled = true;
                balanceListBox.Show();
            }
            else
            {
                numberMonthsSpinner.Enabled = false;
                balanceListBox.Hide();
            }
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            balanceListBox.DataSource = null;
            balanceListBox.Items.Clear();
            
            
            const decimal INTEREST_RATE = Global.INTEREST_RATE;
            int months;
            var listBoxOutput = GlobalHelpers.listBoxOutput;
            var balance = GlobalHelpers.balance;
            if (decimal.TryParse(balanceBox.Text, out balance))
            {
                if (overMonths.Checked)
                {
                    if (int.TryParse(numberMonthsSpinner.Value.ToString(), out months))
                    {
                        for (var count = 1; count <= months; count++)
                        {
                            balance = balance + (INTEREST_RATE * balance);
                            listBoxOutput = "The ending balance for month " + count.ToString() + " is " + balance.ToString("c");
                            balanceListBox.Items.Add(listBoxOutput);
                        }
                        endingBalanceLabel.Text = balance.ToString("c");
                    }
                    else
                    {
                        MessageBox.Show("Invalid value for months.");
                    }
                }
                else
                {
                    balance = balance + (INTEREST_RATE * balance);
                    endingBalanceLabel.Text = balance.ToString("c");
                }


            }
            else
            {
                MessageBox.Show("Invalid value for starting balance");
            }
        }

        private void rubleRadio_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void balanceListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
