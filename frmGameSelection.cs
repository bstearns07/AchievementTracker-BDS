/***************************************************************************************************************************************
****************************************************************************************************************************************
** Program Title: Achievement Tracker
** Author: Ben Stearns
** Date: 11-29-2023
** Description: Allows user to track Achievements/Trophies earned for video game software titles they own
** Usage / Known Issues: none
****************************************************************************************************************************************
****************************************************************************************************************************************/

using System.Diagnostics;

namespace AchievementTracker_BDS
{
    public partial class FrmAchievementTracker : Form
    {
        public FrmAchievementTracker()
        {
            InitializeComponent();
        }
        //Class variables
        private List<Game> gamesList = new();

        //Class method to fill the listbox with elements
        private void FillGamesListBox()
        {
            lstGameList.Items.Clear();//clear listbox of elements to prevent duplicates

            foreach (Game game in gamesList)//Add each game to listbox in GetDisplayText() method format
            {
                lstGameList.Items.Add(game.GetGameDisplayText());
            }

        }
        //Create method to get the title of the game selected by the user from the listbox for use in SaveAchievements() and GetAchievements() methods
        public static String GetSelectedGameTitle()
        {
            if (!Directory.Exists(@"C:\C#\Files\"))
            {
                Directory.CreateDirectory(@"C:\C#\Files\");
            }
            using StreamReader reader = new(new FileStream(@"C:\C#\Files\title.txt", FileMode.OpenOrCreate, FileAccess.Read));
            string title = reader.ReadToEnd();
            return title;
        }

        //Method to store the Title property of the user's selected game for use in SaveAchievements() and GetAchievements() methods
        public void StoreSelectedGameTitle()
        {

            int selectedIndex = lstGameList.SelectedIndex;

            Game game = gamesList[selectedIndex];
            string title = game.Title;
            using StreamWriter writer = new(new FileStream(@"C:\C#\Files\title.txt", FileMode.Create, FileAccess.Write));
            writer.Write($"{title}");

        }
        //Create an event for btnAddGame to allow the user to add a game to the form's listbox
        private void BtnAddGame_Click(object sender, EventArgs e)
        {
            FrmAddGame newAddGameForm = new();//create instance of frmAddGame as reference object
            Game game = newAddGameForm.GetNewGame();//create game object from object created by frmAddGame

            if (game != null)//check if object was successfully created to prevent null exception
            {
                //Add object to list, resave list to text file, and referesh listbox. Select first index in listbox
                gamesList.Add(game);
                AchievementTrackerDB.SaveGame(gamesList);
                FillGamesListBox();
                lstGameList.SelectedIndex = 0;

            }


        }

        //Calls GetGames() method to get games saved by user in text file and load them into lstGamesList
        private void FrmAchievementTracker_Load(object sender, EventArgs e)
        {
            gamesList = AchievementTrackerDB.GetGameList();//populate gamesList variable with text file records
            FillGamesListBox();//fill listbox with gamesList elements
            if (lstGameList.Items.Count != 0)//check if listbox is empty to prevent out-of-bounds exception
            {
                lstGameList.SelectedIndex = 0;//select first item in listbox by default
            }

        }
        //Close form upon using [Exit] button
        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //Create event for [Delete] button to remove a selected item from the listbox
        private void BtnDeleteGame_Click(object sender, EventArgs e)
        {
            int selectedIndex = lstGameList.SelectedIndex;//get user's selected index

            if (selectedIndex == -1)//display error MessageBox if no game is selected
            {
                MessageBox.Show("No item selected. Select a game to delete.", " Selection Error");
            }
            else
            {
                Game game = gamesList[selectedIndex];//create Game object from user's selected index
                string errorMessage = $"Are you sure you want to delete {game.Title}? " +
                                      $"CAUTION: This will also delete all achievements and progress that have been saved for {game.Title}.";

                //Create Dialog Result MessageBox to confirm deletion
                DialogResult confirm = MessageBox.Show($"{errorMessage}", "Confirm Delete",
                                      MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (confirm == DialogResult.Yes) //If "Yes" is chosen, remove the game and delete all saved achievements for that game
                {
                    gamesList.Remove(game);//remove object from list collection
                    AchievementTrackerDB.SaveGame(gamesList);//re-save list to text file
                    FillGamesListBox();//refresh listbox

                    //Delete associated Achievements text file if it exists
                    if (File.Exists(@$"C:\C#\Files\{game.Title}Achievements.txt"))
                    {
                        File.Delete(@$"C:\C#\Files\{game.Title}Achievements.txt");
                    }

                }
            }

        }
        //Load Achievements form upon using [View Achievements] button
        private void BtnViewAchievements_Click(object sender, EventArgs e)
        {
            if (lstGameList.SelectedIndex == -1)//Display error MessageBox if no item from list is selected from listbox
            {
                MessageBox.Show("No item selected. Select a game to view Achievements for.", "Selection Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                FrmAchievements newAchievementForm = new();//create object reference
                newAchievementForm.ShowDialog();//diplay frmAchievements as dialog
            }
        }
        //Store the Title property of whatever Game the user selects from the listbox in a text file
        private void LstGameList_SelectedIndexChanged(object sender, EventArgs e)
        {
            StoreSelectedGameTitle();
        }

        //Load frmAbout as a dialog upon using [About This App] button
        private void BtnAbout_Click(object sender, EventArgs e)
        {
            FrmAbout about = new();
            about.ShowDialog();
        }

    }
}