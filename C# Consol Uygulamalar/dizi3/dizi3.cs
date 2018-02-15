using System;
class dizi3
{
	static void Main()
	{
		Random rnd=new Random();
		int[] A=new int[20];
		int eb=0,ek=100,x=0;
		float ort;
		for(int i=0;i<20;i++)
		{
			A[i]=rnd.Next(0,100);
			if(A[i]>eb)
				eb=A[i];
			if(A[i]<ek)
				ek=A[i];
			
			x=x+A[i];
		}
		ort=(float)x/(float)20;
		Console.Write("En Büyük Sayı={0}",eb);
		Console.WriteLine();
		Console.Write("En Küçük Sayı={0}",ek);
		Console.WriteLine();
		Console.Write("Ortalama={0}",ort);
		Console.WriteLine();
		foreach(int i in A)
			Console.Write("{0} ,",i);
	}
}