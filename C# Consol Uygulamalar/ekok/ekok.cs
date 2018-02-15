//ebob(16,12)=4		16*12=192		192/4=48		ekok(16,12)=48
using System;
class ekok
{
	static int ekokbul(int a,int b)
	{
		int c,d=1;
		c=Math.Max(a,b);
		for(int i=2;i<c;i++)
		{
			while(a%i==0 || b%i==0)
			if(a%i==0 || b%i==0)
			{
				d=d*i;
				if(a%i==0)
					a=a/i;
				if(b%i==0)
					b=b/i;
			}
		}
		return d;
	}
	static void Main()
	{
		int x,y,z;
		int k;
		Console.Write("1. Sayıyı Giriniz: ");
		x=Convert.ToInt32(Console.ReadLine());
		Console.Write("2. Sayıyı Giriniz: ");
		y=Convert.ToInt32(Console.ReadLine());
		Console.WriteLine("EKOK({0},{1})={2}",x,y,ekokbul(x,y));
		Console.Write("EBOB'u da Bulmak İster misiniz?(E/H)");
		k=Convert.ToInt32(Convert.ToChar(Console.ReadLine()));
		if(k==069)
		{
			z=(x*y)/ekokbul(x,y);
			Console.WriteLine("EBOB({0},{1})={2}",x,y,z);
		}
		if(k==072)
			Console.Write("Teşekkür Ederiz!!!");
		
	}
}