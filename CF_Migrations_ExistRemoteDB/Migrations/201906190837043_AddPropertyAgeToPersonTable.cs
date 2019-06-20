namespace CF_Migrations_ExistRemoteDB.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddPropertyAgeToPersonTable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Person", "Age", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Person", "Age");
        }
    }
}
