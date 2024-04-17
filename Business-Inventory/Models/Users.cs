using System.ComponentModel.DataAnnotations;

namespace Business_Inventory.Models
{
    public class Users
    {
        [Key]
        public int UserId { get; set; }

        public string Username { get; set; }

        // Consider storing hashed password
        public string Password { get; set; }

        public string Role { get; set; }

        public string FullName { get; set; }

        public string Email { get; set; }
    }
}
