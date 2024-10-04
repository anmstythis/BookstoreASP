using System.ComponentModel.DataAnnotations;

namespace BookStore.Models
{
    public record class Account
    {
        [Key]
        public int ID_account { get; set; }
        public string? Nickname { get; set; }
        public string? Password_acc { get; set; }
        public int? user_ID { get; set; }
        public int role_ID { get; set; }
    }
}
