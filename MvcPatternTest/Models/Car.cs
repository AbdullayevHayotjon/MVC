using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MvcPatternTest.Models
{
    [Table("Cars", Schema = "Car")]
    public class Car
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Year { get; set; }
        [Required]
        public string Type { get; set; }
        [Required]
        public string CompanyName { get; set; }
        [Required]
        public string Model { get; set; }
        [Required]
        public string Price { get; set; }
        [Required]
        public string Condition { get; set; }
        [Required]
        public string CarImageURL { get; set; }
    }
}
