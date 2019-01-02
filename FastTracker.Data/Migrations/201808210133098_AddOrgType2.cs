namespace FastTracker.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddOrgType2 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.OrgTypes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        OrgTypeName = c.String(),
                        OrgEntityLabel = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.OrgTypes");
        }
    }
}
