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
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AchievementTracker_BDS
{
    public partial class FrmAchievements : Form
    {
        public FrmAchievements()
        {
            InitializeComponent();
        }
        //Class variables
        List<Achievement> achievementsList = null!;

        //Class method to fill checkListBox with list collection
        private void FillAchievementsListBox()
        {
            chklstAchievements.Items.Clear();//clear listbox to prevent duplicates

            foreach (Achievement achievement in achievementsList)//add each element of the list collection into the checkListBox by their Name property
            {
                chklstAchievements.Items.Add(achievement.Name);
            }
            if (chklstAchievements.Items.Count != 0) //check if listbox is empty to prevent out-of-bounds exception
            {
                chklstAchievements.SelectedIndex = 0;//select first item in checkListBox by default
            }
        }

        //Class method to load description richTextBox with the description of whatever item the user selects from their checkListBox of achievements
        private void FillDescriptionTextBox()
        {
            rchtxtDescription.Text = "";//empty textbox to prevent duplications
            int selectedIndex = chklstAchievements.SelectedIndex;//get selected index

            if (selectedIndex != -1)//prevent loading the description richTextBox if no item is selected
            {
                Achievement achievement = achievementsList[selectedIndex];//create object from user's selection
                rchtxtDescription.Text = achievement.Description;//load the object's Description property into richTextBox
            }

        }

        //Class method that saves the status of whether a checkbox is marked to a textfile
        private void SaveCheckedStatus()
        {

            for (int indexNumber = 0; indexNumber < chklstAchievements.Items.Count; indexNumber++)//create loop to go through all the items in the checkListBox
            {
                if (chklstAchievements.GetItemChecked(indexNumber) == true)
                {
                    achievementsList[indexNumber].CheckedStatus = true;
                }
                else
                {
                    achievementsList[indexNumber].CheckedStatus = false;
                }
                Debug.WriteLine($"Item number {indexNumber}'s Checked Status = {achievementsList[indexNumber].CheckedStatus}");
            }
            AchievementTrackerDB.SaveAchievement(achievementsList);
        }
        //Class method to apply checkmarks to checkboxes that were marked off previously
        private void ApplyCheckmarkedStatus()
        {
            for (int indexNumber = 0; indexNumber < chklstAchievements.Items.Count; ++indexNumber)
            {
                if (achievementsList[indexNumber].CheckedStatus == true)
                {
                    chklstAchievements.SetItemChecked(indexNumber, true);
                }
                else
                {
                    chklstAchievements.SetItemChecked(indexNumber, false);
                }
                //Debug.WriteLine($"Item number {indexNumber}'s Checked Status = {achievementsList[indexNumber].CheckedStatus}");
            }
        }
        //Create class method to fill txtNumberOfAchievements with the games total number of achievements
        private void FillNumberOfAchievementsTextbox()
        {
            int totalNumberOfAchievements = chklstAchievements.Items.Count;
            TxtNumberOfTrophies.Text = totalNumberOfAchievements.ToString();
        }

        //Create method to calculate percent completion that can be called outside the ItemChecked event
        private void CalculatePercentCompletion()
        {
            decimal totalNumberOfAchievements = chklstAchievements.Items.Count;//store total number of items in checklistbox
            decimal numberOfGamesChecked = 0m;//set initial variable for number of items checked off the list
            decimal completion = 0;//declare initial variable for the final completion percentage
            for (int indexNumber = 0; indexNumber < totalNumberOfAchievements; indexNumber++)
            {

                if (chklstAchievements.GetItemChecked(indexNumber) == true)//check if each item in checklist is marked
                {
                    numberOfGamesChecked++;//increment variable if the item is marked
                }

            }

            //Calculate percent completed
            if (totalNumberOfAchievements != 0)//prevent divide by zero errors
            {
                completion = numberOfGamesChecked / totalNumberOfAchievements;
            }

            //Output to textbox
            txtComplete.Text = completion.ToString("p1");
        }
        //Save status of checkboxes and close form upon using [Back] button
        private void BtnBack_Click(object sender, EventArgs e)
        {
            SaveCheckedStatus();
            this.Close();
        }

        /* Create event for [Add Achievement] button to allow user to add their own Achievement to the listbox*/
        private void BtnAddAchievement_Click(object sender, EventArgs e)
        {
            frmAddAchievement newAddAchievementForm = new();//create instance of AddAchievements for for object reference
            Achievement achievement = newAddAchievementForm.GetNewAchievement();//load frmAddAchievement as dialog. Create object from user's entry.
            SaveCheckedStatus();
            if (achievement != null)//check if object created isn't null
            {
                achievementsList.Add(achievement);//add object to list collection
                AchievementTrackerDB.SaveAchievement(achievementsList);//resave list collection to text file
                FillAchievementsListBox();//reload checkListBox
                ApplyCheckmarkedStatus();
                CalculatePercentCompletion();
                FillDescriptionTextBox();//reload Description richTextBox
                FillNumberOfAchievementsTextbox();
            }

        }
        /*Fill achievementsList class variable upon form load.
         *Fill checklistbox, description textbox, completion textbox, and checkmarks upon form load*/
        private void Achievements_Load(object sender, EventArgs e)
        {
            achievementsList = AchievementTrackerDB.GetAchievements();//fill list collection with any elements saved to text file
            FillAchievementsListBox();
            FillDescriptionTextBox();
            ApplyCheckmarkedStatus();
            CalculatePercentCompletion();
            FillNumberOfAchievementsTextbox();

        }
        /*Upon using [Delete] button: display confirmation box to confirm the user wants to delete the selected item from listbox.
         *If user responds "Yes", remove the element from list array, resave list array to text file, and refresh listbox & rich 
         *textbox*/
        private void BtnDelete_Click(object sender, EventArgs e)
        {
            SaveCheckedStatus();
            if (chklstAchievements.SelectedIndex == -1)//Display error MessageBox if no item is selected
            {
                MessageBox.Show("No item selected. Select an achievement to delete.", "Selection Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int selectedIndex = chklstAchievements.SelectedIndex;//get selected index
                Achievement achievement = achievementsList[selectedIndex];//create an Achievement object from the user's selection

                //Display a confirmation MessageBox to confirm the user wants to delete the item
                DialogResult cofirm = MessageBox.Show($"Are you sure you want to delete {achievement.Name}?", "Confirm Deletion",
                                                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                //If user selects "Yes", proceed with removing the item
                if (cofirm == DialogResult.Yes)
                {
                    achievementsList.Remove(achievement);//remove object from list collection
                    AchievementTrackerDB.SaveAchievement(achievementsList);//resave list collection to text file
                    FillAchievementsListBox();//refill checkListBox
                    ApplyCheckmarkedStatus();//apply checkmarks
                    CalculatePercentCompletion();//recalcuate percent completion
                    FillDescriptionTextBox();//refresh Description textbox
                    FillNumberOfAchievementsTextbox();
                }

            }
        }
        /* Create an event so when the user selects a different Achievement from the listbox, its matching description is
         * loaded into the Description textbox*/
        private void ChklstAchievements_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillDescriptionTextBox();
        }
        //Save status of checkboxes upon form close
        private void FrmAchievements_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveCheckedStatus();
        }
        //Calculate % complete when the status of a checkbox changes
        private void ChklstAchievements_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            //Begin calculating percent completion if the status of a checkbox is about to be changed

            decimal totalNumberOfAchievements = chklstAchievements.Items.Count;//store total number of items in checklistbox
            decimal numberOfGamesChecked = 0m;//set initial variable for number of items checked off the list
            decimal completion = 0;//declare initial variable for the final completion percentage
            int selectedIndex = chklstAchievements.SelectedIndex;

            if (selectedIndex != -1)//prevent out-of-range exception upon form load
            {
                //check the status of the checkbox user is about to change and before the opposite calculation
                if (chklstAchievements.GetItemChecked(selectedIndex) == true)
                {
                    numberOfGamesChecked--;
                }
                else
                {
                    numberOfGamesChecked++;
                }
            }
            //create loop to go through all items in the checklistbox and see if they are marked off
            for (int indexNumber = 0; indexNumber < totalNumberOfAchievements; indexNumber++)
            {

                if (chklstAchievements.GetItemChecked(indexNumber) == true)//check if each item in checklist is marked
                {
                    numberOfGamesChecked++;//increment variable if the item is marked
                }

            }

            //Calculate percent completed
            if (totalNumberOfAchievements != 0)//prevent divide by zero errors
            {
                completion = numberOfGamesChecked / totalNumberOfAchievements;
            }

            //Output to textbox
            txtComplete.Text = completion.ToString("p1");

        }

    }

}
