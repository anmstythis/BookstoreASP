using System.ComponentModel.DataAnnotations;

namespace BookStore.Models
{
    public record class User
    {
        [Key]
        public int ID_user { get; set; }
        public string? Surname_User { get; set; }
        public string? Name_User { get; set; }
        public string? Patronymic_User { get; set; }
        public string? Email_User { get; set; }
    }
}
