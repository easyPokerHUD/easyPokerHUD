namespace easyPokerHUD
{
    partial class MainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.versionNumberLabel = new System.Windows.Forms.Label();
            this.donateButton = new System.Windows.Forms.Button();
            this.logoPictureBox = new System.Windows.Forms.PictureBox();
            this.successMessage = new System.Windows.Forms.Label();
            this.errorMessage = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buyMessage = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configurationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // versionNumberLabel
            // 
            this.versionNumberLabel.AutoSize = true;
            this.versionNumberLabel.ForeColor = System.Drawing.Color.White;
            this.versionNumberLabel.Location = new System.Drawing.Point(8, 535);
            this.versionNumberLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.versionNumberLabel.Name = "versionNumberLabel";
            this.versionNumberLabel.Size = new System.Drawing.Size(78, 13);
            this.versionNumberLabel.TabIndex = 3;
            this.versionNumberLabel.Text = "versionNumber";
            this.versionNumberLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // donateButton
            // 
            this.donateButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(75)))), ((int)(((byte)(97)))));
            this.donateButton.FlatAppearance.BorderSize = 0;
            this.donateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.donateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.donateButton.ForeColor = System.Drawing.Color.White;
            this.donateButton.Location = new System.Drawing.Point(63, 255);
            this.donateButton.Margin = new System.Windows.Forms.Padding(2);
            this.donateButton.Name = "donateButton";
            this.donateButton.Size = new System.Drawing.Size(193, 46);
            this.donateButton.TabIndex = 8;
            this.donateButton.Text = "Make a donation with PayPal";
            this.donateButton.UseVisualStyleBackColor = false;
            this.donateButton.Click += new System.EventHandler(this.donateButton_Click);
            // 
            // logoPictureBox
            // 
            this.logoPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("logoPictureBox.Image")));
            this.logoPictureBox.InitialImage = null;
            this.logoPictureBox.Location = new System.Drawing.Point(53, 44);
            this.logoPictureBox.Margin = new System.Windows.Forms.Padding(2);
            this.logoPictureBox.Name = "logoPictureBox";
            this.logoPictureBox.Size = new System.Drawing.Size(217, 97);
            this.logoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logoPictureBox.TabIndex = 6;
            this.logoPictureBox.TabStop = false;
            // 
            // successMessage
            // 
            this.successMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.successMessage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.successMessage.Location = new System.Drawing.Point(2, 364);
            this.successMessage.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.successMessage.Name = "successMessage";
            this.successMessage.Size = new System.Drawing.Size(315, 51);
            this.successMessage.TabIndex = 10;
            this.successMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // errorMessage
            // 
            this.errorMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorMessage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.errorMessage.Location = new System.Drawing.Point(2, 416);
            this.errorMessage.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.errorMessage.Name = "errorMessage";
            this.errorMessage.Size = new System.Drawing.Size(315, 56);
            this.errorMessage.TabIndex = 11;
            this.errorMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(16, 210);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(292, 30);
            this.label2.TabIndex = 13;
            this.label2.Text = "We appreciate tips a lot :-)";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buyMessage
            // 
            this.buyMessage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.buyMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buyMessage.ForeColor = System.Drawing.Color.White;
            this.buyMessage.Location = new System.Drawing.Point(11, 190);
            this.buyMessage.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.buyMessage.Name = "buyMessage";
            this.buyMessage.Size = new System.Drawing.Size(297, 131);
            this.buyMessage.TabIndex = 7;
            this.buyMessage.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(319, 24);
            this.menuStrip1.TabIndex = 14;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.configurationToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.AboutToolStripMenuItem_Click);
            // 
            // configurationToolStripMenuItem
            // 
            this.configurationToolStripMenuItem.Name = "configurationToolStripMenuItem";
            this.configurationToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.configurationToolStripMenuItem.Text = "Configuration";
            this.configurationToolStripMenuItem.Click += new System.EventHandler(this.ConfigurationToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(319, 563);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.errorMessage);
            this.Controls.Add(this.successMessage);
            this.Controls.Add(this.donateButton);
            this.Controls.Add(this.buyMessage);
            this.Controls.Add(this.logoPictureBox);
            this.Controls.Add(this.versionNumberLabel);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "MainWindow";
            this.Text = "easyPokerHUD";
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label versionNumberLabel;
        private System.Windows.Forms.PictureBox logoPictureBox;
        private System.Windows.Forms.Button donateButton;
        private System.Windows.Forms.Label successMessage;
        private System.Windows.Forms.Label errorMessage;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label buyMessage;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem configurationToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
    }
}