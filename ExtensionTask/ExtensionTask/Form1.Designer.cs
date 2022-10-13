namespace ExtensionTask
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
            this.overMonths = new System.Windows.Forms.CheckBox();
            this.numberMonthsSpinner = new System.Windows.Forms.NumericUpDown();
            this.exitButton = new System.Windows.Forms.Button();
            this.balanceListBox = new System.Windows.Forms.ListBox();
            this.balanceBox = new System.Windows.Forms.TextBox();
            this.balanceLabel = new System.Windows.Forms.Label();
            this.endingBalance = new System.Windows.Forms.Label();
            this.calculateButton = new System.Windows.Forms.Button();
            this.endingBalanceLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numberMonthsSpinner)).BeginInit();
            this.SuspendLayout();
            // 
            // overMonths
            // 
            this.overMonths.AutoSize = true;
            this.overMonths.Location = new System.Drawing.Point(80, 112);
            this.overMonths.Name = "overMonths";
            this.overMonths.Size = new System.Drawing.Size(237, 29);
            this.overMonths.TabIndex = 1;
            this.overMonths.Text = "Over certain months";
            this.overMonths.UseVisualStyleBackColor = true;
            this.overMonths.CheckedChanged += new System.EventHandler(this.overMonths_CheckedChanged);
            // 
            // numberMonthsSpinner
            // 
            this.numberMonthsSpinner.Enabled = false;
            this.numberMonthsSpinner.Location = new System.Drawing.Point(310, 112);
            this.numberMonthsSpinner.Name = "numberMonthsSpinner";
            this.numberMonthsSpinner.Size = new System.Drawing.Size(120, 31);
            this.numberMonthsSpinner.TabIndex = 3;
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(203, 377);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(82, 36);
            this.exitButton.TabIndex = 5;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // balanceListBox
            // 
            this.balanceListBox.DataSource = this.balanceListBox.CustomTabOffsets;
            this.balanceListBox.Enabled = false;
            this.balanceListBox.FormattingEnabled = true;
            this.balanceListBox.ItemHeight = 25;
            this.balanceListBox.Location = new System.Drawing.Point(44, 147);
            this.balanceListBox.Name = "balanceListBox";
            this.balanceListBox.Size = new System.Drawing.Size(444, 179);
            this.balanceListBox.TabIndex = 6;
            this.balanceListBox.Visible = false;
            this.balanceListBox.SelectedIndexChanged += new System.EventHandler(this.balanceListBox_SelectedIndexChanged);
            // 
            // balanceBox
            // 
            this.balanceBox.Location = new System.Drawing.Point(249, 66);
            this.balanceBox.Name = "balanceBox";
            this.balanceBox.Size = new System.Drawing.Size(181, 31);
            this.balanceBox.TabIndex = 7;
            // 
            // balanceLabel
            // 
            this.balanceLabel.AutoSize = true;
            this.balanceLabel.Location = new System.Drawing.Point(75, 66);
            this.balanceLabel.Name = "balanceLabel";
            this.balanceLabel.Size = new System.Drawing.Size(174, 25);
            this.balanceLabel.TabIndex = 8;
            this.balanceLabel.Text = "Starting balance:";
            // 
            // endingBalance
            // 
            this.endingBalance.AutoSize = true;
            this.endingBalance.Location = new System.Drawing.Point(75, 343);
            this.endingBalance.Name = "endingBalance";
            this.endingBalance.Size = new System.Drawing.Size(157, 25);
            this.endingBalance.TabIndex = 9;
            this.endingBalance.Text = "Ending Balace:";
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(363, 337);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(125, 42);
            this.calculateButton.TabIndex = 11;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // endingBalanceLabel
            // 
            this.endingBalanceLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.endingBalanceLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.endingBalanceLabel.Location = new System.Drawing.Point(238, 342);
            this.endingBalanceLabel.Name = "endingBalanceLabel";
            this.endingBalanceLabel.Size = new System.Drawing.Size(119, 32);
            this.endingBalanceLabel.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(527, 420);
            this.Controls.Add(this.endingBalanceLabel);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.endingBalance);
            this.Controls.Add(this.balanceLabel);
            this.Controls.Add(this.balanceBox);
            this.Controls.Add(this.balanceListBox);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.numberMonthsSpinner);
            this.Controls.Add(this.overMonths);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numberMonthsSpinner)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.CheckBox overMonths;
        private System.Windows.Forms.NumericUpDown numberMonthsSpinner;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.ListBox balanceListBox;
        private System.Windows.Forms.TextBox balanceBox;
        private System.Windows.Forms.Label balanceLabel;
        private System.Windows.Forms.Label endingBalance;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Label endingBalanceLabel;
    }
}

