namespace ExitTask.Infrastructure.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class M1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Tours",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Description = c.String(),
                        Type = c.Int(nullable: false),
                        BeginDepartureTime = c.DateTime(nullable: false),
                        BeginArrivalTime = c.DateTime(nullable: false),
                        EndDepartureTime = c.DateTime(nullable: false),
                        EndArrivalTime = c.DateTime(nullable: false),
                        PersonNumber = c.Int(nullable: false),
                        Feeding = c.Int(nullable: false),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        State = c.Int(nullable: false),
                        CustomerId = c.Int(),
                        StartCityId = c.Int(),
                        EndCityId = c.Int(),
                        HotelId = c.Int(),
                        Image = c.Binary(),
                        FinishCity_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.CustomerId)
                .ForeignKey("dbo.Cities", t => t.FinishCity_Id)
                .ForeignKey("dbo.Hotels", t => t.HotelId)
                .ForeignKey("dbo.Cities", t => t.StartCityId)
                .Index(t => t.CustomerId)
                .Index(t => t.StartCityId)
                .Index(t => t.HotelId)
                .Index(t => t.FinishCity_Id);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        LastName = c.String(),
                        Email = c.String(),
                        Password = c.String(),
                        Sex = c.Int(nullable: false),
                        Role = c.Int(nullable: false),
                        State = c.Int(nullable: false),
                        CityId = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Cities", t => t.CityId)
                .Index(t => t.CityId);
            
            CreateTable(
                "dbo.Cities",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Description = c.String(),
                        CountryId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Countries", t => t.CountryId, cascadeDelete: true)
                .Index(t => t.CountryId);
            
            CreateTable(
                "dbo.Countries",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Capital = c.String(),
                        Population = c.String(),
                        Geography = c.String(),
                        Climate = c.String(),
                        Language = c.String(),
                        Worship = c.String(),
                        PoliticalStructure = c.String(),
                        TimeZone = c.String(),
                        Currency = c.String(),
                        Mainland = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Hotels",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Description = c.String(),
                        Type = c.Int(nullable: false),
                        Stars = c.Int(nullable: false),
                        CityId = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Cities", t => t.CityId)
                .Index(t => t.CityId);
            
            CreateTable(
                "dbo.Comments",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Text = c.String(),
                        AuthorId = c.Int(),
                        TourId = c.Int(),
                        Date = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.AuthorId)
                .ForeignKey("dbo.Tours", t => t.TourId)
                .Index(t => t.AuthorId)
                .Index(t => t.TourId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Comments", "TourId", "dbo.Tours");
            DropForeignKey("dbo.Comments", "AuthorId", "dbo.Users");
            DropForeignKey("dbo.Tours", "StartCityId", "dbo.Cities");
            DropForeignKey("dbo.Tours", "HotelId", "dbo.Hotels");
            DropForeignKey("dbo.Tours", "FinishCity_Id", "dbo.Cities");
            DropForeignKey("dbo.Tours", "CustomerId", "dbo.Users");
            DropForeignKey("dbo.Users", "CityId", "dbo.Cities");
            DropForeignKey("dbo.Hotels", "CityId", "dbo.Cities");
            DropForeignKey("dbo.Cities", "CountryId", "dbo.Countries");
            DropIndex("dbo.Comments", new[] { "TourId" });
            DropIndex("dbo.Comments", new[] { "AuthorId" });
            DropIndex("dbo.Hotels", new[] { "CityId" });
            DropIndex("dbo.Cities", new[] { "CountryId" });
            DropIndex("dbo.Users", new[] { "CityId" });
            DropIndex("dbo.Tours", new[] { "FinishCity_Id" });
            DropIndex("dbo.Tours", new[] { "HotelId" });
            DropIndex("dbo.Tours", new[] { "StartCityId" });
            DropIndex("dbo.Tours", new[] { "CustomerId" });
            DropTable("dbo.Comments");
            DropTable("dbo.Hotels");
            DropTable("dbo.Countries");
            DropTable("dbo.Cities");
            DropTable("dbo.Users");
            DropTable("dbo.Tours");
        }
    }
}
