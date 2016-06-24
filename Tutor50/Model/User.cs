using System;
namespace Tutor50
{
	public class User
	{
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public string Email { get; set; }
		public string Password { get; set; }
		public Tutor Post { get; set; }
		public Tutor[] TutorsRequested { get; set; }

		public User()
		{
		}
	}
}

