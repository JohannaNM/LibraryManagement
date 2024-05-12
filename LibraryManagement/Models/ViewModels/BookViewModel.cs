namespace LibraryManagement.Models.ViewModels
{
    public class BookViewModel
    {
        public int BookId { get; set; }
        public string Title { get; set; }
        public string ISBN { get; set; }
        public string Author { get; set; }
        public string Publisher { get; set; }
        public bool IsAvailable { get; set; }
        public int BorrowHistoryId { get; set; }
    }
}
