using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Timers;

namespace easyPokerHUD
{
    public class HandHistoryWatcher : FileSystemWatcher
    {
        Timer directorySearcher;
        public string pMessage = "";
        public string nMessage = "";

        private Environment.SpecialFolder windowsEnvironmentFolder;
        private string folderPath;
        private string historyFolder;
        private string pokerRoom;
        private string handHistoryFolder;

        /// <summary>
        /// Enables the filewatcher with default path
        /// </summary>
        /// <param name="windowsEnvironmentFolder"></param>
        /// <param name="pokerRoom"></param>
        /// <param name="handHistoryFolder"></param>
        public HandHistoryWatcher(Environment.SpecialFolder windowsEnvironmentFolder, string pokerRoom, string handHistoryFolder)
        {
            // Set the global variables
            this.windowsEnvironmentFolder = windowsEnvironmentFolder;
            this.historyFolder = folderPath;
            this.pokerRoom = pokerRoom;
            this.handHistoryFolder = handHistoryFolder;
            
            //Set the filters for the filewatcher
            NotifyFilter = NotifyFilters.LastWrite;
            Filter = "*.txt";
            IncludeSubdirectories = true;

            // this.Changed += HandHistoryWatcher_Changed; // Not sure if needed

            //Enable Filewatcher
            enableFileWatcher();
        }

        /// <summary>
        /// Enables the filewatcher with specified path
        /// </summary>
        /// <param name="windowsEnvironmentFolder"></param>
        /// <param name="pokerRoom"></param>
        /// <param name="handHistoryFolder"></param>
        public HandHistoryWatcher(string folderPath, string pokerRoom)
        {
            //Set the global variables
            //this.windowsEnvironmentFolder = windowsEnvironmentFolder;
            this.historyFolder = folderPath;
            this.pokerRoom = pokerRoom;
            //this.handHistoryFolder = handHistoryFolder;

            //Set the filters for the filewatcher
            NotifyFilter = NotifyFilters.LastWrite;
            Filter = "*.txt";
            IncludeSubdirectories = true;

            //Enable Filewatcher
            enableFileWatcher();
        }

        /// <summary>
        /// Calls the enableFilewatcher method
        /// </summary>
        /// <param name="obj"></param>
        /// <param name="eve"></param>
        private void tryEnablingFileWatcher(Object obj, EventArgs eve)
        {
            enableFileWatcher();
        }

        /// <summary>
        /// Checks, whether a valid path has been found and enables the filewatching
        /// </summary>
        private void enableFileWatcher()
        {
            Path = getHandHistoryDirectory();

            //Begin watching.
            if (!Path.Equals(""))
            {
                Console.WriteLine("Found path");
                startFileWatcher();
            }
            else
            {
                Console.WriteLine("Invalid path");
                showErrorMessageAndStartdirectorySearcher();
            }
        }

        /// <summary>
        /// Start the file watcher and dispose the directory searcher if necessary
        /// </summary>
        private void startFileWatcher()
        {
            if (directorySearcher != null)
            {
                directorySearcher.Dispose();
            }
            EnableRaisingEvents = true;
            pMessage = pokerRoom;
            nMessage = "";
        }

        /// <summary>
        /// Accesses specified folders and looks for the handhistory
        /// </summary>
        /// <returns>Returns Folder path</returns>
        private string getHandHistoryDirectory()
        {
            try
            {
                //Start in the user folder, where the poker room stores the hand history and move on from there
                var startingDirectory = new DirectoryInfo(@Environment.GetFolderPath(windowsEnvironmentFolder)); 
                var possibleDirectories = startingDirectory.GetDirectories().Where(s => s.ToString().Contains(pokerRoom)).OrderByDescending(f => f.LastWriteTime);

                //Take the list of possible directories and return the most recent one, that contains the hand history folder
                foreach (DirectoryInfo possibleDirectory in possibleDirectories)
                {
                    try
                    {
                        var probableDirectory = possibleDirectory.GetDirectories().Where(s => s.ToString().Contains(handHistoryFolder)).Single();
                        Console.WriteLine("Probable directory: " + probableDirectory.FullName.ToString());
                        return probableDirectory.FullName.ToString();
                    }
                    catch
                    {
                        /*Do nothing when no such directory is found */
                        Console.WriteLine("Directory not find... Checking next.");
                    }
                }

                return "";
            }
            catch
            {
                Console.WriteLine("Can't get history directory");
                return "";
            }
        }

        /// <summary>
        /// Starts a directory searcher that keeps looking for the directory
        /// </summary>
        private void showErrorMessageAndStartdirectorySearcher()
        {
            if (directorySearcher == null)
            {
                directorySearcher = new Timer();
                showErrorMessageAndStartdirectorySearcher();
                directorySearcher.Interval += 3000;
                directorySearcher.Elapsed += tryEnablingFileWatcher;
                directorySearcher.Start();
                nMessage = pokerRoom;
            }
        }
    }
}
