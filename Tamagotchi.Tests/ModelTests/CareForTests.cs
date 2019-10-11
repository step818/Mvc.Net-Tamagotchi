using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System;
using Tamagotchi.Models;

namespace Tamagotchi.Tests
{
  [TestClass]
  public class PetTest : IDisposable
  {
    public void Dispose()
    {
      Pet.ClearAll();
    }
    [TestMethod]
    public void Pet_MakeObject_Obj()
    {
      Pet newPet = new Pet("");
      int point = newPet.Hungry;
      Assert.AreEqual(0, point);
    }
    [TestMethod]
    public void isDead_DieofStarvation_True()
    {
      Pet newPet = new Pet("");
      newPet.Hungry = 100;
      bool result = newPet.isDead();
      Assert.AreEqual(true, result);
    }
    [TestMethod]
    public void Feed_GetANumber_Int()
    {
      Pet newPet = new Pet("");
      int once = newPet.Feed();
      int twice = newPet.Feed();
      Assert.AreEqual(2, twice);
    }
    [TestMethod]
    public void Pet_CreateName_Str()
    {
      Pet newPet = new Pet("Henry");
      string result = newPet.Name;
      Assert.AreEqual("Henry", result);
    }
    [TestMethod]
    public void Kickball_ChangeBored_Int()
    {
      Pet newPet = new Pet("");
      int once = newPet.Kickball();
      Assert.AreEqual(-1, once);
    }
    [TestMethod]
    public void GetId_PetId_Int()
    {
      string name = "Juno";
      Pet newPet = new Pet(name);
      int result = newPet.Id;
      Assert.AreEqual(1, result);
    }
    [TestMethod]
    public void Find_ReturnCorrectPets_Pet()
    {
      string name1 = "Albert";
      string name2 = "Ben";
      Pet newPet1 = new Pet(name1);
      Pet newPet2 = new Pet(name2);
      Pet result = Pet.Find(2);
      Assert.AreEqual(newPet2, result);
    }
  }
}