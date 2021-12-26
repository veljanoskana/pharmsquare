namespace pharmsquare_prototype.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class delete_rows : DbMigration
    {
        public override void Up()
        {
            Sql("DELETE FROM Pharmacies WHERE Name = NULL");
        }
        
        public override void Down()
        {
        }
    }
}
