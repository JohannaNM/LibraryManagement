using System.ComponentModel.DataAnnotations;

namespace LibraryManagement.Models
{
    public class Book
    {
        [Key]
        public int BookId { get; set; }
        [Required]
        [MinLength(10)]
        [MaxLength(60)]
        public string Title { get; set; }
        [Required]
        [MinLength(10)]
        [MaxLength(45)]
        public string Author { get; set; }
        [StringLength(20)]
        public string ISBN { get; set; }
        [MinLength(5)]
        [MaxLength(30)]
        public string Publisher { get; set; }

        //public bool IsAvailable { get; set; }

        public virtual ICollection<BorrowHistory>? BorrowHistories { get; set;}
    }
}
