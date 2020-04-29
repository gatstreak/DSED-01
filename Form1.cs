using System;
using System.Collections.Generic;
using System.Windows.Forms;

//start of project
namespace DSED_01
{
    // start of form
    public partial class Form1 : Form
    {
        // declares integers
        private int Bomb { get; set; } = 0;
        private int Trigger { get; set; } = 0;
        // creates counter for score tracking
        private int Counter { get; set; } = 0;
        // creates number for shield when shield = 2 turns off shield
        private int SheildCounter { get; set; } = 0;

        //Link to method Gameplay
        private GamePlay gamePlay = new GamePlay();

        public Form1()
        {
            InitializeComponent();
        }

        // button to start game

        // creates a new list of numbers already used
        private List<int> SuccessfulTries = new List<int>();

        private void btnLoad_Click(object sender, EventArgs e)
        {
            //loads internal method
            Load();
        }

        /// <summary>
        /// Local method to load game on button click
        /// </summary>

        private new void Load()
        {
            //disables / enables buttons
            btnLoad.Enabled = false;
            btnTry.Enabled = true;
            btnImune.Enabled = true;
            //! Bomb is the value you get when attempting

            //! Trigger is the number set to cause a fail state when bomb = trigger
            Trigger = gamePlay.RandomGen();

            // displays when game has mode has started
            lblInfo.Text = "Bomb Armed";
            lblInfo.BackColor = System.Drawing.Color.Green;
        }

        // make attempt button
        private void btnTry_Click(object sender, EventArgs e)
        {
            // checks if there are dupe numbers in list
            Bomb = gamePlay.DuplicateFilter(SuccessfulTries, Bomb);
            Bomb = gamePlay.RandomGen();

            // checks if the value of Bomb matches the value of Trigger
            if (Bomb == Trigger)
            {
                //!triggers game over state
                lblOutput.Text = "You Lose";
                lblOutput.BackColor = System.Drawing.Color.Red;
                lblInfo.BackColor = System.Drawing.Color.Red;
                lblInfo.Text = "The Bomb Exploded";
                btnTry.Text = "Game is Over";
                //disables buttons
                btnTry.Enabled = false;
                btnLoad.Enabled = false;
                btnImune.Enabled = false;
                // Plays sound effect
                System.Media.SoundPlayer player = new System.Media.SoundPlayer(Properties.Resources.Explosion);
                player.Play();
            }
            // if the values do not match you win
            else
            {
                //! triggers a successful attempt state
                lblOutput.Text = "Success";
                SuccessfulTries.Add(Bomb);
                lblInfo.Text = "You disarmed part of the bomb";
                //adds 1 to the counter
                Counter++;
            }
            // if counter = 5 you win
            if (Counter == 5)
            {
                lblInfo.Text = ("You Win You Defused all 5 parts of the bomb");
                //disables buttons
                btnTry.Enabled = false;
                btnLoad.Enabled = false;
                btnImune.Enabled = false;
                // Plays sound effect
                System.Media.SoundPlayer player = new System.Media.SoundPlayer(Properties.Resources.winner);
                player.Play();
            }
        }

        //button to reset game by reseting application
        private void btnReset_Click(object sender, EventArgs e)
        {
            // resets .exe file
            Application.Restart();
        }

        /// <summary>
        /// button for shield option
        private void btnImune_Click(object sender, EventArgs e)
        {
            Bomb = gamePlay.RandomGen();
            Bomb = gamePlay.DuplicateFilter(SuccessfulTries, Bomb);

            /// uses shield to not die from explosion causes a win state

            // checks if value of Bomb matches Value of Trigger
            if (Bomb == Trigger)
            {
                //!triggers successful state
                lblOutput.Text = "You Win";
                lblOutput.BackColor = System.Drawing.Color.Green;
                lblInfo.BackColor = System.Drawing.Color.Green;
                lblInfo.Text = "The Bomb Exploded But you survived";
                btnTry.Text = "You Win";
                //disables buttons
                btnTry.Enabled = false;
                btnLoad.Enabled = false;
                btnImune.Enabled = false;
                // Plays sound effect
                System.Media.SoundPlayer player = new System.Media.SoundPlayer(Properties.Resources.winner);
                player.Play();
            }
            else

            {
                //! triggers a successful attempt state
                lblOutput.Text = "Success";
                SuccessfulTries.Add(Bomb);
                lblInfo.Text = "You disarmed part of the bomb";
                //adds 1 to the counter
                Counter++;
            }

            if (Counter == 5)
            {
                lblInfo.Text = ("You Win You Defused all 5 parts of the bomb");
                //disables buttons
                btnTry.Enabled = false;
                btnLoad.Enabled = false;
                btnImune.Enabled = false;
                // Plays sound effect
                System.Media.SoundPlayer player = new System.Media.SoundPlayer(Properties.Resources.winner);
                player.Play();
            }

            // disables shields after two uses
            // checks if the value of counter is = to 2
            if (SheildCounter == 2)
            {
                //disables buttons
                btnImune.Enabled = false;
                btnImune.Text = "Out of shields";
            }
            SheildCounter++;
        }

        // button to exit game
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}