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
    public int Feed(int food)
    {
      Food = -food;
      return Food;
    }
    public int Bedtime(int sleep)
    {
      Sleep = -sleep;
      return Sleep;
    }
    public int Kickball(int play)
    {
      Play = -play;
      return Play;
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