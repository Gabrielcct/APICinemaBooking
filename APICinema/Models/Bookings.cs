using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace APICinema.Models
{
    public class Bookings
    {
        [Key]
        public int BookingId { get; set; }

        public int ShowId { get; set; }
        
        [ForeignKey("ShowId")]
        public Show? Show { get; set; } // Navigation property for the Show entity

        [ForeignKey("TicketId")]
        public int TicketId { get; set; }
        public TicketType? Ticket { get; set; } // Navigation property for the Ticket entity

        [Range(1, 100, ErrorMessage = "Seat number must be between 1 and 100.")]
        public int SeatNumber { get; set; }

       

    }
}
