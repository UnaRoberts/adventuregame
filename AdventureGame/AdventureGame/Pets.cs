using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using AdventureGame;
using TriviaGame;
using static System.Console;

namespace AdventureGame
{
    //public class Item
    //{
    //    //constructor
     
    //}

    }

public class Pet
{

    static Random gen = new Random();

    public void PetGenerator1()
    {
        var Pets = new List<Action> { IntroAardvark, IntroCapybara};
        Pets[gen.Next(Pets.Count)]();
        ReadKey();
        
        //WriteLine($"{Pets[random.Next(Pets.Count)]();}");

    }

    public void PetGenerator2()
    {
        var Pets = new List<Action> { IntroBeaver, IntroQuail };
        Pets[gen.Next(Pets.Count)]();
        ReadKey();
       
        //WriteLine($"{Pets[random.Next(Pets.Count)]();}");

    }

    public void PetGenerator3()
    {
        var Pets = new List<Action> { IntroSnail, IntroAxolotl };
        Pets[gen.Next(Pets.Count)]();
        ReadKey();

        //WriteLine($"{Pets[random.Next(Pets.Count)]();}");

    }

    //constructor
    //public Pet(string petType)

    //{
    //   // PetType = petType;

    //}

    public static int totalPets = 0;

    Art currentArt = new Art(); //opening art function for all animals
    public void IntroAardvark()
    {
        Clear();
        totalPets += 1;
        Utility.TopSpaces();
        Utility.Spacing($"You have found a friend!");
        ReadKey();
        Clear();


        Clear();
        ForegroundColor = ConsoleColor.Blue;
        BackgroundColor = ConsoleColor.Black;
        Clear();
        currentArt.aardvarkArt();
        ForegroundColor = ConsoleColor.White;
        Utility.Spacing("It's a Arnie the Aardvark!");
        ReadKey();
        Clear();

        Utility.TopSpaces();
        Utility.Spacing($"You now have {totalPets} friends");
        Utility.Spacing("You need 3 friends to get home quickly");
        Utility.Spacing("Press enter to continue your journey...");
       
    }

    public void IntroCapybara()
    {
        Clear();
        totalPets += 1;
        Utility.TopSpaces();
        Utility.Spacing($"You have found a friend!");
        ReadKey();
        Clear();

        Clear();
        ForegroundColor = ConsoleColor.Red;
        BackgroundColor = ConsoleColor.Black;
        Clear();
        currentArt.capybaraArt();
        ForegroundColor = ConsoleColor.White;
        Utility.Spacing("It's a Carmen the Capybara!");
        ReadKey();
        Clear();

        Utility.TopSpaces();
        Utility.Spacing($"You now have {totalPets} friends");
        Utility.Spacing("You need 3 friends to get home quickly");
        Utility.Spacing("Press enter to continue your journey...");
    }

    public void IntroBeaver()
    {
        Clear();
        totalPets += 1;
        Utility.TopSpaces();
        Utility.Spacing($"You have found a friend!");
        ReadKey();
        Clear();


        Clear();
        ForegroundColor = ConsoleColor.Cyan;
        BackgroundColor = ConsoleColor.Black;
        Clear();
        currentArt.beaverArt();
        ForegroundColor = ConsoleColor.White;
        Utility.Spacing("It's a Barry the Beaver!");
        ReadKey();
        Clear();

        Utility.TopSpaces();
        Utility.Spacing($"You now have {totalPets} friends");
        Utility.Spacing("You need 3 friends to get home quickly");
        Utility.Spacing("Press enter to continue your journey...");
    }

    public void IntroQuail()
    {
        Clear();
        totalPets += 1;
        Utility.TopSpaces();
        Utility.Spacing($"You have found a friend!");
        ReadKey();
        Clear();

        Clear();
        ForegroundColor = ConsoleColor.DarkRed;
        BackgroundColor = ConsoleColor.Black;
        Clear();
        currentArt.quailArt();
        ForegroundColor = ConsoleColor.White;
        Utility.Spacing("It's a Quartz the Quail!");
        ReadKey();
        Clear();

        Utility.TopSpaces();
        Utility.Spacing($"You now have {totalPets} friends");
        Utility.Spacing("You need 3 friends to get home quickly");
        Utility.Spacing("Press enter to continue your journey...");
    }

    public void IntroSnail()
    {
        Clear();
        totalPets += 1;
        Utility.TopSpaces();
        Utility.Spacing($"You have found a friend!");
        ReadKey();
        Clear();

        Clear();
        ForegroundColor = ConsoleColor.DarkYellow;
        BackgroundColor = ConsoleColor.Black;
        Clear();
        currentArt.snailArt();
        ForegroundColor = ConsoleColor.White;
        Utility.Spacing("It's a Sam the snail!");
        ReadKey();
        Clear();

        Utility.TopSpaces();
        Utility.Spacing($"You now have {totalPets} friends");
        Utility.Spacing("You need 3 friends to get home quickly");
        Utility.Spacing("Press enter to continue your journey...");

        //ForegroundColor = ConsoleColor.Green;
        //BackgroundColor = ConsoleColor.Yellow;
        //Clear();
    }

    public void IntroAxolotl()
        
{
        Clear();
        totalPets += 1;
        Utility.TopSpaces();
        Utility.Spacing($"You have found a friend!");
        ReadKey();
        Clear();

        Clear();
                ForegroundColor = ConsoleColor.Magenta;
                BackgroundColor = ConsoleColor.Black;
                Clear();
                currentArt.axolotlArt();
                ForegroundColor = ConsoleColor.White;
                WriteLine("It's a Albert the axolotl!");
                ReadKey();
                Clear();

        Utility.TopSpaces();
        Utility.Spacing($"You now have {totalPets} friends");
        Utility.Spacing("You need 3 friends to get home quickly");
        Utility.Spacing("Press enter to continue your journey...");

        //ForegroundColor = ConsoleColor.Green;
        //BackgroundColor = ConsoleColor.Yellow;
        //Clear();
    }

   


        public void CheckPets()
    {
        //used copilot
        if (totalPets == 3)
        {
            Utility.Spacing("Yay you have found all your friends! Now make it to the end of the forest!");
            ReadKey();

            Game game = new Game();
            game.endGame();

          /*end game here 
           * show end game 
           * game.endgame + print a message explaining it
           * 
           * 
           * */

        }
        else
        {
            
            Utility.Spacing("You need more pets to advance");
        }

        ResetColor();
    }
}
