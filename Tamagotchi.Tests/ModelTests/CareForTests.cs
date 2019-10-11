using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tamagotchi.Models;

namespace Tamagotchi.Tests
{
  [TestClass]
  public class PetTest
  {
    [TestMethod]
    public void Pet_MakeObject_Obj()
    {
      Pet newPet = new Pet();
      int point = newPet.Hungry;
      Assert.AreEqual(0, point);
    }
    [TestMethod]
    public void isDead_DieofStarvation_True()
    {
      Pet newPet = new Pet();
      newPet.Hungry = 100;
      bool result = newPet.isDead();
      Assert.AreEqual(true, result);
    }
    [TestMethod]
    public void Kickball_GetANumber_Int()
    {
      Pet newPet = new Pet();
      int result = newPet.Kickball(1);
      Assert.AreEqual(-1, result);
    }
  }
}