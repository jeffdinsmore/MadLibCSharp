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
    [Route("/DisneyForm")] //Defaults to form
    public ActionResult DisneyForm() { return View(); }
    
    [Route("/DisneyMadLib")]
    public ActionResult DisneyMadlib(string friendsName1, string numberOfHours, string vehicle, string adjective1, string adjective2, string ingVerb, string animal, string adjective3, string pastTenseVerb1, string adjective4, string noun1, string friendsName2, string pastTenseVerb2, string pastTenseVerb3, string place, string verb1)
    {
      DisneyWordVariables myDisneyWordVariables = new DisneyWordVariables();
      myDisneyWordVariables.FriendsName1 = friendsName1;
      myDisneyWordVariables.NumberOfHours = numberOfHours;
      myDisneyWordVariables.Vehicle = vehicle;
      myDisneyWordVariables.Adjective1 = adjective1;
      myDisneyWordVariables.Adjective2 = adjective2;
      myDisneyWordVariables.IngVerb = ingVerb;
      myDisneyWordVariables.Animal = animal;
      myDisneyWordVariables.Adjective3 = adjective3;
      myDisneyWordVariables.PastTenseVerb1 = pastTenseVerb1;
      myDisneyWordVariables.Adjective4 = adjective4;
      myDisneyWordVariables.Noun1 = noun1;
      myDisneyWordVariables.FriendsName2 = friendsName2;
      myDisneyWordVariables.PastTenseVerb2 = pastTenseVerb2;
      myDisneyWordVariables.PastTenseVerb3 = pastTenseVerb3;
      myDisneyWordVariables.Place = place;
      myDisneyWordVariables.Verb1 = verb1;

      return View(myDisneyWordVariables);
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
