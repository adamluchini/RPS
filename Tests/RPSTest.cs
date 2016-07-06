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

    [Fact]
    public void GameResult_PaperVsRock_true()
    {
      RPSClass newRPSClass = new RPSClass("Paper", "Rock");
      Assert.Equal("Player 1 Wins", newRPSClass.GameResult());
    }

    [Fact]
    public void GameResult_PaperVsScissors_true()
    {
      RPSClass newRPSClass = new RPSClass("Paper", "Scissors");
      Assert.Equal("Player 2 Wins", newRPSClass.GameResult());
    }

    [Fact]
    public void GameResult_RockVsRock_true()
    {
      RPSClass newRPSClass = new RPSClass("Rock", "Rock");
      Assert.Equal("Tie Game", newRPSClass.GameResult());
    }

    [Fact]
    public void GameResult_RockVsPaper_true()
    {
      RPSClass newRPSClass = new RPSClass("Rock", "Paper");
      Assert.Equal("Player 2 Wins", newRPSClass.GameResult());
    }

    [Fact]
    public void GameResult_RockVsScissors_true()
    {
      RPSClass newRPSClass = new RPSClass ("Rock", "Scissors");
      Assert.Equal("Player 1 Wins", newRPSClass.GameResult());
    }

    [Fact]
    public void GameResult_ScissorsVsScissors_true()
    {
      RPSClass newRPSClass = new RPSClass ("Scissors", "Scissors");
      Assert.Equal("Tie Game", newRPSClass.GameResult());
    }

    [Fact]
    public void GameResult_ScissorsVsPaper_true()
    {
      RPSClass newRPSClass = new RPSClass ("Scissors", "Paper");
      Assert.Equal("Player 1 Wins", newRPSClass.GameResult());
    }

    [Fact]
    public void GameResult_ScissorsVsRock_true()
    {
      RPSClass newRPSClass = new RPSClass ("Scissors", "Rock");
      Assert.Equal("Player 2 Wins", newRPSClass.GameResult());
    }

  }
}
