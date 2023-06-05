namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class blogimageadd : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Blogs", "BlogImage2", c => c.String(maxLength: 250));
            AddColumn("dbo.Blogs", "BlogImage3", c => c.String(maxLength: 250));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Blogs", "BlogImage3");
            DropColumn("dbo.Blogs", "BlogImage2");
        }
    }
}
