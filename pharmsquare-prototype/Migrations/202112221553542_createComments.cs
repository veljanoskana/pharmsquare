namespace pharmsquare_prototype.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class createComments : DbMigration
    {
        public override void Up()
        {
            CreateTable(
               "dbo.Comments",
               c => new
               {
                   ID = c.Int(nullable: false, identity: true),
                   Text = c.String(),
                   Author = c.String(),
                   TimeStamp = c.DateTime(),
                   PharmacyID = c.Int(nullable: false),
               })
               .PrimaryKey(t => t.ID);
        }

        public override void Down()
        {
            DropTable("dbo.Comments");
        }
    }
}
