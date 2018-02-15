using System;

class asal
{
	static void Main()
	{
		long a,b,c=1;
		Console.WriteLine("Sayıyı Giriniz=");
		a=Convert.ToInt64(Console.ReadLine());
		for(int i=1;i<a;i++)
		{
			c=i*c;
		}
		b=c%a;
		Console.WriteLine("b={0} ve c={1} ",b,c);
		if(b==(a-1))
			Console.WriteLine("Sayı Asal");
		else
			Console.WriteLine("Sayı Asal Değil");
		
	}
}
//19 dan sonrasını hesaplamıyor.
