
using System.ComponentModel.DataAnnotations;

namespace MVCWebApp.Models
{
    public class Car
    {
        public int CarId { get; set; }
        
        [Required]
        public string Make { get; set; }
        [Required]
        public string Model { get; set; }
        public int Year { get; set; }

    }
}
