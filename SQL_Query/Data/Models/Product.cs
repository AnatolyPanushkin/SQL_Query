using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SQL_Query.Data.Models
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }
        
        [Required]
        public string Name { get; set; }
    }
}