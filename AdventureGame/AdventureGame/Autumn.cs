using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace AdventureGame
{
    internal class Autumn : Season
    {
        Headings currentHeading = new Headings();
        
        public Autumn(Player player) : base(player)
        {
        }

        
        public override void Run()
        {
            base.Run();
        }

        public override void Q1()
        {
            Clear();
            currentHeading.AutumnHeading();
            Utility.Spacing("Sunlight spills into the forest but it gets darker the further in you walk.");
            Utility.Spacing("You have just arrived at the first fork in the road- to the right there is a blue glow among the leaves");
            Utility.Spacing("and to the left it continues to get darker.");
            ForegroundColor = ConsoleColor.Cyan;
            Utility.Spacing("Do you go to the right (A), or the left (B)?");
            ForegroundColor = ConsoleColor.Red;

            WriteLine(@"
           
              v .   ._, |_  .,               v .   ._, |_  .,              v .   ._, |_  .,
           `-._\/  .  \ /    |/_          `-._\/  .  \ /    |/_         `-._\/  .  \ /    |/_
               \\  _\, y | \//                \\  _\, y | \//                \\  _\, y | \//
         _\_.___\\, \\/ -.\||           _\_.___\\, \\/ -.\||           _\_.___\\, \\/ -.\||
           `7-,--.`._||  / / ,            `7-,--.`._||  / / ,            `7-,--.`._||  / / ,
           /'     `-. `./ / |/_.'          /'     `-. `./ / |/_.'        /'     `-. `./ / |/_.'
                     |    |//                       |    |//                        |    |//
                     |_    /                        |_    /                         |_    /
                     |-   |                         |-   |                          |-   |
                     |   =|                         |   =|                          |   =|
                     |    |                         |    |                          |    |
--------------------/ ,  . \--------.--------------/ ,  . \--------._--------------/ ,  . \--------._
             ART BY JGS 

");
            //https://www.textartcopy.com/ascii-tree.html#google_vignette
            Utility.Choice();

            ConsoleKeyInfo input = ReadKey();


            Clear();

            if (input.Key == ConsoleKey.A)

            {
                Clear();
                currentHeading.AutumnHeading();
                //Utility.Spacing("You walk towards the glow.");
                Utility.Spacing("As you get closer you hear a loud whooshing coming from the direction you are headed.");
                Utility.Spacing("You continue, nervously now.");
                Utility.Spacing("Suddenly, the woods open up and you find yourself in a clearing.");
                Utility.Spacing("In the middle is a huge, swirling blue storm.");
                Utility.Spacing("You turn to run away from it, but it sucks you in.");
                Utility.Spacing("You fly into the blue storm, realizing as it tosses you about that it is some kind of portal.");
                Utility.Spacing("It spits you out in an unfamilar spot, however, you know you are still in the Autumn forest");
                Utility.Spacing("because the leaves are still shades of red, yellow and orange.");

                ReadKey();
                Clear();
                Utility.TopSpaces();
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

                Utility.MoveOn();


                Q3();

            }
            else if (input.Key == ConsoleKey.B)
            {
                Clear();
                currentHeading.AutumnHeading();
                Utility.Spacing("The path continues, becoming more and more covered in autumn leaves.");
                Utility.Spacing("Owls hoot in the distance and it reminds you of your friends.");
                Utility.Spacing("While it is only the start of your journey, loneliness starts to creep in.");
                Utility.Spacing("Up ahead you see fog crowding the path.");
                WriteLine(@"
                   
                                      v .   ._, |_  .,               v .   ._, |_  .,              
                                   `-._\/  .  \ /    |/_          `-._\/  .  \ /    |/_        
                                       \\  _\, y | \//                \\  _\, y | \//              
                                 _\_.___\\, \\/ -.\||           _\_.___\\, \\/ -.\||           
                                   `7-,--.`._||  / / ,            `7-,--.`._||  / / ,            
                                   /'     `-. `./ / |/_.'          /'     `-. `./ / |/_.'        
                                             |    |//     -----\            |    |//                    
                                             |_    /  __/       ---\        |_    /                       
                                             |-   | /                \      |-   |                         
                                             |   =|                   |____ |   =|                         
                                             |    |                         |    |                          
                        --------------------/ ,  . \--------.--------------/ ,  . \--------._-----              
                                        
");
                Utility.MoveOn();

                Q2();

            }

            else
            {
                currentHeading.AutumnHeading();
                Utility.Spacing("That is not an option. Press enter to return to the options.");
                ReadKey();
                Clear();
                Q1();
            }
        }

        public override void Q2()
        {
            Clear();
            currentHeading.AutumnHeading();
            Utility.Spacing("Finally, you reach the fog. You realize that it covers a giant swamp. ");
            Utility.Spacing("The entrace to a bridge is a few feet in front of you.");
            Utility.Spacing("You hear whimpering from the middle of the swamp- is it a friend?-");
            Utility.Spacing("and there is a stench coming from the edges of the swamp, it smells like rotting and death.");
            ForegroundColor = ConsoleColor.Cyan;
            Utility.Spacing("You have two choices: You can go around the edge of the swamp (A) or you can take the bridge across it (B).");

            ForegroundColor = ConsoleColor.Red;

            WriteLine(@"

                                                       _             _
                                                       ||           ||
                                            ___________||___________||______________
");
            ForegroundColor = ConsoleColor.Black;
            Utility.Choice();
            ForegroundColor = ConsoleColor.Red;

            ConsoleKeyInfo input = ReadKey();

            Clear();

            if (input.Key == ConsoleKey.A)
            {
                Clear();
                currentHeading.AutumnHeading();
                Utility.Spacing("You skirt around the edge of the swamp quickly- ");
                Utility.Spacing("even though it smells awful you sense that you have made the right choice.");
                Utility.MoveOn();

                Q3();
            }
            else if (input.Key == ConsoleKey.B)
            {
                Clear();
                //currentHeading.AutumnHeading();
                Utility.Spacing("You walk slowly to the center of the bridge.");
                Utility.Spacing("You are starting to think this was a bad idea.");
                Utility.Spacing("When you get to the center you see a giant crocodile standing in the middle of the bridge.");
                Utility.Spacing("It runs at you and chomps you before you can even scream.");

                WriteLine(@"
                                                 .--.  .--.
                                                /    \/    \
                                               | .-.  .-.   \
                                               |/_  |/_  |   \
                                               || `\|| `\|    `----.
                                               |\0_/ \0_/    --,    \_
                             .--""""""""""-.       /              (` \     `-.
                            /          \-----'-.              \          \
                            \  () ()                         /`\          \
                            |                         .___.-'   |          \
                            \                        /` \|      /           ;
                             `-.___             ___.' .-.`.---.|             \
                                \| ``-..___,.-'`\| / /   /     |              `\
                                 `      \|      ,`/ /   /   ,  /
                                         `      |\ /   /    |\/
                                          ,   .'`-;   '     \/
                                     ,    |\-'  .'   ,   .-'`
                                   .-|\--;`` .-'     |\.'
                                  ( `""'-.|\ (___,.--'`'   
                                   `-.    `""`          _.--'
                                      `.          _.-'`-.
                                        `''---''``  jgs  `.
");//https://www.asciiart.eu/animals/reptiles/alligators

                ReadKey();
                Utility.CheckDeath();


                ForegroundColor = ConsoleColor.Red;
                BackgroundColor = ConsoleColor.Yellow;
                Q3();

            }

            else
            {
                currentHeading.AutumnHeading();
                Utility.Spacing("That is not an option. Press enter to return to the options.");
                ReadKey();
                Clear();
                Q2();
            }
        }

        public override void Q3()
        {
            Clear();
            currentHeading.AutumnHeading();

            Utility.Spacing("You get to the next fork in the road-");
            Utility.Spacing("You can see a bit down both paths- the forward path leads to a pumpkin patch, ");
            Utility.Spacing("filled with pumpkins bigger than you have ever seen.");
            Utility.Spacing("The path to the left leads to a rundown shack, covered in dead leaves,");
            Utility.Spacing("with boards falling off the sides and rusting hinges on the shades and door.");
            Utility.Spacing("You're headed towards the pumpkins, when you notice footprints headed towards the shack.");
            Utility.Spacing("What if it's one of your friends?");

            ForegroundColor = ConsoleColor.Cyan;
            Utility.Spacing("Do you go into the pumpkin patch (A) or towards the shack (B)?");
            ForegroundColor = ConsoleColor.Red;

            WriteLine(@"

                         \\                \\                \\                       ____||____
                    .-'```^```'-.     .-'```^```'-.     .-'```^```'-.                ///////////\
                   /   /\ __ /\  \   /   (\ __ /)  \   /   /) __ (\  \              ///////////  \
                   |   ^^ \/ ^^  |   |    ` \/ `   |   |   ^  \/  ^  |              |    _    |  |
                   \   \_.__._/  /   \    \____/   /   \    `'=='`   /              |[] | | []|[]|
                    `'-.......-'`     `'-.......-'`     `'-.......-'` ldb           |   | |   |  |

");//pumpkins: https://ascii.co.uk/art/pumpkin House: https://www.asciiarthub.com/house.html


            ForegroundColor = ConsoleColor.White;
            BackgroundColor = ConsoleColor.Cyan;

            WriteLine("                                                     Enter you choice:                                                  ");
            ForegroundColor = ConsoleColor.Red;
            BackgroundColor = ConsoleColor.Yellow;

            ConsoleKeyInfo input = ReadKey();

            Clear();

            if (input.Key == ConsoleKey.A)
            {
                Clear();
                currentHeading.AutumnHeading();
                Utility.Spacing("As you turn away from the shack, you feel like you may be making the wrong choice.");
                Utility.Spacing("You walk through the pumpkin patch slowly.");
                Utility.Spacing("Each turn reveals another huge pumpkin, surrounded by various smaller fruits and vegetables growing in the field.");
                Utility.Spacing("It's eerie, mist swirling and crows circling overhead.");
                Utility.Spacing("Luckily, you see the end of the patch ahead, and a path leading back into the forest.");
                Utility.Spacing("You make your way to the forest, not looking back as you leave the pumpkin patch.");

                WriteLine(@"

                                                             /}
                                                      _,---~-LJ,-~-._
                                                   ,-^  '   '   '    ^:,
                                                  :   .    '      '     :
                                                 :     /| .   /\   '     :
                                                :   . //|    // \   '     :
                                                :     `~` /| `^~`    '     ;
                                                :  '     //|         '    :
                                                :   \-_  `~`    ,    '    :
                                                ;  . \.\_,--,_;^/   ,    :
                                                 :    ^-_!^!__/^   ,    :
                                                  :,  ,  .        ,    :   -ZEUS-
                                                    ^--_____     .   ;`
                                                            `^''----`
");//https://www.asciiart.eu/holiday-and-events/halloween
                Utility.MoveOn();

                RunQuestions runQuestions = new RunQuestions(player);
                Forest currentForest = new Forest("Autumn", player);
                currentForest.forestTransition();
                runQuestions.WinterQuestions();


            }
            else if (input.Key == ConsoleKey.B)
            {
                Clear();
                currentHeading.AutumnHeading();
                
                Utility.Spacing("You walk cautiously up to the shack.");
                Utility.Spacing("As nervous as you are, you feel hopeful that one of your friends might be stayng here.");
                Utility.Spacing("You open the door and peek inside.");
                Utility.Spacing("You look around and see a small bundle in the corner.");
                Utility.Spacing("You walk to it, and poke it.");
                ReadKey();
                Clear();


                Pet currentPet = new Pet(player);
                currentPet.PetGenerator1();

                currentPet.CheckPets();

                ReadKey();
                Clear();
                ForegroundColor = ConsoleColor.Red;
                BackgroundColor = ConsoleColor.Yellow;
                Clear();

                currentHeading.AutumnHeading();
                Utility.Spacing("You see the end of the patch ahead, and a path leading back into the forest.");
                Utility.Spacing("You make your way to the forest, away from the shack.");

                Utility.MoveOn();
                RunQuestions runQuestions = new RunQuestions(player);
                Forest currentForest = new Forest("Autumn", player);
                currentForest.forestTransition();
                runQuestions.WinterQuestions();
            }

            else
            {
                Clear();
                currentHeading.AutumnHeading();
                Utility.Spacing("That is not an option. Press enter to return to the options.");
                ReadKey();
                Clear();
                Q3();
            }
        }
        
    }
 }

