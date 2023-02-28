namespace RockPaperScissors.Models.Computer
{
    public class Computer
    {
        private String computerName="";
        private int computerChoice;
        private String computerMove = "";
        public String winner = "";

        public Computer(String compName)
        {
            this.computerName = compName;
        }

        public string getComputerName()
        {
            return computerName;
        }

        public int getComputerChoice()
        {
            return computerChoice;
        }

        public string getComputerMove()
        {
            return computerMove;
        }

        public string getWinner()
        {
            return winner;
        }

        //method for computer to pick
        public void ComputerTurn(Computer computer)
        {
            Random random = new Random();
            int randomNo = random.Next(0, 3);
            Console.WriteLine("random number : " + randomNo);
            computer.computerChoice = randomNo;

            if (randomNo == 0)
            {
                computer.computerMove = "rock";
            }
            else if (randomNo == 1)
            {
                computer.computerMove = "paper";
            }
            else if (randomNo == 2)
            {
                computer.computerMove = "scissors";
            }

            //CheckWinner();
        }

        public void CheckWinner(Computer computer1, Computer computer2)
        {
            if ((computer1.computerChoice + 1) % 3 == computer2.computerChoice)
            {
                Console.WriteLine("Computer2 Wins");
                //loss++;
                winner = computer2.getComputerName();
                
            }
            else if (computer1.computerChoice == computer2.computerChoice)
            {
                Console.WriteLine("Draw");
                //draw++;
                winner = "Draw";
            }
            else
            {
                Console.WriteLine("Computer1 Wins");
                //win++;
                winner = computer1.getComputerName();
            }
        }

    }
}
