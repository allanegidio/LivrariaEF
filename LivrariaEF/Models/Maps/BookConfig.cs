using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LivrariaEF.Models.Maps
{
    public class BookConfig : EntityTypeConfiguration<Book>
    {
        public BookConfig()
        {
            HasKey(x => x.BookId);
            Property(x => x.BookId).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(x => x.Name)
                .IsRequired()
                .HasMaxLength(60);

            HasRequired(x => x.Shelf)
                .WithMany(x => x.Books)
                .HasForeignKey(x => x.ShelfId);
        }
    }
}
