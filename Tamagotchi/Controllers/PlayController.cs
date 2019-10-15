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
    [HttpGet("/play/{id}")]
    public ActionResult Show(int id)
    {
      Pet foundPet = Pet.Find(id);
      return View(foundPet);
    }
    [HttpPost("/play/{id}/feed")]
    public ActionResult UpdateFood(int id)
    {
      Pet thisPet = Pet.Find(id);
      thisPet.Feed();
      return RedirectToAction("Show");
    }
    [HttpPost("/play/{id}/bedtime")]
    public ActionResult UpdateSleep(int id)
    {
      Pet thisPet = Pet.Find(id);
      thisPet.Bedtime();
      return RedirectToAction("Show");
    }
    [HttpPost("/play/{id}/kickball")]
    public ActionResult UpdatePlay(int id)
    {
      Pet thisPet = Pet.Find(id);
      thisPet.Kickball();
      return RedirectToAction("Show");
    }
    [HttpPost("/play/time")]
    public ActionResult UpdateTime(int id)
    {
      Pet thisPet = Pet.Find(id);
      Pet.Time();
      thisPet.Feed();
      thisPet.Bedtime();
      thisPet.Kickball();

      var model = DateTime.Now;

      return RedirectToAction("Show", model);
    }
  }
}