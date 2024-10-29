using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using TriviaGame;
using static System.Console;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace AdventureGame
{
    internal class Question
    {
        string input = "";
        int totalPets = 0;
       // Game currentGame = new Game();
        Headings currentHeading = new Headings();
        Player player;
        public int deathcount;
        public Question(Player player)
        {
            player = player;
        }

        public void AutumnQuestions()
        {


            void Autumnq1()
            {
                Clear();
                currentHeading.AutumnHeading();


                Utility.Spacing("Sunlight spills into the forest but it gets darker the further in you walk.");
              

                Utility.Spacing("You have just arrived at the first fork in the road- to the right there is a blue glow among the leaves");
                Utility.Spacing("and to the left it continues to get darker.");
                ForegroundColor = ConsoleColor.Cyan;

                /// console writleine "sentence is a 
                /// color blue
                /// console write "sentence
                /// color white
                /// console write "rest of the sentance
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
                   

                    Autumnq3();

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

                    Autumnq2();

                }

                else
                {
                    currentHeading.AutumnHeading();
                    Utility.Spacing("That is not an option. Press enter to return to the options.");
                    ReadKey();
                    Clear();
                    Autumnq1();
                }

            }
            void Autumnq2()
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

                    Autumnq3();


                    //write a good continuation here too 
                }
                else if (input.Key == ConsoleKey.B)
                {
                    Clear();
                    currentHeading.AutumnHeading();
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

                    Utility.CheckDeath(); 
                   
                   
                    ForegroundColor = ConsoleColor.Red;
                    BackgroundColor = ConsoleColor.Yellow;
                    Autumnq3();
                   
                }

                else
                {
                    currentHeading.AutumnHeading();
                    Utility.Spacing("That is not an option. Press enter to return to the options.");
                    ReadKey();
                    Clear();
                    Autumnq2();
                }

            }
            void Autumnq3()
            {
                // AUTUMN Q3
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

                    //Utility.MoveOn();  dont have this at the last question of the season
                    ReadKey();
                    Clear();

                }
                else if (input.Key == ConsoleKey.B)
                {
                    Clear();
                    currentHeading.AutumnHeading();
                    Utility.Spacing("As you turn away from the shack, you feel like you may be making the wrong choice.");
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

                    ReadKey(); //used to advance and fix console color
                    Clear();
                    ForegroundColor = ConsoleColor.Red;
                    BackgroundColor = ConsoleColor.Yellow;
                    Clear();

                    currentHeading.AutumnHeading();
                    Utility.Spacing("You see the end of the patch ahead, and a path leading back into the forest.");
                    Utility.Spacing("You make your way to the forest, away from the shack.");

                }

                else
                {
                    Clear();
                    currentHeading.AutumnHeading();
                    Utility.Spacing("That is not an option. Press enter to return to the options.");
                    ReadKey();
                    Clear();
                    Autumnq3();
                }
            }
            Autumnq1();
           
        }

        public void WinterQuestions()
        {
            void Winterq1()
            {

                Clear();
                currentHeading.WinterHeading();
                Utility.Spacing("As you walk through the freezing cold, you hear happy shouts up ahead.");    //describe animals better so owl sounds natural
                Utility.Spacing("When you get to the gathering you see a group of forest animals riding wooden sleds down a massive sledding hill.");
                Utility.Spacing("As you run towards it an owl swoops down towards you.");
                Utility.Spacing("As it swoops by, you think you hear it say 'careful - you wouldnt want to get hurt now would you...'");
                Utility.Spacing("It stops you in your tracks. You did not consider the danger of the huge, icy hill.");
                Utility.Spacing("You look look close at the hill and you see a set of stairs running the whole way down the hill.");
                ForegroundColor = ConsoleColor.Cyan;
                Utility.Spacing("You can either take the risk and ride a sled down the hill (A), or start the tedious trek down the stairs (B).");
                ForegroundColor = ConsoleColor.DarkBlue;



//                WriteLine(@"


//                                            ,sdPBbs.
//                                          ,d$$$$$$$$b.
//                                         d$P'`Y'`Y'`?$b
//                                        d'    `  '  \ `b
//                                       /    |        \  \
//                                      /    / \       |   \
//                                 _,--'        |      \    |
//                               /' _/          \   |        \
//                            _/' /'             |   \        `-.__
//                        __/'       ,-'    /    |    |     \      `--...__
//                      /'          /      |    / \     \     `-.           `\
//                     /    /;;,,__-'      /   /    \            \            `-.
//                    /    |;;;;;;;\                                             \

//");
                
//                //https://ascii.co.uk/art/mountain#google_vignette
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

                    Winterq2();
                    
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
                    Winterq2();

                }

                else
                {
                    
                    currentHeading.WinterHeading();
                    Utility.Spacing("That is not an option. Press enter to return to the options.");
                    ReadKey();
                    Clear();
                    Winterq1();


                }

            }
            void Winterq2()
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
                    Winterq3();

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
                    //Clear();
                    //portal
                }

                else
                {
                    Clear();
                    currentHeading.WinterHeading();
                    Utility.Spacing("That is not an option. Press enter to return to the options.");

                    ReadKey();
                    Clear();
                    Winterq2();

                }

                // Clear();

            }
            void Winterq3()
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
                   // Clear();



                   


                  
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


                    
                }

                else
                {
                   
                    currentHeading.WinterHeading();
                    Utility.Spacing("That is not an option. Press enter to return to the options.");
                    ReadKey();
                    Clear();
                    Winterq3();

                }

            }

            Winterq1();

        }

        public void SpringQuestions()
        {
            void Springq1()
            {
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


                    ReadKey(); //used to advance and fix console color
                    Clear();
                    ForegroundColor = ConsoleColor.White;
                    BackgroundColor = ConsoleColor.DarkGreen;
                    Clear();

                    //Utility.MoveOn();

                    Springq2();

                    
                }
                else if (input.Key == ConsoleKey.B)
                {
                    Clear();
                    currentHeading.SpringHeading();

                    Utility.Spacing("You continue on the path, away from the waterfall.");
                    Utility.Spacing("For some reason you can't shake the feeling that you picked wrong...");

                    Utility.MoveOn();

                    Springq2();
                }

                else
                {
                    Clear();
                    currentHeading.SpringHeading();
                    Utility.Spacing("That is not an option. Press enter to return to the options.");
                    ReadKey();
                    Clear();
                    Springq1();



                }

            }
            void Springq2()
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

//                ReadKey();
//                Clear();
//                WriteLine(@"

//                                              &&& &&  & &&                       &&& &&  & &&
//                                          && &\/&\|& ()|/ @, &&              && &\/&\|& ()|/ @, &&             
//                                          &\/(/&/&||/& /_/)_&/_&             &\/(/&/&||/& /_/)_&/_&
//                                       &() &\/&|()|/&\/ '%"" & ()         &() &\/&|()|/&\/ '%"" & ()
//                                      &_\_&&_\ |& |&&/&__%_/_& &&        &_\_&&_\ |& |&&/&__%_/_& &&
//                                    &&   && & &| &| /& & % ()& /&&      &&   && & &| &| /& & % ()& /&&
//                                     ()&_---()&\&\|&&-&&--%---()~         ()&_---()&\&\|&&-&&--%---()~
//                                         &&     \|||                          &&     \|||
//                                                 |||                                  |||
//                                                 |||                                  |||
//                                                 |||                                  |||
//                                           , -=-~  .-^- _                       , -=-~  .-^- _


//");//https://www.asciiarthub.com/tree.html


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

                    Springq3();
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

                   
                    //ForegroundColor = ConsoleColor.Red;
                    //skips to summer
                }

                else
                {
                    Clear();
                    currentHeading.SpringHeading();
                    Utility.Spacing("That is not an option. Press enter to return to the options.");
                    ReadKey();
                    Springq2();

                }



            }
            void Springq3()
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
                    Clear();
                    currentHeading.SpringHeading();
                    Utility.Spacing("You walk down the path.");
                    Utility.Spacing("You shiver as you walk away, and you know that was the right choice.");

                }
                else if (input.Key == ConsoleKey.B)
                {
                    Clear();
                    //currentHeading.SpringHeading();
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

                }

                else
                {
                    Clear();
                    currentHeading.SpringHeading();
                    Utility.Spacing("That is not an option. Press enter to return to the options.");
                    ReadKey();
                    Clear();
                    Springq3();

                }
            }
            Springq1();
        }

        
        public void SummerQuestions()
        {
            void Summerq1()
            {
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

                    //THIS IS HOW YOU RESET COLOR AFTER PETS
                    ReadKey(); 
                    Clear();

                    ForegroundColor = ConsoleColor.Green;
                    BackgroundColor = ConsoleColor.Yellow;
                    Clear();
                    Utility.MoveOn();

                    Summerq2();
                }
                else if (input.Key == ConsoleKey.B)
                {
                    currentHeading.SummerHeading();
                    Utility.Spacing("You continue on the path.");
                    Utility.Spacing("As you keep walking, you get the feeling that you made the wrong choice.");


                    Utility.MoveOn();

                    Summerq2();
                }

                else
                {
                    currentHeading.SummerHeading();
                    Utility.Spacing("That is not an option. Press enter to return to the options.");
                    ReadKey();
                    Clear();
                    Summerq1();

                }



            }
            void Summerq2()
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
                    //Clear();
                    Summerq3();


                }
                else if (input.Key == ConsoleKey.B)
                {
                    currentHeading.SummerHeading();
                    Utility.Spacing("Once you have your lemonade and cookies, you thank the squirrels and continue on.");
                    Utility.Spacing("As you walk, you're grateful that you got cookies- you think otherwise you might have starved to death.");

                    Utility.MoveOn();

                    Summerq3();
                }

                else
                {
                    currentHeading.SummerHeading();
                    Utility.Spacing("That is not an option. Press enter to return to the options.");
                    ReadKey();
                    Clear();
                    Summerq2();

                }

            }
            void Summerq3()
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
                    currentHeading.SummerHeading();
                    Utility.Spacing("You walk down the right path.");
                    Utility.Spacing("You see your's and your friends cottage ahead.");
                    Utility.Spacing("When you look back at the path, you realize that the left and right path both converge at the cottage.");

                    Utility.MoveOn();


                }
                else if (input.Key == ConsoleKey.B)
                {
                    currentHeading.SummerHeading();
                    Utility.Spacing("You walk down the left path.");
                    Utility.Spacing("You see your's and your friends cottage ahead.");
                    Utility.Spacing("When you look back at the path, you realize that the left and right path both converge at the cottage.");
                    Pet currentPet = new Pet(player);
                    currentPet.CheckPets();
                    //Utility.MoveOn();

                }

                else
                {
                    currentHeading.SummerHeading();
                    Utility.Spacing("That is not an option. Press enter to return to the options.");
                    ReadKey();
                    Clear();
                    Summerq3();

                }

            }

            Summerq1();

            
           // endGame.EndingSequence();


            //            ForegroundColor = ConsoleColor.Yellow;
            //            BackgroundColor = ConsoleColor.Blue;
            //            Clear();
            //            Utility.TopSpaces();

            //            endGame.EndingSequence();

            //            Utility.Spacing($"Congratulations {player.Name}! You have successfully made it home!");
            //            WriteLine(@"

            //                                                                 8o88o          __
            //                                                               o88o           o688o)
            //                                         '-,    .``'.          _o8o    .-.'-.(6886898o
            //                                            \,'`   . \.  .----| |-.  ,'     o688868698o)
            //                                           .'  /   :   '/          \'  \  (68968886)6/88o
            //                                          /   '    '   /____________\   '.  866\88|889)
            //                                         /    .    \   | ___   __   | .'  `   (969/9\
            //                                         `           _ ||_|_| /  \  |______     \//  \
            //                                        '.`""'.`,`'./_\||_|_| | .|  |______\.`.`||,`,'
            //                                        `'^,_`'. ,""|O||______|  |__|======|,.',|| ,..
            //                                        .'`. ""\'^,`.,'.`'``.'/==\.,.'`,.' `,' .||.,.`
            //                                        `',`' `,'.^ '. ,.'`,/====\,' `,. ^, `.-',, `,
            //                                        .,`^  `. `,`  ,  ,`/======\,  ,'  `'.,""  .DR.
            //                                        Dariusz Ruman
            //");

            //            Utility.Spacing("However, you did not find all of your friends. You are so lonely without all of them...");
            //            Utility.Spacing("If you want to find them, you can return to the start of the forest.");
            //            Utility.Spacing("Press A to return to the forest, and B to end the game.");

            //            ConsoleKeyInfo input = ReadKey();

            //            if (input.Key == ConsoleKey.A)
            //            {

            //                Clear();
            //                ForegroundColor = ConsoleColor.White;
            //                BackgroundColor = ConsoleColor.Cyan;
            //                Clear();
            //                Utility.TopSpaces();
            //                Utility.Spacing("Try making choices you have not yet tried- and pay close attention to the questions highlighted in this blue color.");
            //                ReadKey();
            //                Clear();
            //                //Question dyingQuestion = new Question();
            //                //dyingQuestion.AutumnQuestions();

            //                Forest currentForest = new Forest("Autumn");
            //                //currentForest.StartForest();
            //                currentForest.returnToForestColors();
            //                Question dyingQuestion = new Question();
            //                dyingQuestion.AutumnQuestions();
            //                dyingQuestion.WinterQuestions();
            //                dyingQuestion.SpringQuestions();
            //                dyingQuestion.SummerQuestions();




            //            }

            //            else if (input.Key == ConsoleKey.B)
            //            { 

            //            Environment.Exit(0); 
            //                                 //print cottage at end (not in question, but as big finale scene )

            //        }
            //        }
            //    }

        }
    }
}






