using Microsoft.AspNetCore.Mvc;
using Tamagotchi.Models;

namespace Tamagotchi.Controllers
{
  public class PlayController : Controller
  {
    [HttpGet("/play")]
    public ActionResult Index()
    {
      Pet newPet = new Pet();
      return View(newPet);
    }
    [HttpPost("/play/feed")]
    public ActionResult Feed()
    {
      newPet.Feed();
      return RedirectToAction("Index");
    }
    [HttpPost("/play/bedtime")]
    public ActionResult Bedtime()
    {
      newPet.Bedtime();
      return RedirectToAction("Index");
    }
    [HttpPost("/play/kickball")]
    public ActionResult Kickball()
    {
      newPet.Kickball();
      return RedirectToAction("Index");
    }
  }
}