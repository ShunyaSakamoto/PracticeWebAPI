using System;

namespace PracticeWebAPI.Models
{
	public class User
	{
        public int Id { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public string PasswordConfirmation { get; set; }
        public int Age { get; set; }
        public string Email { get; set; }
        public DateTime Created_at { get; set; }
        public DateTime? Updated_at { get; set; }
    }
}
