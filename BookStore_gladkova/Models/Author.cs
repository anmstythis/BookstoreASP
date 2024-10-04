using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookStore.Models
{
    [Table("Authors")]
    public record class Author
    {
        [Key]
        public int ID_author {  get; set; }
        public string? Surname_Author { get; set; }
        public string? Name_Author { get; set; }
        public string? Patronymic_Author { get; set; }
        public string? Country { get; set; }
    }
}
