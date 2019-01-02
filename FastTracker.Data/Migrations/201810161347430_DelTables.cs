namespace FastTracker.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DelTables : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Locations", "Organization_Id", "dbo.Organizations");
            DropForeignKey("dbo.UserOrganizations", "User_Id", "dbo.Users");
            DropForeignKey("dbo.UserOrganizations", "Organization_Id", "dbo.Organizations");
            DropIndex("dbo.Locations", new[] { "Organization_Id" });
            DropIndex("dbo.UserOrganizations", new[] { "User_Id" });
            DropIndex("dbo.UserOrganizations", new[] { "Organization_Id" });
            DropColumn("dbo.Locations", "Organization_Id");
            DropTable("dbo.Organizations");
            DropTable("dbo.OrgTypes");
            DropTable("dbo.UserOrganizations");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.UserOrganizations",
                c => new
                    {
                        User_Id = c.Int(nullable: false),
                        Organization_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.User_Id, t.Organization_Id });
            
            CreateTable(
                "dbo.OrgTypes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        OrgTypeName = c.String(),
                        OrgEntityLabel = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Organizations",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(maxLength: 1024),
                        Website = c.String(),
                        Notes = c.String(),
                        OrgType = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Locations", "Organization_Id", c => c.Int());
            CreateIndex("dbo.UserOrganizations", "Organization_Id");
            CreateIndex("dbo.UserOrganizations", "User_Id");
            CreateIndex("dbo.Locations", "Organization_Id");
            AddForeignKey("dbo.UserOrganizations", "Organization_Id", "dbo.Organizations", "Id", cascadeDelete: true);
            AddForeignKey("dbo.UserOrganizations", "User_Id", "dbo.Users", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Locations", "Organization_Id", "dbo.Organizations", "Id");
        }
    }
}
