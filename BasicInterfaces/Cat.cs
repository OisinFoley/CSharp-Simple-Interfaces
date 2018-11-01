using System;

public class Cat: ICrawlable
{
	public string Name { get; set; }
	public string Sound { get; set; }
	
	public Cat(string name, string sound)
	{
		Name = name;
		Sound = sound;
	}

  public Cat(string name)
	{
		Name = name;
    Sound = "im a quiet introvert";
	}
	
	public void shout()
	{
		Console.WriteLine("I'm {0} the Cat and I can shout!", Name);
	}

  public void Crawl()
	{
		Console.WriteLine($"I'm {Name} the Cat, I make a {Sound} sound and I can shout!");
	}
}