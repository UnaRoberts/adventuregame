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
            //Console.Beep();
            //Console.SetWindowSize(100, 40);

            Game currentGame = new Game();

            currentGame.startGame();
            currentGame.greetPlayer();
            currentGame.playGame();
            currentGame.endGame();

        }

    }
}

/* TO DO (fromm tutoring)
 * add readkeys in the long paragraphs 
 * make a better final screen w house 
 * create an avatar (?)
 * make animals have charcter 
 * 
 * consider making the dying class a static one frm utility 
 * 
 * Tutoring questions:
 * how to increment deaths
 * how do I make the dying class end end at 3 deaths 
 * how to make game end at 3 pets
 * change the individual letters (A and B) to be a different color - idk How to do this
 * how to make heading NOT repeat
 * does this way Im working the pets right now work or should I increment it
 * */