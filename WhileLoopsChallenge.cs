using System;
					
public class Program
{
	public static void Main(string[] args)
	{
		int day = 1;
		int daysLeft = 180;
			while (day < 180)
			{
				Console.WriteLine("There are " + daysLeft + " days left of school!");
				day++;
				daysLeft--;
			}
	}
}