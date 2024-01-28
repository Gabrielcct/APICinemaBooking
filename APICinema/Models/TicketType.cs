using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace APICinema.Models
{
    public class TicketType
    {
        [Key]
        public int TicketId { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        public string TicketName { get; set;} = "";

        [Column(TypeName = "decimal(18,2)")]
        public int TicketPrice { get; set;}
    }
}
