using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace AdventureGame
{
    internal class Spring : Season
    {
        Headings currentHeading = new Headings();
        public Spring(Player player) : base(player)
        {
        }

        public override void Run()
        {
            base.Run();
        }

        public override void Q1()
        {
            Clear();
           
            ForegroundColor = ConsoleColor.White;
            BackgroundColor = ConsoleColor.DarkGreen;
            Clear();
            currentHeading.SpringHeading();
            
            Utility.Spacing("The relief of the warm is overwhelming.");
            Utility.Spacing("Positivity washes over you and you start to feel hopeful about finding your friends again.");
            Utility.Spacing("Up ahead, you see a waterfall- it is well off the path and it seems dangerous to get to");
            Utility.Spacing("You hear noises from the waterfall- is it a friend?");
            Utility.Spacing("The path continues past the waterfall.");

            ReadKey();
            Clear();
            currentHeading.SpringHeading();
            ForegroundColor = ConsoleColor.Cyan;
            Utility.Spacing("Do you go to the waterfall (A) or continue on the path (B)?");
            ForegroundColor = ConsoleColor.White;

            WriteLine(@"
                             _.._
                               _________....-~    ~-.______
                            ~~~                            ~~~~-----...___________..--------
                                                                       |   |     |
                                                                       | |   |  ||
                                                                       |  |  |   |
                                                                       |'. .' .`.|
                            ___________________________________________|0oOO0oO0o|____________
                             -          -         -       -      -    / '  '. ` ` \    -    -
                                  --                  --       --   /    '  . `   ` \    --
                            ---            ---          ---       /  '                \ ---
                                 ----               ----        /       ' ' .    ` `    \  ----
                            -----         -----         ----- /   '   '        `      `   \
                                 .-~~-.          ------     /          '    . `     `    `  \
                                (_^..^_)-------           /  '    '      '      `
                            Lester||||AMC       --------/     '     '   '

");//https://www.asciiart.eu/nature/waterfall



            ForegroundColor = ConsoleColor.White;
            BackgroundColor = ConsoleColor.Cyan;
            WriteLine("");
            WriteLine("                                                     Enter you choice:                                                  ");
            ForegroundColor = ConsoleColor.White;
            BackgroundColor = ConsoleColor.DarkGreen;


            ConsoleKeyInfo input = ReadKey();

            Clear();

            if (input.Key == ConsoleKey.A)
            {
                Clear();
                currentHeading.SpringHeading();
                Utility.Spacing("You approach the waterfall and look behind it.");
                Utility.Spacing("On a ledge of rocks behind the waterfall, is one of your friends.");
                ReadKey();
                Clear();

                Pet currentPet = new Pet(player);
                currentPet.PetGenerator2();
                currentPet.CheckPets();


                ReadKey();
                Clear();
                ForegroundColor = ConsoleColor.White;
                BackgroundColor = ConsoleColor.DarkGreen;
                Clear();
                Q2();

            }
            else if (input.Key == ConsoleKey.B)
            {
                Clear();
                currentHeading.SpringHeading();

                Utility.Spacing("You continue on the path, away from the waterfall.");
                Utility.Spacing("For some reason you can't shake the feeling that you picked wrong...");

                Utility.MoveOn();

                Q2();
            }

            else
            {
                Clear();
                currentHeading.SpringHeading();
                Utility.Spacing("That is not an option. Press enter to return to the options.");
                ReadKey();
                Clear();
                Q1();

            }
        }
        
        public override void Q2()
        {
            Clear();
            currentHeading.SpringHeading();

            Utility.Spacing("It appears that the path continues on forever.");
            Utility.Spacing("However, as you walk, you realize there is a burrow on the side of the road a while ahead. ");
            Utility.Spacing("Once you reach it you observe it.");
            Utility.Spacing("It looks relatively uneventful, but so does the path ahead.");
            ForegroundColor = ConsoleColor.Cyan;
            Utility.Spacing("You can continue on the path (A), or take a risk and go into the burrow (B).");
            ForegroundColor = ConsoleColor.White;

            Utility.Choice();

            ConsoleKeyInfo input = ReadKey();

            Clear();

            if (input.Key == ConsoleKey.A)
            {
                Clear();
                currentHeading.SpringHeading();

                Utility.Spacing("As you walk, the path feels like it will go on forever.");
                Utility.Spacing("You walk on for a long time");

                Utility.MoveOn();

                Q3();
            }
            else if (input.Key == ConsoleKey.B)
            {
                Clear();
                currentHeading.SpringHeading();

                Utility.Spacing("You climb down into the burrow carefully, ");
                Utility.Spacing("but as soon as you get inside you realize it is a steep downhill hole.");
                Utility.Spacing("You make your way down it.");
                Utility.Spacing("Once you make it to the end you see how far the burrow really went.");
                Utility.Spacing("It turns out that the burrow was actually a portal to the end of the forest.");
                ReadKey();
                Clear();
                ForegroundColor = ConsoleColor.Cyan;
                WriteLine(@"
                                                     . :H@@@MM@M#H/.,+%;,
                                                   ,/X+ +M@@M@MM%=,-%HMMM@X/,
                                                 -+@MM; $M@@MH+-,;XMMMM@MMMM@+-
                                                ;@M@@M- XM@X;. -+XXXXXHHH@M@M#@/.
                                              ,%MM@@MH ,@%=            .---=-=:=,.
                                              -@#@@@MX .,              -%HX$$%%%+;
                                             =-./@M@M$                  .;@MMMM@MM:
                                             X@/ -$MM/                    .+MM@@@M$
                                            ,@M@H: :@:                    . -X#@@@@-
                                            ,@@@MMX, .                    /H- ;@M@M=
                                            .H@@@@M@+,                    %MM+..%#$.
                                             /MMMM@MMH/.                  XM@MH; -;
                                              /%+%$XHH@$=              , .H@@@@MX,
                                               .=--------.           -%H.,@@@@@MX,
                                               .%MM@@@HHHXX$$$%+- .:$MMX -M@@MM%.
                                                 =XMMM@MM@MM#H;,-+HMM@M+ /MMMX=
                                                   =%@M@M#@$-.=$@MM@@@M; %M%=
                                                     ,:+$+-,/H#MMMMMMM@- -,
              
                      ");//https://blog.kazitor.com/2014/12/portal-ascii/ (edited for size)
                
                RunQuestions runQuestions = new RunQuestions(player);
                Forest currentForest = new Forest("Summer", player);
                currentForest.forestTransition();
                runQuestions.SummerQuestions();
            }

            else
            {
                Clear();
                currentHeading.SpringHeading();
                Utility.Spacing("That is not an option. Press enter to return to the options.");
                ReadKey();
                Q2();

            }

        }

        public override void Q3()

        {
            Clear();
            currentHeading.SpringHeading();
            Utility.Spacing("Finally, you see a fountain.");
            Utility.Spacing("You approach it and look into it.");
            Utility.Spacing("It is filled with koi fish.");
            Utility.Spacing("Suddenly, you have the urge to jump into the fountain.");

            ReadKey();
            Clear();

            WriteLine(@"
                                 .      .       .       .
                          .   .       .          .      . .      .         .          .    .
                                 .       .         .    .   .         .         .            .
                            .   .    .       .         . . .        .        .     .    .
                         .          .   .       .       . .      .        .  .              .
                              .  .    .  .       .     . .    .       . .      .   .        .
                         .   .       .    . .      .    . .   .      .     .          .     .
                            .            .    .     .   . .  .     .   .               .
                             .               .  .    .  . . .    .  .                 .
                                                . .  .  . . .  . .
                                                    . . . . . .
                                                      . . . .
                                                       I . I
                                         _______________III_______________
                                        /    .       .       .       .    \
                                       ( ~~~ .  ~~~  .  ~~~  .  ~~~  . ~~~ )
                                         \SSSSSSSSSSSSSSSSSSSSSSSSSSSSSSS/
                                            \ ======================= /
                                                \SSSSSSSSSSSSSSSSS/
                                             ________\       /________
                                            (=+=+=+=+=+=+=+=+=+=+=+=+=)
                                             ~~~~~~~~~~~~~~~~~~~~~~~~~

");// by Whitney Dinsmore (https://ascii.co.uk/art/fountain)
            ReadKey();
            Clear();

            currentHeading.SpringHeading();

            ForegroundColor = ConsoleColor.Cyan;
            Utility.Spacing("Do you continue on the path (A) or do you jump into the fountain (B)?");
            ForegroundColor = ConsoleColor.White;

            ForegroundColor = ConsoleColor.Black;
            Utility.Choice();
            ForegroundColor = ConsoleColor.White;

            ConsoleKeyInfo input = ReadKey();

            Clear();

            if (input.Key == ConsoleKey.A)
            {
                //Clear();
                currentHeading.SpringHeading();
                Utility.Spacing("You walk down the path.");
                Utility.Spacing("You shiver as you walk away, and you know that was the right choice.");
                //Utility.MoveOn();
                RunQuestions runQuestions = new RunQuestions(player);
                Forest currentForest = new Forest("Summer", player);
                currentForest.forestTransition();
                runQuestions.SummerQuestions();
            }
            else if (input.Key == ConsoleKey.B)
            {
                Clear();
                Utility.Spacing("You jump onto the pond.");
                Utility.Spacing("It is freezing and you instantly regret it.");
                Utility.Spacing("The last thing you see is the koi fish swimmming towards you.");
                Utility.Spacing("You pass out from the cold and the fish eat your body.");
                WriteLine(@"
                                      _
                                     )_ `.
                                    )_ `. \
                                   )_ `. `|
                                  )_ `.` /
                                 )_ `-.` |
                                )_ `-.` ` \
                                 )_.- ` `  \
                                  )_.-` `   \
                                   )_.-`\ /\ \
                                    )_.-| \O  \
                                        |  \   \
                              _        /   /    \        _
                             ) `-._   / /O\  /O\ \   _.-` (
                            )      `-/  `-'  `-'  \-`      (
                            )     _.-|    __      |-._     (
                             )_.-`   \ .-'  `-._  /   `-._(
                                LGB   \ `-.__.--`/
                                       `-._  _.-""

");//https://www.asciiarthub.com/fish.html
                ReadKey();
                Clear();

                Utility.CheckDeath();

                ForegroundColor = ConsoleColor.White;
                BackgroundColor = ConsoleColor.Green;
                Clear();
                Utility.MoveOn();
                RunQuestions runQuestions = new RunQuestions(player);
                Forest currentForest = new Forest("Summer", player);
                currentForest.forestTransition();
                runQuestions.SummerQuestions();

            }
            else
            {
                Clear();
                currentHeading.SpringHeading();
                Utility.Spacing("That is not an option. Press enter to return to the options.");
                ReadKey();
                Clear();
                Q3();

            }
        }
        

    }

    
}
