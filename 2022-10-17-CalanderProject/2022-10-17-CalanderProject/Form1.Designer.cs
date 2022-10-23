namespace _2022_10_17_CalanderProject
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
            this.OpenBtn = new System.Windows.Forms.Button();
            this.SideBarPanel = new System.Windows.Forms.Panel();
            this.ProfileContainerPanel = new System.Windows.Forms.Panel();
            this.CalanderContainerPanel = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.EmailLabel = new System.Windows.Forms.LinkLabel();
            this.NameLabel = new System.Windows.Forms.Label();
            this.CalanderListBox = new System.Windows.Forms.ListBox();
            this.ProfilePicturePicBox = new System.Windows.Forms.PictureBox();
            this.DragDropLabel = new System.Windows.Forms.Label();
            this.SideBarPanel.SuspendLayout();
            this.ProfileContainerPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProfilePicturePicBox)).BeginInit();
            this.SuspendLayout();
            // 
            // OpenBtn
            // 
            this.OpenBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(31)))), ((int)(((byte)(48)))));
            this.OpenBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.OpenBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.OpenBtn.FlatAppearance.BorderSize = 2;
            this.OpenBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OpenBtn.ForeColor = System.Drawing.Color.White;
            this.OpenBtn.Location = new System.Drawing.Point(356, 10);
            this.OpenBtn.Name = "OpenBtn";
            this.OpenBtn.Size = new System.Drawing.Size(53, 31);
            this.OpenBtn.TabIndex = 1;
            this.OpenBtn.Text = "Open";
            this.OpenBtn.UseVisualStyleBackColor = false;
            this.OpenBtn.Click += new System.EventHandler(this.OpenBtn_Click);
            // 
            // SideBarPanel
            // 
            this.SideBarPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(159)))), ((int)(((byte)(232)))));
            this.SideBarPanel.Controls.Add(this.CalanderListBox);
            this.SideBarPanel.Controls.Add(this.ProfileContainerPanel);
            this.SideBarPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.SideBarPanel.Location = new System.Drawing.Point(0, 0);
            this.SideBarPanel.Name = "SideBarPanel";
            this.SideBarPanel.Size = new System.Drawing.Size(186, 577);
            this.SideBarPanel.TabIndex = 2;
            this.SideBarPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.SideBarPanel_Paint);
            // 
            // ProfileContainerPanel
            // 
            this.ProfileContainerPanel.Controls.Add(this.CalanderContainerPanel);
            this.ProfileContainerPanel.Controls.Add(this.flowLayoutPanel1);
            this.ProfileContainerPanel.Controls.Add(this.EmailLabel);
            this.ProfileContainerPanel.Controls.Add(this.NameLabel);
            this.ProfileContainerPanel.Controls.Add(this.ProfilePicturePicBox);
            this.ProfileContainerPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.ProfileContainerPanel.Location = new System.Drawing.Point(0, 0);
            this.ProfileContainerPanel.Name = "ProfileContainerPanel";
            this.ProfileContainerPanel.Size = new System.Drawing.Size(186, 144);
            this.ProfileContainerPanel.TabIndex = 0;
            // 
            // CalanderContainerPanel
            // 
            this.CalanderContainerPanel.Location = new System.Drawing.Point(0, 144);
            this.CalanderContainerPanel.Name = "CalanderContainerPanel";
            this.CalanderContainerPanel.Size = new System.Drawing.Size(186, 433);
            this.CalanderContainerPanel.TabIndex = 1;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 142);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(183, 279);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // EmailLabel
            // 
            this.EmailLabel.ActiveLinkColor = System.Drawing.Color.White;
            this.EmailLabel.AutoSize = true;
            this.EmailLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EmailLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmailLabel.LinkColor = System.Drawing.Color.White;
            this.EmailLabel.Location = new System.Drawing.Point(65, 102);
            this.EmailLabel.Name = "EmailLabel";
            this.EmailLabel.Size = new System.Drawing.Size(44, 15);
            this.EmailLabel.TabIndex = 2;
            this.EmailLabel.TabStop = true;
            this.EmailLabel.Text = "Email";
            this.EmailLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.EmailLabel.VisitedLinkColor = System.Drawing.Color.White;
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameLabel.ForeColor = System.Drawing.Color.White;
            this.NameLabel.Location = new System.Drawing.Point(46, 86);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(85, 16);
            this.NameLabel.TabIndex = 1;
            this.NameLabel.Text = "User Name";
            // 
            // CalanderListBox
            // 
            this.CalanderListBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(159)))), ((int)(((byte)(232)))));
            this.CalanderListBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CalanderListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CalanderListBox.ForeColor = System.Drawing.Color.White;
            this.CalanderListBox.FormattingEnabled = true;
            this.CalanderListBox.ItemHeight = 15;
            this.CalanderListBox.Location = new System.Drawing.Point(3, 144);
            this.CalanderListBox.Name = "CalanderListBox";
            this.CalanderListBox.Size = new System.Drawing.Size(180, 420);
            this.CalanderListBox.TabIndex = 1;
            // 
            // ProfilePicturePicBox
            // 
            this.ProfilePicturePicBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(159)))), ((int)(((byte)(232)))));
            this.ProfilePicturePicBox.Image = global::_2022_10_17_CalanderProject.Properties.Resources.icons8_user_962;
            this.ProfilePicturePicBox.Location = new System.Drawing.Point(59, 11);
            this.ProfilePicturePicBox.Name = "ProfilePicturePicBox";
            this.ProfilePicturePicBox.Size = new System.Drawing.Size(63, 63);
            this.ProfilePicturePicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ProfilePicturePicBox.TabIndex = 0;
            this.ProfilePicturePicBox.TabStop = false;
            this.ProfilePicturePicBox.Click += new System.EventHandler(this.ProfilePicturePicBox_Click);
            // 
            // DragDropLabel
            // 
            this.DragDropLabel.AllowDrop = true;
            this.DragDropLabel.AutoEllipsis = true;
            this.DragDropLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DragDropLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DragDropLabel.ForeColor = System.Drawing.Color.White;
            this.DragDropLabel.Location = new System.Drawing.Point(192, 11);
            this.DragDropLabel.Name = "DragDropLabel";
            this.DragDropLabel.Size = new System.Drawing.Size(158, 30);
            this.DragDropLabel.TabIndex = 2;
            this.DragDropLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.DragDropLabel.Click += new System.EventHandler(this.DragDropLabel_Click);
            this.DragDropLabel.DragDrop += new System.Windows.Forms.DragEventHandler(this.DragDropLabelDrop);
            this.DragDropLabel.DragOver += new System.Windows.Forms.DragEventHandler(this.DragDropLabelOver);
            this.DragDropLabel.Paint += new System.Windows.Forms.PaintEventHandler(this.DragDropLabelPaint);
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(31)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(739, 577);
            this.Controls.Add(this.DragDropLabel);
            this.Controls.Add(this.SideBarPanel);
            this.Controls.Add(this.OpenBtn);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "WorkCalander";
            this.TransparencyKey = System.Drawing.Color.DimGray;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.SideBarPanel.ResumeLayout(false);
            this.ProfileContainerPanel.ResumeLayout(false);
            this.ProfileContainerPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProfilePicturePicBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button OpenBtn;
        private System.Windows.Forms.Panel SideBarPanel;
        private System.Windows.Forms.Panel ProfileContainerPanel;
        private System.Windows.Forms.PictureBox ProfilePicturePicBox;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.LinkLabel EmailLabel;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel CalanderContainerPanel;
        private System.Windows.Forms.ListBox CalanderListBox;
        private System.Windows.Forms.Label DragDropLabel;
    }
}

