using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace APICinema.Models
{
    public class Show
    {
        [Key]
        public int ShowId { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        public string MovieTitle { get; set; } = "";
       
        [Column(TypeName = "DateTime")]
        public DateTime RentalTime { get; set;}

    }
}
