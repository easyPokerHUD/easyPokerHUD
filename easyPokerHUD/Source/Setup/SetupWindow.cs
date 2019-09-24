using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace easyPokerHUD
{
    public partial class SetupWindow : Form
    {
        List<Panel> Panels = new List<Panel>();
        Panel VisiblePanel = null;

        public SetupWindow()
        {
            InitializeComponent();            
        }

        /// <summary>
        /// Display the appropriate Panel.
        /// </summary>
        /// <param name="index"></param>
        private void DisplayPanel(int index)
        {
            if (Panels.Count < 1) return;

            // If this is the same Panel, do nothing.
            if (VisiblePanel == Panels[index]) return;

            // Hide the previously visible Panel.
            if (VisiblePanel != null) VisiblePanel.Visible = false;

            // Display the appropriate Panel.
            Panels[index].Visible = true;
            VisiblePanel = Panels[index];
        }

        private void SetupWindow_Load(object sender, EventArgs e)
        {
            CheckFolderPathSetting();

            // Expand all tree nodes
            treeViewSetup.ExpandAll();

            // Move the panels out of the tab control
            tabControlSetup.Visible = false;
            foreach (TabPage page in tabControlSetup.TabPages)
            {
                // Add the panel to the list
                Panel panel = page.Controls[0] as Panel;
                Panels.Add(panel);

                //Reparent and move panel
                panel.Parent = tabControlSetup.Parent;
                panel.Location = tabControlSetup.Location;
                panel.Visible = false;
            }

            // Start on the first panel which is the General tab
            DisplayPanel(0);
        }

        #region General

        private void TreeViewSetup_AfterSelect(object sender, TreeViewEventArgs e)
        {
            int index = int.Parse(e.Node.Tag.ToString());
            DisplayPanel(index);
        }

        private void ButtonFolderPathOk_Click(object sender, EventArgs e)
        {            
            SaveFolderPath(textBoxFolderPath.Text);
            MainMethods.activateFileWatchers();
            MessageBox.Show("New folder path saved at: \n" + textBoxFolderPath.Text);
        }

        private void ButtonFolderPathCancel_Click(object sender, EventArgs e)
        {
            textBoxFolderPath.Text = LoadFolderPath();
        }

        private void ButtonFolderPathBrowse_Click(object sender, EventArgs e)
        {
            string folderPath = "";
            FolderBrowserDialog folderBrowserDialog1 = new FolderBrowserDialog();
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                folderPath = folderBrowserDialog1.SelectedPath;
            }

            textBoxFolderPath.Text = folderPath;
        }

        #endregion
    }
}
