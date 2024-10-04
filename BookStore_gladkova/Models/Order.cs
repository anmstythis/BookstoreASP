using System.ComponentModel.DataAnnotations;

namespace BookStore.Models
{
    public record class Order
    {
        [Key]
        public int ID_order { get; set; }
        public int? user_ID { get; set; }
        public int book_ID { get; set; }
        public int Book_Amount { get; set; }
        public DateTime? Order_Date { get; set; }
    }
}
