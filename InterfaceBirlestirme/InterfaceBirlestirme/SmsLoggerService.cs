using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceBirlestirme
{
    class SmsLoggerService : ILoggerManager
    {
        public void Log()
        {
            Console.WriteLine("Sms Gönderilme işlemi tamamlandı!."); ;
        }
    }
}
