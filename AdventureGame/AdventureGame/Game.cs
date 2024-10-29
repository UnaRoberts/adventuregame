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
            //changing window size
            //Console.SetWindowSize(80, 20);

            //Setting opening color
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
        //string PlayerName = ReadLine().Trim();

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

        public void AutumnWelcome()
        {
            Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.BackgroundColor = ConsoleColor.Yellow;
            Clear();
            currentHeading.AutumnHeading();
            Utility.Spacing($"Welcome to the Autumn forest {player.Name}");
            ReadKey();
        }
        public void EndingSequence()
        {
            ForegroundColor = ConsoleColor.Yellow;
            BackgroundColor = ConsoleColor.Blue;
            Clear();
            Utility.TopSpaces();

            Utility.Spacing($"Congratulations{name}! You have successfully made it home!");
            WriteLine(@"

                                                                 8o88o          __
                                                               o88o           o688o)
                                         '-,    .``'.          _o8o    .-.'-.(6886898o
                                            \,'`   . \.  .----| |-.  ,'     o688868698o)
                                           .'  /   :   '/          \'  \  (68968886)6/88o
                                          /   '    '   /____________\   '.  866\88|889)
                                         /    .    \   | ___   __   | .'  `   (969/9\
                                         `           _ ||_|_| /  \  |______     \//  \
                                        '.`""'.`,`'./_\||_|_| | .|  |______\.`.`||,`,'
                                        `'^,_`'. ,""|O||______|  |__|======|,.',|| ,..
                                        .'`. ""\'^,`.,'.`'``.'/==\.,.'`,.' `,' .||.,.`
                                        `',`' `,'.^ '. ,.'`,/====\,' `,. ^, `.-',, `,
                                        .,`^  `. `,`  ,  ,`/======\,  ,'  `'.,""  .DR.
                                        Dariusz Ruman
");
            
            
                        Utility.Spacing("However, you did not find all of your friends. You are so lonely without all of them...");
            Utility.Spacing("If you want to find them, you can return to the start of the forest.");
            Utility.Spacing("Press A to return to the forest, and B to end the game.");

            ConsoleKeyInfo input = ReadKey();

            if (input.Key == ConsoleKey.A)
            {

                Clear();
                ForegroundColor = ConsoleColor.White;
                BackgroundColor = ConsoleColor.Cyan;
                Clear();
                Utility.TopSpaces();
                Utility.Spacing("Try making choices you have not yet tried- and pay close attention to the questions highlighted in this blue color.");
                ReadKey();
                Clear();
               
                Forest newForest = new Forest("Autumn", player);
                AutumnWelcome();  //need t add the colors and make all of these in the game class 
                newForest.StartForest();
                newForest.forestTransition();

                WinterWelcome();
                Forest newForest2 = new Forest("Winter", player);
                newForest2.StartForest();
                newForest2.forestTransition();

                SpringWelcome();
                Forest newForest3 = new Forest("Spring", player);
                newForest3.StartForest();
                newForest3.forestTransition();

                SummerWelcome();
                Forest newForest4 = new Forest("Summer", player);
                newForest4.StartForest();
            }
            else if (input.Key == ConsoleKey.B)
            {

                Environment.Exit(0);
                //print cottage at end (not in question, but as big finale scene )

            }
        }

        public void WinterWelcome()
        {
            Clear();
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.BackgroundColor = ConsoleColor.White;
            Clear();
            currentHeading.WinterHeading();
            Utility.Spacing($"Welcome to the Winter forest {player.Name}");
            ReadKey();
        }

        public void SpringWelcome()
        {
            Clear();
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Clear();
            currentHeading.SpringHeading();
            Utility.Spacing($"Welcome to the Spring forest {player.Name}");
            ReadKey();
        }

        public void SummerWelcome()
        {
            Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.BackgroundColor = ConsoleColor.Yellow;
            Clear();
            currentHeading.SummerHeading();
            Utility.Spacing($"Welcome to the Summer forest {player.Name}");
            ReadKey();
        }

        
        public void playGame()
        {

            Forest currentForest = new Forest("Autumn", player);
            //AutumnWelcome();  //need t add the colors and make all of these in the game class 
            //currentForest.StartForest();
            //currentForest.forestTransition();


            //WinterWelcome();
            //Forest currentForest2 = new Forest("Winter", player);
            //currentForest2.StartForest();
            //currentForest2.forestTransition();


            //SpringWelcome();
            //Forest currentForest3 = new Forest("Spring", player);
            //currentForest3.StartForest();
            //currentForest3.forestTransition();

            SummerWelcome();
            Forest currentForest4 = new Forest("Summer", player);
            currentForest4.StartForest();
            EndingSequence();
        }


    }

}




/* this is for items!

Console.WriteLine(CharacterName + " you found some items in your journey:");

foreach (string item in Inventory)
{
Console.WriteLine(item);
}*/

/*if (Inventory.Contains("key"))
{
Console.ForegroundColor = ConsoleColor.Cyan;
Console.WriteLine("Congratulations you accomplished the goal! You found the key!");
Console.ResetColor();
}
else
{
Console.WriteLine("You didn't find the key... better luck next time!");
}*/




