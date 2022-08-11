using System;

namespace HoclaptrinhCsharp
{
    class TestCsharp
    {
        int result;
        TestCsharp()
        {
            result = 0;
        }
        public void phepChia(int num1, int num2)
        {
            try
            {
                result = num1 / num2;
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("Bat Exception: {0}", e);
            }
            finally
            {
                Console.WriteLine("Ket qua: {0}", result);
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Vi du minh hoa Exception trong C#");
            Console.WriteLine("---------------------------------");

            TestCsharp d = new TestCsharp();
            d.phepChia(25, 0);
            Console.ReadKey();
        }
    }
}