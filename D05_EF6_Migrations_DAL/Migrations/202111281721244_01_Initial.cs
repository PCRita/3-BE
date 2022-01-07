namespace D05_EF6_Migrations_DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _01_Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Editora",
                c => new
                    {
                        EditoraID = c.Int(nullable: false, identity: true),
                        EditoraNome = c.String(nullable: false, maxLength: 100),
                    })
                .PrimaryKey(t => t.EditoraID);
            
            CreateTable(
                "dbo.Livro",
                c => new
                    {
                        LivroID = c.Int(nullable: false, identity: true),
                        ISBN = c.String(nullable: false, maxLength: 9),
                        Titulo = c.String(nullable: false, maxLength: 100),
                        EditoraID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.LivroID)
                .ForeignKey("dbo.Editora", t => t.EditoraID, cascadeDelete: true)
                .Index(t => t.EditoraID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Livro", "EditoraID", "dbo.Editora");
            DropIndex("dbo.Livro", new[] { "EditoraID" });
            DropTable("dbo.Livro");
            DropTable("dbo.Editora");
        }
    }
}
