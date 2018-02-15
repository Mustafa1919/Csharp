using System;
class kompleks
{
	private double mgercek;
	private double msanal;
	
	public double gercek
	{
		get{return mgercek;}
		set{mgercek=value;}
	}
	
	public double sanal
	{
		get{return msanal;}
		set{msanal=value;}
	}
	public kompleks(double a,double b)
	{
		mgercek=a;
		msanal=b;
	}
	public kompleks()
	{
		mgercek=0;
		msanal=0;
	}
	public kompleks(double a)
	{
		mgercek=a.gercek;
		msanal=a.sanal;
	}
	public void yazdır()
	{
		if(msanal>0)
			Console.WriteLine("{0}+{1}j",mgercek,msanal);
		else
			Console.WriteLine("{0}+{1}j",mgercek,msanal);
	}
	
	public static kompleks operator+(kompleks a,kompleks b)
	{
		double gtoplam=a.gerçek+b.gercek;
		double stoplam=a.sanal+b.sanal;
		return new kompleks(gtoplam,stoplam);
	}
	
	public static kompleks operator-(kompleks a,kompleks b)
	{
		double gcıkarma=a.gerçek-b.gercek;
		double scıkarma=a.sanal-b.sanal;
		return new kompleks(gcıkarma,scıkarma);
	}
	public static kompleks operator*(kompleks a,kompleks b)
	{
		double gcarpma=(a.gercek*b.gercek)-(a.sanal*b.sanal);
		double scarpma=(a.gercek*b.sanal)+(a.sanal*b.gercek);
		return new kompleks(gcarpma,scarpma);
	}
	public static kompleks operator/(kompleks a,kompleks b)
	{
		kompleks eslenik=new kompleks(b.gercek-b.sanal); //bu bölge sor
		kompleks pay=a*eslenik;
		double payda=(b.gercek*b.gercek)+(b.sanal*b.sanal);
		double gbolme=pay.gercek/payda;
		double sbolme=pay.sanal/payda;
		return new kompleks(gbolme,sbolme);
	}
}