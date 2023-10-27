using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teknoloji10_BConsole.Interface
{
	public interface IActionInterface
	{
		public void Topla(int say1, int say2);
		public void Cikarma(int say1, int say2);
		public void Carpma(int say1, int say2);
		public void Bolme(int say1, int say2);
	}
}
