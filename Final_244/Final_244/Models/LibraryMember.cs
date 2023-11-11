namespace Final_244.Models
{
    public class LibraryMember
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public DateTime RegistrationDate { get; set; }
        public bool Active { get; set; }
        //will have associations to member can check out multiple books
        public IEnumerable<CheckOut> Checkouts { get; set; }
    }
}
