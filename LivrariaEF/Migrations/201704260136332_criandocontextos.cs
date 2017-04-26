namespace LivrariaEF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class criandocontextos : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.AuthorBooks", "AuthorId", "dbo.Authors");
            DropForeignKey("dbo.AuthorBooks", "BookId", "dbo.Books");
            DropForeignKey("dbo.Books", "ShelfId", "dbo.Shelves");
            AddForeignKey("dbo.AuthorBooks", "AuthorId", "dbo.Authors", "AuthorId");
            AddForeignKey("dbo.AuthorBooks", "BookId", "dbo.Books", "BookId");
            AddForeignKey("dbo.Books", "ShelfId", "dbo.Shelves", "ShelfId");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Books", "ShelfId", "dbo.Shelves");
            DropForeignKey("dbo.AuthorBooks", "BookId", "dbo.Books");
            DropForeignKey("dbo.AuthorBooks", "AuthorId", "dbo.Authors");
            AddForeignKey("dbo.Books", "ShelfId", "dbo.Shelves", "ShelfId", cascadeDelete: true);
            AddForeignKey("dbo.AuthorBooks", "BookId", "dbo.Books", "BookId", cascadeDelete: true);
            AddForeignKey("dbo.AuthorBooks", "AuthorId", "dbo.Authors", "AuthorId", cascadeDelete: true);
        }
    }
}
