using System.ComponentModel.DataAnnotations;

namespace Practical_20.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public DateTime Timestamp { get; set; } = DateTime.Now; // When the user is created
    }
}
