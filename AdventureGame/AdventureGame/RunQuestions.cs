using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace AdventureGame
{
    public class RunQuestions
    {
        string input = "";
        int totalPets = 0;
        Headings currentHeading = new Headings();
        Player player;
        public int deathcount;
        public bool moveToWinter = false;
        public RunQuestions(Player player)
        {
            player = player;
        }


        public void AutumnQuestions()
        {
            Autumn autumn = new Autumn(player);
            autumn.Run();
        }

        public void WinterQuestions()
        {
            Winter winter = new Winter(player);
            winter.Run();
        }

        public void SpringQuestions()
        {
            Spring spring = new Spring(player);
            spring.Run();
        }

        public void SummerQuestions()
        {
            Summer summer = new Summer(player);
            summer.Run();
        }



    }
}

