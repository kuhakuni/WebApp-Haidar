using System.ComponentModel.DataAnnotations;

namespace WebApp.Models
{
	public class LoginRequest
	{
        [Required(ErrorMessage = "Email is required")]
        [EmailAddress(ErrorMessage = "Invalid email address")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Password is required")]
        public string Password { get; set; }
    }


	public class LoginResponse
	{
		public required string Message { get; set; }
		public required int Status { get; set; }
		public required UserData Data { get; set; }
	}

	public class UserData
	{
		public required string Id { get; set; }
		public required string Email { get; set; }
		public required List<Role> Roles { get; set; }
		public required string Token { get; set; }
		public required string RefreshToken { get; set; }
	}

	public class Role
	{
		public required string Name { get; set; }
	}

}
