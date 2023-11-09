using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teknoloji10_AConsole.ATM.Interface
{
    public interface IAtmAction
    {
        public void ParaCekme(int Para, int Bakiye);
        public void ParaYatirma(int Para, int Bakiye);
        public void BakiyeSorgula(int Bakiye);
    }
}
