using Microsoft.AspNetCore.Mvc;
using MadLibs.Models;

namespace MadLibs.Controllers
{
  public class HomeController : Controller
  {
    //root path: "/"
    [Route("/")]
    public ActionResult Story() {
      LibVariable myLibVariable = new LibVariable();
      myLibVariable.Name = "Lina";
      myLibVariable.AdventurerDescriptor = "Jasmine";
      myLibVariable.Thing = "Tortuga";
      return View(myLibVariable);
    }
    [Route("/form")]
    public ActionResult Form() { return View(); }
    [Route("/story")]
    public ActionResult Story(string name, string adventurerDescriptor, string thing)
    {
      LibVariable myLibVariable = new LibVariable();
      myLibVariable.Name = name;
      myLibVariable.AdventurerDescriptor = adventurerDescriptor;
      myLibVariable.Thing = location;
      return View(myLibVariable);
    }
  }
}