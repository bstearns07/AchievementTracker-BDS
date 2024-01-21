/***************************************************************************************************************************************
****************************************************************************************************************************************
** Program Title: Achievement Tracker
** Author: Ben Stearns
** Date: 11-29-2023
** Description: Allows user to track Achievements/Trophies earned for video game software titles they own
** Class Description: Constructs an object called "Achievement" to represent an achievement for a video game title
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
    public class Achievement
    {
        //Code class constructors
        public Achievement() { }

        public Achievement(string name, string description, bool checkedStatus)
        {
            Name = name;
            Description = description;
            CheckedStatus = checkedStatus;
        }
        //Code class properties
        public string Name { get; set; }
        public string Description { get; set;}
        public bool CheckedStatus { get; set; }

    }
}
