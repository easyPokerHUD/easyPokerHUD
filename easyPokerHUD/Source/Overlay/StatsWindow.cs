using System;
using System.Drawing;
using System.Windows.Forms;

namespace easyPokerHUD
{
    public partial class StatsWindow : UserControl
    {
        public int seatNumber;

        public StatsWindow()
        {
            InitializeComponent();
        }

        //Populates the stats window with the proper values
        public void populateStatsWindow(Player player)
        {
            populateLabels(player);

            //handsplayed.Text = player.name + "  "+ player.seat; //This line is for debugging purposes only
            this.Username.ForeColor = Color.GhostWhite;
            setAFqColor();
            setPFRColor();
            setVPIPColor();
            setBBColor();
        }

        //Populates the labels with the player data
        private void populateLabels(Player player)
        {
            Username.Text = player.name;// + "(" + getNumberOfHandsPlayedString(player.handsPlayed) + ")";

            //Set VPIP, PFR, AFq and handsPlayed 
            VPIP.Text = player.calculateVPIP().ToString();
            PFR.Text = player.calculatePFR().ToString();
            AFq.Text = player.calculateAFq().ToString();
            BB.Text = player.calculateBB().ToString() + " BB";
            //handsplayed.Text = getNumberOfHandsPlayedString(player.handsPlayed);

            //In case pfr is higher than vpip, vpip will be shown instead of pfr
            if (player.calculatePFR() > player.calculateVPIP())
            {
                PFR.Text = player.calculateVPIP().ToString();
            }
        }

        //Adjusts the displaying of the number of hands played according to size
        private string getNumberOfHandsPlayedString(int numberOfHandsPlayed)
        {
            if (numberOfHandsPlayed >= 1000 && numberOfHandsPlayed < 1000000)
            {
                return (numberOfHandsPlayed / 1000).ToString() + "k";
            }
            else if (numberOfHandsPlayed >= 1000000)
            {
                return (numberOfHandsPlayed / 1000000).ToString() + "k";
            }
            else
            {
                return numberOfHandsPlayed.ToString();
            }
        }

        //Sets the color of the VPIP stat
        private void setVPIPColor()
        {
            int vpip = Convert.ToInt16(VPIP.Text);
            if (vpip > 30)
            {
                this.VPIP.ForeColor = Color.Green;
            }
            else if (vpip > 18)
            {
                this.VPIP.ForeColor = Color.Orange;
            }
            else if (vpip > 1)
            {
                this.VPIP.ForeColor = Color.Red;
            }
            else
            {
                this.VPIP.ForeColor = Color.GhostWhite;
            }
        }

        //Sets the color of the PFR stat
        private void setPFRColor()
        {
            int pfr = Convert.ToInt16(PFR.Text);
            int vpip = Convert.ToInt16(VPIP.Text);

            if (pfr == 0)
            {
                this.PFR.ForeColor = Color.GhostWhite;
            }
            else if (pfr >= vpip * 0.8)
            {
                this.PFR.ForeColor = Color.Red;
            }
            else if (pfr > vpip * 0.5)
            {
                this.PFR.ForeColor = Color.Orange;
            }
            else if (pfr > 0)
            {
                this.PFR.ForeColor = Color.Green;
            }
        }

        //Sets the color of the AF stat
        private void setAFqColor()
        {
            int afq = Convert.ToInt16(AFq.Text);
            if (afq > 39)
            {
                this.AFq.ForeColor = Color.Red;
            }
            else if (afq > 24)
            {
                this.AFq.ForeColor = Color.Orange;
            }
            else if (afq > 1)
            {
                this.AFq.ForeColor = Color.Green;
            }
            else
            {
                this.AFq.ForeColor = Color.GhostWhite;
            }
        }

        //Sets the color of the BB stat
        private void setBBColor()
        {
            string s = BB.Text;
            var firstWhitespace = s.IndexOf(" ");
            string bbString = s.Substring(0, firstWhitespace);
            double bb = Convert.ToDouble(bbString);
            if (bb > 50)
            {
                this.BB.ForeColor = Color.Green;
            }
            else if (bb > 30)
            {
                this.BB.ForeColor = Color.Orange;
            }
            else if (bb > 20)
            {
                this.BB.ForeColor = Color.Yellow;
            }
            else
            {
                this.BB.ForeColor = Color.Red;
            }
        }

        private void StatsWindow_SizeChanged(object sender, EventArgs e)
        {
            this.AutoScaleMode = AutoScaleMode.Dpi;

            while (Username.Width < System.Windows.Forms.TextRenderer.MeasureText(Username.Text, new Font(Username.Font.FontFamily, Username.Font.Size, Username.Font.Style)).Width)
            {
                Username.Font = new Font(Username.Font.FontFamily, Username.Font.Size - 0.5f, Username.Font.Style);
            }

            while (BB.Width < System.Windows.Forms.TextRenderer.MeasureText(BB.Text, new Font(BB.Font.FontFamily, BB.Font.Size, BB.Font.Style)).Width)
            {
                BB.Font = new Font(BB.Font.FontFamily, BB.Font.Size - 0.5f, BB.Font.Style);
            }

        }
    }
}
