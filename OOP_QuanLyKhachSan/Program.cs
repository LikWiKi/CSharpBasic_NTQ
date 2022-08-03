using OOP_QuanLyKhachSan;
using System;
using System.Collections.Generic;

namespace OOP2
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<Customer> customerList = new List<Customer>();
            List<Hotel> hotelList = new List<Hotel>();
            List<Booking> bookingList = new List<Booking>();

            int choose;

            do
            {
                ShowMenu();
                choose = int.Parse(Console.ReadLine());

                switch (choose)
                {
                    case 1:
                        InputHotel(hotelList);
                        break;
                    case 2:
                        DisplayHotel(hotelList);
                        break;
                    case 3:
                        BookingRoom(customerList, hotelList, bookingList);
                        break;
                    case 4:
                        FindEmptyRoom(hotelList);
                        break;
                    case 5:
                        break;
                    default:
                        Console.WriteLine("Enter wrong!!!");
                        break;
                }
            } while (choose != 5);
            Console.ReadLine();
        }

        static void FindEmptyRoom(List<Hotel> hotels)
        {
            foreach(Hotel hotel in hotels)
            {
                foreach(Room room in hotel.RoomList)
                {
                    if(room.CustomerList.Count == 0)
                    {
                        room.Display();
                    }
                }
            }
        }

        static void BookingRoom(List<Customer> customers, List<Hotel> hotels, List<Booking> bookings)
        {
            Booking book = new Booking();

            book.Input(customers, hotels);

            bookings.Add(book);
        }

        static void DisplayHotel(List<Hotel> hotels)
        {
            foreach (Hotel hotel in hotels)
            {
                hotel.Display();
            }
        }

        static void InputHotel(List<Hotel> hotels)
        {
            for(; ; )
            {
                Hotel hotel = new Hotel();
                hotel.Input();

                hotels.Add(hotel);

                Console.WriteLine("Continue? Y/N: ");
                string options = Console.ReadLine();
                if(options.ToUpper().Equals("N"))
                {
                    break;
                }
            }
        }

        static void ShowMenu()
        {
            Console.WriteLine("1. Enter hotel information");
            Console.WriteLine("2. Display hotel information");
            Console.WriteLine("3. Book room");
            Console.WriteLine("4. Find empty room");
            Console.WriteLine("5. Exit");
            Console.WriteLine("Choose: ");
        }
    }
}
