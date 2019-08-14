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

        // initiate sub-pages
        static SetupGeneral general;

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

        public void ShowGeneral()
        {
            general = new SetupGeneral();
        }

        private void SetupWindow_Load(object sender, EventArgs e)
        {
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

            DisplayPanel(0);
        }

        private void TreeViewSetup_AfterSelect(object sender, TreeViewEventArgs e)
        {
            int index = int.Parse(e.Node.Tag.ToString());
            DisplayPanel(index);
        }
    }    
}
