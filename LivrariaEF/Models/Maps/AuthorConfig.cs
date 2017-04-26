using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LivrariaEF.Models.Maps
{
    public class AuthorConfig : EntityTypeConfiguration<Author>
    {
        public AuthorConfig()
        {
            HasKey(x => x.AuthorId);
            Property(x => x.AuthorId).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(t => t.Name)
               .IsRequired()
               .HasMaxLength(60);

            HasMany(x => x.Books)
                .WithMany(x => x.Authors)
                .Map(x =>
                {
                    x.ToTable("AuthorBooks");
                    x.MapLeftKey("AuthorId");
                    x.MapRightKey("BookId");
                });

        }
    }
}
