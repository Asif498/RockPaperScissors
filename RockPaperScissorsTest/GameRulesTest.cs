using Bunit;
using RockPaperScissors.Models.Game;

namespace RockPaperScissorsTest
{
    public class GameRulesTest
    {
        //public GameRulesTest()
        //{
        //    Game RockScissors = new Game("Test");
        //    RockScissors.CheckWinner(0, 2);
        //    Game PaperRock = new Game("Test");
        //    PaperRock.CheckWinner(1,0);
        //    Game ScissorsPaper = new Game("Test");
        //    ScissorsPaper.CheckWinner(2,1);
        //}

        [Fact]
        public void RockBeatsScissors()
        {
            String expected = "player1";
            Game RockScissors = new Game("Test");
            String actual = RockScissors.CheckWinner("player1", "computer1", 0, 2);

            Assert.Equal(actual, expected);

        }

        [Fact]
        public void PaperBeatsRock()
        {
            String expected = "player1";
            Game PaperRock = new Game("Test");
            String actual = PaperRock.CheckWinner("player1", "computer1", 1, 0);

            Assert.Equal(actual, expected);
        }

        [Fact]
        public void ScissorsBeatsPaper()
        {
            String expected = "player1";
            Game ScissorsPaper = new Game("Test");
            String actual = ScissorsPaper.CheckWinner("player1", "computer1", 2, 1);

            Assert.Equal(actual, expected);
        }
    }
}