using System;

public class Ant: ICrawlable
{
	public string Name { get; set; }
	public string Sound { get; set; }
	
	public Ant(string name, string sound)
	{
		Name = name;
		Sound = sound;
	}

  public Ant(string name)
	{
		Name = name;
    Sound = "im a quiet introvert";
	}
	
	public void shout()
	{
		Console.WriteLine("I'm {0} the Ant and I can shout!", Name);
	}

  public void Crawl()
	{
		Console.WriteLine($"I'm {Name} the Ant, I make a {Sound} sound and I can shout!");
	}
}