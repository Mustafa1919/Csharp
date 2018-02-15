using System;
class Ornek2
{
	static void Main()
	{
		int x=0;
		for(int i=0;i<=100;i+=5)
		{
			if(x%6==0)
				Console.WriteLine();
			Console.WriteLine("{0,3}   ",i);
			x++;
		}
	}
}