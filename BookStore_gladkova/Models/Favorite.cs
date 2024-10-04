using System.ComponentModel.DataAnnotations;

namespace BookStore.Models
{
    public record class Favorite
    {
        [Key]
        public int ID_fav {  get; set; }
        public int? user_ID { get; set; }
        public int book_ID { get; set; }
    }
}
