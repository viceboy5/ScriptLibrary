using System;

  public class Program
  {
		int x = 20;
		int y = 18;
		int a = 5;
		int b = 17;
    public void Main()
    {
     	if (x > y) 
      {
        Console.WriteLine("20 is greater than 18");
      }    
		if (a > b) {
			Console.WriteLine("a is a big number");
		}
		else if (a == b) {
			Console.WriteLine("a is a medium number");
		}
		else {
			Console.WriteLine("a is a small number");
		}
    }
  }