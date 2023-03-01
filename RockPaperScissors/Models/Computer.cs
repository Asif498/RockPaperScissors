namespace RockPaperScissors.Models.Computer
{
    public class Computer
    {
        private string computerName="";
        private int computerChoice;
        private string computerMove = "";
        public string winner = "";

        public Computer(string compName)
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

        }

    }
}
