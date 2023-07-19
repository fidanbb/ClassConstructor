using System;
namespace ClassWorkConstructor.Models
{
	public class Student
	{
		public string fullName;
		public string address;
		public int age;

		public string GetFullData()
		{
            Book book = new();
            book.ShowAdvers();

            return $"fullname - {fullName}, address - {address}, age - {age}";
		}

	}
}

