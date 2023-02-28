namespace RockPaperScissors.Models.Game
{
    public class Game
    {
        //private int win;
        //private int draw;
        //private int loss;
        public string winner = "";
        public string gameState = "";

        public Game(string GameState) 
        {
            this.gameState = GameState;
        }

        public string GetWinner()
        {
            return winner;
        }

        //public int GetWins()
        //{
        //    return win;
        //}
        //public int GetDraws()
        //{
        //    return draw;
        //}
        //public int GetLosses()
        //{
        //    return loss;
        //}

        public string CheckWinner(int player1, int player2)
        {
            if ((player1 + 1) % 3 == player2)
            {
                Console.WriteLine("Computer2 Wins");
                loss++;
                winner = "computer2";
                return winner;
            }
            else if (player1 == player2)
            {
                Console.WriteLine("Draw");
                draw++;
                winner = "Draw";
                return winner;
            }
            else
            {
                Console.WriteLine("Computer1 Wins");
                win++;
                winner = "computer1";
                return winner;
            }
        }

        public string CheckWinner(string player1, string player2, int player1choice, int player2choice)
        {
            if ((player1choice + 1) % 3 == player2choice)
            {
                Console.WriteLine("Computer2 Wins");
                loss++;
                winner = player2;
                return winner;
            }
            else if (player1choice == player2choice)
            {
                Console.WriteLine("Draw");
                draw++;
                winner = "Draw";
                return winner;
            }
            else
            {
                Console.WriteLine("Computer1 Wins");
                win++;
                winner = player1;
                return winner;
            }
        }
    }
}
