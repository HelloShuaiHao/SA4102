using System;
namespace SearchUsers.Models
{
	public class User
	{
		public string Name { get; set; }
		public string JobTitle  { get; set; }
		public string Gender { get; set; }

		public User(string name, string jobTitle, string gender)
		{
			this.Name = name;
			this.JobTitle = jobTitle;
			this.Gender = gender;
		}

	}
}

