using System;
class yedi1
{
	static void Main()
	{
		int a,b;
		Console.Write("Lütfen Sayıyı Giriniz=  ");
		a=Convert.ToInt32(Console.ReadLine());
		while(a/10!=0)
		{
			int c=a%10;
			a=a-c;
			a=a/10;
			a=(a*3)+c;
		}
		if(a==7)
			Console.WriteLine("Sayı 7 ile Tam Bölünür");
		else
			Console.WriteLine("Sayı 7 ile Tam Bölünmez");
	}
}