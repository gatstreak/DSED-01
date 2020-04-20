using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Windows.Forms;

//start of project
namespace DSED_01
{
    // start of form
    public partial class Form1 : Form
    {
  
        //! declares trigger and bomb are...
        //! set to 0 to prep for random number
        private int Bomb = 0;

        private int Trigger = 0;
        // creates counter for score tracking
        private int Counter = 0;

        private int SheildCounter = 0;

        // !random number
        private Random myRandom = new Random();

        public Form1()
        {
            InitializeComponent();
        }

        //button to start game

        //! creates a new list
        private List<int> SuccessfulTries = new List<int>();

        private void btnLoad_Click(object sender, EventArgs e)
        {
            //sets random number parameters
            //! Bomb is the value you get when attempting
            //! Trigger is the number set as a fail state
            Trigger = myRandom.Next(1, 6);
            lblTrigger.Text = Convert.ToString(Trigger);
            // displays when game has mode has started
            lblInfo.Text = "Bomb Armed";
            lblInfo.BackColor = System.Drawing.Color.Green;
        }

        // make attempt button

        private void btnTry_Click(object sender, EventArgs e)
        {
            //sets random number parameters
           
            // checks if there are dupe numbers in list
            if (SuccessfulTries.Contains(Bomb))
            {
                int newBomb = myRandom.Next(1, 6);
                while (SuccessfulTries.Contains(newBomb))
                {
                    newBomb = myRandom.Next(1, 6);
                }
                Bomb = newBomb;
            }

            if (Bomb == Trigger)
            {
                //!triggers game over state
                lblOutput.Text = "You Lose";
                lblOutput.BackColor = System.Drawing.Color.Red;
                lblInfo.BackColor = System.Drawing.Color.Red;
                lblInfo.Text = "The Bomb Exploded";
                btnTry.Text = "Game is Over";
                btnTry.Enabled = false;
                btnLoad.Enabled = false;
            }
            else
            {
                //! triggers a successful attempt state
                lblOutput.Text = "Success";
                SuccessfulTries.Add(Bomb);
                lblInfo.Text = "You disarmed part of the bomb";
                //adds 1 to the counter
                Counter++;
                lblDebug.Text = Convert.ToString(Counter); ;
            }

            if (Counter == 5)
            {
                lblInfo.Text = ("You Win You Defused all 5 parts of the bomb");
                btnTry.Enabled = false;
                btnLoad.Enabled = false;
            }

            lblBomb.Text = Convert.ToString(Bomb);
        }

    

        private void btnReset_Click(object sender, EventArgs e)
        {
            // resets .exe file
            Application.Restart();
        }


        private void btnImune_Click(object sender, EventArgs e)
        {
            // checks if there are dupe numbers in list
            if (SuccessfulTries.Contains(Bomb))
            {
                int newBomb = myRandom.Next(1, 6);
                while (SuccessfulTries.Contains(newBomb))
                {
                    newBomb = myRandom.Next(1, 6);
                }

                Bomb = newBomb;
            }

            if (Bomb == Trigger)
            {
                //!triggers successful state
                lblOutput.Text = "You Win";
                lblOutput.BackColor = System.Drawing.Color.Green;
                lblInfo.BackColor = System.Drawing.Color.Green;
                lblInfo.Text = "The Bomb Exploded But you survived";
                btnTry.Text = "You Win";
                btnTry.Enabled = false;
                btnLoad.Enabled = false;
            }

            else

            {
                //! triggers a successful attempt state
                lblOutput.Text = "Success";
                SuccessfulTries.Add(Bomb);
                lblInfo.Text = "You disarmed part of the bomb";
                //adds 1 to the counter
                Counter++;
                lblDebug.Text = Convert.ToString(Counter); ;
            }

            if (Counter == 5)
            {
                lblInfo.Text = ("You Win You Defused all 5 parts of the bomb");
                btnTry.Enabled = false;
                btnLoad.Enabled = false;
            }

            lblBomb.Text = Convert.ToString(Bomb);
            SheildCounter++;

            // disables shields after two uses
            if (SheildCounter == 2)
            {
                btnImune.Enabled = false;
                btnImune.Text = "Out of shields";
            }

        }
    }
}