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
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AchievementTracker_BDS
{
    public partial class frmAddAchievement : Form
    {
        public frmAddAchievement()
        {
            InitializeComponent();
        }
        //Class variables
        Achievement achievement = null!;

        //Create Data Validation method to check if any textboxes are left blank by the user
        private bool IsPresent()
        {
            bool success = true;//set default variable
            string errorMessage = "";//set default variable

            if (txtAchievementName.Text.Trim() == "")//Validate txtAchievementName
            {
                errorMessage += "[Achievement Name] is a required field. Enter an achievement name.\n";
            }
            if (rchtxtDescription.Text.Trim() == "")//Validate rchtxtDescription
            {
                errorMessage += "[Description] is required. Enter a description for the achievement.\n";
            }
            if (errorMessage != "")//create error MessageBox if either textbox is left blank
            {
                success = false;
                MessageBox.Show($"{errorMessage}", "Entry Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return success;
        }

        //Class method to load form as dialog and return object created by form
        public Achievement GetNewAchievement()
        {
            this.ShowDialog();
            return achievement;
        }
        //Create Achievement object based on user entry upon using [Save] button
        private void btnSave_Click(object sender, EventArgs e)
        {
            //Create object from user entry if it passes data validation and close the form
            if (IsPresent())
            {
                achievement = new(
                   txtAchievementName.Text.Trim(),
                   rchtxtDescription.Text.Trim(),
                   false);//set checked status as False by default

                this.Close();//Close form to return to previous screen
            }

        }
        //Close form upon using [Cancel] button
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
