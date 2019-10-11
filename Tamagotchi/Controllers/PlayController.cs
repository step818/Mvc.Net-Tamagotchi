using Microsoft.AspNetCore.Mvc;
using Tamagotchi.Models;
using System;
using System.Collections.Generic;

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
    public ActionResult Feed(Pet newPet)
    {
      newPet.Feed();
      Console.WriteLine(newPet.Hungry);
      return View("Index", newPet);
    }
  }
}