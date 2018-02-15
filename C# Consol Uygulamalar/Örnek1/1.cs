using System;
class Ornek1
{
	static void Main()
	{
		int x=0,top=0;
		for(int i=0;i<1000;i++)
		{
			if((i%5==0) && (i%7!=0))
			Console.WriteLine(i);
			x++;
			top+=i;
		}
		Console.WriteLine("{0} Sayı Bulundu",x);
		Console.WriteLine("Toplamları={0}",top);
	}
}