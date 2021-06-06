using System;

namespace InterfaceBirlestirme
{
    class FileLoggerService : ILoggerManager
    {
        public void Log()
        {
            Console.WriteLine("logged to File!.");
        }
    }
}
