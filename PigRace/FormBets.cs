using PigRace.Business;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PigRace
{
    public partial class FormBets : Form
    {
        // instantiate an array of pigs and punters
        Pig[] myPig = new Pig[4];
        Punter[] myPunter = new Punter[3];
        // instantiate a punter for the selected punter making the bet
        Punter selectedPunter;
        public int Id { get; set; }
        public string selectedPig { get; set; }
        public string winner { get; set; }

        public FormBets()
        {
            InitializeComponent();

            SetUpPigs();
            SetUpPunters();
            ShowBrokePlayers();
            LoadComboBox();
        }
        /// <summary>
        /// Give the pigs starting variables
        /// </summary>
        private void SetUpPigs()
        {
            // Give the pigs starting variables
            myPig[0] = new Pig { Name = "Bacon", myPB = pb1, StartingLocation = "Top", StartingPosition = 1, FinishLine = 248 }; //158
            myPig[1] = new Pig { Name = "Pork", myPB = pb2, StartingLocation = "Right", StartingPosition = 875, FinishLine = 717 };//158
            myPig[2] = new Pig { Name = "Ham", myPB = pb3, StartingLocation = "Bottom", StartingPosition = 491, FinishLine = 337 };//158
            myPig[3] = new Pig { Name = "Ribs", myPB = pb4, StartingLocation = "Left", StartingPosition = 381, FinishLine = 628 };//158

            SetPigPictures();
        }
        /// <summary>
        /// Setting images for the picture boxes
        /// </summary>
        private void SetPigPictures()
        {
            myPig[0].myPB.BackgroundImage = Resource1.pig3;
            myPig[1].myPB.BackgroundImage = Resource1.pig1;
            myPig[2].myPB.BackgroundImage = Resource1.pig4;
            myPig[3].myPB.BackgroundImage = Resource1.pig2;
        }
        /// <summary>
        /// Use the factory to set up the punters from their classes
        /// </summary>
        private void SetUpPunters()
        {
            for (int i = 0; i < 3; i++)
            {
                myPunter[i] = Factory.GetAPunter(i);
            }
        }
        /// <summary>
        /// Add each punter to the combobox as long as they have some money
        /// </summary>
        private void LoadComboBox()
        {
            for (int i = 0; i < 3; i++)
            {
                if (myPunter[i].Broke != true)
                {
                    cbxPunter.Items.Add(myPunter[i].PunterName);
                }
            }
        }
        /// <summary>
        /// Display on the screen which players have lost all their money
        /// </summary>
        private void ShowBrokePlayers()
        {
            lblBroke.Text = string.Empty;
            for (int i = 0; i < 3; i++)
            {
                if (myPunter[i].Cash <= 0)
                {
                    myPunter[i].Broke = true;
                    lblBroke.Text += "\n" + myPunter[i].PunterName + " is broke and can no longer bet.";
                }
            }
        }
        /// <summary>
        /// Get the name of the selected punter so the selected punter can be instantiated
        /// </summary>
        private void cbxPunter_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selection = cbxPunter.SelectedItem.ToString();
            // set ID manually because indexes change once punters are removed from the combobox
            Id = SetComboBoxValue(selection);
            // set up the selected punter as the correct punter
            selectedPunter = myPunter[Id];

            SetMaxUDValues();
        }
        /// <summary>
        /// Set the values of the numeric up down 
        /// </summary>
        public void SetMaxUDValues()
        {
            udBet.Maximum = (decimal)selectedPunter.Cash;
            udBet.Value = (decimal)selectedPunter.Cash;
            // show how much cash the punter has left to bet with
            lblCashLeft.Text = "I have $" + selectedPunter.Cash + " left to bet with.";
        }
        /// <summary>
        /// Return the Id for the selected punter 
        /// </summary>
        /// <param name="selection"></param>
        private int SetComboBoxValue(string selection)
        {
            switch (selection)
            {
                case "Mad Butcher":
                    return 0;
                case "Farmer Brown":
                    return 1;
                case "Mrs Piggy":
                    return 2;
                default: return 9;
            }
        }
        /// <summary>
        /// Radio button check changed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void radButton_CheckedChanged(object sender, EventArgs e)
        {
            // set name of the selected pig
            if (radBacon.Checked)
            {
                selectedPig = "Bacon";
            }
            if (radHam.Checked)
            {
                selectedPig = "Ham";
            }
            if (radPork.Checked)
            {
                selectedPig = "Pork";
            }
            if (radRibs.Checked)
            {
                selectedPig = "Ribs";
            }
            // once a pig is selected, enable the confirm bet button
            btnConfirm.Enabled = true;
        }
        /// <summary>
        /// Confirm bet button clicked
        /// </summary>
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            // Assign the bet value and the pig to the selected punter
            selectedPunter.Bet = (float)udBet.Value;
            selectedPunter.Pig = selectedPig;
            // display the bet the punter has just placed
            lblBet1.Text += "\n" + selectedPunter.PunterName + " is placing a $" + selectedPunter.Bet + " bet on " + selectedPunter.Pig;
            // reset values on the form
            lblCashLeft.Text = string.Empty;
            udBet.Value = 0;
            btnConfirm.Enabled = false;
            // remove the punter who just made the bet from the combo box
            cbxPunter.Items.Remove(cbxPunter.SelectedItem);
            // uncheck the selected radio button
            if (radBacon.Checked)
            {
                radBacon.Checked = false;
            }
            else if (radHam.Checked)
            {
                radHam.Checked = false;
            }
            else if (radPork.Checked)
            {
                radPork.Checked = false;
            }
            else if (radRibs.Checked)
            {
                radRibs.Checked = false;
            }
            // once no more punters left, enable start race button
            if (cbxPunter.Items.Count == 0)
            {
                cbxPunter.Enabled = false;
                btnAllBets.Enabled = true;
            }
        }
        /// <summary>
        /// All bets button clicked
        /// </summary>
        private void btnAllBets_Click(object sender, EventArgs e)
        {
            // create 4 random numbers between 1 and 5
            int[] num = new int[4];
            Random rnd = new Random();
            for (int i = 0; i < 4; i++)
            {
                num[i] = rnd.Next(1, 5);
            }
            bool endRace = false;
            // repeat loop until endRace = true
            while (endRace != true)
            {
                // make each pig run towards the middle using the corresponding random number
                // until one pig reaches the finish line
                for (int i = 0; i < 4; i++)
                {
                    Application.DoEvents();
                    myPig[i].Run(num[i]);
                    // pig moving down
                    if (myPig[i].StartingLocation == "Top")
                    {
                        if ((myPig[i].myPB.Top + 89) > myPig[i].FinishLine)
                        {
                            myPig[i].Winner = true;
                            endRace = true;
                            break;
                        }
                    }
                    // pig moving to the left
                    else if (myPig[i].StartingLocation == "Right")
                    {
                        if ((myPig[i].myPB.Left) < myPig[i].FinishLine)
                        {
                            myPig[i].Winner = true;
                            endRace = true;
                            break;
                        }
                    }
                    // pig moving up
                    else if (myPig[i].StartingLocation == "Bottom")
                    {
                        if (myPig[i].myPB.Top < myPig[i].FinishLine)
                        {
                            myPig[i].Winner = true;
                            endRace = true;
                            break;
                        }
                    }
                    // pig moving to the right
                    else if (myPig[i].StartingLocation == "Left")
                    {
                        if ((myPig[i].myPB.Left + 89) > myPig[i].FinishLine)
                        {
                            myPig[i].Winner = true;
                            endRace = true;
                            break;
                        }
                    }
                }
            }
            // set an image for 1st place and end race
            for (int i = 0; i < 4; i++)
            {
                if (myPig[i].Winner == true)
                {
                    myPig[i].myPB.BackgroundImage = Resource1.first;
                    winner = myPig[i].Name;
                    EndOfRace();
                }
            }
        }
        /// <summary>
        /// End the race and find winner and losers
        /// </summary>
        private void EndOfRace()
        {
            // show which pig won the race
            string results = winner + " won the race.";
            for (int i = 0; i < 3; i++)
            {
                // display results for punters who still have cash
                if (myPunter[i].Cash >= 1)
                {
                    // if the punter chose the winning pig
                    if (myPunter[i].Pig == winner)
                    {
                        // add on the amount that they bet
                        myPunter[i].Cash += myPunter[i].Bet;
                        results += "\n" + myPunter[i].PunterName + " won their bet and now has $" + myPunter[i].Cash;
                    }
                    // punters who lost their bet
                    else
                    {
                        // take away the amount that they bet and lost
                        myPunter[i].Cash -= myPunter[i].Bet;
                        // if the punter is now busted and has no money
                        if (myPunter[i].Cash <= 0)
                        {
                            results += "\n" + myPunter[i].PunterName + " lost their bet so is now BUSTED and can no longer make any more bets";
                            myPunter[i].Broke = true;
                        }
                        // if the punter still has cash
                        else
                        {
                            results += "\n" + myPunter[i].PunterName + " lost their bet and now has $" + myPunter[i].Cash;
                        }
                    }
                }
                
            }
            MessageBox.Show(results);
            LoadComboBox();
            if (cbxPunter.Items.Count == 0)
            {
                MessageBox.Show("Uh oh! Everyone lost their money, game over! \n\nStart again");
                for (int i = 0; i < 3; i++)
                {
                    myPunter[i].Cash = 50;
                }
            }
            RefreshForm();
            
        }
        /// <summary>
        /// Refresh the form ready to start a new game
        /// </summary>
        private void RefreshForm()
        {
            cbxPunter.Enabled = true;
            lblBroke.Text = string.Empty;
            // show which players are broke
            ShowBrokePlayers();
            // reset values
            lblCashLeft.Text = string.Empty;
            udBet.Value = 0;
            lblBet1.Text = string.Empty;
            // move pictures back to their starting position
            myPig[0].myPB.Top = myPig[0].StartingPosition;
            myPig[1].myPB.Left = myPig[1].StartingPosition;
            myPig[2].myPB.Top = myPig[2].StartingPosition;
            myPig[3].myPB.Left = myPig[3].StartingPosition;
            SetUpPigs();
        }
    }
}
