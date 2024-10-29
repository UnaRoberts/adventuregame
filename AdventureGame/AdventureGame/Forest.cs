using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using TriviaGame;
using static System.Console;

namespace AdventureGame
{
    internal class Forest
    {
        public string ForestType;
        public string ColorTheme;
        //Game PlayerGame = new Game();
        Player player;
        public Forest(string forestType, Player player)

        {
            ForestType = forestType;
            player = player;

        }

        public void StartForest()
        {

            {
                switch (ForestType)
                {

                    case "Autumn":
                        Title = "Autumn Forest";
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.BackgroundColor = ConsoleColor.Yellow;
                        Console.Clear();
                        break;

                    case "Winter":
                        Title = "Winter Forest";
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        Console.BackgroundColor = ConsoleColor.White;
                        Console.Clear();
                        break;

                    case "Spring":
                        Title = "Spring Forest";
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.BackgroundColor = ConsoleColor.DarkGreen;
                        Console.Clear();
                        break;

                    case "Summer":
                        Title = "Summer Forest";
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.BackgroundColor = ConsoleColor.Yellow;
                        Console.Clear();
                        break;
                }

               

                Question currentQuestion = new Question(player);

                switch (ForestType)
                {

                    case "Autumn":

                        currentQuestion.AutumnQuestions();
                       
                        break;

                    case "Winter":
                        currentQuestion.WinterQuestions();
                        break;

                    case "Spring":
                        currentQuestion.SpringQuestions();
                        break;

                    case "Summer":
                       
                        currentQuestion.SummerQuestions();
                        break;
                }


                ReadKey();
            }
        }

      

        public void forestTransition()
        {
            switch (ForestType)
            {

                case "Autumn":
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.Clear();
                    Utility.TopSpaces();
                    Utility.Spacing("As you walk through the colorful forest, there is a sudden change.");
                    Utility.Spacing("As you walk, the wind picks up, the air gets colder and the further you get, the icier the trees get.");
                    Utility.Spacing("The colorful leaves become few and far between and eventually they are completely gone.");
                    Utility.Spacing("The world around you turns icy and white and you begin to shiver. ");
                   
                    break;

                case "Winter":
                    Console.ForegroundColor = ConsoleColor.DarkBlue; 
                    Console.BackgroundColor = ConsoleColor.Yellow;
                    Console.Clear();
                    Utility.TopSpaces();
                    Utility.Spacing("As you walk down the path, the air finally starts to feel warmer.");
                    Utility.Spacing("As you look ahead there is less and less ice. ");
                    Utility.Spacing("You start to see flower buds and greenery and later flowers start to bloom.");
                    break;

                case "Spring":
                    Console.ForegroundColor = ConsoleColor.Green; // not the same as the season colors!
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.Clear();
                    Utility.TopSpaces();
                    Utility.Spacing("There are no more bright green plants and colorful flowers.");
                    Utility.Spacing("The sun beats down and it feels muggy");
                    Utility.Spacing("As you look around it seems that the forest is relaxed.");


                    break;

                case "Summer":
                    WriteLine("");
                    break;
            }




            ReadKey();

        }


        public void returnToForestColors()
        {
            switch (ForestType)
            {

                case "Autumn":
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.BackgroundColor = ConsoleColor.Yellow;
                    Console.Clear();
                    break;

                case "Winter":
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.Clear();
                    break;

                case "Spring":
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.BackgroundColor = ConsoleColor.DarkGreen;
                    Console.Clear();
                    break;

                case "Summer":
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.BackgroundColor = ConsoleColor.Yellow;
                    Console.Clear();
                    break;
            }

        }
    }

}
