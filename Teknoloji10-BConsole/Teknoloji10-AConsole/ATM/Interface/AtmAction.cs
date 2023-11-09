using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teknoloji10_AConsole.ATM.Interface
{
    public class AtmAction : IAtmAction
    {     
        public void BakiyeSorgula(int Bakiye)
        {
            Console.WriteLine("Bakiye Tutarınız : " + Bakiye);
        }

        public void ParaCekme(int Para, int Bakiye)
        {
            if (Bakiye <= 0) 
            {
                Console.WriteLine("Para Çekme işlemi yapamazsınız");
            }
            else
            {
                if (Para > Bakiye)
                {
                    Console.WriteLine("Para çekme limitiniz bakiyeden büyük olamaz");
                }
                else
                {
                    Bakiye = Para - Bakiye;
                    Console.WriteLine("Kalan Bakiyeniz : " + Bakiye);
                }
            }
        }

        public void ParaYatirma(int Para, int Bakiye)
        {
            if (Para < 0)
            {
                Console.WriteLine("Paranız Eksili Tutarda olamaz");
            }
            else
            {
                Bakiye = Para + Bakiye;
                Console.WriteLine("Kalan Bakiyeniz : " + Bakiye);
            }
        }
    }
}
