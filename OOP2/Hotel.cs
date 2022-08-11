using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_QuanLyKhachSan
{
    public class Hotel
    {
        public string HotelName { get; set; }
        public string Address { get; set; }
        public string HotelType { get; set; }
        public List<Room> RoomList { get; set; }
        public string HotelCode { get; set; }

        public Hotel()
        {
            RoomList = new List<Room>();
        }

        public Hotel(string hotelName, 
                    string address, 
                    string hotelType, 
                    List<Room> roomList, 
                    string hotelCode)
        {
            HotelName = hotelName;
            Address = address;
            HotelType = hotelType;
            RoomList = roomList;
            HotelCode = hotelCode;
        }

        public void Input()
        {
            Console.WriteLine("Enter hotel name: ");
            HotelName = Console.ReadLine();
            Console.WriteLine("Enter address: ");
            Address = Console.ReadLine();
            Console.WriteLine("Enter type of hotel: ");
            HotelType = Console.ReadLine();
            Console.WriteLine("Enter hotel code: ");
            HotelCode = Console.ReadLine();
            for(; ; )
            {
                Room room = new Room();
                room.Input();
                RoomList.Add(room);
                Console.WriteLine("Continue? Y/N:");
                string answer = Console.ReadLine();
                if(answer.ToUpper().Equals("N"))
                {
                    break;
                }
            }
        }

        public void Display()
        {
            Console.WriteLine("Code: {0}, Hotel Name: {1}, Type: {2}, Address: {3}",
                                HotelCode, HotelName, HotelType, Address);
            foreach(Room room in RoomList)
            {
                room.Display();
            }
        }
    }
}
