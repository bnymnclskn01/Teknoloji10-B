using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Teknoloji10_AConsole.Concrete;

namespace Teknoloji10_AConsole.Abstract
{
	public class IslemNo : IProject
	{
		private string islemKodu;
		private string Tarih;
		private double Tutar;
        public IslemNo()
        {
			islemKodu = "";
			Tarih = "";
			Tutar = 0.0;
        }
		public IslemNo(string c, string d, double a)
		{
			islemKodu = c;
			Tarih= d;
			Tutar = a;
		}
        public void islemGoster()
		{
			Console.WriteLine("İşlem No : {0}", islemKodu);
			Console.WriteLine("İşlem Tarih : {0}", Tarih);
			Console.WriteLine("İşlem Tutar : {0}", Tutar);
		}

		public double tutarGetir()
		{
			return Tutar;
		}
	}
}
