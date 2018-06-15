using System;
using Xunit;

namespace Bowling
{
    public class BowlingUnitTests
    {
        [Fact]
        public void RollStrike()
        {
            Game game = new Game();
            game.Roll(10);
            Assert.Equal(10, game.Score);
        }
    }
}