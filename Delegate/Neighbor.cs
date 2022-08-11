using System;
using System.Collections.Generic;
using System.Text;

namespace Delegates
{
    public class Neighbor
    {
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public bool IsCare { get; set; }

        public Neighbor()
        {
            
        }

        public Neighbor(string name, string phoneNumber)
        {
            this.Name = name;
            this.PhoneNumber = phoneNumber;
        }

        public Care careBayby { get; set; }
    }
}
