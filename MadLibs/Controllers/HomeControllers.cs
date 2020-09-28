using MadLibs.Models;
using Microsoft.AspNetCore.Mvc;

namespace MadLibs.Controllers 
{
public class HomeController : Controller 
{
  [Route("/")]
  public ActionResult Letter() 
  {
    LetterVariable myLetterVariable = new LetterVariable();
    myLetterVariable.Recipient = "Lima";
    myLetterVariable.Sender = "Jasmine";
    myLetterVariable.Location = "Paris";
    myLetterVariable.Souvenir = "Bracelet";
    return View( myLetterVariable);
    }
    
    [Route("/form")]
    public ActionResult Form() { return View(); }

    [Route("/postcard")]
    public ActionResult Postcard(string recipient, string sender, string location, string souvenir)
    {
      LetterVariable myLetterVariable = new LetterVariable();
      myLetterVariable.Recipient = recipient;
      myLetterVariable.Sender = sender;
      myLetterVariable.Location = location;
      myLetterVariable.Souvenir = souvenir;


      return View(myLetterVariable);
    }

  }
}
