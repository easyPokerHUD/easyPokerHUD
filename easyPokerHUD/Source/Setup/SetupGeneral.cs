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
    public partial class SetupWindow
    {   
        private string defaultFolderPath = Environment.GetFolderPath(System.Environment.SpecialFolder.LocalApplicationData);

        /// <summary>
        /// Check if there is a path saved in settings, otherwise load the default path.
        /// </summary>
        private void CheckFolderPathSetting()
        {
            // Check folder path
            if (string.IsNullOrEmpty(Properties.Settings.Default.userFolderPath))
            {
                // If settings for folder path is empty, set and save to default
                Console.WriteLine("Folder Path Is Empty");
                Console.WriteLine("Folder Path: " + defaultFolderPath);
                textBoxFolderPath.Text = defaultFolderPath;
                Properties.Settings.Default.Save();
            }
            else
            {
                Console.WriteLine("Folder path is not empty.");                
                textBoxFolderPath.Text = Properties.Settings.Default.userFolderPath;
            }
        }

        /// <summary>
        /// Save a new folder path
        /// </summary>
        /// <param name="newPath"></param>
        public void SaveFolderPath(string newPath)
        {
            Properties.Settings.Default.userFolderPath = newPath;
            Properties.Settings.Default.Save();
        }

        /// <summary>
        /// Get the current folder path
        /// </summary>
        /// <returns>Folder path</returns>
        public string LoadFolderPath()
        {
            return Properties.Settings.Default.userFolderPath.ToString();
        }
    }
}
