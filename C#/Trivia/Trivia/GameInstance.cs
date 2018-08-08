using System;
using UglyTrivia;

namespace Trivia
{
    public class GameInstance
    {
        private static bool notAWinner;

        public void RunGameSimulation(int? seed)
        {
            Game aGame = new Game();

            aGame.add("Chet");
            aGame.add("Pat");
            aGame.add("Sue");

            Random rand = seed.HasValue ? new Random(seed.Value) : new Random();

            do
            {
                aGame.roll(rand.Next(5) + 1);

                if (rand.Next(9) == 7)
                {
                    notAWinner = aGame.wrongAnswer();
                }
                else
                {
                    notAWinner = aGame.wasCorrectlyAnswered();
                }
            } while (notAWinner);
        }
    }
}
