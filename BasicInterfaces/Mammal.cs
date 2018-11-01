

public abstract class Mammal
{
  int ArmsCount { get; set; }
  int LegCount  { get; set; }
  public abstract void WaveArms();
  public abstract void KickLegs();

  public Mammal(int arms, int legs)
  {
    ArmsCount = arms;
    LegCount = legs;
  }
}