// See https://aka.ms/new-console-template for more information
using Teknoloji10_AConsole.Abstract;
using Teknoloji10_AConsole.ATM.Interface;

//IslemNo islem1 = new IslemNo("0001", "29/10/2023", 1923);
//IslemNo islem2 = new IslemNo("0002", "19/05/2023", 1919);
//IslemNo islem3 = new IslemNo("0003", "28/02/2023", 1998);
//islem1.islemGoster();
//islem2.islemGoster();
//islem3.islemGoster();

AtmAction atmAction = new AtmAction();
int para, bakiye = 2500;
int secim = 0;
Basla:
Console.Title = "Kartal Bank'a Hoş Geldiniz";
Console.WriteLine("Kartal Bank'a Hoş Geldiniz...");
Console.WriteLine("İşlemlerinizi aşağıdaki seçim bloklarından yapabilirsiniz.");
Console.WriteLine("--- Lütfen Seçim Yapınız ---");
Console.WriteLine("1 - Bakiye Sorgulama\n2 - Para Çekme\n3 - Para Yatırma\n4 - Çıkış Yap");
secim = int.Parse(Console.ReadLine());
switch (secim)
{
	case 1:
		atmAction.BakiyeSorgula(bakiye);
		goto Basla;
	case 2:
		Console.WriteLine("Lütfen Çekilecek olan parayı giriniz?");
		para = int.Parse(Console.ReadLine());
		atmAction.ParaCekme(para, bakiye);
		goto Basla;
	case 3:
        Console.WriteLine("Lütfen Çekilecek olan parayı giriniz?");
        para = int.Parse(Console.ReadLine());
        atmAction.ParaCekme(para, bakiye);
		goto Basla;
	case 4:
		Console.WriteLine("Sistemden başarılı bir şekilde çıkış yaptınız iyi günler dileriz");
		break;
    default:
		Console.WriteLine("Yanlış İşlem Yaptınız.");
		goto Basla;
}
Console.ReadKey();