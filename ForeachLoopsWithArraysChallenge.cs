using System;
					
public class Program
{

	public static void Main(string[] args)
	{
	string[,] superheroes = {{"Iron Man", "Smartest"}, {"Hulk", "Strongest"}, {"Captain America", "Leader"}, {"Black Widow", "Sneakiest"}, {"Hawkeye", "Sharpest"}, {"Thor", "Oldest"}};
	foreach(string i in superheroes)
		{
			Console.WriteLine(i);
		}
	}
}