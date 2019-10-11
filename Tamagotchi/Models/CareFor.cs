using System;

namespace Tamagotchi.Models
{
  public class Pet
  {
    public int Hungry { get;set; }
    public int Tired { get;set; }
    public int Bored { get;set; }
    public int Food { get;set; }
    public int Sleep { get;set; }
    public int Play { get;set; }
    public Pet()
    {
      Hungry = 0;
      Tired = 0;
      Bored = 0;
    }
    public int Feed()
    {
      Hungry = Hungry + 1;
      return Hungry;
    }
    public int Bedtime()
    {
      return Tired--;
    }
    public int Kickball()
    {
      return Bored--;
    }
    public bool isDead()
    {
      if(Hungry == 100)
      {
        return true;
      }
      else if(Tired == 100)
      {
        return true;
      }
      else if(Bored == 100)
      {
        return true;
      }
      else
      {
        return false;
      }
    }

  }
}