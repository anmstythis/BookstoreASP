using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookStore.Models
{
    [Table("TypesOfBook")]
    public record class TypeOfBook
    {
        [Key]
        public int ID_type {  get; set; }
        public string? Name_Type { get; set; }
    }
}
