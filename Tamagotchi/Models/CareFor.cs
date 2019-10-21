using System;
using System.Collections.Generic;
using System.Timers;

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
    private static Timer _timer;
    public Pet(string name)
    {
      Name = name;
      Hungry = 0;
      Tired = 0;
      Bored = 0;
      _instances.Add(this);
      Id = _instances.Count;

      if (_timer == null)
      {
        // Create a timer and set a 5 second interval
        _timer = new Timer(1000);
        // Hook up the Elapsed event for the timer
        _timer.Elapsed += OnTimedEvent;
        // Have the timer fire repeated events (true is the default)
        _timer.AutoReset = true;
        // Start the timer
        _timer.Enabled = true;
      }
    }
    private static void OnTimedEvent(Object source, ElapsedEventArgs e)
    {
      Console.WriteLine("The Elapsed event was raised at {0}", e.SignalTime);

      Time();
    }
    public static void Time()
    {
      foreach(Pet pet in _instances)
      {
        pet.Hungry = pet.Hungry + 1;
        pet.Tired = pet.Tired + 1;
        pet.Bored = pet.Bored + 1;
      }
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
      if(Hungry < 20)
      {
        if(Hungry <= 4)
        {
          return 0;
        }
        else
        {
          Hungry = Hungry - 5;
          return Hungry;
        }
      }
      else
      {
        return 0;
      }
    }
    public int Bedtime()
    {
      if(Tired < 20)
      {
        if(Tired <= 4)
        {
          return 0;
        }
        else
        {
          Tired = Tired - 5;
          return Tired;
        }
      }
      else
      {
        return 0;
      }
    }
    public int Kickball()
    {
      if(Bored < 20)
      {
        if(Bored <= 4)
        {
          return 0;
        }
        else
        {
          Bored = Bored - 5;
          return Bored;
        }
      }
      else
      {
        return 0;
      }   
    }
    public bool isStarving()
    {
      if(Hungry > 7 && Hungry < 20)
      {
          return true;
      }
      else
      {
        return false;
      }
    }
    public bool isExhausted()
    {
      if(Tired > 7 && Tired < 20)
      {
        return true;
      }
      else
      {
        return false;
      }
    }
    public bool isDepressed()
    {
      if(Bored > 7 && Bored < 20)
      {
        return true;
      }
      else
      {
        return false;
      }
    }
    public bool isDead()
    {
      if(Hungry >= 20)
      {
        return true;
      }
      else if(Tired >= 20)
      {
        return true;
      }
      else if(Bored >= 20)
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