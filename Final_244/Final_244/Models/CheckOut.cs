using System.Security.Cryptography.X509Certificates;

namespace Final_244.Models
{
    public class CheckOut
    {
        public int Id { get; set; }
        public DateTime CheckedOutDate { get; set; }
        public DateTime DueDate { get; set; }
        public DateTime? ReturnedDate { get; set; }
        public int BookId { get; set; }
        public int LibraryMemberId { get; set; }
        //associations to one book and one member
        public Book book { get; set; }
        public LibraryMember Member { get; set; }
    }
}
