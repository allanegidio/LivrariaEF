namespace LivrariaEF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Authors",
                c => new
                    {
                        AuthorId = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 60),
                    })
                .PrimaryKey(t => t.AuthorId);
            
            CreateTable(
                "dbo.Books",
                c => new
                    {
                        BookId = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 60),
                        ShelfId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.BookId)
                .ForeignKey("dbo.Shelves", t => t.ShelfId, cascadeDelete: true)
                .Index(t => t.ShelfId);
            
            CreateTable(
                "dbo.Shelves",
                c => new
                    {
                        ShelfId = c.Int(nullable: false, identity: true),
                        Number = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ShelfId);
            
            CreateTable(
                "dbo.AuthorBooks",
                c => new
                    {
                        BookId = c.Int(nullable: false),
                        AuthorId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.BookId, t.AuthorId })
                .ForeignKey("dbo.Authors", t => t.BookId, cascadeDelete: true)
                .ForeignKey("dbo.Books", t => t.AuthorId, cascadeDelete: true)
                .Index(t => t.BookId)
                .Index(t => t.AuthorId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.AuthorBooks", "AuthorId", "dbo.Books");
            DropForeignKey("dbo.AuthorBooks", "BookId", "dbo.Authors");
            DropForeignKey("dbo.Books", "ShelfId", "dbo.Shelves");
            DropIndex("dbo.AuthorBooks", new[] { "AuthorId" });
            DropIndex("dbo.AuthorBooks", new[] { "BookId" });
            DropIndex("dbo.Books", new[] { "ShelfId" });
            DropTable("dbo.AuthorBooks");
            DropTable("dbo.Shelves");
            DropTable("dbo.Books");
            DropTable("dbo.Authors");
        }
    }
}
