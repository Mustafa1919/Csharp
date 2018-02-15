using System;
class asal
{
	static void Main()
	{
		int a,sayaç=0;
		Console.WriteLine("Lütfen kontrol Edilecek Sayıyı Giriniz: ");
		a=Convert.ToInt32(Console.ReadLine());
		while(sayaç==0)
		{
			for(int i=2;i<a;i++)
			{
				if(a%i==0)
				{
					sayaç++;
					
				}
				
					
			}
			sayaç++;
		}
		if(sayaç==1)
			Console.WriteLine("Sayı Asal");
		else
			Console.WriteLine("Sayı Asal Değil!!!");
		
	}
	
}