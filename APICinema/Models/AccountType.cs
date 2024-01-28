using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace APICinema.Models
{
    public class AccountType
    {
        [Key]
        public int AccountId { get; set; }
        
        [Column(TypeName = "nvarchar(100)")]
        public string AccountName { get; set; } = "";

    }
}
