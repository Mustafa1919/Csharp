using System;
class dizi1
{
	static void Main()
	{
		Random rnd=new Random();
		int[] d1=new int[100];
		
		for(int i=0;i<100;i++)
			d1[i]=rnd.Next(1,11);
		//üretilen sayıların kaçar adet olacağını bulup yıldız koyan program devam edecek.
	}
}