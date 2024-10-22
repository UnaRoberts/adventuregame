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
        Art currentArt = new Art();
        //int deathcount = 0;
        private string GameTitle = "Forest Adventure";
        private string Description = "Battle your friends for the top score in silly trivia";
        //string PlayerName = "";// declaring character name here so I can use it everywhere 
        Headings currentHeading = new Headings();
        //public Game(){
        //    startGame();
        //}

        Player player = new Player("PlayerName");
        public void startGame()

        {
            //changing window size
            //Console.SetWindowSize(80, 20);

            //Setting opening color
            ForegroundColor = ConsoleColor.Yellow;
            BackgroundColor = ConsoleColor.Blue;
            Clear();


            //welcoming player (title, description, move on directive


            Utility.Spacing("Welcome to");

            //Art currentArt = new Art();
            currentArt.OpenGameTitleArt();

            Utility.Spacing("You are a cat and you and your friends have been stranded from your home.");
            Utility.Spacing("Now you need to make it back through the four seasonal forests to get back.");
            Utility.Spacing("You lost you friends somewhere along the way- ");


            ForegroundColor = ConsoleColor.Black;
            Utility.Spacing("To complete the game you must make it home, find all your friends and avoid death.");
            ForegroundColor = ConsoleColor.Cyan;
            
            Utility.Spacing("If you find all of your friends, you will all collectively be able to make it home faster then alone.");
            ForegroundColor = ConsoleColor.Yellow;

            Utility.Spacing("Since you are a cat, you have some extra lives.");
            Utility.Spacing("However, you long journey has been difficult and you only have 3 lives left.");
            Utility.Spacing("If you die three times you hav elost the game.");
            Utility.Spacing("When you die, you will be prompted to return to the Autumn forest");
            Utility.Spacing("At any point, press enter to continue your journey.");



            // you have made it home, but you do not have your friends! (prompt to restart and find them)


            WriteLine("");
            Utility.Spacing("Press enter to start your journey!");

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
            WriteLine("Enter Player Name...");
            string playerName = ReadLine();
            player = new Player(playerName);

            WriteLine("Awesome! Your Character name is " + player.Name);
            ReadKey();
            //WriteLine("Press enter to step foot into the Autum Forest!");
            //ReadKey();
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

        public void WinterWelcome()
        {
            Clear();
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.BackgroundColor = ConsoleColor.White;
            Clear();
            currentHeading.WinterHeading();
            Utility.Spacing($"Welcome to the Autumn forest {player.Name}");
            ReadKey();
        }

        public void SpringWelcome()
        {
            Clear();
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Clear();
            currentHeading.SpringHeading();
            Utility.Spacing($"Welcome to the Autumn forest {player.Name}");
            ReadKey();
        }

        public void SummerWelcome()
        {
            Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.BackgroundColor = ConsoleColor.Yellow;
            Clear();
            currentHeading.SummerHeading();
            Utility.Spacing($"Welcome to the Autumn forest {player.Name}");
            ReadKey();
        }
        public void playGame()
        {
            Forest currentForest = new Forest("Autumn");
            AutumnWelcome();  //need t add the colors and make all of these in the game class 
            currentForest.StartForest();
            currentForest.forestTransition();

            WinterWelcome();
            Forest currentForest2 = new Forest("Winter");
            currentForest2.StartForest();
            currentForest2.forestTransition();

            SpringWelcome();
            Forest currentForest3 = new Forest("Spring");
            currentForest3.StartForest();
            currentForest3.forestTransition();

            SummerWelcome();
            Forest currentForest4 = new Forest("Summer");
            currentForest4.StartForest();

        }


        

        public void dying() // make this more artsy add that it makes your pets = to 0 
        {
            
            //incrementDeathcount(); //adds another death


            ForegroundColor = ConsoleColor.Red;
            BackgroundColor = ConsoleColor.Black;
            Clear();

            Console.Beep();//credit

            WriteLine(@"

      |\      _,,,---,,_
      /,`.-'`'    -.  ;-;;,_
     |,4-  ) )-,_. ,\ (  `'-'
    '---''(_/--'  `-'\_)  Felix Lee 

");//https://www.asciiart.eu/animals/cats (slightly edited for my purposes)

            WriteLine("You died. Press enter to restart game");
            player.deathcount++;

            if (player.deathcount == 1)
            {
                currentArt.TwoHearts();

                WriteLine($"You have died {player.deathcount} times. You have 2 lives left.");
                
            }

            else if (player.deathcount == 2)
            {
                currentArt.OneHeart();
                WriteLine($"You have died {player.deathcount} times. You have 1 lives left.");
                //deathcount = 3;
            }

            else if (player.deathcount == 3)
            {
                WriteLine("You are out of lives! Press enter to exit game.");
                WriteLine($"You have died {player.deathcount} times. You have 0 lives left.");
                ReadKey();//idk how to finish thissss
            }


            ReadKey();
            //Question dyingQuestion = new Question();
            //dyingQuestion.AutumnQuestions();

            Forest currentForest = new Forest("Autumn");
            //currentForest.StartForest();
            currentForest.returnToForestColors();
            Question dyingQuestion = new Question();
            dyingQuestion.AutumnQuestions();
        }

        //how do I use this???
        



        public int totalPets;
        public void endGame()
        {

            if (totalPets == 3)//this is not working
            {

                ForegroundColor = ConsoleColor.Yellow;
                BackgroundColor = ConsoleColor.Blue;
                Clear();
               Utility.Spacing($"Congratulations {player.Name}! You have successfully made it home!");
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
");//https://ascii.co.uk/art/houses

              
               Utility.Spacing("Thanks for playing!");
                ReadKey();
                Utility.Spacing("Press any key to exit...");
                ReadKey();

            }

            else 
            {
                Utility.Spacing("U didnt win.sorry.");
                ReadKey();
                Utility.Spacing("Thanks for playing!");
                ReadKey();//this readkey will end the whole game 
            }


        }







            //make this run on the conditions that 1) they have ALL pets 2) they did not die too many times (this should run by itself)


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




            public void Play()
        //this is not currently running - it has not been
        //called- it is also from the trviai game and does not match my game
        {
            Title = GameTitle;
            //WriteLine(GameTitleArt);
            WriteLine($"Welcome to {GameTitle}!");
            WriteLine(Description);

            Write("What is your name: ");
            string playerName = ReadLine();
            WriteLine($"You said {playerName}");
            //CurrentPlayer = new Player(playerName);
            // WriteLine($"Welcome to {GameTitle}, {CurrentPlayer.Name}!");
            //  WriteLine($"Your current score is {CurrentPlayer.Score}.");
            WriteLine("Press and key to exit");
            ReadKey();

        }
    }
}

