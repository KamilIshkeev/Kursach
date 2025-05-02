using System.ComponentModel.DataAnnotations;

namespace Kursach.Models
{
    public class Achiev
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
    }
}

