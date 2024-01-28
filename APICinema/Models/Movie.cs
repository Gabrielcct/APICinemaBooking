using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace APICinema.Models
{
    public class Movie
    {
        [Key]
        public string Name { get; set; } = "";
        
        [Column(TypeName = "nvarchar(100)")]
        public string Description { get; set; } = "";

        public byte[]? Picture { get; set; } // Store image as byte array

        // Method to convert image to Base64 string
        public string PictureBase64 => Picture != null ? Convert.ToBase64String(Picture) : "";

        // Method to convert Base64 string to image byte array
        public void SetPictureFromBase64(string base64String)
        {
            Picture = Convert.FromBase64String(base64String);
        }
    }
}
