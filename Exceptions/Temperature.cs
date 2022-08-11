using System;
using System.Collections.Generic;
using System.Text;

namespace Exceptions
{
    class Temperature
    {
        int temperature = 0;
        public void showTemp()
        {
            if (temperature == 0)
            {
                throw (new MyException("Muc nhiet do 0!"));
            }
            else
            {
                Console.WriteLine("Nhiet do: {0}", temperature);
            }
        }
    }
}
