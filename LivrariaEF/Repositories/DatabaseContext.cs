using LivrariaEF.Models;
using LivrariaEF.Models.Maps;
using System;
using System.Collections.Generic;
using System.Data.Entity;
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

            Database.Log = (sql) => Debug.Write(sql);
        }

        public virtual DbSet<Book> Books { get; set; }
        public virtual DbSet<Shelf> Shelfs { get; set; }
        public virtual DbSet<Author> Authors { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new BookConfig());
            modelBuilder.Configurations.Add(new AuthorConfig());
            modelBuilder.Configurations.Add(new ShelfConfig());
        }
    }
}
