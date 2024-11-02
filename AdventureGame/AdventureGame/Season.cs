using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using TriviaGame;
using static System.Console;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace AdventureGame
{
    public class Season
    {
        public Player player;
        public Season(Player player)
        {
            this.player = player;
        }
        public virtual void Run()
        {
            Q1 ();
            Q2 ();
            Q3 ();
           
        }
        public virtual void Q1()
        {

        }
        public virtual void Q2()
        {

        }
        public virtual void Q3()
        {

        }
       
    }
}