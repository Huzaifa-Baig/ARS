namespace ARS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Admin_Login",
                c => new
                    {
                        AdminId = c.Int(nullable: false, identity: true),
                        AdminName = c.String(nullable: false, maxLength: 20),
                        AdminPassword = c.String(nullable: false, maxLength: 20),
                    })
                .PrimaryKey(t => t.AdminId);
            
            CreateTable(
                "dbo.AirlinePlaneInfoes",
                c => new
                    {
                        PlaneId = c.Int(nullable: false, identity: true),
                        PlaneName = c.String(nullable: false, maxLength: 30),
                        PlaneSeatingCapacity = c.Int(nullable: false),
                        PlaneSeatingPrice = c.Single(nullable: false),
                    })
                .PrimaryKey(t => t.PlaneId);
            
            CreateTable(
                "dbo.Plane_Booking",
                c => new
                    {
                        BookingID = c.Int(nullable: false, identity: true),
                        DepartingCity = c.String(nullable: false, maxLength: 40),
                        Destination = c.String(nullable: false, maxLength: 40),
                        DepartingDate = c.DateTime(nullable: false),
                        DepartingTime = c.DateTime(nullable: false),
                        PlaneId = c.Int(nullable: false),
                        PlaneSeatType = c.String(maxLength: 30),
                    })
                .PrimaryKey(t => t.BookingID)
                .ForeignKey("dbo.AirlinePlaneInfoes", t => t.PlaneId, cascadeDelete: true)
                .Index(t => t.PlaneId);
            
            CreateTable(
                "dbo.User_Accounts",
                c => new
                    {
                        UserId = c.Int(nullable: false, identity: true),
                        UserFirstName = c.String(nullable: false, maxLength: 40),
                        UserLastName = c.String(nullable: false, maxLength: 40),
                        UserEmail = c.String(nullable: false),
                        UserPassword = c.String(nullable: false, maxLength: 20),
                        UserConfirmPassword = c.String(maxLength: 20),
                        UserAge = c.Int(nullable: false),
                        UserPhoneNumber = c.String(nullable: false, maxLength: 11),
                        UserNIC = c.String(nullable: false, maxLength: 13),
                    })
                .PrimaryKey(t => t.UserId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Plane_Booking", "PlaneId", "dbo.AirlinePlaneInfoes");
            DropIndex("dbo.Plane_Booking", new[] { "PlaneId" });
            DropTable("dbo.User_Accounts");
            DropTable("dbo.Plane_Booking");
            DropTable("dbo.AirlinePlaneInfoes");
            DropTable("dbo.Admin_Login");
        }
    }
}
