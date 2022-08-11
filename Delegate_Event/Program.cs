using System;
using System.Text;

namespace Delegate_Event
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            Family family = new Family();
            family.InputFamily();

            Neighbor nei1 = new Neighbor("Linh1", "03923828323", true, family);
            Neighbor nei2 = new Neighbor("Linh2", "02323982932", true, family);
            Neighbor nei3 = new Neighbor("Linh3", "09428342834", false, family);
            Neighbor nei4 = new Neighbor("Linh4", "06527833344", true, family);

            family.Notification();

            Console.ReadLine();
        }
    }
}
