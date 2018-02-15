using System;
class dizi2
{
	static void Main()
	{
		int[][] d1=new int [3][];
		d1[0]= new int[] {1,2,3};
		d1[1]=new int[] {4,5};
		d1[2]=new int[] {6,7,8,9};
		
		for(int i=0;i<d1.GetLength(0);i++)
		{
			for(int j=0;j<d1[i].GetLength(0);j++)
				Console.WriteLine("dizi [{0}][{1}]={2}",i,j,d1[i][j]);
		}
	}
}