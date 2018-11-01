using System;

public class Person
{
	public string Name { get; set; }
  public IUprightMammal HumansLimbs { get; set; }
	
  public Person(string n)
	{
		Name = n;
	}

	// public Person(string n, IUprightMammal humansLimbs)
	// {
	// 	Name = n;
  //   HumansLimbs = humansLimbs;
	// }
	
	public void shout()
	{
		Console.WriteLine("I'm {0} the Person and I can shout!", Name);
	}
}