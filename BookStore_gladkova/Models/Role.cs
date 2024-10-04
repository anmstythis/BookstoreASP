using System.ComponentModel.DataAnnotations;

namespace BookStore.Models
{
    public record class Role
    {
        [Key]
        public int ID_role { get; set; }
        public string? Name_Role { get; set; }
    }
}
