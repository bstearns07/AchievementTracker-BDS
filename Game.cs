/***************************************************************************************************************************************
****************************************************************************************************************************************
** Program Title: Achievement Tracker
** Author: Ben Stearns
** Date: 11-29-2023
** Description: Allows user to track Achievements/Trophies earned for video game software titles they own
** Class Description: Constructs an object called "Achievement" to represent a digital trophy that can be earned in a video game title
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
    public class Game
    {
        //Code constructors
        public Game () {}
        public Game(string gameTitle, string gamePlatform)
        {
            Title = gameTitle;
            Platform = gamePlatform;
        }

        //Code class properties
        public string Title { get; set; }
        public string Platform { get; set; }

        //Code class methods
        public string GetGameDisplayText() => $"{Title}    {Platform}";
     
    }
}
