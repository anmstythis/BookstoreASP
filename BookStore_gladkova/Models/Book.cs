using BookStore.Models;
using Microsoft.EntityFrameworkCore.Scaffolding.Metadata;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookStore_gladkova.Models
{
    public record class Book
    {
        [Key]
        public int ID_book { get; set; }
        public string Title_Book { get; set; }
        public string Description_Book { get; set; }
        public string Image_Link { get; set; }
        public decimal Price_Book { get; set; }
        public DateTime? Publish_Date { get; set; }

        [ForeignKey("Author")]
        public int? author_ID { get; set; }
        public Author Author { get; set; }

        [ForeignKey("TypeOfBook")]
        public int? type_ID { get; set; }
        public TypeOfBook TypeOfBook { get; set; }

        public Book() { }
    }
}
