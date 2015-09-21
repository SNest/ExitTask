namespace ExitTask.Infrastructure.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class M1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Countries", "Capital", c => c.String(nullable: false));
            AddColumn("dbo.Countries", "Population", c => c.String());
            AddColumn("dbo.Countries", "Geography", c => c.String());
            AddColumn("dbo.Countries", "Climate", c => c.String());
            AddColumn("dbo.Countries", "Language", c => c.String());
            AddColumn("dbo.Countries", "Worship", c => c.String());
            AddColumn("dbo.Countries", "PoliticalStructure", c => c.String());
            AddColumn("dbo.Countries", "TimeZone", c => c.String());
            AddColumn("dbo.Countries", "Currency", c => c.String());
            DropColumn("dbo.Countries", "Description");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Countries", "Description", c => c.String(nullable: false));
            DropColumn("dbo.Countries", "Currency");
            DropColumn("dbo.Countries", "TimeZone");
            DropColumn("dbo.Countries", "PoliticalStructure");
            DropColumn("dbo.Countries", "Worship");
            DropColumn("dbo.Countries", "Language");
            DropColumn("dbo.Countries", "Climate");
            DropColumn("dbo.Countries", "Geography");
            DropColumn("dbo.Countries", "Population");
            DropColumn("dbo.Countries", "Capital");
        }
    }
}
