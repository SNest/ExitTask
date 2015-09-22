namespace ExitTask.Infrastructure.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class M2 : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.Tours", name: "FinishCity_Id", newName: "FinishCityId");
            RenameIndex(table: "dbo.Tours", name: "IX_FinishCity_Id", newName: "IX_FinishCityId");
            DropColumn("dbo.Tours", "EndCityId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Tours", "EndCityId", c => c.Int());
            RenameIndex(table: "dbo.Tours", name: "IX_FinishCityId", newName: "IX_FinishCity_Id");
            RenameColumn(table: "dbo.Tours", name: "FinishCityId", newName: "FinishCity_Id");
        }
    }
}
