using System;

public struct sampStru
{
    public int x;
    public int y;
}
public class Program
{
    //Method return struct
    public sampStru sqrLength()
    {
        sampStru rct = new sampStru();
        rct.x = 2;
        rct.y = 5;
        return rct;
    }

    static void Main()
    {
        //Mang struct
        sampStru[] st = new sampStru[10];
        Console.Write("Enter x1 = ");
        st[0].x = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter y1 = ");
        st[0].y = Convert.ToInt32(Console.ReadLine());
        
        Console.Write("Enter x2 = ");
        st[1].x = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter y2 = ");
        st[1].y = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine(st[0].x + ", " + st[0].y);
        Console.WriteLine(st[1].x + ", " + st[1].y);
        Console.WriteLine();
    }
}
