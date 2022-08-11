using System;
using System.Collections.Generic;
using System.Text;

namespace Delegates
{
    public delegate void Care(Neighbor neighbor);
    public class Family
    {
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
    }
}
