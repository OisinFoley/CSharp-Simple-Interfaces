using System;

public class Mammal: IUprightMammal
{
  public int ArmsCount { get; set; }
  public int LegCount  { get; set; }

  public void WaveArms()
  {
    Console.WriteLine($"I'm a {this.GetType()} over here waving my arms!");
  }
  public void KickLegs()
  {
    Console.WriteLine($"I'm a {this.GetType()} over here kicking my legs!");
  }

  public Mammal(int arms, int legs)
  {
    ArmsCount = arms;
    LegCount = legs;
  }
}