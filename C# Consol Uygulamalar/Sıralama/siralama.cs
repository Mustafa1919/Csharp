using System;

class sıralama
{
	static void Main()
	{
		int a=3,b=7,c=4,d=1,e1;
		Console.WriteLine("{0} , {1} , {2} , {3} ",a,b,c,d);
		if(a<b)
		{
			e1=a;
			a=b;
			b=e1;
		}
		Console.WriteLine("{0} , {1} , {2} , {3} ",a,b,c,d);
		if(c>a)
		{
			e1=a;
			a=c;
			c=a;
		}
		else if (c<a && c>b)
		{
			e1=b;
			b=c;
			c=e1;
		}
		Console.WriteLine("{0} , {1} , {2} , {3} ",a,b,c,d);
		if(d>a)
		{
			e1=a;
			a=d;
			d=e1;
		}
		else if(d<a && d>b)
		{
			e1=b;
			b=d;
			d=e1;
		}
		else if(d<a && d<b && d>c)
		{
			e1=c;
			c=d;
			d=e1;
		}
		Console.WriteLine("{0} , {1} , {2} , {3} ",a,b,c,d);
		
	}
	
}