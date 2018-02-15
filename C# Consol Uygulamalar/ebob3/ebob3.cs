using System;
class ebob3
{
	static int ebob(int a,int b)
	{
		int c=Math.Min(a,b);
		int son=1;
		for(int i=2;i<=c;i++)
		{
			if(a%i==0 && b%i==0)
				son=i;
		}
		return son;
	}
	
	static void Main()
	{
		int x,y;
		Console.Write("1. Sayıyı Giriniz: ");
		x=Convert.ToInt32(Console.ReadLine());
		Console.Write("\n2. Sayıyı Giriniz: ");
		y=Convert.ToInt32(Console.ReadLine());
		Console.WriteLine();
		Console.Write("EBOB({0},{1})={2}",x,y,ebob(x,y));
	}
}