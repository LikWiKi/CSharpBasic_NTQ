using System;
using System.Collections.Generic;
using System.Text;

namespace Delegate_Event
{
    public class Neighbor
    {
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public bool IsCare { get; set; }

        public Neighbor()
        {
        }

        public Neighbor(string name, string phoneNumber, bool isCare, Family family)
        {
            Name = name;
            PhoneNumber = phoneNumber;
            IsCare = isCare;
            if(isCare)
            {
                family.RaiseNotificationEvent += HandleNotificationEvent;
            }
        }

        void HandleNotificationEvent(object sender, NotificationEventArgs e)
        {
            Console.WriteLine($"{Name} đã nhận được thông báo từ gia đình: {e.Message}");
        }
    }
}
