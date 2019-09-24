using System;
using System.Data.SQLite;
using System.IO;

namespace easyPokerHUD
{
    class DBControls
    {
        public static readonly string dataBasePath = @Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + @"\easyPokerHUD\";
        public static readonly string dataBasePathWithFile = dataBasePath + "easyPokerHUD.sqlite";
        public static readonly string connectionInfo = "Data Source=" + dataBasePathWithFile + ";Version=3;";

        //Creates the database
        public static void createDatabase()
        {
            Directory.CreateDirectory(dataBasePath);
            if (!File.Exists(dataBasePathWithFile))
            {
                SQLiteConnection.CreateFile(dataBasePathWithFile);
            }
            createTable("PokerStars");
            createTable("EightPoker");
        }

        //Inserts a table with specified name in the database
        public static void createTable(string pokerRoom)
        {
            string query = "create table if not exists "
                + pokerRoom
                + " ("
                + "name char(30) primary key,"
                + "handsPlayed int,"
                + "preflopCalls int,"
                + "preflopBetsAndRaises int,"
                + "postflopBetsAndRaises int,"
                + "postflopCallsChecksAndFolds int"
                + ")";
            executeCommandInDatabase(query);
        }

        //Inserts or replaces the player
        public static void insertOrReplacePlayer(Player player)
        {
            string query = "insert or replace into "
                + player.pokerRoom
                + " values ("
                + "'" + player.name + "',"
                + player.handsPlayed + ","
                + player.preflopCalls + ","
                + player.preflopBetsAndRaises + ","
                + player.postflopBetsAndRaises + ","
                + player.postflopCallsChecksAndFolds
                + ")";
            executeCommandInDatabase(query);
        }

        //Reads out the stored data for the specific player and combines it with the current stats
        public static void combineDataSets(Player player)
        {
            try
            {
                string query = "select * from " + player.pokerRoom + " where name = '" + player.name + "'";
                using (SQLiteConnection connection = new SQLiteConnection(connectionInfo))
                {
                    connection.Open();
                    using (SQLiteCommand command = new SQLiteCommand(query, connection))
                    {
                        using (SQLiteDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                player.name = Convert.ToString(reader["name"]);
                                player.handsPlayed = player.handsPlayed + Convert.ToInt32(reader["handsPlayed"]);
                                player.preflopCalls = player.preflopCalls + Convert.ToInt32(reader["preflopCalls"]);
                                player.preflopBetsAndRaises = player.preflopBetsAndRaises + Convert.ToInt32(reader["preflopBetsAndRaises"]);
                                player.postflopBetsAndRaises = player.postflopBetsAndRaises + Convert.ToInt32(reader["postflopBetsAndRaises"]);
                                player.postflopCallsChecksAndFolds = player.postflopCallsChecksAndFolds + Convert.ToInt32(reader["postflopCallsChecksAndFolds"]);
                            }
                        }
                    }
                }
            } catch (Exception e)
            {
                Console.WriteLine("CombineDataSets Error. \n" + e.Message);
                createDatabase();
            }
        }

        //Executes a query in the database and throws an exception if something goes wrong
        private static void executeCommandInDatabase(string query)
        {
            try
            {
                using (SQLiteConnection connection = new SQLiteConnection(connectionInfo))
                {
                    using (SQLiteCommand command = new SQLiteCommand(query, connection))
                    {
                        connection.Open();
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Execute command in database Error. \n" + e.Message);
                createDatabase();
            }
        }
    }
}
