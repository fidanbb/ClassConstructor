using System;
namespace ClassWorkConstructor.Models
{
	public class Employee
	{
        public string fullName;
        public string address;
        public int age;
        public decimal salary;

        public void Test()
        {
            //int a = 5;
            //string b = "Welcome";
            //Console.WriteLine("Advertisment" + a + b);

            Book book = new();
            book.ShowAdvers();

            Console.WriteLine("Test");
        }
    }
}

