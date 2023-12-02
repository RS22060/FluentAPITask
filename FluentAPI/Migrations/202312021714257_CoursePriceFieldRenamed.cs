namespace FluentAPI.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CoursePriceFieldRenamed : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Courses", "Price", c => c.Single(nullable: false));
            DropColumn("dbo.Courses", "FullPrice");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Courses", "FullPrice", c => c.Single(nullable: false));
            DropColumn("dbo.Courses", "Price");
        }
    }
}
