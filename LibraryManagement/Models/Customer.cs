using System.ComponentModel.DataAnnotations;

namespace LibraryManagement.Models
{
    public class Customer
    {
        [Key]
        public int CustomerId { get; set; }
        [Required]
        [MinLength(5)]
        [MaxLength(35)]
        public string CustomerName { get; set; }
        [Phone]
        [MinLength(10)]
        [MaxLength(15)]
        public string CustomerPhone { get; set; }
        [EmailAddress]
        [MinLength(11)]
        [MaxLength(30)]
        [Required]
        public string CustomerEmail { get; set; }

        public virtual ICollection<BorrowHistory>? BorrowHistories { get; set; }
    }
}
