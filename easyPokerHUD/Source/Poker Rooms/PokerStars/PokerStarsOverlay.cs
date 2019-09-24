using System;
using System.Drawing;
using System.Threading;

namespace easyPokerHUD
{
    public partial class PokerStarsOverlay : PokerRoomOverlay
    {
        public PokerStarsOverlay(PokerStarsHand hand)
        {
            InitializeComponent();

            //Prepare the overlay
            prepareOverlay(hand.tableName, hand.tableSize, hand.playerName);

            //Add an event to the timers
            statsFetcherTimer.Tick += new EventHandler(updatePlayerStatsIfNewHandExists);
            controlSizeUpdateTimer.Tick += new EventHandler(updateControlSizeOrCloseOverlay);

            //Set the size for all controls
            setPositionOfStatsWindowsWindowsAccordingToTableSize();
        }

        //Updates all of the controls size on the form or closes the overlay if the table is closed
        public void updateControlSizeOrCloseOverlay(Object obj, EventArgs eve)
        {
            if (getTableWindowName() == "")
            {
                PokerStarsMain.overlays.TryRemove(tableName, out tableName);
                Close();
                Thread.CurrentThread.Abort();
            }
            else if (this.Height != oldHeight || this.Width != oldWidth)
            {
                oldHeight = Height;
                oldWidth = Width;
                setPositionOfStatsWindowsWindowsAccordingToTableSize();
                setStatsWindowsFontSize();
            }
        }

        //Updates the player stats 
        protected void updatePlayerStatsIfNewHandExists(Object obj, EventArgs eve)
        {
            PokerStarsHand hand;
            if (PokerStarsMain.newHandsToBeFetched.TryRemove(tableName, out hand))
            {
                hand.players = preparePlayerListForCorrectPositioning(hand.players);
                populateStatsWindows(hand.players);
            }
        }

        //Updates the size of the controls for the according table size
        protected void setPositionOfStatsWindowsWindowsAccordingToTableSize()
        {
            if (tableSize == 2)
            {
                positionControlsHeadsUp();
            } else if (tableSize == 3)
            {
                positionControls3Max();
            }
            else if (tableSize == 6)
            {
                positionControls6Max();
            }
            else if (tableSize == 9)
            {
                positionControls9Max();
            } 
        }

        //Positions the controls relative to the window size for HeadsUp
        private void positionControlsHeadsUp()
        {
            statsWindow1.Location = new Point(Convert.ToInt32(Convert.ToDouble(this.Width) / 2.4), Convert.ToInt32(Convert.ToDouble(this.Height / 1.25)));
            statsWindow2.Location = new Point(Convert.ToInt32(Convert.ToDouble(this.Width) / 1.65), Convert.ToInt32(Convert.ToDouble(this.Height / 6.5)));
        }

        //Positions the controls relative to the window size for 3max
        private void positionControls3Max()
        {
            statsWindow1.Location = new Point(Convert.ToInt32(Convert.ToDouble(this.Width) / 1.25), Convert.ToInt32(Convert.ToDouble(this.Height / 3.01)));
            statsWindow2.Location = new Point(Convert.ToInt32(Convert.ToDouble(this.Width) / 2.4), Convert.ToInt32(Convert.ToDouble(this.Height / 1.25)));
            statsWindow3.Location = new Point(Convert.ToInt32(Convert.ToDouble(this.Width) / 25.0), Convert.ToInt32(Convert.ToDouble(this.Height / 3.01)));
        }

        //Positions the controls relative to the window size for 6Max
        private void positionControls6Max()
        {
            statsWindow1.Location = new Point(Convert.ToInt32(Convert.ToDouble(this.Width) / 1.25), Convert.ToInt32(Convert.ToDouble(this.Height / 3.01)));
            statsWindow2.Location = new Point(Convert.ToInt32(Convert.ToDouble(this.Width) / 1.25), Convert.ToInt32(Convert.ToDouble(this.Height / 1.58)));
            statsWindow3.Location = new Point(Convert.ToInt32(Convert.ToDouble(this.Width) / 2.4), Convert.ToInt32(Convert.ToDouble(this.Height / 1.25)));
            statsWindow4.Location = new Point(Convert.ToInt32(Convert.ToDouble(this.Width) / 25.0), Convert.ToInt32(Convert.ToDouble(this.Height / 1.58)));
            statsWindow5.Location = new Point(Convert.ToInt32(Convert.ToDouble(this.Width) / 25.0), Convert.ToInt32(Convert.ToDouble(this.Height / 3.01)));
            statsWindow6.Location = new Point(Convert.ToInt32(Convert.ToDouble(this.Width) / 1.65), Convert.ToInt32(Convert.ToDouble(this.Height / 6.5)));
        }

        //Positions the controls relative to the window size for 9Max
        private void positionControls9Max()
        {
            statsWindow1.Location = new Point(Convert.ToInt32(Convert.ToDouble(this.Width) / 1.40), Convert.ToInt32(Convert.ToDouble(this.Height / 8))); // (1.34, 8.0)     *5th from player
            statsWindow2.Location = new Point(Convert.ToInt32(Convert.ToDouble(this.Width) / 1.40), Convert.ToInt32(Convert.ToDouble(this.Height / 3.3))); // ()            *6th from player
            statsWindow3.Location = new Point(Convert.ToInt32(Convert.ToDouble(this.Width) / 1.38), Convert.ToInt32(Convert.ToDouble(this.Height / 2))); // (1.2, 1.9)      *7th from player
            statsWindow4.Location = new Point(Convert.ToInt32(Convert.ToDouble(this.Width) / 1.45), Convert.ToInt32(Convert.ToDouble(this.Height / 1.42))); // (1.4, 1.37)  *8th from player
            statsWindow5.Location = new Point(Convert.ToInt32(Convert.ToDouble(this.Width) / 2.4), Convert.ToInt32(Convert.ToDouble(this.Height / 1.28))); // (2.4, 1.25)   *Player
            statsWindow6.Location = new Point(Convert.ToInt32(Convert.ToDouble(this.Width) / 7.8), Convert.ToInt32(Convert.ToDouble(this.Height / 1.42))); // (7.8, 1.37)   *1st from player
            statsWindow7.Location = new Point(Convert.ToInt32(Convert.ToDouble(this.Width) / 12.0), Convert.ToInt32(Convert.ToDouble(this.Height / 2))); // (55, 1.9)       *2rd from player
            statsWindow8.Location = new Point(Convert.ToInt32(Convert.ToDouble(this.Width) / 12.0), Convert.ToInt32(Convert.ToDouble(this.Height / 3.3))); // (14.0, 3.01)  *3nd from player
            statsWindow9.Location = new Point(Convert.ToInt32(Convert.ToDouble(this.Width) / 8), Convert.ToInt32(Convert.ToDouble(this.Height / 8))); // (8.0, 8.0)       *4th from player
        }

        //Needed by the designer
        private void PokerStarsOverlay_Load(object sender, EventArgs e)
        {

        }
    }
}
