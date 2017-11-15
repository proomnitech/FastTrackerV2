namespace NewProject.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateCreateDateName : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "CreateDateUtc", c => c.DateTime());
            DropColumn("dbo.AspNetUsers", "CreateDate");
        }
        
        public override void Down()
        {
            AddColumn("dbo.AspNetUsers", "CreateDate", c => c.DateTime());
            DropColumn("dbo.AspNetUsers", "CreateDateUtc");
        }
    }
}
