using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_QuanLyKhachSan
{
    public class Customer
    {
        public int IdCard { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
        public string Address { get; set; }
        public Customer()
        {

        }

        public Customer(int idCard, 
                        string name, 
                        int age,
                        string gender, 
                        string address)
        {
            IdCard = idCard;
            Name = name;
            Age = age;
            Gender = gender;
            Address = address;
        }

        public void Input()
        {
            Console.WriteLine("Enter ID card: ");
            IdCard = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter name: ");
            Name = Console.ReadLine();
            Console.WriteLine("Enter age: ");
            Age = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter gender: ");
            Gender = Console.ReadLine();
            Console.WriteLine("Enter address: ");
            Address = Console.ReadLine();
        }
        
        public void InputWithoutIdCard()
        {
            Console.WriteLine("Enter name: ");
            Name = Console.ReadLine();
            Console.WriteLine("Enter age: ");
            Age = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter gender: ");
            Gender = Console.ReadLine();
            Console.WriteLine("Enter address: ");
            Address = Console.ReadLine();
        }

        public void Display()
        {
            Console.WriteLine("Id Card: {0}, Name: {1}, Age: {2}, Gender: {3}, Address: {4}",
                IdCard, Name, Age, Gender, Address);
        }
    }
}
