using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Models
{
    public class Player : INotifyPropertyChanged
    {
        private string _name;
        private string _characterClass;
        private int _hitPoints;
        private int _experiencePoints;
        private int _level;
        private int _gold;

        public string Name 
        {
            get { return _name; }
            set
            {
                _name = value;
                OnPropertyChanged("Name");
            }
        }

        public string CharacterClass 
        {
            get { return _characterClass; }
            set
            {
                _characterClass = value;
                OnPropertyChanged("CharacterClass");
            }
        }

        public int HitPoints 
        {
            get { return _hitPoints; }
            set 
            { 
                _hitPoints = value;
                OnPropertyChanged("HitPoints");
            }
        }

        public int ExperiencePoints
        {
            get { return _experiencePoints; }
            set 
            { 
                _experiencePoints = value;
                OnPropertyChanged("ExperiencePoints");
            }
        }
        public int Level 
        {
            get { return _level; }
            set
            {
                _level = value;
                OnPropertyChanged("Level");
            }
        }
        public int Gold 
        {
            get { return _gold; }
            set
            {
                _gold = value;
                OnPropertyChanged("Gold");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertName)
        { 
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertName));
        }
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