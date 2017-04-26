using LivrariaEF.Models;
using LivrariaEF.Models.Maps;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LivrariaEF.Repositories
{
    public partial class DatabaseContext : DbContext
    {
        public DatabaseContext()
            : base("LivrariaEFConnectionString")
        {
            Configuration.LazyLoadingEnabled = false;
            Configuration.ProxyCreationEnabled = false;
            Database.Log = (sql) => Debug.Write(sql);
        }

        public virtual DbSet<Book> Books { get; set; }
        public virtual DbSet<Shelf> Shelfs { get; set; }
        public virtual DbSet<Author> Authors { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();

            modelBuilder.Configurations.Add(new BookConfig());
            modelBuilder.Configurations.Add(new AuthorConfig());
            modelBuilder.Configurations.Add(new ShelfConfig());
        }
    }
}
