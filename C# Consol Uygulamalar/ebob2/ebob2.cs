using System;
class ebob2
{
	static void Main()
	{
		int a,b,c;
		Console.WriteLine("1. Sayýyý Giriniz= ");
		a=Convert.ToInt32(Console.ReadLine());
		Console.WriteLine("2. Sayýyý Giriniz= ");
		b=Convert.ToInt32(Console.ReadLine());
		int d,e;
			d=a;
			e=b;
		if(a==b)
			Console.WriteLine("EBOB({0},{1})={2}",a,b,a);
		else if(a>b)
		{
			
			c=a-b;
			while(b!=c)
			{
				if(c>b)
					a=c;
				else
				{
					a=b;
					b=c;
				}
				c=a-b;
			}
			Console.WriteLine("EBOB({0},{1})={2}",d,a,c);
		}
		else
		{
			c=b-a;
			while(a!=c)
			{
				if(c>a)
					b=c;
				else
				{
					b=a;
					a=c;
				}
				c=b-a;
			}
			Console.WriteLine("EBOB({0},{1})={2}",d,e,c);
		}
	}
}