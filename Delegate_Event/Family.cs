using System;
using System.Collections.Generic;
using System.Text;

namespace Delegate_Event
{
    public class Family
    {
        public event EventHandler<NotificationEventArgs> RaiseNotificationEvent;
        public string Name { get; set; }
        public DateTime TimeBorn { get; set; }
        public Family()
        {
        }

        public void InputFamily()
        {
            Console.Write("Nhập vào tên gia đình: ");
            Name = Console.ReadLine();

            Console.WriteLine("Nhập vào thời gian đứa bé sinh ra: ");
            Console.Write("Ngày: ");
            int day = int.Parse(Console.ReadLine());
            Console.Write("Tháng: ");
            int month = int.Parse(Console.ReadLine());
            Console.Write("Năm: ");
            int year = int.Parse(Console.ReadLine());
            TimeBorn = new DateTime(year, month, day);
        }

        public void Notification()
        {
            OnRaiseNotificationEvent(new NotificationEventArgs("Đứa bé đã sinh"));
        }

        protected virtual void OnRaiseNotificationEvent(NotificationEventArgs e)
        {
            EventHandler<NotificationEventArgs> raiseEvent = RaiseNotificationEvent;

            if (raiseEvent != null)
            {
                e.Message += $" vào lúc {TimeBorn.ToString("dd/MM/yyyy")}";
                raiseEvent(this, e);
            }
        }
    }
}
