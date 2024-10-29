using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using AdventureGame;
using TriviaGame;
using static System.Console;

namespace AdventureGame
{
}
    public class Player
    {
    
        public string Name;
        public static int deathcount;
    Art currentArt = new Art();

    //if correction is needed: 
    public List<string> Inventory;

    public void AddItem(string item)
    { Inventory.Add(item); }
        public Player(string name)
        {
            Name = name;
            //player.Name is how you access the name 
        }



//        public void CheckDeath()
//        {
//            ForegroundColor = ConsoleColor.Red;
//            BackgroundColor = ConsoleColor.Black;
//            Clear();

//            Console.Beep();//credit

//            WriteLine(@"

//                                              |\      _,,,---,,_
//                                              /,`.-'`'    -.  ;-;;,_
//                                             |,4-  ) )-,_. ,\ (  `'-'
//                                            '---''(_/--'  `-'\_)  Felix Lee 

//");//https://www.asciiart.eu/animals/cats (slightly edited for my purposes)

//            Utility.Spacing("You died. Press enter to restart game");
           
//            deathcount++;
//            HandleDeath();
//        }

//             void HandleDeath()
//            {
//                if (deathcount == 1)
//                {
//                    currentArt.TwoHearts();

//                    Utility.Spacing($"You have died {deathcount} time. You have 2 lives left.");
//                    ReadKey();  
//                //Utility.Spacing("An ominous source delivers you back to the start of the Autumn forest.");
//                }

//                else if (deathcount == 2)
//                {
//                    currentArt.OneHeart();
//                    Utility.Spacing($"You have died {deathcount} times. You have 1 lives left.");
//                    ReadKey();
//            //Utility.Spacing("An ominous source delivers you back to the start of the Autumn forest.");
//            //deathcount = 3;
//        }

//                else if (deathcount == 3)
//                {
//                currentArt.ThreeHearts();
//                Utility.Spacing("You are out of lives! Press enter to exit game.");
//                    Utility.Spacing($"You have died {deathcount} times. You have 0 lives left.");
//                    ReadKey();//idk how to finish thissss
//                    Environment.Exit(0);
//                }
//            }
        










            //ReadKey();
        //Question dyingQuestion = new Question();
        //dyingQuestion.AutumnQuestions();

       
        //game.whenYouDie();

        //    Forest currentForest = new Forest("Autumn");
        //    //currentForest.StartForest();
        //    currentForest.returnToForestColors();
        //    Question dyingQuestion = new Question();
        //    dyingQuestion.AutumnQuestions();
        //dyingQuestion.WinterQuestions();
        //dyingQuestion.SpringQuestions();
        //dyingQuestion.SummerQuestions();
    }
    


    
