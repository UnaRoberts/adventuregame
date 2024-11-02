using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace AdventureGame
{
    internal class Winter : Season
    {
        Headings currentHeading = new Headings();
        public Winter(Player player) : base(player)
        {
        }
        public override void Run()
        {
            base.Run();
        }

        public override void Q1()
        {
            Clear();
            currentHeading.WinterHeading();
            Utility.Spacing("As you walk through the freezing cold, you hear happy shouts up ahead.");
            Utility.Spacing("When you get to the gathering you see a group of forest animals riding wooden sleds down a massive sledding hill.");
            Utility.Spacing("As you run towards it an owl swoops down towards you.");
            Utility.Spacing("As it swoops by, you think you hear it say 'careful - you wouldnt want to get hurt now would you...'");
            Utility.Spacing("It stops you in your tracks. You did not consider the danger of the huge, icy hill.");
            Utility.Spacing("You look look close at the hill and you see a set of stairs running the whole way down the hill.");
            ForegroundColor = ConsoleColor.Cyan;
            Utility.Spacing("You can either take the risk and ride a sled down the hill (A), or start the tedious trek down the stairs (B).");
            ForegroundColor = ConsoleColor.DarkBlue;

            Utility.Choice();

            ConsoleKeyInfo input = ReadKey();

            Clear();

            if (input.Key == ConsoleKey.A)
            {
                Clear();
                currentHeading.WinterHeading();
                Utility.Spacing("You run towards the hill, finding a sled lying on the ground at the top.");
                Utility.Spacing("You jump on and immmediately the wind whips you in the face down.");
                Utility.Spacing("The ride down in exhilirating at first, but as you go it quicly becomes terrifying and exhausting.");
                Utility.Spacing("What looked like a massive hill, was actaully a hill bigger than any you had ever seen or heard of.");
                Utility.Spacing("The ride downn lasts five minutes");
                Utility.Spacing("by the time you make it to the bottom you are freezing and never want to sled again.");
                Utility.Spacing("Unfortunately, it sounds like there is another exciting activity going on up ahead.");
                Utility.Spacing("You make your way towards the cheerful shouts of more animals of the forest,");
                Utility.Spacing("Hoping that your friends are nearby.");

                WriteLine(@"

                                                        .--.
                                                        | * `.
                                                        |    (          .-.
                                                        |<><> '._     .'  |
                                                        | /\ <><>'._.'  * |
                                                        :  *  /\ *   *   .'
                                                      (__'.____________.'__)lc
                                                    (______/\___/\___/\______)"
);//https://ascii.co.uk/art/sleigh

                Utility.MoveOn();

                Q2();

            }
            else if (input.Key == ConsoleKey.B)
            {
                Clear();
                currentHeading.WinterHeading();
                Utility.Spacing("You make the difficult, but responsible decision to go down the stairs.");
                Utility.Spacing("It is as grueling as it looked- the climb down takes an hour. ");
                Utility.Spacing("By the end you are freezing and ready to leave this hill behind.");
                Utility.Spacing("You make your way towards the cheerful shouts of more animals of the forest,");
                Utility.Spacing("Hoping that your friends are nearby.");

                WriteLine(@"

                                            __
                                              |
                                                __
                                                  |
                                                    __
                                                      |
                                                        __
                                                          |
                                                            __
                                                              |
                                                                __
                                                                  |

");// by me



                Utility.MoveOn();
                Q2();

            }

            else
            {

                currentHeading.WinterHeading();
                Utility.Spacing("That is not an option. Press enter to return to the options.");
                ReadKey();
                Clear();
                Q1();
            }
        }

        public override void Q2()
        {
            Clear();
            currentHeading.WinterHeading();
            Utility.Spacing("As you near the voices, the path opens up into a clearing. It appears to be a winter festival of some kind.");
            Utility.Spacing("Animals of all kinds are playing fair games, drinking hot cocoa, skating and investigating a network of igloos.");
            Utility.Spacing("You go up to the hot choclate stand to ask for directions, under the guise of getting a hot choclate.");
            Utility.Spacing("When you ask the person at the stand how to leave the fair");
            Utility.Spacing("They simply respond 'You never leave this forest'");
            Utility.Spacing("Panicked and disturbed, you move away from the stand quickly");
            Utility.Spacing("You start to feel animals looking at you and in need for an escape you look around");
            ReadKey();
            Clear();

            ForegroundColor = ConsoleColor.Cyan;
            Utility.Spacing("The two closest options are to try to escape into the crowd on the ice rink (A), or to run into the maze of igloos (B)");
            ForegroundColor = ConsoleColor.DarkBlue;

            WriteLine(@"
                       ,
           \O                    ,   .-.___             .-'''''-.                   .-'''''-.   
           /\                  O/   /xx\XXX\          .'_ / _ \ _'.____           .'_ / _ \ _'.____    
        __/\ `\                /\   |xx|XXX|         / _/ _ | _ \_ \ _.'.        / _/ _ | _ \_ \ _.'.      
          \, \_ =            _/` << |xx|XXX|________/_/___/___\___\_\_|_|_______/_/___/___\___\_\_|_|_____
                jgs


");//ice rink by Joan Stark (https://www.asciiart.eu/sports-and-outdoors/ice-hockey) and igloos: 
            Utility.Choice();



            ConsoleKeyInfo input = ReadKey();

            Clear();

            if (input.Key == ConsoleKey.A)
            {
                Clear();
                currentHeading.WinterHeading();
                Utility.Spacing("Animals are everywhere- ");
                Utility.Spacing("they crowd you, and once you finally make it around them you end up getting pushed out onto the ice rink.");
                Utility.Spacing("You slip and slide to the exit, finally escaping the crowds and the rink,");
                Utility.Spacing("running as fast as you can to a trail you see on the other side of the clearing. ");
                ReadKey();
                Clear();
                Q3();

            }
            else if (input.Key == ConsoleKey.B)
            {
                Clear();
                currentHeading.WinterHeading();

                Utility.Spacing("As it turns out, the igloos were the best chose you could have made.");
                Utility.Spacing("Once you make it through the maze of different igloos, and step out into the light,");
                Utility.Spacing("you realize that you are much farther through the forest than you expected.");
                Utility.Spacing("Turns out, the igloos were a portal to the Spring Forest.");
                ReadKey();
                Clear();
                ForegroundColor = ConsoleColor.Blue;
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
                ForegroundColor = ConsoleColor.Red;
                ReadKey();
                Clear();
                RunQuestions runQuestions = new RunQuestions(player);
                Forest currentForest = new Forest("Winter", player);
                currentForest.forestTransition();
                runQuestions.SpringQuestions();
            }

            else
            {
                Clear();
                currentHeading.WinterHeading();
                Utility.Spacing("That is not an option. Press enter to return to the options.");

                ReadKey();
                Clear();
                Q2();

            }
        }


        public override void Q3()
        {
            Clear();
            currentHeading.WinterHeading();
            Utility.Spacing("Once you are in the forest again you remember just how cold and lonely you are.");
            Utility.Spacing("You had hoped to find a friend in the winter forest, but alas.");
            Utility.Spacing("You trek along for a day, becoming more and more desperate by the hour.");
            Utility.Spacing("Finally, up ahead, you see a house, cozy and warm looking, with smoke rising from the chimney.");
            Utility.Spacing("It looks so cozy and like exactly what you need right now.");
            Utility.Spacing("But, right next to it, is a barn. What if your friends are there?");



            ForegroundColor = ConsoleColor.Cyan;
            Utility.Spacing("Do you go into the house (A), or the barn (B)?");
            ForegroundColor = ConsoleColor.DarkBlue;


            WriteLine(@"
                                 )                                  _.-^-._    .--.
                                (                                .-'   _   '-. |__|
                        ________[]_                             /     |_|     \|  |
                       /^=^-^-^=^-^\                           /               \  |
                      /^-^-^-^-^-^-^\                         /|     _____     |\ |
                     /__^_^_^_^^_^_^_\                         |    |==|==|    |  |
                      |  .==.       |      |---|---|---|---|---|    |--|--|    |  |
                    ^^|  |LI|  [}{] |^^^^  |---|---|---|---|---|    |==|==|    |  |
                    &&|__|__|_______|&&   ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
                         ====             
                          ====          
");//https://www.asciiarthub.com/house.html




            ForegroundColor = ConsoleColor.Black;
            Utility.Choice();
            ForegroundColor = ConsoleColor.DarkBlue;


            ConsoleKeyInfo input = ReadKey();

            Clear();

            if (input.Key == ConsoleKey.A)
            {
                Clear();
                currentHeading.WinterHeading();
                Utility.Spacing("As you walk up you smell cinnamon and then you start to smell dinner and cookies.");
                Utility.Spacing("You knock on the door and hear someone get up and shuffle towards the door.");
                Utility.Spacing("They open it- its an old lady, who looks kind.");
                Utility.Spacing("She lets you in and asks who you are and what you are looking for.");
                Utility.Spacing("You tell her your story, and while you talk she prepares you a meal.");
                Utility.Spacing("She gives you supper while you continue to tell her your hardships.");
                Utility.Spacing("As you talk, you start to slur your words and get veryyy tired.");
                Utility.Spacing("The last thing you remember is passing out while she cackles at you."); // make less confusing 

                WriteLine(@"

                      (
                    )    )
              _.(--""(""""""--.._
              /, _..-----).._,\
             |  `'''-----'''`  |
              \               /
               '.           .'
           jgs   '--.....--'

    
");//https://ascii.co.uk/art/soup

                ReadKey();

                Utility.CheckDeath();

                ForegroundColor = ConsoleColor.DarkBlue;
                BackgroundColor = ConsoleColor.White;
                Utility.MoveOn();
                RunQuestions runQuestions = new RunQuestions(player);
                Forest currentForest = new Forest("Winter", player);
                currentForest.forestTransition();
                runQuestions.SpringQuestions();
            }
            else if (input.Key == ConsoleKey.B)
            {
                Clear();
                currentHeading.WinterHeading();
                Utility.Spacing("You walk slowly towards the barn.");
                Utility.Spacing("When you enter, you look around, hoping for signs of your friends.");
                Utility.Spacing("As you search, it becomes apparent that the owner has never kept animals around- ");
                Utility.Spacing("the barn just came with the house.");
                Utility.Spacing("It is completely empty.");
                Utility.Spacing("Disappointed and cold, you walk away from the house and the barn, back into the forest.");
                Utility.Spacing("As you walk away, you get chills.");
                Utility.Spacing("Even though the barn was disappointing, you feel like you made the right choice.");
                Utility.MoveOn();

                RunQuestions runQuestions = new RunQuestions(player);
                Forest currentForest = new Forest("Winter", player);
                currentForest.forestTransition();
                runQuestions.SpringQuestions();
            }

            else
            {
                currentHeading.WinterHeading();
                Utility.Spacing("That is not an option. Press enter to return to the options.");
                ReadKey();
                Clear();
                Q3();

            }

        }

       
    }
 }
