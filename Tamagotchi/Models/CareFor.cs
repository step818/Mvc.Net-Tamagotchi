using System;
using System.Collections.Generic;

namespace Tamagotchi.Models
{
  public class Pet
  {
    public string Name { get;set; }
    public int Hungry { get;set; }
    public int Tired { get;set; }
    public int Bored { get;set; }
    public int Id { get; }
    private static List<Pet> _instances = new List<Pet> {};
    public Pet(string name)
    {
      Name = name;
      Hungry = 0;
      Tired = 0;
      Bored = 0;
      _instances.Add(this);
      Id = _instances.Count;
    }
    public static List<Pet> GetAll()
    {
      return _instances;
    }
    public static void ClearAll()
    {
      _instances.Clear();
    }
    public static Pet Find(int searchId)
    {
      return _instances[searchId-1];
    }
    public int Feed()
    {
      if(Hungry != 100)
      {
        Hungry = Hungry + 1;
        return Hungry;
      }
      else
      {
        return 0;
      }
    }
    public int Bedtime()
    {
      if(Tired < 100)
      {
        Tired = Tired + 1;
        return Tired;
      }
      else
      {
        return 0;
      }
    }
    public int Kickball()
    {
      if(Bored < 100)
      {
        Bored = Bored + 1;
        return Bored;
      }
      else
      {
        return 0;
      }
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