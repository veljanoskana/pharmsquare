namespace pharmsquare_prototype.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class removingAttr : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Pharmacies", "Email");
            DropColumn("dbo.Pharmacies", "Phone");
            DropColumn("dbo.Pharmacies", "URL");
            DropColumn("dbo.Pharmacies", "StreetName");
            DropColumn("dbo.Pharmacies", "StreetNo");
        }
        
        public override void Down()
        {
            
        }
    }
}
