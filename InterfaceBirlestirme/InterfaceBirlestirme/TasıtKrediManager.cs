using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceBirlestirme
{
    class TasıtKrediManager:IKrediManager
    {
        public void Hesapla()
        {
            Console.WriteLine("taşıt kredisi hesaplandı.");
        }
    }
}
