using System;
using SQLite;
namespace Tutor50
{
	public class Tutor
	{
		[PrimaryKeyAttribute, AutoIncrement]
		public int ID { get; set; }
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public string FullName
		{ 
			get
			{
				return FirstName + " " + LastName;
			}
		}
		public string Email { get; set; }
		public string Phone { get; set; }
		//public string[] Languages { get; set; }
		public string Languages { get; set; }
		public double Rate { get; set; }
	}
}

