using System.ComponentModel.DataAnnotations;

namespace ZooBazaarWebApp.Model
{
    public class LoginRequest
    {
        [Required]
        public string? Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string? Password { get; set; }

        public LoginRequest()
        {

        }

        public LoginRequest(string email, string password)
        {
            Email = email;
            Password = password;
        }

    }
}
