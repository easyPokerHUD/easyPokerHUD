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
            this.VPIP = new System.Windows.Forms.Label();
            this.PFR = new System.Windows.Forms.Label();
            this.AFq = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.labelUsername = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // VPIP
            // 
            this.VPIP.AutoSize = true;
            this.VPIP.BackColor = System.Drawing.Color.Transparent;
            this.VPIP.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VPIP.ForeColor = System.Drawing.Color.White;
            this.VPIP.Location = new System.Drawing.Point(3, 23);
            this.VPIP.Name = "VPIP";
            this.VPIP.Size = new System.Drawing.Size(25, 14);
            this.VPIP.TabIndex = 0;
            this.VPIP.Text = "100";
            this.VPIP.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PFR
            // 
            this.PFR.AutoSize = true;
            this.PFR.BackColor = System.Drawing.Color.Transparent;
            this.PFR.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PFR.ForeColor = System.Drawing.Color.White;
            this.PFR.Location = new System.Drawing.Point(78, 23);
            this.PFR.Name = "PFR";
            this.PFR.Size = new System.Drawing.Size(25, 14);
            this.PFR.TabIndex = 1;
            this.PFR.Text = "100";
            this.PFR.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AFq
            // 
            this.AFq.AutoSize = true;
            this.AFq.BackColor = System.Drawing.Color.Transparent;
            this.AFq.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AFq.ForeColor = System.Drawing.Color.White;
            this.AFq.Location = new System.Drawing.Point(153, 23);
            this.AFq.Name = "AFq";
            this.AFq.Size = new System.Drawing.Size(25, 14);
            this.AFq.TabIndex = 2;
            this.AFq.Text = "100";
            this.AFq.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Controls.Add(this.AFq, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.PFR, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.VPIP, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.labelUsername, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(1, 1);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(225, 37);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // labelUsername
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.labelUsername, 2);
            this.labelUsername.ForeColor = System.Drawing.Color.White;
            this.labelUsername.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelUsername.Location = new System.Drawing.Point(3, 0);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(100, 23);
            this.labelUsername.TabIndex = 4;
            this.labelUsername.Text = "Username(HP)";
            this.labelUsername.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // StatsWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.Name = "StatsWindow";
            this.Padding = new System.Windows.Forms.Padding(1, 1, 1, 0);
            this.Size = new System.Drawing.Size(227, 38);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label VPIP;
        public System.Windows.Forms.Label PFR;
        public System.Windows.Forms.Label AFq;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        public System.Windows.Forms.Label labelUsername;
    }
}
