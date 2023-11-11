using System.Collections.Generic;

namespace Final_244.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string ISBN { get; set; }
        public DateTime PublishedDate { get; set; }
        public int CopiesAvalible { get; set; }
        public int CopiesTotal { get; set; }
        //maybe add a isCirculating or not? 

        //will have associations to multiple checkouts by members
        public IEnumerable<CheckOut> checkOut { get; set; }
    }
}
