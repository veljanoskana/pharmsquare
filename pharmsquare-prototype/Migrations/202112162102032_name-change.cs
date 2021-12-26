namespace pharmsquare_prototype.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class namechange : DbMigration
    {
        public override void Up()
        {
            Sql("ALTER TABLE Drugs ALTER COLUMN Name nvarchar(MAX)");
        }
        
        public override void Down()
        {
            Sql("ALTER TABLE Drugs ALTER COLUMN Name nvarchar(MAX)");
        }
    }
}
