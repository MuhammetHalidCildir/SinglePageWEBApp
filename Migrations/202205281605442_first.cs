namespace SinglePageWebApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class first : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Icons",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Header = c.String(),
                        Paragraph = c.String(),
                        IconType = c.String(),
                        Url = c.String(),
                        Section_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Sections", t => t.Section_Id)
                .Index(t => t.Section_Id);
            
            CreateTable(
                "dbo.Sections",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Header = c.String(),
                        Paragraph = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Icons", "Section_Id", "dbo.Sections");
            DropIndex("dbo.Icons", new[] { "Section_Id" });
            DropTable("dbo.Sections");
            DropTable("dbo.Icons");
        }
    }
}
