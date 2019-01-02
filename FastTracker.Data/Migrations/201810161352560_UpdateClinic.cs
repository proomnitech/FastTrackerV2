namespace FastTracker.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateClinic : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Locations", newName: "Clinics");
            AddColumn("dbo.Clinics", "User_Id", c => c.Int());
            CreateIndex("dbo.Clinics", "User_Id");
            AddForeignKey("dbo.Clinics", "User_Id", "dbo.Users", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Clinics", "User_Id", "dbo.Users");
            DropIndex("dbo.Clinics", new[] { "User_Id" });
            DropColumn("dbo.Clinics", "User_Id");
            RenameTable(name: "dbo.Clinics", newName: "Locations");
        }
    }
}
