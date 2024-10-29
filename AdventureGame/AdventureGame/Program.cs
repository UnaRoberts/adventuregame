/*
 * [Forest Adventure]
 * by Una Roberts, 9/25/24
 *  
 * This work is a derivative of 
 * "C# Adventure Game" by http://programmingisfun.com, used under CC BY.
 * https://creativecommons.org/licenses/by/4.0/
 * "[Your Game Title]" is licensed under
 * [license] by [Your name here].
 */



using TriviaGame;
using static System.Console;

namespace AdventureGame
{
    class Program
    {
        static void Main()
        {
            Title = "Una's Forest Adventure";

            WriteLine("Hellow World");


            Game currentGame = new Game();

            currentGame.startGame();
            currentGame.greetPlayer();
            currentGame.playGame();


        }

    }
}

/* TO DO 
 * need to store pets in inventory so that you can display them at the end (try bools)
 * 
 *(fix headers)

 * make sure end game is right and done
 * add credits in comments 
 * 
 * can i track name to pets ending
 
 *dont let name = empty 
 *
 *
 *
 *
 *
 *
 *
 *
 *
 *
 *
 *
 *
 *
 *
 *
 *
 *
 *
 *
 *
 * NOTES:
 * need to fix the deaths (you added new instances of player so its gonna be wrong )
 * now after you die, it move you to the next question- i can fix this but the going back to the startwas unpopular 
  */