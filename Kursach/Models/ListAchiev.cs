using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Kursach.Models
{
    public class ListAchiev
    {
        [Key]
        public int Id { get; set; }

        public int User_Id { get; set; }
        public int Achiev_Id { get; set; }

        //// Навигационные свойства
        //[ForeignKey("User_Id")]
        //public User User { get; set; }

        //[ForeignKey("Achiev_Id")]
        //public Achiev Achiev { get; set; }
    }
}

