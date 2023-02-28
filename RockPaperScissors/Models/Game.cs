namespace RockPaperScissors.Models.Game
{
    public class Game
    {
        private int win;
        private int draw;
        private int loss;
        public String winner = "";
        public String text = "Game Not Started";

        public Game(String winner) 
        {
            this.text = winner;
        }

        public String GetWinner()
        {
            return winner;
        }

        public int GetWins()
        {
            return win;
        }
        public int GetDraws()
        {
            return draw;
        }
        public int GetLosses()
        {
            return loss;
        }

        public String CheckWinner(int player1, int player2)
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
    }
}
