using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_QuanLyKhachSan
{
    public class Room
    {
        public string RoomName { get; set; }
        public float Price { get; set; }
        public int Floor { get; set; }
        public int PeopleMax { get; set; }
        public string RoomCode { get; set; }
        public List<Customer> CustomerList { get; set; }

        public Room()
        {
            CustomerList = new List<Customer>();
        }

        public Room(string roomName, 
                    float price, 
                    int floor, 
                    int peopleMax, 
                    string roomCode,
                    List<Customer> customerList)
        {
            RoomName = roomName;
            Price = price;
            Floor = floor;
            PeopleMax = peopleMax;
            RoomCode = roomCode;
            CustomerList = customerList;
        }

        public void Input()
        {
            Console.WriteLine("Enter room code: ");
            RoomCode = Console.ReadLine();
            Console.WriteLine("Enter room name: ");
            RoomName = Console.ReadLine();
            Console.WriteLine("Enter price of room: ");
            Price = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter max people: ");
            PeopleMax = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter floor: ");
            Floor = int.Parse(Console.ReadLine());
        }

        public void Display()
        {
            Console.WriteLine("Room code: {0}, Room name: {1}, Price: {2}, Max people: {3}, Floor: {4}",
                RoomCode, RoomName, Price, PeopleMax, Floor);
            if(CustomerList.Count != 0)
            {
                foreach(Customer customer in CustomerList)
                {
                    customer.Display();
                }    
            }
        }
    }
}
