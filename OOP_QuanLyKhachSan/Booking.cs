using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_QuanLyKhachSan
{
    public class Booking
    {
        public int IdCard { get; set; }
        public string HotelCode { get; set; }
        public string RoomCode { get; set; }
        public DateTime CheckIn { get; set; }
        public DateTime CheckOut { get; set; }

        public Booking()
        {

        }

        public Booking(int idCard, 
                    string hotelCode,
                    string roomCode, 
                    DateTime checkIn, 
                    DateTime checkOut)
        {
            IdCard = idCard;
            HotelCode = hotelCode;
            RoomCode = roomCode;
            CheckIn = checkIn;
            CheckOut = checkOut;
        }

        public void Input(List<Customer> customers, List<Hotel> hotels)
        {
            if(hotels.Count == 0)
            {
                Console.WriteLine("Have no data!!!");
                return;
            }

            Console.WriteLine("Enter ID card: ");
            IdCard = int.Parse(Console.ReadLine());

            //check Id Card available
            bool isFind = false;
            foreach(Customer customer in customers)
            {
                if (customer.IdCard.Equals(IdCard))
                {
                    isFind = true;
                    break;
                }
            }

            if(!isFind)
            {
                //Input new customer information
                Customer customer = new Customer();
                customer.IdCard = IdCard;
                customer.InputWithoutIdCard();
                customers.Add(customer);
            }

            Hotel currentHotel = null;
            for(; ; )
            {
                Console.WriteLine("Enter hotel code: ");
                HotelCode = Console.ReadLine();
                foreach(Hotel hotel in hotels)
                {
                    if (hotel.HotelCode.Equals(HotelCode))
                    {
                        currentHotel = hotel;
                        break;
                    }
                }
                if(currentHotel != null)
                {
                    break;
                }
                Console.WriteLine("Not found! Try again!");
            }

            
            Room currentRoom = null;
            for(; ; )
            {
                Console.WriteLine("Enter room code: ");
                if (currentHotel.RoomList.Count == 0)
                {
                    Console.WriteLine("Hotel have not room!!!");
                    break;
                }
                RoomCode = Console.ReadLine();
                foreach(Room room in currentHotel.RoomList)
                {
                    if (room.RoomCode.Equals(RoomCode))
                    {
                        currentRoom = room;
                        break;
                    }
                }
                if(currentRoom != null)
                {
                    break;
                }
                Console.WriteLine("Not found! Try again!");
            }

            Console.WriteLine("Enter time check in: ");
            string dateTime = Console.ReadLine();
            CheckIn = ConverStringToDateTime(dateTime);

            Console.WriteLine("Enter time check out: ");
            dateTime = Console.ReadLine();
            CheckOut = ConverStringToDateTime(dateTime);
        }

        public DateTime ConverStringToDateTime(string value)
        {
            DateTime oDate = DateTime.ParseExact(value, "dd/MM/yyyy", null);
            return oDate;
        }
    }
}
