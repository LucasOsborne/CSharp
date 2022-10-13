namespace AccountBalance
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
            this.startingBalancePromptLabel = new System.Windows.Forms.Label();
            this.monthsPromptLabel = new System.Windows.Forms.Label();
            this.outputDescriptionLabel = new System.Windows.Forms.Label();
            this.startingBalTextBox = new System.Windows.Forms.TextBox();
            this.monthsTextBox = new System.Windows.Forms.TextBox();
            this.endingBalanceLabel = new System.Windows.Forms.Label();
            this.calculateButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.detailListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // startingBalancePromptLabel
            // 
            this.startingBalancePromptLabel.AutoSize = true;
            this.startingBalancePromptLabel.Location = new System.Drawing.Point(56, 63);
            this.startingBalancePromptLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.startingBalancePromptLabel.Name = "startingBalancePromptLabel";
            this.startingBalancePromptLabel.Size = new System.Drawing.Size(176, 25);
            this.startingBalancePromptLabel.TabIndex = 0;
            this.startingBalancePromptLabel.Text = "Starting Balance:";
            // 
            // monthsPromptLabel
            // 
            this.monthsPromptLabel.AutoSize = true;
            this.monthsPromptLabel.Location = new System.Drawing.Point(40, 113);
            this.monthsPromptLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.monthsPromptLabel.Name = "monthsPromptLabel";
            this.monthsPromptLabel.Size = new System.Drawing.Size(193, 25);
            this.monthsPromptLabel.TabIndex = 1;
            this.monthsPromptLabel.Text = "Number of months:";
            this.monthsPromptLabel.Click += new System.EventHandler(this.monthsPromptLabel_Click);
            // 
            // outputDescriptionLabel
            // 
            this.outputDescriptionLabel.AutoSize = true;
            this.outputDescriptionLabel.Location = new System.Drawing.Point(63, 444);
            this.outputDescriptionLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.outputDescriptionLabel.Name = "outputDescriptionLabel";
            this.outputDescriptionLabel.Size = new System.Drawing.Size(169, 25);
            this.outputDescriptionLabel.TabIndex = 2;
            this.outputDescriptionLabel.Text = "Ending Balance:";
            // 
            // startingBalTextBox
            // 
            this.startingBalTextBox.Location = new System.Drawing.Point(238, 58);
            this.startingBalTextBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.startingBalTextBox.Name = "startingBalTextBox";
            this.startingBalTextBox.Size = new System.Drawing.Size(196, 31);
            this.startingBalTextBox.TabIndex = 3;
            // 
            // monthsTextBox
            // 
            this.monthsTextBox.Location = new System.Drawing.Point(238, 108);
            this.monthsTextBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.monthsTextBox.Name = "monthsTextBox";
            this.monthsTextBox.Size = new System.Drawing.Size(196, 31);
            this.monthsTextBox.TabIndex = 4;
            this.monthsTextBox.TextChanged += new System.EventHandler(this.monthsTextBox_TextChanged);
            // 
            // endingBalanceLabel
            // 
            this.endingBalanceLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.endingBalanceLabel.Location = new System.Drawing.Point(238, 443);
            this.endingBalanceLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.endingBalanceLabel.Name = "endingBalanceLabel";
            this.endingBalanceLabel.Size = new System.Drawing.Size(198, 42);
            this.endingBalanceLabel.TabIndex = 5;
            this.endingBalanceLabel.Click += new System.EventHandler(this.endingBalanceLabel_Click);
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(15, 511);
            this.calculateButton.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(150, 44);
            this.calculateButton.TabIndex = 6;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(228, 511);
            this.clearButton.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(150, 44);
            this.clearButton.TabIndex = 7;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(444, 511);
            this.exitButton.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(150, 44);
            this.exitButton.TabIndex = 8;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // detailListBox
            // 
            this.detailListBox.FormattingEnabled = true;
            this.detailListBox.ItemHeight = 25;
            this.detailListBox.Location = new System.Drawing.Point(45, 148);
            this.detailListBox.Name = "detailListBox";
            this.detailListBox.Size = new System.Drawing.Size(518, 279);
            this.detailListBox.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 582);
            this.Controls.Add(this.detailListBox);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.endingBalanceLabel);
            this.Controls.Add(this.monthsTextBox);
            this.Controls.Add(this.startingBalTextBox);
            this.Controls.Add(this.outputDescriptionLabel);
            this.Controls.Add(this.monthsPromptLabel);
            this.Controls.Add(this.startingBalancePromptLabel);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Form1";
            this.Text = "Ending balance";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label startingBalancePromptLabel;
        private System.Windows.Forms.Label monthsPromptLabel;
        private System.Windows.Forms.Label outputDescriptionLabel;
        private System.Windows.Forms.TextBox startingBalTextBox;
        private System.Windows.Forms.TextBox monthsTextBox;
        private System.Windows.Forms.Label endingBalanceLabel;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.ListBox detailListBox;
    }
}

