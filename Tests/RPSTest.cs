using System;
using System.Collections.Generic;
using Xunit;
namespace RPSGenerator.Objects
{
  public class RPSClassTest
  {
    [Fact]
    public void GameResult_PaperVsPaper_true()
    {
      RPSClass newRPSClass = new RPSClass("Paper", "Paper");
      Assert.Equal("Tie Game", newRPSClass.GameResult());
    }

  }
}
