namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig10 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Comments", "BlogRating", c => c.Int(nullable: false));
            DropColumn("dbo.Comments", "UserPhoto");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Comments", "UserPhoto", c => c.String(maxLength: 500));
            DropColumn("dbo.Comments", "BlogRating");
        }
    }
}
