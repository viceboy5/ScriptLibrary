using System;

public class Operators	
{
	
    public void Main()
    {
		bool isMale = true;
		bool isTall = true;
		
		if (isMale && isTall)
		{
			Console.WriteLine("You are a tall male");
		} else
		{
			Console.WriteLine("You are either not male or not tall or both");
		}
        
	}
}