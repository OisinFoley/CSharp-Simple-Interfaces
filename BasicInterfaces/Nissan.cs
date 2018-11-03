using System;

public class Nissan : Vehicle
{
  public override void Accelerate()
  {
    Console.WriteLine("Nissan is currently accelerating!");
  }

  public override void ActivateAirConditioning()
  {
    Console.WriteLine("Nissan is activating its air conditioning!");
  }

  public override void ActivateBrakeLight()
  {
    Console.WriteLine("Nissan has activated its brake lights!");
  }

  public override void Decelerate()
  {
    Console.WriteLine("Nissan is currently decelerating!");
  }
}