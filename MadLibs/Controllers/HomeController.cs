using Microsoft.AspNetCore.Mvc;
using MadLibs.Models;

namespace MadLibs.Controllers
{
  public class HomeController : Controller
  {
    //root path: "/"
    [Route("/")]
    public ActionResult Form() { return View(); }

    [Route("/story")]
    public ActionResult Story(string name, string ad, string thing, string verb, string adverb, string noun, int number)
    {
      LibVariable myLibVariable = new LibVariable();
      myLibVariable.Name = name;
      myLibVariable.AD = ad;
      myLibVariable.Thing = thing;
      myLibVariable.Verb = verb;
      myLibVariable.Adverb = adverb;
      myLibVariable.Noun = noun;
      myLibVariable.Number = number;
      return View(myLibVariable);
    }
  }
}