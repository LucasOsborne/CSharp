using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2022_11_01_T_Shirt
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        decimal printPrice = 0m;
        decimal totalPrice = 0m;
        decimal totalMaterialCost = 0m;
        decimal shirtSizeCost = 0m;
  

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)

        { 
            var ShirtSize = (string)ShirtSize_LstBx.SelectedItem;
            MessageBox.Show($"You have selected: {ShirtSize}");
            string[] ShirtSplit = ShirtSize.Split(' '); //splits the text from the price
            decimal ShirtCost = decimal.Parse(ShirtSplit[2].Substring(1, 5)); //Gets the price and converts it to deicmal
            shirtSizeCost = shirtSizeCost + ShirtCost;
            
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (!PrintTextChk.Checked)
            {
                TshirtPrintLbl.Hide();
                TextPrintLbl.Hide();
                printPrice = 0m;
            }
            else
            {
                TshirtPrintLbl.Show();
                TextPrintLbl.Show();
                printPrice = 3.50m;


            }
        }

        private void TshirtPrintLbl_Click(object sender, EventArgs e)
        {

        }

        private void TextPrintLbl_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var MaterialSize = (string)MaterialComboBox.SelectedItem;
            //MessageBox.Show($"You have selected: {MaterialSize}");
            string[] MaterialSplit = MaterialSize.Split(' '); //splits the text from the price
            decimal MaterialCost = decimal.Parse(MaterialSplit[2].Substring(1, 4)); //Gets the price and converts it to deicmal
            totalMaterialCost = totalMaterialCost + MaterialCost;
        }

        private void CalculateBtn_Click(object sender, EventArgs e)
        {
            totalPrice = ((printPrice + shirtSizeCost + totalMaterialCost) * QuantityUD.Value);
            TotalLbl.Text = ($"£{totalPrice}");
        }

        private void QuantityLbl_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void ColourListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Bitmap bmp = (Bitmap)Bitmap.FromFile("C:\\Users\\lucas\\OneDrive\\Documents\\CSharp\\2022-11-01-T-Shirt\\2022-11-01-T-Shirt\\tshirt.png");
            for (int x = 0; x < bmp.Width; x++)
            {
                for(int y = 0; y < bmp.Height; y++)
                {
                    bmp.SetPixel(x, y, Color.Teal);
                }
            }
            Tshi.Image = bmp;

        }
    }
}
