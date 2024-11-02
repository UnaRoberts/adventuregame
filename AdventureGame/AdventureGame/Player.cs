using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using AdventureGame;
using TriviaGame;
using static System.Console;

namespace AdventureGame
{
}
    public class Player
    {
    
        public string Name;
        public static int deathcount;
    Art currentArt = new Art();

    //if correction is needed: 
    public List<string> Inventory;

    public void AddItem(string item)
    { Inventory.Add(item); }
        public Player(string name)
        {
            Name = name;
            //player.Name is how you access the name 
        }
    }