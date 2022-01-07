namespace D05_EF6_Migrations_DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _02_Livro_NovoCampoTipo : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Livro", "Tipo", c => c.String(nullable: false, maxLength: 100));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Livro", "Tipo");
        }
    }
}
