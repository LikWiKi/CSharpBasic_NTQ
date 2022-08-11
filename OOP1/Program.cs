using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    internal class Program
    {
        static void Main(string[] args)
        {
			Console.OutputEncoding = Encoding.UTF8;

			Student tester = new Student();
			Student addStudent = new Student(3, "Linh", "26-11-2000", 1, "0362213282", "Ha Noi", "CNTT");
			List<Student> testers = new List<Student>(){
				new Student(1 ,"Linh", "26-12-2000", 1, "0362147282", "Ha Noi", "CNTT"),
				new Student(2 ,"Nam", "30-03-2000", 0, "023447282", "Ha Noi", "ATTT")
			};
			tester.GetStudent(testers);
			Console.WriteLine("---------------Lớp học sau khi thêm----------------");
			tester.GetStudent(tester.AddStudent(testers, addStudent));
		}
    }
}
