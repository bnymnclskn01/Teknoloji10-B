using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teknoloji10_BConsole.Interface
{
	internal class ActioClass : IActionInterface
	{
		public void Bolme(int say1, int say2)
		{
			Console.WriteLine(say1 + "/" + say2 + "=" + (say1 / say2));
		}

		public void Carpma(int say1, int say2)
		{
			Console.WriteLine(say1 + "*" + say2 + "=" + (say1 * say2));
		}

		public void Cikarma(int say1, int say2)
		{
			Console.WriteLine(say1 + "-" + say2 + "=" + (say1 - say2));
		}

		public void Topla(int say1, int say2)
		{
			Console.WriteLine(say1 + "+" + say2 + "=" + (say1 + say2));
		}
	}
}
