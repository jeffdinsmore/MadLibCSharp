using MadLibs.Models;
using Microsoft.AspNetCore.Mvc;

namespace MadLibs.Controllers 
{
  public class HomeController : Controller 
  {

    [Route("/")]
    public ActionResult MadLibChoices() 
    {
      MadlibChoice myMadlibChoice = new MadlibChoice();
      myMadlibChoice.Cake = "cake";
      return View( myMadlibChoice);
    }
      
    [Route("/form")] //Defaults to form
    public ActionResult Form() { return View(); }

    [Route("/MadLibs")]
    public ActionResult MadLibs(string pluralNoun1, string pluralNoun2, string verb1, string noun1, string ingVerb, string pluralNoun3, string noun2, string pluralNoun4)
    {
      WordVariables myWordVariables = new WordVariables();
      myWordVariables.PluralNoun1 = pluralNoun1;
      myWordVariables.PluralNoun2 = pluralNoun2;
      myWordVariables.Verb1 = verb1;
      myWordVariables.Noun1 = noun1;
      myWordVariables.IngVerb = ingVerb;
      myWordVariables.PluralNoun3 = pluralNoun3;
      myWordVariables.Noun2 = noun2;
      myWordVariables.PluralNoun4 = pluralNoun4;

      return View(myWordVariables);
    }
  }
}
