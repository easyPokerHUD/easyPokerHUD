using System.Windows.Forms;
using System.Threading;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace easyPokerHUD
{
    public class PokerStarsMain
    {
        public static HandHistoryWatcher handHistoryWatcher;
        public static List<Player> playerCache = new List<Player>();
        public static ConcurrentDictionary<string, string> overlays = new ConcurrentDictionary<string, string>();
        public static ConcurrentDictionary<string, PokerStarsHand> newHandsToBeFetched = new ConcurrentDictionary<string, PokerStarsHand>();

        //Activates the Filewatcher
        public static void activateFileWatcher()
        {
            if (string.IsNullOrEmpty(Properties.Settings.Default.userFolderPath))
            {
                handHistoryWatcher = new HandHistoryWatcher(System.Environment.SpecialFolder.LocalApplicationData, "PokerStars", "HandHistory");
            }
            else
            {
                // If user has set a filepath directly in the handhistory folder
                handHistoryWatcher = new HandHistoryWatcher(Properties.Settings.Default.userFolderPath);
            }

            handHistoryWatcher.Changed += getInformationAndPassItToHUD;
        }

        //Creates a hand, fills it with the information about players and finally passes it on to the hud
        private static void getInformationAndPassItToHUD(object source, FileSystemEventArgs e)
        {
            PokerStarsHand hand = new PokerStarsHand(e.FullPath);
            if (checkIfHandIsValidForHUD(hand.tableSize, hand.handInformation))
            {
                combineDataSets(hand.players);
                createNewOverlayOrStoreInformation(hand);
            }
        }

        //Gets the stats stored in the database
        protected static void combineDataSets(List<Player> players)
        {
            foreach (Player player in players)
            {
                try
                {
                    Player playerStoredInCache = playerCache.Where(p => p.name.Equals(player.name)).Single();
                    player.handsPlayed = player.handsPlayed + playerStoredInCache.handsPlayed;
                    player.preflopCalls = player.preflopCalls + playerStoredInCache.preflopCalls;
                    player.preflopBetsAndRaises = player.preflopBetsAndRaises + playerStoredInCache.preflopBetsAndRaises;
                    player.postflopBetsAndRaises = player.postflopBetsAndRaises + playerStoredInCache.postflopBetsAndRaises;
                    player.postflopCallsChecksAndFolds = player.postflopCallsChecksAndFolds + playerStoredInCache.postflopCallsChecksAndFolds;
                    playerCache[playerCache.IndexOf(playerStoredInCache)] = player;
                }
                catch
                {
                    player.combinethisPlayerWithStoredStats();
                    playerCache.Add(player);
                }
            }
        }

        //Updates the players in the database
        public static void updatePlayersInDatabaseFromCache()
        {
            foreach (Player player in playerCache)
            {
                player.updateOrCreatePlayerInDatabase();
            }
        }

        //Creates a new overlay or stores the information in a list to be fetched by the overlay timer
        private static void createNewOverlayOrStoreInformation(PokerStarsHand hand)
        {
            if (overlays.ContainsKey(hand.tableName))
            {
                newHandsToBeFetched.TryAdd(hand.tableName, hand);
            }
            else
            {
                newHandsToBeFetched.TryAdd(hand.tableName, hand);
                overlays.TryAdd(hand.tableName, hand.tableName);
                new Thread(() => Application.Run(new PokerStarsOverlay(hand))).Start();
            }
        }

        //Checks whether this hand is eligible to be hudded 
        private static bool checkIfHandIsValidForHUD(int tableSize, string handInformation)
        {
            if (handInformation.Contains("Zoom"))
            {
                return false;
            }
            if (tableSize == 2)
            {
                return true;
            }
            else if (tableSize == 3)
            {
                return true;
            }
            else if (tableSize == 6)
            {
                return true;
            }
            else if (tableSize == 9)
            {
                return true;
            }
            return false;
        }
    }
}