namespace FastTracker.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddNewModels21 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Availabilities",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        IsApproved = c.Boolean(nullable: false),
                        LastUpdatedUtc = c.DateTime(nullable: false),
                        AvailabilityTypes_Id = c.Int(),
                        Clinic_Id = c.Int(),
                        Service_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AvailabilityTypes", t => t.AvailabilityTypes_Id)
                .ForeignKey("dbo.Clinics", t => t.Clinic_Id)
                .ForeignKey("dbo.Services", t => t.Service_Id)
                .Index(t => t.AvailabilityTypes_Id)
                .Index(t => t.Clinic_Id)
                .Index(t => t.Service_Id);
            
            CreateTable(
                "dbo.AvailabilityTypes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Description = c.String(),
                        AvailabilityInWeeks = c.Int(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Services",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Description = c.String(),
                        Abbreviation = c.String(),
                        ServiceCategory = c.String(maxLength: 255),
                        Definition = c.String(),
                        EligibleRecipients = c.String(),
                        CoveredServices = c.String(),
                        EligibleProviders = c.String(),
                        DetailsPage = c.String(),
                        DetailsLink = c.String(),
                        RequiresApproval = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.InsurancePlans",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Plan = c.String(),
                        Website = c.String(),
                        Phone = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Clinics", "Service_Id", c => c.Int());
            AddColumn("dbo.Clinics", "InsurancePlan_Id", c => c.Int());
            CreateIndex("dbo.Clinics", "Service_Id");
            CreateIndex("dbo.Clinics", "InsurancePlan_Id");
            AddForeignKey("dbo.Clinics", "Service_Id", "dbo.Services", "Id");
            AddForeignKey("dbo.Clinics", "InsurancePlan_Id", "dbo.InsurancePlans", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Clinics", "InsurancePlan_Id", "dbo.InsurancePlans");
            DropForeignKey("dbo.Clinics", "Service_Id", "dbo.Services");
            DropForeignKey("dbo.Availabilities", "Service_Id", "dbo.Services");
            DropForeignKey("dbo.Availabilities", "Clinic_Id", "dbo.Clinics");
            DropForeignKey("dbo.Availabilities", "AvailabilityTypes_Id", "dbo.AvailabilityTypes");
            DropIndex("dbo.Clinics", new[] { "InsurancePlan_Id" });
            DropIndex("dbo.Clinics", new[] { "Service_Id" });
            DropIndex("dbo.Availabilities", new[] { "Service_Id" });
            DropIndex("dbo.Availabilities", new[] { "Clinic_Id" });
            DropIndex("dbo.Availabilities", new[] { "AvailabilityTypes_Id" });
            DropColumn("dbo.Clinics", "InsurancePlan_Id");
            DropColumn("dbo.Clinics", "Service_Id");
            DropTable("dbo.InsurancePlans");
            DropTable("dbo.Services");
            DropTable("dbo.AvailabilityTypes");
            DropTable("dbo.Availabilities");
        }
    }
}
