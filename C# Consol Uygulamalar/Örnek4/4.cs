using System;
class Ornek4
{
	static void Main()
	{
		int eb=0,ek=100,y=10,top=0,x;
		float ort;
		for(int i=0;i<y;i++)
		{
			Console.Write("Notları Giriniz:");
			x=Convert.ToInt32(Console.ReadLine());
			top+=x;
			if(x<ek)
				ek=x;
			if(x>eb)
				eb=x;
			
		}
		ort=(float)top/(float)y;
		Console.WriteLine("Ortalama={0}",ort);
		Console.WriteLine("En Büyük Sayı={0}",eb);
		Console.WriteLine("En Küçük Sayı={0}",ek);
	}
}