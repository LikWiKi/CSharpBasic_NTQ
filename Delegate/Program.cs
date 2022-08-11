using Delegates;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp
{
    class Program
    {
        static Family family;
        static List<Neighbor> neighbors;
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            family = new Family();
            family.InputFamily();

            neighbors = new List<Neighbor>();
            neighbors.Add(new Neighbor("Nguyễn Văn A", "02381283232"));
            neighbors.Add(new Neighbor("Nguyễn Văn B", "01231893242"));
            neighbors.Add(new Neighbor("Nguyễn Văn C", "09543253423"));
            neighbors.Add(new Neighbor("Nguyễn Văn D", "03284932853"));

            WantToReceiveNotification(neighbors);
            //subcriber
            Notifications notifications = new Notifications();

            Console.WriteLine("----------------------------------------");
            foreach (var neighbor in neighbors)
            {
                if (neighbor.IsCare == true)
                {
                    notifications.NotificationToNeighbors(neighbor);
                    //phát sự kiện
                    neighbor.careBayby.Invoke(neighbor);
                }
            }

            Console.ReadLine();
        }

        public static void WantToReceiveNotification(List<Neighbor> neighbors)
        {
            foreach (var neighbor in neighbors)
            {
                Console.WriteLine("Tên: {0}, Số điện thoại: {1}", neighbor.Name, neighbor.PhoneNumber);
                Console.Write("Có muốn nhận thông báo về đứa bé hay không(Y/N)?: ");
                string isCare = Console.ReadLine();
                if (isCare.ToUpper().Equals("Y"))
                {
                    neighbor.IsCare = true;
                }
                else
                {
                    neighbor.IsCare = false;
                }
            }
        }
    }

    class Notifications
    {
        public void NotificationToNeighbors(Neighbor neighbor)
        {
            neighbor.careBayby = NotificationDetail;
        }

        public void NotificationDetail(Neighbor neighbor)
        {
            Console.WriteLine("Gia đình đã thông báo tới {0} rằng đứa bé đã ra đời.",
                                neighbor.Name);
        }
    }
}