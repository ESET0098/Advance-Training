using System.ComponentModel.DataAnnotations;
using System.Numerics;

namespace BookManage.Data.Entities
{
    public class Account
    {
        [Key]
        public int Id { get; set; }

        [Required,MaxLength(100)]
        public string? Username { get; set; }

        [Required,MaxLength(10),Phone]
        public string? Phone { get; set; }

        [Required,MaxLength(100),EmailAddress]
        public string? Email { get; set; }

        [Required,MaxLength(100)]
        public string? Password { get; set; }
    }
}
