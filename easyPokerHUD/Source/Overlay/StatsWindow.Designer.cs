namespace easyPokerHUD
{
    partial class StatsWindow
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.AFq = new System.Windows.Forms.Label();
            this.PFR = new System.Windows.Forms.Label();
            this.VPIP = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.Username = new System.Windows.Forms.Label();
            this.BB = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // AFq
            // 
            this.AFq.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AFq.AutoSize = true;
            this.AFq.BackColor = System.Drawing.Color.Transparent;
            this.AFq.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AFq.ForeColor = System.Drawing.Color.White;
            this.AFq.Location = new System.Drawing.Point(65, 14);
            this.AFq.Name = "AFq";
            this.AFq.Size = new System.Drawing.Size(25, 14);
            this.AFq.TabIndex = 2;
            this.AFq.Text = "100";
            this.AFq.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PFR
            // 
            this.PFR.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PFR.AutoSize = true;
            this.PFR.BackColor = System.Drawing.Color.Transparent;
            this.PFR.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PFR.ForeColor = System.Drawing.Color.White;
            this.PFR.Location = new System.Drawing.Point(34, 14);
            this.PFR.Name = "PFR";
            this.PFR.Size = new System.Drawing.Size(25, 14);
            this.PFR.TabIndex = 1;
            this.PFR.Text = "100";
            this.PFR.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // VPIP
            // 
            this.VPIP.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.VPIP.AutoSize = true;
            this.VPIP.BackColor = System.Drawing.Color.Transparent;
            this.VPIP.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VPIP.ForeColor = System.Drawing.Color.White;
            this.VPIP.Location = new System.Drawing.Point(3, 14);
            this.VPIP.Name = "VPIP";
            this.VPIP.Size = new System.Drawing.Size(25, 14);
            this.VPIP.TabIndex = 0;
            this.VPIP.Text = "100";
            this.VPIP.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.AFq, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.PFR, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.Username, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.VPIP, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.BB, 2, 0);
            this.tableLayoutPanel1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(1, 1);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(93, 28);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // Username
            // 
            this.Username.AutoSize = true;
            this.Username.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.SetColumnSpan(this.Username, 2);
            this.Username.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Username.ForeColor = System.Drawing.Color.White;
            this.Username.Location = new System.Drawing.Point(3, 0);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(56, 14);
            this.Username.TabIndex = 3;
            this.Username.Text = "Username";
            this.Username.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BB
            // 
            this.BB.AutoSize = true;
            this.BB.ForeColor = System.Drawing.Color.White;
            this.BB.Location = new System.Drawing.Point(65, 0);
            this.BB.Name = "BB";
            this.BB.Size = new System.Drawing.Size(21, 14);
            this.BB.TabIndex = 4;
            this.BB.Text = "BB";
            // 
            // StatsWindow
            // 
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "StatsWindow";
            this.Padding = new System.Windows.Forms.Padding(1);
            this.Size = new System.Drawing.Size(95, 30);
            this.SizeChanged += new System.EventHandler(this.StatsWindow_SizeChanged);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label VPIP;
        public System.Windows.Forms.Label PFR;
        public System.Windows.Forms.Label AFq;
        public System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        public System.Windows.Forms.Label Username;
        public System.Windows.Forms.Label BB;
    }
}
