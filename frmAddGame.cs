/***************************************************************************************************************************************
****************************************************************************************************************************************
** Program Title: Achievement Tracker
** Author: Ben Stearns
** Date: 11-29-2023
** Description: Allows user to track Achievements/Trophies earned for video game software titles they own
** Usage / Known Issues: none
****************************************************************************************************************************************
****************************************************************************************************************************************/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AchievementTracker_BDS
{
    public partial class FrmAddGame : Form
    {
        public FrmAddGame()
        {
            InitializeComponent();
        }
        //Class variables
        private Game game = null!;

        //Create class array of video game platforms
        private readonly string[] platforms = { "Select a platform...", "PS5", "PS4", "PS3",
                                "Xbox 360","Xbox One", "Xbox Series X/S", "PC" };

        //Create method that returns the Game class object created by this form
        public Game GetNewGame()
        {
            this.ShowDialog();
            return game;
        }
        //Create Data Validation Method
        private bool IsPresent()
        {
            bool success = true;//create default variable
            string errorMessage = "";//create default variable

            if (txtGameTitle.Text.Trim() == "")//Validate txtGameTitle
            {
                errorMessage += "[Game Title] is a required field. Enter a game title.\n";
            }
            if (cboPlatforms.SelectedIndex == 0)//Validate cboPlatform
            {
                errorMessage += "[Platform] is required. Select a game platform.\n";
            }
            if (errorMessage != "")//Display error MessageBox if an error was found
            {
                success = false;
                MessageBox.Show($"{errorMessage}", "Entry Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return success;
        }
        //Close form upon using [Cancel] button
        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //Create object from user entry if it passes data validation
        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (IsPresent())//create object from user entry if it passes validation
            {
                game = new(
                    txtGameTitle.Text.Trim(),
                    cboPlatforms.Text.Trim());
                this.Close();//Close the form to return to the previous screen
            }


        }

        private void FrmAddGame_Load(object sender, EventArgs e)
        {
            foreach (String platform in platforms)
            {
                cboPlatforms.Items.Add(platform);
            }
            cboPlatforms.SelectedIndex = 0;
        }
    }
}
