namespace FastTracker.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddOrgType : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Organizations", "OrgType", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Organizations", "OrgType");
        }
    }
}
