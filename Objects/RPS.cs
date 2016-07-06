using System;
using System.Collections.Generic;
namespace RPSGenerator.Objects
{
  public class RPSClass
  {
    private static string _player1;
    private string _player2;

    public RPSClass (string player1, string player2)
    {
      _player1 = player1;
      _player2 = player2;
    }
    public static string GetPlayer1()
    {
      return _player1;
    }

    public string GetPlayer2()
    {
      return _player2;
    }
    public void SetPlayer2(string player2)
    {
      _player2 = player2;
    }

    public string GameResult()
    {
      if (_player1 == this.GetPlayer2())
      {
        return "Tie Game";
      }
      else
      {
        return "Someone Won";
      }
    }
  }
}