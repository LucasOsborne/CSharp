using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace _2022_10_17_CalanderProject
{
    
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void FileDropTxtBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void OpenBtn_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dialog = new OpenFileDialog())
            {
                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    DragDropLabel.Text = dialog.SafeFileName.Trim();
                }
            }
        }

        private void FileDropTxtBox_DragOver(object sender, DragEventArgs e)
        {
            
        }

        private void FileDropTxtBox_DragDrop(object sender, DragEventArgs e)
        {
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void CreateButton_Click(object sender, EventArgs e)
        {

            Panel ContainerPanel = new Panel()
            {
            };

            // Adding this control to the form
            this.Controls.Add(ContainerPanel);

        }

        private void SideBarPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ProfilePicturePicBox_Click(object sender, EventArgs e)
        {

        }

        private void DragDropLabel_Click(object sender, EventArgs e)
        {
            
        }

        private void DragDropLabelDrop(object sender, DragEventArgs e)
        {
            string[] files = e.Data.GetData(DataFormats.FileDrop) as string[]; //Get all files droppeds
            if (files != null && files.Any())
                DragDropLabel.Text = files.First().Substring(1 + files.First().LastIndexOf('\\')); //Select the first one

        }

        private void DragDropLabelOver(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.Link;
            else
                e.Effect = DragDropEffects.None;
        }

        private void DragDropLabelPaint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, DragDropLabel.DisplayRectangle, Color.White, ButtonBorderStyle.Solid);

        }
    }
}
