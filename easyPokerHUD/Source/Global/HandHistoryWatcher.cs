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
            this.historyFolder = Environment.GetFolderPath(windowsEnvironmentFolder);
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
        public HandHistoryWatcher(string folderPath)
        {
            //Set the global variables
            this.historyFolder = folderPath;

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
        /// Stop the filewatcher if it is throwing too many exceptions and crashes the app
        /// </summary>
        private void stopFileWatcher()
        {
            EnableRaisingEvents = false;

            nMessage = pokerRoom + " is deactivated.";
        }

        /// <summary>
        /// Check if the a folder is empty
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        public bool IsDirectoryEmpty(string path)
        {
            IEnumerable<string> items = Directory.EnumerateFileSystemEntries(path);
            using (IEnumerator<string> en = items.GetEnumerator())
            {
                return !en.MoveNext();
            }
        }

        /// <summary>
        /// Accesses specified folders and looks for the handhistory
        /// </summary>
        /// <returns>Returns Folder path</returns>
        private string getHandHistoryDirectory()
        {
            Console.WriteLine("PokerRoom: " + pokerRoom);
            if (!string.IsNullOrEmpty(pokerRoom))
            {
                
                Console.WriteLine("No pokerRoom variable");
                try
                {
                    //Start in the user folder, where the poker room stores the hand history and move on from there
                    var startingDirectory = new DirectoryInfo(historyFolder);
                    Console.WriteLine("Starting directory: " + startingDirectory);
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
                            Console.WriteLine("Directory not found... Checking next.");
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
            else
            {
                Console.WriteLine("PokerRoom preferred");
                // If the user has set the handhistory folder there is no need to look for it.
                // We don't know what software the user is using so we're using a general term for the poker room here, which will be showed on the main window.
                pokerRoom = "your poker app"; 

                try
                {
                    var startingDirectory = new DirectoryInfo(historyFolder);
                    Console.WriteLine("Starting directory: " + startingDirectory);
                    var possibleDirectories = startingDirectory.FullName;

                    try
                    {
                        return possibleDirectories.ToString();
                    }
                    catch
                    {
                        Console.WriteLine("Can't find directory");
                    }

                    return "";
                }
                catch
                {
                    return "";
                }
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
