using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Models
{
    public class Player : INotifyPropertyChanged
    {//currently the scope is public, but it will be changed later 
        public string Name { get; set; }
        public string characterClass { get; set; }
        public int HitPoints { get; set; }
        public int ExperiencePoints { get; set; }
        public int Level { get; set; }
        public int Gold { get; set; }
    }
}
/*
 One way that Scott Lily explained the starting points of building a program by listing out the requirements of a game. 
A user can create a player, different classes and bonuses for each class.
The player can move to locations, fight monsters, obtain treasures and skill points. 
In battle, hit points might be lost or regained. 
If a player loses, then he returns home and is completely healed.
The location might have a quest, monster, loot, or so forth.
If the quest is failed, then the player is sent back home. 
If the quest is completed then the player gets skills, loot and moves forward.
The location might have a merchant or trader, so the player can buy/sell items. 
Player can also save/load game at a checkpoint. 
SO now take all the nouns and turn them into classes, then determine properties of the classes. 
 */