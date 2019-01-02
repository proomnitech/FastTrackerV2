namespace FastTracker.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddNewModels3 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ZipGeocodes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Zip = c.String(maxLength: 10),
                        Latitude = c.Double(nullable: false),
                        Longitude = c.Double(nullable: false),
                        CreateDateUtc = c.DateTime(nullable: false),
                        UpdateDateUtc = c.DateTime(nullable: false),
                        CreateUserId = c.Int(nullable: false),
                        UpdateUserId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Availabilities", "CreateDateUtc", c => c.DateTime(nullable: false));
            AddColumn("dbo.Availabilities", "UpdateDateUtc", c => c.DateTime(nullable: false));
            AddColumn("dbo.Availabilities", "CreateUserId", c => c.Int(nullable: false));
            AddColumn("dbo.Availabilities", "UpdateUserId", c => c.Int(nullable: false));
            AddColumn("dbo.AvailabilityTypes", "CreateDateUtc", c => c.DateTime(nullable: false));
            AddColumn("dbo.AvailabilityTypes", "UpdateDateUtc", c => c.DateTime(nullable: false));
            AddColumn("dbo.AvailabilityTypes", "CreateUserId", c => c.Int(nullable: false));
            AddColumn("dbo.AvailabilityTypes", "UpdateUserId", c => c.Int(nullable: false));
            AddColumn("dbo.Clinics", "CreateDateUtc", c => c.DateTime(nullable: false));
            AddColumn("dbo.Clinics", "UpdateDateUtc", c => c.DateTime(nullable: false));
            AddColumn("dbo.Clinics", "CreateUserId", c => c.Int(nullable: false));
            AddColumn("dbo.Clinics", "UpdateUserId", c => c.Int(nullable: false));
            AddColumn("dbo.Providers", "CreateDateUtc", c => c.DateTime(nullable: false));
            AddColumn("dbo.Providers", "UpdateDateUtc", c => c.DateTime(nullable: false));
            AddColumn("dbo.Providers", "CreateUserId", c => c.Int(nullable: false));
            AddColumn("dbo.Providers", "UpdateUserId", c => c.Int(nullable: false));
            AddColumn("dbo.Licenses", "CreateDateUtc", c => c.DateTime(nullable: false));
            AddColumn("dbo.Licenses", "UpdateDateUtc", c => c.DateTime(nullable: false));
            AddColumn("dbo.Licenses", "CreateUserId", c => c.Int(nullable: false));
            AddColumn("dbo.Licenses", "UpdateUserId", c => c.Int(nullable: false));
            AddColumn("dbo.Services", "CreateDateUtc", c => c.DateTime(nullable: false));
            AddColumn("dbo.Services", "UpdateDateUtc", c => c.DateTime(nullable: false));
            AddColumn("dbo.Services", "CreateUserId", c => c.Int(nullable: false));
            AddColumn("dbo.Services", "UpdateUserId", c => c.Int(nullable: false));
            AddColumn("dbo.InsurancePlans", "CreateDateUtc", c => c.DateTime(nullable: false));
            AddColumn("dbo.InsurancePlans", "UpdateDateUtc", c => c.DateTime(nullable: false));
            AddColumn("dbo.InsurancePlans", "CreateUserId", c => c.Int(nullable: false));
            AddColumn("dbo.InsurancePlans", "UpdateUserId", c => c.Int(nullable: false));
            AddColumn("dbo.Users", "CreateDateUtc", c => c.DateTime(nullable: false));
            AddColumn("dbo.Users", "UpdateDateUtc", c => c.DateTime(nullable: false));
            AddColumn("dbo.Users", "CreateUserId", c => c.Int(nullable: false));
            AddColumn("dbo.Users", "UpdateUserId", c => c.Int(nullable: false));
            DropColumn("dbo.Availabilities", "LastUpdatedUtc");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Availabilities", "LastUpdatedUtc", c => c.DateTime(nullable: false));
            DropColumn("dbo.Users", "UpdateUserId");
            DropColumn("dbo.Users", "CreateUserId");
            DropColumn("dbo.Users", "UpdateDateUtc");
            DropColumn("dbo.Users", "CreateDateUtc");
            DropColumn("dbo.InsurancePlans", "UpdateUserId");
            DropColumn("dbo.InsurancePlans", "CreateUserId");
            DropColumn("dbo.InsurancePlans", "UpdateDateUtc");
            DropColumn("dbo.InsurancePlans", "CreateDateUtc");
            DropColumn("dbo.Services", "UpdateUserId");
            DropColumn("dbo.Services", "CreateUserId");
            DropColumn("dbo.Services", "UpdateDateUtc");
            DropColumn("dbo.Services", "CreateDateUtc");
            DropColumn("dbo.Licenses", "UpdateUserId");
            DropColumn("dbo.Licenses", "CreateUserId");
            DropColumn("dbo.Licenses", "UpdateDateUtc");
            DropColumn("dbo.Licenses", "CreateDateUtc");
            DropColumn("dbo.Providers", "UpdateUserId");
            DropColumn("dbo.Providers", "CreateUserId");
            DropColumn("dbo.Providers", "UpdateDateUtc");
            DropColumn("dbo.Providers", "CreateDateUtc");
            DropColumn("dbo.Clinics", "UpdateUserId");
            DropColumn("dbo.Clinics", "CreateUserId");
            DropColumn("dbo.Clinics", "UpdateDateUtc");
            DropColumn("dbo.Clinics", "CreateDateUtc");
            DropColumn("dbo.AvailabilityTypes", "UpdateUserId");
            DropColumn("dbo.AvailabilityTypes", "CreateUserId");
            DropColumn("dbo.AvailabilityTypes", "UpdateDateUtc");
            DropColumn("dbo.AvailabilityTypes", "CreateDateUtc");
            DropColumn("dbo.Availabilities", "UpdateUserId");
            DropColumn("dbo.Availabilities", "CreateUserId");
            DropColumn("dbo.Availabilities", "UpdateDateUtc");
            DropColumn("dbo.Availabilities", "CreateDateUtc");
            DropTable("dbo.ZipGeocodes");
        }
    }
}
