using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace SQL_Query.Data.Models
{
    public class ProductCategory
    {
        [ForeignKey("Product")]
        public int ProductId { get; set; }
        public virtual Product Product { get; set; }
        
        [ForeignKey("Catigory")]
        public int CatigoryId { get; set; }
        public virtual Catigory Catigory { get; set; }
        
    }
}