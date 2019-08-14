using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace easyPokerHUD
{
    /// <summary>
    /// This class holds variables and methods for the General page in the settings menu
    /// </summary>
    class SetupGeneral : SetupWindow
    {   
        private string defaultFolderPath = Environment.GetFolderPath(System.Environment.SpecialFolder.LocalApplicationData);

        public SetupGeneral()
        {
            Console.WriteLine("Load General!");
            CheckFolderPathSetting();
        }

        private void CheckFolderPathSetting()
        {
            // Check folder path
            if (string.IsNullOrEmpty(Properties.Settings.Default.userFolderPath))
            {
                // If settings for folder path is empty, set and save to default
                textBoxFolderPath.Text = defaultFolderPath;
                Properties.Settings.Default.Save();
            }
            else
            {
                textBoxFolderPath.Text = Properties.Settings.Default.userFolderPath;
            }
        }

        public string FolderPath { get; set; }
    }
}
