using System;
class dizi1
{
	static void Main()
	{
		int[] A={5,2,1,4,6,0,7};
		int x;
		for(int i=0;i<A.Length;i++)
		{
			for(int j=i+1;j<A.Length;j++)
			{
				if(A[i]>A[j])
				{
					x=A[j];
					A[j]=A[i];
					A[i]=x;
				}
			}
			//Console.WriteLine(A[i]);
		}
		
		foreach(int i in A)
			Console.WriteLine(i);
	}
}