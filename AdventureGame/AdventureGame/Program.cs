/*"Forest Adventure"
 * by Una Roberts, 9/25/24
 *  
 *  Referenced 
 * "C# Adventure Game" by http://programmingisfun.com, used under CC BY.
 * https://creativecommons.org/licenses/by/4.0/
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

            Game currentGame = new Game();
            currentGame.startGame();
            currentGame.greetPlayer();
            currentGame.playGame();
        }
    }
}