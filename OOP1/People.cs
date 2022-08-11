using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    public class People
    {
        public int Id { get; set; }
        public string Fullname { get; set; }
        public string Birthday { get; set; }
        public int Gender { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public People()
        {

        }

        public People(int id, string fullname, string birthday, int gender, string phone, string address)
        {
            Id = id;
            Fullname = fullname;
            Birthday = birthday;
            Gender = gender;
            Phone = phone;
            Address = address;
        }
    }
}
