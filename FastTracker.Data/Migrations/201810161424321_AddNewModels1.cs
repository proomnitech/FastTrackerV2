namespace FastTracker.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddNewModels1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Providers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        LastName = c.String(),
                        Notes = c.String(),
                        Clinic_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Clinics", t => t.Clinic_Id)
                .Index(t => t.Clinic_Id);
            
            CreateTable(
                "dbo.Licenses",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Description = c.String(),
                        Abbreviation = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.LicenseProviders",
                c => new
                    {
                        License_Id = c.Int(nullable: false),
                        Provider_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.License_Id, t.Provider_Id })
                .ForeignKey("dbo.Licenses", t => t.License_Id, cascadeDelete: true)
                .ForeignKey("dbo.Providers", t => t.Provider_Id, cascadeDelete: true)
                .Index(t => t.License_Id)
                .Index(t => t.Provider_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.LicenseProviders", "Provider_Id", "dbo.Providers");
            DropForeignKey("dbo.LicenseProviders", "License_Id", "dbo.Licenses");
            DropForeignKey("dbo.Providers", "Clinic_Id", "dbo.Clinics");
            DropIndex("dbo.LicenseProviders", new[] { "Provider_Id" });
            DropIndex("dbo.LicenseProviders", new[] { "License_Id" });
            DropIndex("dbo.Providers", new[] { "Clinic_Id" });
            DropTable("dbo.LicenseProviders");
            DropTable("dbo.Licenses");
            DropTable("dbo.Providers");
        }
    }
}
