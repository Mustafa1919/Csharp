using System;
class Ornek3
{
	static void Main()
	{
		int x,y;
		Console.WriteLine("Satır Sayısı: ");
		x=Convert.ToInt32(Console.ReadLine());
		Console.WriteLine("Sütun Sayısı: ");
		y=Convert.ToInt32(Console.ReadLine());
		for(int i=0;i<x;i++)
		{
			for(int j=0;j<y;j++)
			{
				Console.Write("*");
			}
			Console.WriteLine();
		}
	}
}