using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebStore.Core.Domain;

namespace WebStore.Data.Mapping
{
    public class ProductsMap : EntityTypeConfiguration<Product>
    {
        public ProductsMap()
        {
            this.ToTable("Products");
            this.HasKey(a => a.Id);
            this.Property(p => p.Name).IsRequired().HasMaxLength(400);
            this.Property(p => p.MetaKeywords).HasMaxLength(400);
            this.Property(p => p.Description).IsRequired();
            this.Property(p => p.Description).IsRequired();
            this.Property(p => p.Price).HasPrecision(18, 4);
        }
     }
}
