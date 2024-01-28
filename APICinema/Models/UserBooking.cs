using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace APICinema.Models
{
    public class UserBooking
    {
        [Key]
        public int UserBookingId { get; set; }

        [ForeignKey("UserId")]
        public int UserId { get; set; }
        public User? User { get; set; } // Navigation property for the User entity

        [ForeignKey("BookingId")]
        public int BookingId { get; set; }
        public Bookings? Booking { get; set; } // Navigation property for the Booking entity
    }
}
