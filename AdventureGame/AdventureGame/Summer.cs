using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using TriviaGame;
using static System.Console;

namespace AdventureGame
{

    public class Summer : Season
    {
        Headings currentHeading = new Headings();
        public Summer(Player player) : base(player)
        {
        }

        public override void Run()
        {
            base.Run();
        }

        public override void Q1()
        {


            Clear();

            ForegroundColor = ConsoleColor.Green;
            BackgroundColor = ConsoleColor.Yellow;
            Clear();

            currentHeading.SummerHeading();
            Utility.Spacing("You keep walking, even though the heat is exhausting.");
            Utility.Spacing("You see a small structure up ahead.");
            Utility.Spacing("The shack looks like one you made with your friends at home- maybe they constructed it?");
            Utility.Spacing("As you look closer you realize that the fort is in a clearing that is far off the path.");
            Utility.Spacing("It seems unwise to go off the path again, but you do not want to risk not finding your friends.");
            ForegroundColor = ConsoleColor.Cyan;
            Utility.Spacing("Do you go to the fort (A) or continue on the path (B)?");
            ForegroundColor = ConsoleColor.Green;

            WriteLine(@"
                                             _
                                          _-'_'-_
                                       _-' _____ '-_
                                    _-' ___________ '-_
                                     |___|||||||||___|
                                     |___|||||||||___|
                                     |___|||||||o|___|
                                     |___|||||||||___|
                                     |___|||||||||___|
                                     |___|||||||||___|

");//https://www.asciiarthub.com/house.html


            ForegroundColor = ConsoleColor.White;
            BackgroundColor = ConsoleColor.Cyan;
            WriteLine("");
            WriteLine("                                                     Enter you choice:                                                  ");
            ForegroundColor = ConsoleColor.Red;
            BackgroundColor = ConsoleColor.Yellow;


            ConsoleKeyInfo input = ReadKey();

            Clear();

            if (input.Key == ConsoleKey.A)
            {
                currentHeading.SummerHeading();
                Utility.Spacing("You walk towards the fort.");
                Utility.Spacing("It turns out to be even further away from the path than you thought");
                Utility.Spacing("It takes forever to get there.");
                Utility.Spacing("Once you get there you carefully approach and open the makeshift door.");

                WriteLine(@"
                                    __________
                                   |  __  __  |
                                   | |  ||  | |
                                   | |  ||  | |
                                   | |__||__| |
                                   |  __  __()|
                                   | |  ||  | |
                                   | |  ||  | |
                                   | |  ||  | |
                                   | |  ||  | |
                                   | |__||__| |
                        ejm        |__________|

");//https://ascii.co.uk/art/doors#google_vignette

                Utility.MoveOn();

                Pet currentPet = new Pet(player);
                currentPet.PetGenerator3();
                currentPet.CheckPets();

                ReadKey();
                Clear();

                ForegroundColor = ConsoleColor.Green;
                BackgroundColor = ConsoleColor.Yellow;
                Clear();
                //Utility.MoveOn();

                Q2();
            }
            else if (input.Key == ConsoleKey.B)
            {
                currentHeading.SummerHeading();
                Utility.Spacing("You continue on the path.");
                Utility.Spacing("As you keep walking, you get the feeling that you made the wrong choice.");


                Utility.MoveOn();

                Q2();
            }

            else
            {
                currentHeading.SummerHeading();
                Utility.Spacing("That is not an option. Press enter to return to the options.");
                ReadKey();
                Clear();
                Q1();

            }
        }

        public override void Q2()
        {
            Clear();
            currentHeading.SummerHeading();
            Utility.Spacing("You become unbearably hot as you walk.");
            Utility.Spacing("You are thirsty, hungry, and starving");
            Utility.Spacing("As if on cue, you see a lemonade stand ahead.");
            Utility.Spacing("It is run by two young squirrels.");
            Utility.Spacing("A sign says that they have lemonade and cookies.");
            ForegroundColor = ConsoleColor.Cyan;
            Utility.Spacing("Do you just get lemonade (A), or do you get lemonade and cookies (B)?");
            ForegroundColor = ConsoleColor.Green;

            WriteLine(@"
                                             __
                                            /.-
                                    ______ //
                                   /______'/|
                                   [       ]|
                                   [ Lemon ]|
                                   [ -ade  ]|          ______
                                   [  _\_  ]|        /  -  -  \
                                   [  :::  ]|        \ -    - /
                                   [   :'  ]/         --------
                             jgs   '-------'

");//https://ascii.co.uk/art/juice

            ForegroundColor = ConsoleColor.Black;
            Utility.Choice();
            ForegroundColor = ConsoleColor.Green;

            ConsoleKeyInfo input = ReadKey();

            Clear();

            if (input.Key == ConsoleKey.A)
            {
                currentHeading.SummerHeading();
                Utility.Spacing("Once you have your lemonade, you thank the squirrels and continue on.");
                Utility.Spacing("You start to feel queasy- turns out you are too hungry to go on.");
                Utility.MoveOn();


                Utility.CheckDeath();

                ForegroundColor = ConsoleColor.Green;
                BackgroundColor = ConsoleColor.Yellow;
                Q3();


            }
            else if (input.Key == ConsoleKey.B)
            {
                currentHeading.SummerHeading();
                Utility.Spacing("Once you have your lemonade and cookies, you thank the squirrels and continue on.");
                Utility.Spacing("As you walk, you're grateful that you got cookies- you think otherwise you might have starved to death.");

                Utility.MoveOn();

                Q3();
            }

            else
            {
                currentHeading.SummerHeading();
                Utility.Spacing("That is not an option. Press enter to return to the options.");
                ReadKey();
                Clear();
                Q2();

            }
        }

        public override void Q3()
        {
            Clear();

            currentHeading.SummerHeading();
            Utility.Spacing("You can feel that you are close to home.");
            Utility.Spacing("The path splits ahead- one last choice.");
            ForegroundColor = ConsoleColor.Cyan;
            Utility.Spacing("Do you go right (A) or left (B)?");
            ForegroundColor = ConsoleColor.Green;

            WriteLine(@"
                                       ,@@@@@@@,
                               ,,,.   ,@@@@@@/@@,  .oo8888o.
                            ,&%%&%&&%,@@@@@/@@@@@@,8888\88/8o
                           ,%&\%&&%&&%,@@@\@@@/@@@88\88888/88'
                           %&&%&%&/%&&%@@\@@/ /@@@88888\88888'
                           %&&%/ %&%%&&@@\ V /@@' `88\8 `/88'
                           `&%\ ` /%&'    |.|        \ '|8'
                               |o|        | |         | |
                               |.|        | |         | |
                        jgs \\/ ._\//_/__/  ,\_//__\\/.  \_//__/_
");//https://ascii.co.uk/art/tree

            Utility.Choice();

            ConsoleKeyInfo input = ReadKey();

            Clear();

            if (input.Key == ConsoleKey.A)
            {
                ForegroundColor = ConsoleColor.Yellow;
                BackgroundColor = ConsoleColor.Cyan;
                Clear();
                Utility.TopSpaces();
                Utility.Spacing("You walk down the right path.");
                Utility.Spacing("You see your's and your friends cottage ahead.");
                Utility.Spacing("When you look back at the path, you realize that the left and right path both converge at the cottage.");
                ReadKey();
                Clear();
                Utility.Spacing($"Congratulations! You have successfully made it home!");
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
                Utility.Spacing("If you play again, try making choices you have not yet tried- ");
                Utility.Spacing("and pay close attention to the questions highlighted in this blue color.");
                ReadKey();
                Environment.Exit(0);
                

            }
            else if (input.Key == ConsoleKey.B)
            {
                ForegroundColor = ConsoleColor.Yellow;
                BackgroundColor = ConsoleColor.Cyan;
                Clear();
                Utility.TopSpaces();
                Utility.Spacing("You walk down the left path.");
                Utility.Spacing("You see your's and your friends cottage ahead.");
                Utility.Spacing("When you look back at the path, you realize that the left and right path both converge at the cottage.");
                ReadKey();
                Clear();
                Utility.Spacing($"Congratulations! You have successfully made it home!");
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
                Utility.Spacing("If you play again, try making choices you have not yet tried- ");
                Utility.Spacing("and pay close attention to the questions highlighted in this blue color.");
                ReadKey();
                Environment.Exit(0);
               


            }

            else
            {
                currentHeading.SummerHeading();
                Utility.Spacing("That is not an option. Press enter to return to the options.");
                ReadKey();
                Clear();
                Q3();

            }
        }
    }
}

 
          