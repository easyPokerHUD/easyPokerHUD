using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;

namespace easyPokerHUD
{
    public class PokerRoomOverlay : OverlayFrame
    {
        protected string playerName;
        protected int tableSize;
        protected System.Windows.Forms.Timer controlSizeUpdateTimer = new System.Windows.Forms.Timer();
        protected System.Windows.Forms.Timer statsFetcherTimer = new System.Windows.Forms.Timer();
        protected int oldHeight;
        protected int oldWidth;
        protected List<StatsWindow> statsWindowList = new List<StatsWindow>();

        protected StatsWindow statsWindow1 = new StatsWindow();
        protected StatsWindow statsWindow2 = new StatsWindow();
        protected StatsWindow statsWindow3 = new StatsWindow();
        protected StatsWindow statsWindow4 = new StatsWindow();
        protected StatsWindow statsWindow5 = new StatsWindow();
        protected StatsWindow statsWindow6 = new StatsWindow();
        protected StatsWindow statsWindow7 = new StatsWindow();
        protected StatsWindow statsWindow8 = new StatsWindow();
        protected StatsWindow statsWindow9 = new StatsWindow();
        protected StatsWindow statsWindow10 = new StatsWindow();
        protected StatsWindow tableStatsWindow = new StatsWindow();

        //These are needed for the table overview
        protected int handsPlayedOnThisTable;
        protected int tableHandsPlayed;
        protected int tablePreflopCalls;
        protected int tablePreflopBetsAndRaises;
        protected int tablePostflopBetsAndRaises;
        protected int tablePostflopCallsChecksAndFolds;

        //Is needed by the get scaling factor method
        [DllImport("gdi32.dll")]
        static extern int GetDeviceCaps(IntPtr hdc, int nIndex);
        public enum DeviceCap
        {
            VERTRES = 10,
            DESKTOPVERTRES = 117,
            LOGPIXELSY = 90,
        }

        protected void prepareOverlay(string pTableName, int pTableSize, string pPlayerName)
        {
            //Set the basic functions
            this.ShowInTaskbar = false;
            tableName = pTableName;
            tableSize = pTableSize;
            playerName = pPlayerName;
            SetOwner();

            //Initialize the position of the overlay
            GetWindowRect(handle, out rect);
            setTransparency();
            setSize();
            setPosition();

            //Initialize the form
            startOverlayFrameUpdateTimer();

            //Setup the stats windows
            setupStatsWindows();
            setStatsWindowsFontSize();

            //Setup the timers
            statsFetcherTimer.Interval = 500;
            statsFetcherTimer.Enabled = true;

            controlSizeUpdateTimer.Interval = 250;
            controlSizeUpdateTimer.Enabled = true;
        }

        //Sets the stats Windows up
        protected void setupStatsWindows()
        {
            //Set the seat numbers
            statsWindow1.seatNumber = 1;
            statsWindow2.seatNumber = 2;
            statsWindow3.seatNumber = 3;
            statsWindow4.seatNumber = 4;
            statsWindow5.seatNumber = 5;
            statsWindow6.seatNumber = 6;
            statsWindow7.seatNumber = 7;
            statsWindow8.seatNumber = 8;
            statsWindow9.seatNumber = 9;
            statsWindow10.seatNumber = 10;

            //Add all the statswindows to the list
            statsWindowList.Add(statsWindow1);
            statsWindowList.Add(statsWindow2);
            statsWindowList.Add(statsWindow3);
            statsWindowList.Add(statsWindow4);
            statsWindowList.Add(statsWindow5);
            statsWindowList.Add(statsWindow6);
            statsWindowList.Add(statsWindow7);
            statsWindowList.Add(statsWindow8);
            statsWindowList.Add(statsWindow9);
            statsWindowList.Add(statsWindow10);

            //Add all the statsWindows to the overlay
            foreach (StatsWindow statsWindow in statsWindowList)
            {
                this.Controls.Add(statsWindow);
                statsWindow.Visible = false;
                statsWindow.tableLayoutPanel1.AutoSize = true;
            }
        }

        //Adjusts the font size according to the window size
        public void setStatsWindowsFontSize()
        {
            float fontSize = this.Width / 128 /getScalingFactor(); //99
            //float fontSizeForWindow = this.Width / 120; //120
            FontFamily fontFamily = new FontFamily("Helvetica");
            foreach (StatsWindow statsWindow in statsWindowList)
            {
                //statsWindow.Font = new Font("Arial", fontSizeForWindow);
                Font fontForTheStats = new Font(fontFamily, fontSize, FontStyle.Bold);
                //Font fontForTheText = new Font(fontFamily, fontSize, FontStyle.Regular, GraphicsUnit.Point, 0);

                statsWindow.VPIP.Font = fontForTheStats;
                statsWindow.PFR.Font = fontForTheStats;
                statsWindow.AFq.Font = fontForTheStats;
                statsWindow.BB.Font = fontForTheStats;
                statsWindow.Username.Font = fontForTheStats; // new Font("Arial", fontSize, FontStyle.Regular);
            }
        }

        //Gets the scaling factor of the current dpi settings
        protected float getScalingFactor()
        {
            Graphics g = Graphics.FromHwnd(IntPtr.Zero);
            IntPtr desktop = g.GetHdc();
            int LogicalScreenHeight = GetDeviceCaps(desktop, (int)DeviceCap.VERTRES);
            int PhysicalScreenHeight = GetDeviceCaps(desktop, (int)DeviceCap.DESKTOPVERTRES);
            int logpixelsy = GetDeviceCaps(desktop, (int)DeviceCap.LOGPIXELSY);
            float screenScalingFactor = (float)PhysicalScreenHeight / (float)LogicalScreenHeight;
            float dpiScalingFactor = (float)logpixelsy / (float)96; //96;

            return dpiScalingFactor; // 1.25 = 125%
            //return screenScalingFactor;
        }

        //Prepares the player seat numbers according to the size of the table
        protected List<Player> preparePlayerListForCorrectPositioning(List<Player> players)
        {
            while (!players.Find(p => p.name.Equals(playerName)).seat.Equals(tableSize - (tableSize / 2)))
            {
                foreach (Player player in players)
                {
                    if (player.seat == tableSize)
                    {
                        player.seat = 0;
                    }
                    player.seat = player.seat + 1;
                }
            }
            return players;
        }

        //Populates the controls with the player infos
        protected void populateStatsWindows(List<Player> players)
        {
            foreach (StatsWindow statsWindow in statsWindowList)
            {
                try
                {
                    var playerForThisSeat = players.Single(p => p.seat == statsWindow.seatNumber);
                    statsWindow.populateStatsWindow(playerForThisSeat);
                    statsWindow.Visible = true;
                }
                catch(InvalidOperationException)
                {
                    Console.Out.WriteLine("Hiding HUD for Seat " + statsWindow.seatNumber);
                    statsWindow.Visible = false;
                }
            }
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // PokerRoomOverlay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(278, 244);
            this.Name = "PokerRoomOverlay";
            this.ResumeLayout(false);

        }
    }
}
