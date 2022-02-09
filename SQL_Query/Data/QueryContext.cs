using Microsoft.EntityFrameworkCore;
using SQL_Query.Data.Models;


namespace SQL_Query.Data
{
    public class QueryContext:DbContext
    {
        public QueryContext(){}
        
        public QueryContext(DbContextOptions options):base(options){}

        public virtual DbSet<Catigory> Catigories { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<ProductCategory> ProductCategories { get; set; }
        
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(@"Server=.;Database=SQLQuery;Integrated Security=True;");
            }

            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
             
            modelBuilder.Entity<ProductCategory>(entity => { entity.HasKey(sc => new {sc.ProductId, sc.CatigoryId}); });
        }
        
    }
}