using System;
class dizi2
{
	static void Main()
	{
		char[] A={'a','b','c','d','e'};
		char x;
		foreach(char i in A)
			Console.Write("{0} ,",i);
		for(int i=0;i<A.Length/2;i++)
		{
			x=A[i];
			A[i]=A[A.Length-i-1];
			A[A.Length-i-1]=x;
		}
		Console.WriteLine();
		foreach(char i in A)
			Console.Write("{0} ,",i);
	}
}