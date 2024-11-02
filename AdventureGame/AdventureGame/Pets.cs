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
{   }

public class Pet
{
    static Player player;
    static Random gen = new Random();
    public static int totalPets = 0;

    public Pet(Player player)
    {
        player = player;
    
    }

    public void PetGenerator1()
    {
        var Pets = new List<Action> { IntroAardvark, IntroCapybara}; 
        Pets[gen.Next(Pets.Count)]();
        ReadKey();
    }

    public void PetGenerator2()
    {
        var Pets = new List<Action> {  IntroSnail, IntroAxolotl };
        Pets[gen.Next(Pets.Count)]();
        ReadKey();
    }

    public void PetGenerator3()
    {
        var Pets = new List<Action> { IntroBeaver };//IntroQuail
        Pets[gen.Next(Pets.Count)]();
        ReadKey();
    }

    Art currentArt = new Art();
   
    public void IntroAardvark()
    {
        Clear();
        totalPets += 1;
        //hasCapybara = true;
        Utility.TopSpaces();
        Utility.Spacing($"You have found a friend!");
        ReadKey();
        Clear();

        Clear();
        ForegroundColor = ConsoleColor.DarkGray;
        BackgroundColor = ConsoleColor.Cyan;
        Clear();
        currentArt.aardvarkArt();
        ReadKey();
        Clear();
        ForegroundColor = ConsoleColor.White;
        Utility.TopSpaces();
        Utility.Spacing("It's Arnie the Aardvark!");
        ReadKey();
        Utility.Spacing("\"Arnie:'There is safety among numbers. Good to see you my friend.'");
        ReadKey();
        Clear();

        Utility.TopSpaces();
        Utility.Spacing($"You have found {totalPets} of your friends");
        Utility.Spacing("You need 3 friends to get home quickly");
        //Utility.Spacing("Press enter to continue your journey...");
    }

    public void IntroCapybara()
    {
        Clear();
        totalPets += 1;
        //hasCapybara = true;
        Utility.TopSpaces();
        Utility.Spacing($"You have found a friend!");
        ReadKey();
        Clear();

        Clear();
        ForegroundColor = ConsoleColor.DarkGray;
        BackgroundColor = ConsoleColor.Cyan;
        Clear();
        currentArt.capybaraArt();
        ReadKey();
        Clear();
        ForegroundColor = ConsoleColor.White;
        Utility.TopSpaces();
        Utility.Spacing("It's Carmen the Capybara!");
        ReadKey();
        Utility.Spacing("Carmen:'Are we far from home? Nevermind- we are together now.'");
        ReadKey();
        Clear();

        Utility.TopSpaces();
        Utility.Spacing($"You have found {totalPets} of your friends");
        Utility.Spacing("You need 3 friends to get home quickly");
        //Utility.Spacing("Press enter to continue your journey...");
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
        ForegroundColor = ConsoleColor.DarkGreen;
        BackgroundColor = ConsoleColor.Cyan;
        Clear();
        currentArt.beaverArt();
        ReadKey();
        Clear();
        ForegroundColor = ConsoleColor.White;
        Utility.TopSpaces();
        Utility.Spacing("It's Barry the Beaver!");
        ReadKey();
        Utility.Spacing("Barry:'I was so scared! I thought I would never see you again.'");
        ReadKey();
        Clear();
        Utility.TopSpaces();
        Utility.Spacing($"You have found {totalPets} of your friends");
        Utility.Spacing("You need 3 friends to get home quickly");
       // Utility.Spacing("Press enter to continue your journey...");
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
        ForegroundColor = ConsoleColor.DarkMagenta;
        BackgroundColor = ConsoleColor.Cyan;
        Clear();
        currentArt.quailArt();
        ReadKey();
        Clear();
        ForegroundColor = ConsoleColor.White;
        Utility.TopSpaces();
        Utility.Spacing("It's Quartz the Quail!");
        ReadKey();
        Utility.Spacing("Quartz:'Finally! I've been looking for you everywhere! I've missed you so much!'");
        ReadKey();
        Clear();

        Utility.TopSpaces();
        Utility.Spacing($"You have found {totalPets} of your friends");
        Utility.Spacing("You need 3 friends to get home quickly");
        //Utility.Spacing("Press enter to continue your journey...");
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
        BackgroundColor = ConsoleColor.Cyan;
        Clear();
        currentArt.snailArt();
        ReadKey();
        Clear();
        ForegroundColor = ConsoleColor.White;
        Utility.TopSpaces();
        Utility.Spacing("It's Sam the snail!");
        ReadKey();
        Utility.Spacing("Sam:'I've been trying to find you- it took me two weeks to make it down that giant sledding hill.'");
        ReadKey();
        Clear();

        Utility.TopSpaces();
        Utility.Spacing($"You have found {totalPets} of your friends");
        Utility.Spacing("You need 3 friends to get home quickly");
        //Utility.Spacing("Press enter to continue your journey...");

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
        BackgroundColor = ConsoleColor.Cyan;
        Clear();
        currentArt.axolotlArt();
        ReadKey();
        Clear();
        ForegroundColor = ConsoleColor.White;
        Utility.TopSpaces();
        Utility.Spacing("It's Albert the axolotl!");
        ReadKey();
        Utility.Spacing("Albert:'I've been so lonely- you certainly took your time getting here.'");
        ReadKey();
        Clear();

        Utility.TopSpaces();
        Utility.Spacing($"You have found {totalPets} of your friends");
        Utility.Spacing("You need 3 friends to get home quickly");
        //Utility.Spacing("Press enter to continue your journey...");

        //ForegroundColor = ConsoleColor.Green;
        //BackgroundColor = ConsoleColor.Yellow;
        //Clear();
    }


    public void CheckPets()

    {
        
        if (totalPets == 3)
        {
            Utility.Spacing("Yay! You have found all your friends!");
            ReadKey();
            ForegroundColor = ConsoleColor.Yellow;
            BackgroundColor = ConsoleColor.Blue;
            Clear();

            Utility.Spacing("Working together you find your way home much quicker.");
            ReadKey();
            Clear();
            Utility.Spacing($"Congratulations! You have successfully made it home with your friends!");
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

            Utility.Spacing("Press any key to exit game.");

            ReadKey();
            Environment.Exit(0); 
        }
        else if (totalPets <= 2)
        {

            Utility.Spacing("You have more friends to find."); 
        }

        ResetColor();
    }

}