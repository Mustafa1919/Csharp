using System;
class metot1
{
	static double[] karekök(params double[] A)
	{
		
		double[] B=new double[A.Length];
		
		for(int i=0;i<A.Length;i++)
		{
			B[i]=Math.Sqrt(A[i]);
		}
		return B;
	}
	
	static void Main()
	{
		double[] d1=karekök(1,2,4,9,144,500,24);
		
		foreach(double i in d1)
			Console.WriteLine(i);
		
	}
}