namespace LivrariaEF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial_Database3 : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.AuthorBooks", name: "BookId", newName: "__mig_tmp__0");
            RenameColumn(table: "dbo.AuthorBooks", name: "AuthorId", newName: "BookId");
            RenameColumn(table: "dbo.AuthorBooks", name: "__mig_tmp__0", newName: "AuthorId");
            RenameIndex(table: "dbo.AuthorBooks", name: "IX_BookId", newName: "__mig_tmp__0");
            RenameIndex(table: "dbo.AuthorBooks", name: "IX_AuthorId", newName: "IX_BookId");
            RenameIndex(table: "dbo.AuthorBooks", name: "__mig_tmp__0", newName: "IX_AuthorId");
        }
        
        public override void Down()
        {
            RenameIndex(table: "dbo.AuthorBooks", name: "IX_AuthorId", newName: "__mig_tmp__0");
            RenameIndex(table: "dbo.AuthorBooks", name: "IX_BookId", newName: "IX_AuthorId");
            RenameIndex(table: "dbo.AuthorBooks", name: "__mig_tmp__0", newName: "IX_BookId");
            RenameColumn(table: "dbo.AuthorBooks", name: "AuthorId", newName: "__mig_tmp__0");
            RenameColumn(table: "dbo.AuthorBooks", name: "BookId", newName: "AuthorId");
            RenameColumn(table: "dbo.AuthorBooks", name: "__mig_tmp__0", newName: "BookId");
        }
    }
}
