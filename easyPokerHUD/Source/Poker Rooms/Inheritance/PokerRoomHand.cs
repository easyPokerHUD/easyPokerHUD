using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace easyPokerHUD
{
    public class PokerRoomHand
    {
        //Properties of this hand
        public string path;
        public string pokerRoom;
        public string tableName;
        public string playerName;
        public int tableSize;
        public bool tournament;

        //Parts of this hand
        public string[] hand;
        public string handInformation;
        public int bigBlind;
        public string tableInformation;
        public string[] playerOverview;
        public string[] preflop;
        public string[] postflop;

        //The players in this hand
        public List<Player> players = new List<Player>();

        //Reads out specified handhistory from the back and returns only the last played hand
        protected string[] getHand(string path, string skipKeyword, string takeKeyword)
        {
            try
            {
                FileInfo file = new FileInfo(path);
                while (isFileLocked(file))
                {
                    Console.WriteLine("File not accessable.");
                    return null;
                }               
                var hand = File.ReadLines(path).Reverse().SkipWhile(s => !s.Contains(skipKeyword)).TakeWhile(s => s != takeKeyword).Reverse();
                if (!string.IsNullOrEmpty(hand.ToString()))
                {
                    return hand.ToArray();
                }

                return null;
                
            }
            catch(Exception e)
            {
                Console.WriteLine("Error, could not get hand.\n" + e.Message);
                return null;
            }
        }

        //Resets the hadActionInPot variable in the whole player list
        protected static List<Player> resetHadActionInPot(List<Player> players)
        {
            foreach (Player player in players)
            {
                player.hadActionInPot = false;
            }
            return players;
        }

        //Inserts the preflop stats into the player list
        protected static List<Player> insertPreFlopStats(string[] preFlop, List<Player> players,
            string wordForCall, string wordForRaise, string wordForBet)
        {
            foreach (string line in preFlop)
            {
                foreach (Player player in players)
                {
                    if (line.Contains(player.name) && player.hadActionInPot == false)
                    {
                        if (line.Contains(wordForCall))
                        {
                            player.preflopCalls = player.preflopCalls + 1;
                            player.hadActionInPot = true;
                        }
                        else if (line.Contains(wordForBet) || line.Contains(wordForRaise))
                        {
                            player.preflopBetsAndRaises = player.preflopBetsAndRaises + 1;
                            player.hadActionInPot = true;
                        }
                    }
                }
            }
            return resetHadActionInPot(players);
        }

        //Inserts the postflop stats into the player list
        protected static List<Player> insertPostFlopStats(string[] postflop, List<Player> players,
            string wordForCall, string wordForRaise, string wordForBet, string wordForCheck, string wordForFold)
        {
            foreach (string line in postflop)
            {
                foreach (Player player in players)
                {
                    if (line.Contains(player.name) && player.hadActionInPot == false)
                    {
                        if (line.Contains(wordForCall) || line.Contains(wordForCheck) || line.Contains(wordForFold))
                        {
                            player.postflopCallsChecksAndFolds = player.postflopCallsChecksAndFolds + 1;
                        }
                        else if (line.Contains(wordForBet) || line.Contains(wordForRaise))
                        {
                            player.postflopBetsAndRaises = player.postflopBetsAndRaises + 1;
                        }
                    }
                }
            }
            return players;
        }

        //Inserts the blinds stats into the player list
        protected static List<Player> insertChipStats(string[] playerInformation, int bigBlind, List<Player> players,
            string wordForChips)
        {
            foreach (string line in playerInformation)
            {
                foreach (Player player in players)
                {
                    if (line.Contains(player.name))
                    {
                        if (line.Contains(wordForChips))
                        {
                            player.chips = System.Int32.Parse(Regex.Match(line, @"(\d+)" + wordForChips).Groups[1].Value);
                            player.bigBlinds = (double)player.chips / (double)bigBlind;
                        }
                    }
                }
            }
            return resetHadActionInPot(players);
        }

        //Checks if a file is still used by another process. Needs to be used with a while loop
        public bool isFileLocked(FileInfo file)
        {
            FileStream stream = null;
            try
            {
                stream = file.Open(FileMode.Open, FileAccess.Read, FileShare.None);
            }
            catch (IOException)
            {
                return true;
            }
            finally
            {
                if (stream != null)
                    stream.Close();
            }
            return false;
        }
    }
}
