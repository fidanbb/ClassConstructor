using System;
namespace ClassAndConstructor.Models
{
	public class Account
	{
		public string dbUsername;
		public string dbPassword;

		public bool Login(string username,string password)
		{
			if (username=="cavid123" && password=="Cavid1993")
			{
				return true;
			}
			return false;
		}
	}
}

