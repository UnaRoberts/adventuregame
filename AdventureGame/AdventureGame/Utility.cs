using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace AdventureGame
{
    public static class Utility
    {
        public static void MoveOn()
        {

            ReadKey();
            Clear();
        }

        public static void Choice()
        {
            WriteLine("");
            Utility.Spacing("Enter you choice: ");
        }

        public static void Spacing(string text)
        {
            // Logan ACT 
            int padding = (WindowWidth - text.Length) / 2;

            WriteLine(new string(' ', padding) + text);
        }


        public static void TopSpaces()
        {
            WriteLine("");
            WriteLine("");
            WriteLine("");
        }

        public static void centerHeading(string text)
        {
            int padding = (WindowWidth);
            WriteLine(new string(' ', padding) + text);
        }

        
        public static int deathcount;
       



        public static void CheckDeath()
        {
            Clear();
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

            Utility.Spacing("You died. Press enter to restart game");

            deathcount++;
            HandleDeath();
        }

        public static void HandleDeath()
        {
            if (deathcount == 1)
            {
                
                
                    Write(@"
                                                _   _         _   _        
                                              /   V   \     /   V   \    
                                              |       |     |       |     
                                               \     /       \     /      
                                                 \ /           \ /          
                                                  *             *            ");
                    ForegroundColor = ConsoleColor.Blue;
                    WriteLine(@"
                                                        _   _        
                                                      /   V   \    
                                                      |       |     
                                                       \     /       
                                                         \ /          
                                                          *  
");
                    ForegroundColor = ConsoleColor.Red;
                

                Utility.Spacing($"You have died {deathcount} time. You have 2 lives left.");
                ReadKey();
                //Utility.Spacing("An ominous source delivers you back to the start of the Autumn forest.");
            }

            else if (deathcount == 2)
            {
                Write(@"
                                    _   _        
                                  /   V   \    
                                  |       |     
                                   \     /       
                                     \ /          
                                      *            ");
                ForegroundColor = ConsoleColor.Blue;
                WriteLine(@" 
                            _   _         _   _        
                          /   V   \     /   V   \    
                          |       |     |       |     
                           \     /       \     /      
                             \ /           \ /          
                              *             *  ");
                ForegroundColor = ConsoleColor.Red;
                Utility.Spacing($"You have died {deathcount} times. You have 1 lives left.");
                ReadKey();
                //Utility.Spacing("An ominous source delivers you back to the start of the Autumn forest.");
                //deathcount = 3;
            }

            else if (deathcount == 3)
            {
               
                    ForegroundColor = ConsoleColor.Blue;
                    WriteLine(@"
                                    _   _         _   _         _   _         
                                  /   V   \     /   V   \     /   V   \     
                                  |       |     |       |     |       |    
                                   \     /       \     /       \     /      
                                     \ /           \ /           \ /          
                                      *             *             *             ");

                    ForegroundColor = ConsoleColor.Red;
                
                Utility.Spacing("You are out of lives! Press enter to exit game.");
                Utility.Spacing($"You have died {deathcount} times. You have 0 lives left.");
                ReadKey();//idk how to finish thissss
                Environment.Exit(0);
            }
        }
    }
}
