using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace easyPokerHUD
{
    public class EightPokerHand : PokerRoomHand
    {
        public EightPokerHand(string path)
        {
            this.path = path;
            pokerRoom = "EightPoker";

            try
            {
                //Read in the hand from the txt file
                hand = getHand(path, "Summary", "");

                //Store the general information about the hand in separate strings
                handInformation = hand[1];
                tableInformation = hand[3];

                //Separate the hand into pieces
                playerOverview = hand.TakeWhile(s => !s.Contains("Dealing down cards")).ToArray();
                playerOverview = hand.Reverse().SkipWhile(s => !s.Contains("Seat")).TakeWhile(s => s.Contains("Seat ")).Reverse().ToArray();
                preflop = hand.SkipWhile(s => !s.Contains("Dealing down cards")).TakeWhile(s => !s.Contains("Dealing flop")).ToArray();
                postflop = hand.SkipWhile(s => !s.Contains("Dealing flop")).TakeWhile(s => !s.Contains("Summary")).ToArray();

                //Get the table name and table size from the tableinformation string
                tableName = getTableName(tableInformation);
                tableSize = getTableSize(tableInformation);

                //Get the players with stats playing in this hand
                players = getPlayersWithStats(playerOverview, preflop, postflop, pokerRoom);

                //Get the player name of this hand
                playerName = getPlayerName(hand);
            }
            catch(IndexOutOfRangeException e)
            {                
                Console.WriteLine(e.Message);
            }
            catch(NullReferenceException e)
            {
                Console.WriteLine(e.Message);
            }
            catch(NotImplementedException e)
            {
                Console.WriteLine(e.Message);
            }
        }

        //Gets the table name of the hand
        protected string getTableName(string tableInformation)
        {
            string tableName = tableInformation.Substring(tableInformation.IndexOf(" ") + 1);
            tableName = tableName.Substring(0, tableName.IndexOf(" "));
            return tableName;
        }

        //Gets the size of the table
        protected int getTableSize(string tableInformation)
        {
            string stringThatContainsTableSize = tableInformation;
            if (tableInformation.Contains("Tournament"))
            {
                stringThatContainsTableSize = tableInformation.Substring(tableInformation.IndexOf("Max")-3);
                stringThatContainsTableSize = Regex.Match(stringThatContainsTableSize, @"\d+").Value;
            }
            else
            {
                stringThatContainsTableSize = Regex.Match(tableInformation, @"\d+").Value;
            }
            int tableSize = Int32.Parse(stringThatContainsTableSize.ToString());
            return tableSize;
        }

        //Gets the name of this hands player
        protected string getPlayerName(string[] hand)
        {
            foreach (string line in hand)
            {
                if (line.Contains("Dealt"))
                {
                    foreach (Player player in players)
                    {
                        if (line.Contains(player.name))
                        {
                            return player.name;
                        }
                    }
                }
            }
            return "";
        }

        //Creates a list of players
        public static List<Player> getPlayersWithStats(string[] playerOverview, string[] preflop, string[] postflop,
             string pokerRoom)
        {
            //Create a list for all the players
            List<Player> players = new List<Player>();

            //Go through the player overview and extract seat as well as name
            foreach (String line in playerOverview)
            {
                Player player = new Player(getName(line));
                player.seat = getSeatNumber(line);
                player.pokerRoom = pokerRoom;
                player.handsPlayed = 1;
                players.Add(player);
            }

            players = insertPreFlopStats(preflop, players, "calls", "raises", "bets");
            players = insertPostFlopStats(postflop, players, "calls", "raises", "bets", "checks", "folds");
            return players;
        }

        //Extracts the name out of a given line 
        protected static String getName(String line)
        {
            String name = line.Substring(line.IndexOf(":") + 2);
            name = name.Substring(0, name.IndexOf("(") - 1);
            return name;
        }

        //Extracts the seatnumber out of a given line
        protected static int getSeatNumber(String line)
        {
            String resultString = Regex.Match(line, @"\d+").Value;
            int seatNumber = Int32.Parse(resultString);
            return seatNumber;
        }
    }
}
