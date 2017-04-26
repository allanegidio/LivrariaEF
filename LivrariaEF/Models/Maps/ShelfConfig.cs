using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LivrariaEF.Models.Maps
{
    public class ShelfConfig : EntityTypeConfiguration<Shelf>
    {
        public ShelfConfig()
        {
            HasKey(x => x.ShelfId);
            Property(x => x.ShelfId).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(x => x.Number);

        }
    }
}
