using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    public class Student : People
    {
        public string Room { get; set; }
        public Student()
        {

        }

        public Student(int Id, string FullName, string Address, int Gender, string Birthday, string Phone, string room) : base(Id, FullName, Address, Gender, Birthday, Phone)
        {
            Room = room;
        }

		public void GetStudent(List<Student> studentList)
		{
			List<Student> tester = new List<Student>();
			foreach (var student in studentList)
			{
				Console.WriteLine("MSV: {0} - Name: {1} - Địa Chỉ: {2} - Giới tính: {3} - Ngày sinh: {4} - Sđt: {5} - Lớp: {6}",
								  student.Id, student.Fullname, student.Address, student.Gender, student.Birthday, student.Phone, student.Room);
			}
		}
		public List<Student> AddStudent(List<Student> studentDtos, Student member)
		{
			List<Student> students = new List<Student>();

			foreach (var student in studentDtos)
			{
				students.Add(new Student(student.Id, student.Fullname, student.Address,
									   student.Gender, student.Birthday, student.Phone, student.Room));
			}
			students.Add(new Student(member.Id, member.Fullname, member.Address,
									   member.Gender, member.Birthday, member.Phone, member.Room));
			return students;
		}
	}
}
