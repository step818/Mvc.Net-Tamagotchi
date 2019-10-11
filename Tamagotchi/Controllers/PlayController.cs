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
      List<Pet> allPets = Pet.GetAll();
      return View(allPets);
    }
    
    [HttpPost("/play")]
    public ActionResult Create(string name)
    {
      Pet newPet = new Pet(name);
      return RedirectToAction("Index");
    }
    [HttpPost("/play/delete")]
    public ActionResult DeleteAll()
    {
      Pet.ClearAll();
      return View();
    }
    [HttpPost("/play/feed")]
    public ActionResult Update(Pet allPets)
    {
      allPets.Feed();
      return RedirectToAction("Index");
    }
  }
}