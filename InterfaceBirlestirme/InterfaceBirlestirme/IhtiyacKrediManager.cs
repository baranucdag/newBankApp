using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceBirlestirme
{
    class IhtiyacKrediManager:IKrediManager
    {
        public void Hesapla()
        {
            Console.WriteLine("ihtiyac kredisi hesaplandı.");
        }
    }
}
