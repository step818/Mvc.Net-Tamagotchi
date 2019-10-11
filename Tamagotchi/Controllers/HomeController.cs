using Microsoft.AspNetCore.Mvc;
using Tamagotchi.Models;

namespace Tamagotchi.Controllers
{
  public class HomeController : Controller
  {
    [HttpGet("/")]
    public ActionResult Index()
    {
      return View();
    }
    // I'll have a Home page
    // The user clicks start and that enables pet to be created, time to start
    // and feed, pet, and sleep buttons to show
    // Maybe have an end button, Quit, takes you back to Homepage 
  }
}