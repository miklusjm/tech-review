namespace TechReviewSite.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AutoTime : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Reviews", "PublishDate");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Reviews", "PublishDate", c => c.DateTime(nullable: false));
        }
    }
}
