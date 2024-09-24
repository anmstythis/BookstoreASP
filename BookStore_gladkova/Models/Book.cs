namespace BookStore_gladkova.Models
{
    public record class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Author { get; set; }

        public Book() { }
    }
}
