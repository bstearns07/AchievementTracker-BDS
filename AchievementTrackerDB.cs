/***************************************************************************************************************************************
****************************************************************************************************************************************
** Program Title: Achievement Tracker
** Author: Ben Stearns
** Date: 11-29-2023
** Description: Allows user to track Achievements/Trophies earned for video game software titles they own
** Class Description: Stores the methods used to write Games and Achievements saved by the user so they are saved, and read/retrieve
**                    those saved Games and Achievements from those text files
** Usage / Known Issues: none
****************************************************************************************************************************************
****************************************************************************************************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AchievementTracker_BDS
{
    public static class AchievementTrackerDB
    {
        //Code directory, path, and seperators used to save Game and Achievement class objects
        const string Dir = @"C:\C#\Files\";
        const string GamesPath = Dir + "Games.txt";
        const string Sep = "|";

        /*******************Code class methods***************/

//Create method to save/write games added by user to a text file
public static void SaveGame(List<Game> gamesList)
        {
            using StreamWriter writer = new(new FileStream(GamesPath, FileMode.Create, FileAccess.Write));

            foreach (Game game in gamesList)
            {
                writer.Write(game.Title + Sep);
                writer.WriteLine(game.Platform);
            }
        }
        //Create method to save/write Achievements added by user to a text file
        public static void SaveAchievement(List<Achievement> achievementsList) 
        {
            //Create StreamWriter object to save the user's Achievements to a textfile specific to that game's title
            using StreamWriter writer = new(new FileStream(Dir + FrmAchievementTracker.GetSelectedGameTitle() + "Achievements.txt", 
                                                           FileMode.Create, FileAccess.Write));

            //Use StreamWriter to write gamesList to text file
            foreach (Achievement achievement in achievementsList)
            {
                writer.Write(achievement.Name + Sep);
                writer.Write(achievement.Description + Sep);
                writer.WriteLine(achievement.CheckedStatus);
            }
        }
        /*Create method to read Game.txt file, create a Game object from the records, and 
         * add that object to gamesList variable*/
        public static List<Game> GetGameList()
        {
            //Create directory if it doesn't exist
            if (!Directory.Exists(Dir))
            {
                Directory.CreateDirectory(Dir);
            }
            List<Game> gamesList = new();
            using StreamReader reader = new(new FileStream(GamesPath, FileMode.OpenOrCreate, FileAccess.Read));

            while(reader.Peek() != -1)
            {
                string row = reader.ReadLine() ?? "";
                string[] columns = row.Split(Sep);

                if(columns.Length == 2 )
                {
                    Game game = new()
                    {
                        Title = columns[0],
                        Platform = columns[1],
                    };
                    gamesList.Add(game);
                }
            }
            return gamesList;
        }
        /* Create method to read Achievements.txt file, create Achievement class objects from the records
         * and add them to achievementsList varible*/
        public static List<Achievement> GetAchievements()
        {
            List<Achievement> achievementsList = new();//declare default variable

            //Create directory if it doesn't exist
            if (!Directory.Exists(Dir))
            {
                Directory.CreateDirectory(Dir);
            }
            //Create StreamWriter object to read the text file the matches the game's title
            using StreamReader reader = new(new FileStream(Dir + FrmAchievementTracker.GetSelectedGameTitle() + "Achievements.txt",
                                                           FileMode.OpenOrCreate, FileAccess.Read));

            while (reader.Peek() != -1)
            {
                string row = reader.ReadLine() ?? "";
                string[] columns = row.Split(Sep);

                if (columns.Length == 3)
                {
                    Achievement achievement = new()
                    {
                        Name = columns[0],
                        Description = columns[1],
                        CheckedStatus = Convert.ToBoolean(columns[2])
                    };
                    achievementsList.Add(achievement);
                }
            }
             return achievementsList;
        }
        
    }
}
