using System;

public class Variables
{
	public string heroName;
	public string heroClass;
	
	public void Main()
	{
		Console.WriteLine("What would you like to be called?");
		heroName = Console.ReadLine();
		Console.WriteLine("Choose between Rogue, Cleric, Fighter, Paladin, Ranger, Wizard, Sorcerer, Warlock, or Artificer.  Type your answer."); 
		heroClass = Console.ReadLine();
		Console.WriteLine("Hello " + heroName + "! I've heard you are the greatest " + heroClass + " in the land! Will you join me on an adventure to avenge my fallen clan?");
		Console.ReadLine();
	}
}