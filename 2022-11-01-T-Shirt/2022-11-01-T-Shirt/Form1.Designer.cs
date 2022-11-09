namespace _2022_11_01_T_Shirt
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ColourLbl = new System.Windows.Forms.Label();
            this.SizeLbl = new System.Windows.Forms.Label();
            this.ShirtSize_LstBx = new System.Windows.Forms.ComboBox();
            this.PrintTextChk = new System.Windows.Forms.CheckBox();
            this.TotalLbl = new System.Windows.Forms.Label();
            this.Total_Lbl = new System.Windows.Forms.Label();
            this.TshirtPrintLbl = new System.Windows.Forms.Label();
            this.TextPrintLbl = new System.Windows.Forms.Label();
            this.MaterialLbl = new System.Windows.Forms.Label();
            this.MaterialComboBox = new System.Windows.Forms.ComboBox();
            this.CalculateBtn = new System.Windows.Forms.Button();
            this.QuantityUD = new System.Windows.Forms.NumericUpDown();
            this.QuantityLbl = new System.Windows.Forms.Label();
            this.ColourListBox = new System.Windows.Forms.ComboBox();
            this.TshirtPB = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.QuantityUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TshirtPB)).BeginInit();
            this.SuspendLayout();
            // 
            // ColourLbl
            // 
            this.ColourLbl.AutoSize = true;
            this.ColourLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ColourLbl.Location = new System.Drawing.Point(86, 80);
            this.ColourLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ColourLbl.Name = "ColourLbl";
            this.ColourLbl.Size = new System.Drawing.Size(66, 20);
            this.ColourLbl.TabIndex = 1;
            this.ColourLbl.Text = "Colour:";
            // 
            // SizeLbl
            // 
            this.SizeLbl.AutoSize = true;
            this.SizeLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SizeLbl.Location = new System.Drawing.Point(104, 152);
            this.SizeLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SizeLbl.Name = "SizeLbl";
            this.SizeLbl.Size = new System.Drawing.Size(49, 20);
            this.SizeLbl.TabIndex = 3;
            this.SizeLbl.Text = "Size:";
            // 
            // ShirtSize_LstBx
            // 
            this.ShirtSize_LstBx.FormattingEnabled = true;
            this.ShirtSize_LstBx.Items.AddRange(new object[] {
            "XS - £15.00",
            "S - £16.50",
            "M - £18.00",
            "L - £19.50",
            "XL - £25.00",
            "2XL - £40.00"});
            this.ShirtSize_LstBx.Location = new System.Drawing.Point(158, 148);
            this.ShirtSize_LstBx.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ShirtSize_LstBx.Name = "ShirtSize_LstBx";
            this.ShirtSize_LstBx.Size = new System.Drawing.Size(175, 28);
            this.ShirtSize_LstBx.TabIndex = 4;
            this.ShirtSize_LstBx.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // PrintTextChk
            // 
            this.PrintTextChk.AutoSize = true;
            this.PrintTextChk.Location = new System.Drawing.Point(158, 192);
            this.PrintTextChk.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PrintTextChk.Name = "PrintTextChk";
            this.PrintTextChk.Size = new System.Drawing.Size(115, 24);
            this.PrintTextChk.TabIndex = 6;
            this.PrintTextChk.Text = "Printed text";
            this.PrintTextChk.UseVisualStyleBackColor = true;
            this.PrintTextChk.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // TotalLbl
            // 
            this.TotalLbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TotalLbl.Location = new System.Drawing.Point(158, 505);
            this.TotalLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TotalLbl.Name = "TotalLbl";
            this.TotalLbl.Size = new System.Drawing.Size(176, 24);
            this.TotalLbl.TabIndex = 7;
            // 
            // Total_Lbl
            // 
            this.Total_Lbl.AutoSize = true;
            this.Total_Lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Total_Lbl.Location = new System.Drawing.Point(96, 506);
            this.Total_Lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Total_Lbl.Name = "Total_Lbl";
            this.Total_Lbl.Size = new System.Drawing.Size(54, 20);
            this.Total_Lbl.TabIndex = 8;
            this.Total_Lbl.Text = "Total:";
            // 
            // TshirtPrintLbl
            // 
            this.TshirtPrintLbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TshirtPrintLbl.Location = new System.Drawing.Point(158, 222);
            this.TshirtPrintLbl.Name = "TshirtPrintLbl";
            this.TshirtPrintLbl.Size = new System.Drawing.Size(226, 140);
            this.TshirtPrintLbl.TabIndex = 9;
            this.TshirtPrintLbl.Visible = false;
            this.TshirtPrintLbl.Click += new System.EventHandler(this.TshirtPrintLbl_Click);
            // 
            // TextPrintLbl
            // 
            this.TextPrintLbl.AutoSize = true;
            this.TextPrintLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextPrintLbl.Location = new System.Drawing.Point(57, 223);
            this.TextPrintLbl.Name = "TextPrintLbl";
            this.TextPrintLbl.Size = new System.Drawing.Size(93, 20);
            this.TextPrintLbl.TabIndex = 10;
            this.TextPrintLbl.Text = "Enter text:";
            this.TextPrintLbl.Visible = false;
            this.TextPrintLbl.Click += new System.EventHandler(this.TextPrintLbl_Click);
            // 
            // MaterialLbl
            // 
            this.MaterialLbl.AutoSize = true;
            this.MaterialLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaterialLbl.Location = new System.Drawing.Point(72, 409);
            this.MaterialLbl.Name = "MaterialLbl";
            this.MaterialLbl.Size = new System.Drawing.Size(78, 20);
            this.MaterialLbl.TabIndex = 11;
            this.MaterialLbl.Text = "Material:\r\n";
            // 
            // MaterialComboBox
            // 
            this.MaterialComboBox.FormattingEnabled = true;
            this.MaterialComboBox.Items.AddRange(new object[] {
            "Cotton - £5.00",
            "Nylon - £5.00",
            "linen - £5.00"});
            this.MaterialComboBox.Location = new System.Drawing.Point(158, 405);
            this.MaterialComboBox.Name = "MaterialComboBox";
            this.MaterialComboBox.Size = new System.Drawing.Size(175, 28);
            this.MaterialComboBox.TabIndex = 12;
            this.MaterialComboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // CalculateBtn
            // 
            this.CalculateBtn.Location = new System.Drawing.Point(183, 554);
            this.CalculateBtn.Name = "CalculateBtn";
            this.CalculateBtn.Size = new System.Drawing.Size(93, 42);
            this.CalculateBtn.TabIndex = 13;
            this.CalculateBtn.Text = "Calculate";
            this.CalculateBtn.UseVisualStyleBackColor = true;
            this.CalculateBtn.Click += new System.EventHandler(this.CalculateBtn_Click);
            // 
            // QuantityUD
            // 
            this.QuantityUD.Location = new System.Drawing.Point(158, 460);
            this.QuantityUD.Maximum = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.QuantityUD.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.QuantityUD.Name = "QuantityUD";
            this.QuantityUD.Size = new System.Drawing.Size(54, 26);
            this.QuantityUD.TabIndex = 14;
            this.QuantityUD.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // QuantityLbl
            // 
            this.QuantityLbl.AutoSize = true;
            this.QuantityLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuantityLbl.Location = new System.Drawing.Point(70, 463);
            this.QuantityLbl.Name = "QuantityLbl";
            this.QuantityLbl.Size = new System.Drawing.Size(81, 20);
            this.QuantityLbl.TabIndex = 15;
            this.QuantityLbl.Text = "Quantity:";
            this.QuantityLbl.Click += new System.EventHandler(this.QuantityLbl_Click);
            // 
            // ColourListBox
            // 
            this.ColourListBox.FormattingEnabled = true;
            this.ColourListBox.Items.AddRange(new object[] {
            "red",
            "orange",
            "yellow",
            "green",
            "blue",
            "black",
            "white"});
            this.ColourListBox.Location = new System.Drawing.Point(158, 75);
            this.ColourListBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ColourListBox.Name = "ColourListBox";
            this.ColourListBox.Size = new System.Drawing.Size(175, 28);
            this.ColourListBox.TabIndex = 0;
            this.ColourListBox.SelectedIndexChanged += new System.EventHandler(this.ColourListBox_SelectedIndexChanged);
            // 
            // TshirtPB
            // 
            this.TshirtPB.Location = new System.Drawing.Point(433, 12);
            this.TshirtPB.Name = "TshirtPB";
            this.TshirtPB.Size = new System.Drawing.Size(755, 668);
            this.TshirtPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.TshirtPB.TabIndex = 16;
            this.TshirtPB.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.TshirtPB);
            this.Controls.Add(this.QuantityLbl);
            this.Controls.Add(this.QuantityUD);
            this.Controls.Add(this.CalculateBtn);
            this.Controls.Add(this.MaterialComboBox);
            this.Controls.Add(this.MaterialLbl);
            this.Controls.Add(this.TextPrintLbl);
            this.Controls.Add(this.TshirtPrintLbl);
            this.Controls.Add(this.Total_Lbl);
            this.Controls.Add(this.TotalLbl);
            this.Controls.Add(this.PrintTextChk);
            this.Controls.Add(this.ShirtSize_LstBx);
            this.Controls.Add(this.SizeLbl);
            this.Controls.Add(this.ColourLbl);
            this.Controls.Add(this.ColourListBox);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.QuantityUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TshirtPB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label ColourLbl;
        private System.Windows.Forms.Label SizeLbl;
        private System.Windows.Forms.ComboBox ShirtSize_LstBx;
        private System.Windows.Forms.CheckBox PrintTextChk;
        private System.Windows.Forms.Label TotalLbl;
        private System.Windows.Forms.Label Total_Lbl;
        private System.Windows.Forms.Label TshirtPrintLbl;
        private System.Windows.Forms.Label TextPrintLbl;
        private System.Windows.Forms.Label MaterialLbl;
        private System.Windows.Forms.ComboBox MaterialComboBox;
        private System.Windows.Forms.Button CalculateBtn;
        private System.Windows.Forms.NumericUpDown QuantityUD;
        private System.Windows.Forms.Label QuantityLbl;
        private System.Windows.Forms.ComboBox ColourListBox;
        private System.Windows.Forms.PictureBox TshirtPB;
    }
}

