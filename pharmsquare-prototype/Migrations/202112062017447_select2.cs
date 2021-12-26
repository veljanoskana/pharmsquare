namespace pharmsquare_prototype.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class select2 : DbMigration
    {
        public override void Up()
        {
            Sql("SELECT ID, Longitude, Latitude, Name, WorkingHours FROM Pharmacies WHERE Name IS NOT NULL");
        }
        
        public override void Down()
        {
            Sql("SELECT ID, Longitude, Latitude, Name, WorkingHours FROM Pharmacies WHERE Name IS NOT NULL");
        }
    }
}
