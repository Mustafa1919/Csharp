using System;
class metot2
{
	static int fib(int x)
	{
		if(x==0)
			return 0;
		else if(x==1)
			return 1;
		else
			return fib(x-1)+fib(x-2);
	}
	
	static void Main()
	{
		int a;
		Console.WriteLine("Kaçıncı Fibonecci Değeri Bulunacak=");
		a=Convert.ToInt32(Console.ReadLine());
		Console.WriteLine();
		Console.Write("Fibonecci({0})={1}",a,fib(a));
	}
}