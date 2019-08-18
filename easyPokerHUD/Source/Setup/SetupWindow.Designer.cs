namespace easyPokerHUD
{
    partial class SetupWindow
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("General");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Visual");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Database");
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tabControlSetup = new System.Windows.Forms.TabControl();
            this.tabPageGeneral = new System.Windows.Forms.TabPage();
            this.panelGeneral = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonFolderPathOk = new System.Windows.Forms.Button();
            this.buttonFolderPathCancel = new System.Windows.Forms.Button();
            this.textBoxFolderPath = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPageVisual = new System.Windows.Forms.TabPage();
            this.panelVisual = new System.Windows.Forms.Panel();
            this.tabPageDatabse = new System.Windows.Forms.TabPage();
            this.panelDatabase = new System.Windows.Forms.Panel();
            this.treeViewSetup = new System.Windows.Forms.TreeView();
            this.tableLayoutPanel1.SuspendLayout();
            this.tabControlSetup.SuspendLayout();
            this.tabPageGeneral.SuspendLayout();
            this.panelGeneral.SuspendLayout();
            this.tabPageVisual.SuspendLayout();
            this.tabPageDatabse.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.tableLayoutPanel1.Controls.Add(this.tabControlSetup, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.treeViewSetup, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 450);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tabControlSetup
            // 
            this.tabControlSetup.Controls.Add(this.tabPageGeneral);
            this.tabControlSetup.Controls.Add(this.tabPageVisual);
            this.tabControlSetup.Controls.Add(this.tabPageDatabse);
            this.tabControlSetup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlSetup.Location = new System.Drawing.Point(203, 3);
            this.tabControlSetup.Name = "tabControlSetup";
            this.tabControlSetup.SelectedIndex = 0;
            this.tabControlSetup.Size = new System.Drawing.Size(594, 444);
            this.tabControlSetup.TabIndex = 0;
            // 
            // tabPageGeneral
            // 
            this.tabPageGeneral.Controls.Add(this.panelGeneral);
            this.tabPageGeneral.Location = new System.Drawing.Point(4, 22);
            this.tabPageGeneral.Name = "tabPageGeneral";
            this.tabPageGeneral.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageGeneral.Size = new System.Drawing.Size(586, 418);
            this.tabPageGeneral.TabIndex = 0;
            this.tabPageGeneral.Tag = "0";
            this.tabPageGeneral.Text = "General";
            this.tabPageGeneral.UseVisualStyleBackColor = true;
            // 
            // panelGeneral
            // 
            this.panelGeneral.Controls.Add(this.button1);
            this.panelGeneral.Controls.Add(this.buttonFolderPathOk);
            this.panelGeneral.Controls.Add(this.buttonFolderPathCancel);
            this.panelGeneral.Controls.Add(this.textBoxFolderPath);
            this.panelGeneral.Controls.Add(this.label1);
            this.panelGeneral.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelGeneral.Location = new System.Drawing.Point(3, 3);
            this.panelGeneral.Name = "panelGeneral";
            this.panelGeneral.Size = new System.Drawing.Size(580, 412);
            this.panelGeneral.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(502, 386);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Default";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // buttonFolderPathOk
            // 
            this.buttonFolderPathOk.Location = new System.Drawing.Point(226, 56);
            this.buttonFolderPathOk.Name = "buttonFolderPathOk";
            this.buttonFolderPathOk.Size = new System.Drawing.Size(75, 23);
            this.buttonFolderPathOk.TabIndex = 3;
            this.buttonFolderPathOk.Text = "OK";
            this.buttonFolderPathOk.UseVisualStyleBackColor = true;
            this.buttonFolderPathOk.Click += new System.EventHandler(this.ButtonFolderPathOk_Click);
            // 
            // buttonFolderPathCancel
            // 
            this.buttonFolderPathCancel.Location = new System.Drawing.Point(307, 56);
            this.buttonFolderPathCancel.Name = "buttonFolderPathCancel";
            this.buttonFolderPathCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonFolderPathCancel.TabIndex = 2;
            this.buttonFolderPathCancel.Text = "Cancel";
            this.buttonFolderPathCancel.UseVisualStyleBackColor = true;
            this.buttonFolderPathCancel.Click += new System.EventHandler(this.ButtonFolderPathCancel_Click);
            // 
            // textBoxFolderPath
            // 
            this.textBoxFolderPath.Location = new System.Drawing.Point(72, 29);
            this.textBoxFolderPath.Name = "textBoxFolderPath";
            this.textBoxFolderPath.Size = new System.Drawing.Size(311, 20);
            this.textBoxFolderPath.TabIndex = 1;
            this.textBoxFolderPath.Text = "Folder Path";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Folder path:";
            // 
            // tabPageVisual
            // 
            this.tabPageVisual.Controls.Add(this.panelVisual);
            this.tabPageVisual.Location = new System.Drawing.Point(4, 22);
            this.tabPageVisual.Name = "tabPageVisual";
            this.tabPageVisual.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageVisual.Size = new System.Drawing.Size(586, 418);
            this.tabPageVisual.TabIndex = 1;
            this.tabPageVisual.Tag = "1";
            this.tabPageVisual.Text = "Visual";
            this.tabPageVisual.UseVisualStyleBackColor = true;
            // 
            // panelVisual
            // 
            this.panelVisual.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelVisual.Location = new System.Drawing.Point(3, 3);
            this.panelVisual.Name = "panelVisual";
            this.panelVisual.Size = new System.Drawing.Size(580, 412);
            this.panelVisual.TabIndex = 0;
            // 
            // tabPageDatabse
            // 
            this.tabPageDatabse.Controls.Add(this.panelDatabase);
            this.tabPageDatabse.Location = new System.Drawing.Point(4, 22);
            this.tabPageDatabse.Name = "tabPageDatabse";
            this.tabPageDatabse.Size = new System.Drawing.Size(586, 418);
            this.tabPageDatabse.TabIndex = 2;
            this.tabPageDatabse.Tag = "2";
            this.tabPageDatabse.Text = "Database";
            this.tabPageDatabse.UseVisualStyleBackColor = true;
            // 
            // panelDatabase
            // 
            this.panelDatabase.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDatabase.Location = new System.Drawing.Point(0, 0);
            this.panelDatabase.Name = "panelDatabase";
            this.panelDatabase.Size = new System.Drawing.Size(586, 418);
            this.panelDatabase.TabIndex = 0;
            // 
            // treeViewSetup
            // 
            this.treeViewSetup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeViewSetup.Location = new System.Drawing.Point(3, 3);
            this.treeViewSetup.Name = "treeViewSetup";
            treeNode1.Name = "nodeGeneral";
            treeNode1.Tag = "0";
            treeNode1.Text = "General";
            treeNode2.Name = "nodeVisual";
            treeNode2.Tag = "1";
            treeNode2.Text = "Visual";
            treeNode3.Name = "nodeDatabase";
            treeNode3.Tag = "2";
            treeNode3.Text = "Database";
            this.treeViewSetup.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3});
            this.treeViewSetup.Size = new System.Drawing.Size(194, 444);
            this.treeViewSetup.TabIndex = 1;
            this.treeViewSetup.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.TreeViewSetup_AfterSelect);
            // 
            // SetupWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "SetupWindow";
            this.Text = "SetupWindow";
            this.Load += new System.EventHandler(this.SetupWindow_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tabControlSetup.ResumeLayout(false);
            this.tabPageGeneral.ResumeLayout(false);
            this.panelGeneral.ResumeLayout(false);
            this.panelGeneral.PerformLayout();
            this.tabPageVisual.ResumeLayout(false);
            this.tabPageDatabse.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TabControl tabControlSetup;
        private System.Windows.Forms.TabPage tabPageGeneral;
        private System.Windows.Forms.TabPage tabPageVisual;
        private System.Windows.Forms.TreeView treeViewSetup;
        private System.Windows.Forms.TabPage tabPageDatabse;
        private System.Windows.Forms.Panel panelGeneral;
        private System.Windows.Forms.Panel panelVisual;
        private System.Windows.Forms.Panel panelDatabase;
        public System.Windows.Forms.TextBox textBoxFolderPath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonFolderPathOk;
        private System.Windows.Forms.Button buttonFolderPathCancel;
    }
}