using Nancy;
using System.Collections.Generic;
using RPSGenerator.Objects;

namespace RPSGenerator
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"]= _ => View["index.cshtml"];
      Post["/"]= _ => {
        string player1 = RPSClass.GetPlayer1();
        string player2 = Request.Form["player2"];
        RPSClass newRPS = new RPSClass(player1, player2);
        return View["index.cshtml", newRPS.GameResult()];
      };
      Post["/player2"] = _ => {
        RPSClass newRPS = new RPSClass(Request.Form["player1"], "");
        return View["player2.cshtml"];
      };

    }
  }
}
