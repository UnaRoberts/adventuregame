using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using AdventureGame;
using static System.Console;


namespace TriviaGame
{
    internal class Game
    {
        string name;
        Headings currentHeading = new Headings();
        static Player player;
        Forest currentForest;

        public void startGame()

        {
            Art someArt = new Art();

            ForegroundColor = ConsoleColor.Yellow;
            BackgroundColor = ConsoleColor.Blue;
            Clear();


            Utility.TopSpaces();
            Utility.Spacing("Welcome to");

            someArt.OpenGameTitleArt();

            Utility.Spacing("You are a cat and you and your friends have been stranded from your home.");
            Utility.Spacing("Now you need to make it back through the four seasonal forests to get back.");
            Utility.Spacing("You lost you friends somewhere along the way- ");


            ForegroundColor = ConsoleColor.Black;
            Utility.Spacing("To complete the game you must make it home, find all your friends and avoid death.");
            ForegroundColor = ConsoleColor.Cyan;

            Utility.Spacing("If you find all of your friends, you will all be able to make it home faster together.");
            ForegroundColor = ConsoleColor.Yellow;

            Utility.Spacing("Since you are a cat, you have some extra lives.");
            Utility.Spacing("However, you long journey has been difficult and you only have 3 lives left.");
            Utility.Spacing("If you die three times you have lost the game.");
            Utility.Spacing("When you die, you will be prompted to return to the Autumn forest");
            Utility.Spacing("At any point, press any key to continue your journey.");

            WriteLine("");
            Utility.Spacing("This game was created by Una Roberts.");
            Utility.Spacing("Throughout the game there is art- most of the friends are made by Una Roberts and the rest has credits embedded in it.");

            WriteLine("");
            Utility.Spacing("Press any key to start your journey!");

            ReadKey();
            Clear();
        }

        public void greetPlayer()
        {
            ForegroundColor = ConsoleColor.Yellow;
            BackgroundColor = ConsoleColor.DarkBlue;
            Clear();
            Utility.TopSpaces();
            Write("                                                 Enter Player Name...");
            string playerName = ReadLine();
            player = new Player(playerName);
            name = player.Name;
            Utility.Spacing("Awesome! Your Player name is " + player.Name);
            ReadKey();
        }

        public void playGame()
        {
            Forest currentForest = new Forest("Autumn", player);
            AutumnWelcome();
            currentForest.StartForest();
            currentForest.forestTransition();


            WinterWelcome();
            Forest currentForest2 = new Forest("Winter", player);
            currentForest2.StartForest();
            currentForest2.forestTransition();


            SpringWelcome();
            Forest currentForest3 = new Forest("Spring", player);
            currentForest3.StartForest();
            currentForest3.forestTransition();

            SummerWelcome();
            Forest currentForest4 = new Forest("Summer", player);
            currentForest4.StartForest();

        }
        public void AutumnWelcome()
        {
            Clear();
            ForegroundColor = ConsoleColor.Red;
            BackgroundColor = ConsoleColor.Yellow;
            Clear();
            currentHeading.AutumnHeading();
            Utility.Spacing($"Welcome to the Autumn forest {player.Name}");
            ReadKey();
        }
        public void WinterWelcome()
        {
            Clear();
            ForegroundColor = ConsoleColor.DarkBlue;
            BackgroundColor = ConsoleColor.White;
            Clear();
            currentHeading.WinterHeading();
            Utility.Spacing($"Welcome to the Winter forest {player.Name}");
            ReadKey();
        }

        public void SpringWelcome()
        {
            Clear();
            ForegroundColor = ConsoleColor.White;
            BackgroundColor = ConsoleColor.DarkGreen;
            Clear();
            currentHeading.SpringHeading();
            Utility.Spacing($"Welcome to the Spring forest {player.Name}");
            ReadKey();
        }

        public void SummerWelcome()
        {
            Clear();
            ForegroundColor = ConsoleColor.Green;
            BackgroundColor = ConsoleColor.Yellow;
            Clear();
            currentHeading.SummerHeading();
            Utility.Spacing($"Welcome to the Summer forest {player.Name}");
            ReadKey();
        }

    }
}