namespace pharmsquare_prototype.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial_drugs : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Drugs",
                c => new
                {
                    ID = c.Int(nullable: false, identity: true),
                    Name = c.String(),
                    Price = c.Double(nullable: false),
                    ImageURL = c.String()
                })
                .PrimaryKey(t => t.ID);
        }
        
        public override void Down()
        {
            DropTable("dbo.Drugs");
        }
    }
}
