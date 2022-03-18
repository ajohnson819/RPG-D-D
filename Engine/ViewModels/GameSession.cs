using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Engine.Models;

namespace Engine.ViewModels
{
    public class GameSession
    {
        public Player CurrentPlayer { get; set; }
        
        public GameSession() //a constructor is like a factory that builds prototypes
        { //adding a reference allows files from one project use files in another project
            CurrentPlayer = new Player();
            CurrentPlayer.Name = "Adam";
            CurrentPlayer.characterClass = "Fighter";
            CurrentPlayer.HitPoints = 10;
            CurrentPlayer.Gold = 1000000;
            CurrentPlayer.ExperiencePoints = 0;
            CurrentPlayer.Level = 1;

        }
    }
}
