using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SQL_Query.Data.Models
{
    public class Catigory
    {
        [Key]
        public int CatigoryId { get; set; }
        
        [Required]
        public string Name { get; set; }
    }
}