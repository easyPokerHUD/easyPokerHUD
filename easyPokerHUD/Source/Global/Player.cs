using System;

namespace easyPokerHUD
{
    public class Player
    {
        //Variables of the Object "Player"
        public string name;
        public string pokerRoom;
        public Boolean hadActionInPot;
        public int seat;
        public int handsPlayed;
        public int chips;
        public double bigBlinds;
        public int preflopCalls;
        public int preflopBetsAndRaises;
        public int postflopBetsAndRaises;
        public int postflopCallsChecksAndFolds;

        public Player(string name)
        {
            this.name = name;
            this.pokerRoom = "";
            this.hadActionInPot = false;
            this.seat = 0;
            this.handsPlayed = 0;
            chips = 0;
            bigBlinds = 0;
            preflopCalls = 0;
            preflopBetsAndRaises = 0;
            postflopBetsAndRaises = 0;
            postflopCallsChecksAndFolds = 0;
        }

        //Calculates and returns the VPIP of a given player
        public int calculateVPIP()
        {
            if (this.handsPlayed == 0)
            {
                return 0;
            }
            else
            {
                int VPIP = (preflopCalls + preflopBetsAndRaises) * 100 / handsPlayed;
                return VPIP;
            }
        }

        //Calculates and returns the PFR of a given player
        public int calculatePFR()
        {
            if (this.handsPlayed == 0)
            {
                return 0;
            }
            else
            {
                int PFR = Convert.ToInt16((((decimal)preflopBetsAndRaises) / (decimal)handsPlayed) * 100);
                return PFR;
            }
        }

        //Calculates and returns the AF of a given player
        public int calculateAFq()
        {
            if (postflopBetsAndRaises + postflopCallsChecksAndFolds == 0)
            {
                return 0;
            }
            else
            {
                float AFq = ((float)postflopBetsAndRaises / ((float)postflopBetsAndRaises+(float)postflopCallsChecksAndFolds)) * 100;
                return Convert.ToInt16(AFq);
            }
        }

        public double calculateBB()
        {
            return Math.Round(bigBlinds, 1);
        }

        //Combines the current dataset with the dataset in the database
        public void combinethisPlayerWithStoredStats()
        {
            DBControls.combineDataSets(this);
        }

        //Updates or creates this player in the database
        public void updateOrCreatePlayerInDatabase()
        {
            DBControls.insertOrReplacePlayer(this);
        }

        public void printStats()
        {
            Console.WriteLine("hp: "+handsPlayed+
                " preC: "+preflopCalls+
                " preBR: "+preflopBetsAndRaises+
                " postBR: "+postflopBetsAndRaises+
                " postCCF: "+postflopCallsChecksAndFolds+
                " Name: "+name);
        }
    }
}
