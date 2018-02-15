using System;
class onbir
{
	static void Main()
	{
		int a;
		Console.WriteLine("Sayıyı Giriniz= ");
		a=Convert.ToInt32(Console.ReadLine());
		while(a>12)
		{
			int b=a%10;
			a=a/10;
			a=a-b;
		}
		if(a==11 || a==0)
			Console.WriteLine("Sayı 11'e Tam Bölünür.");
		else
			Console.WriteLine("Sayı 11'e Tam Bölünmez.");
	}
}//örnek sayı 896544