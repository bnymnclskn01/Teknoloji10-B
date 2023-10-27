// See https://aka.ms/new-console-template for more information
using Teknoloji10_AConsole.Abstract;

IslemNo islem1 = new IslemNo("0001", "29/10/2023", 1923);
IslemNo islem2 = new IslemNo("0002", "19/05/2023", 1919);
IslemNo islem3 = new IslemNo("0003", "28/02/2023", 1998);
islem1.islemGoster();
islem2.islemGoster();
islem3.islemGoster();
Console.ReadKey();