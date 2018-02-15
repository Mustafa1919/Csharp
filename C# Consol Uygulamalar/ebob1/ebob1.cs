using System;
class ebob1
{
	static void Main()
	{
		int a,b,k,c,d,e;
		Console.WriteLine("1. Sayıyı Giriniz:  ");
		a=Convert.ToInt32(Console.ReadLine());
		Console.WriteLine("2. Sayıyı Giriniz:  ");
		b=Convert.ToInt32(Console.ReadLine());
		d=a;
		e=b;
		if(a==b)
			Console.WriteLine("EBOB({0},{1})={2}",a,b,a);
		else
		{
			c=1;
			
			while(c != 0)
			{
				if(a>b)
				{
					k=a/b;
					c=a%b;
					a=b*k+c;
					a=b;
					b=c;
				}
				else
				{
					int k1;
					k1=b;
					b=a;
					a=k1;
					k=b/a;
					c=b%a;
					a=b*k+c;
					a=b;
					b=c;
				}
			}
			Console.WriteLine("EBOB({0},{1})={2}",d,e,a);
		}
	}
	
}