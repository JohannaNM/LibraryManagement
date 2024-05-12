using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LibraryManagement.Models
{
    public class BorrowHistory
    {
        [Key]
        public int BorrowHistoryId { get; set; }
        
        [Required]
        [ForeignKey("Book")]
        [Display(Name ="Book")]
        public int FkBookId { get; set; }
        public Book? Book { get; set; }

        [Required]
        [ForeignKey("Customer")]
        [Display(Name ="Customer")]
        public int FkCustomerId { get; set; }
        public Customer? Customer { get; set; }

        [Display(Name = "Borrow Date")]
        [DataType(DataType.Date)]
        public DateTime BorrowDate { get; set; }
        [Display(Name ="Due Date")]
        [DataType(DataType.Date)]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public DateTime ReturnDueDate => BorrowDate.AddMonths(1);
        //public DateTime? EndOfLoan 
        //{
        //    get
        //    {
        //        if(BorrowDate != default(DateTime))
        //        {
        //            DateTime oneMonthLater = BorrowDate.AddMonths(1);
        //            return oneMonthLater;
        //        }
        //        else
        //        {
        //            return null;
        //        }
        //    }
        //}
        [DataType(DataType.Date)]
        [Display(Name = "Returned")]
        public DateTime? ActualReturnDate { get; set; }

        //private DateTime _Returned = DateTime.Now;
        //[DataType(DataType.Date)]
        //public DateTime Returned { get { return _Returned; } set { _Returned = value; } }
    }
}
