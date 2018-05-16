namespace WebPortal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialMigrate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Events",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        DepartmentId = c.Int(nullable: false),
                        BeginDate = c.DateTime(nullable: false),
                        EndDate = c.DateTime(nullable: false),
                        Description = c.String(),
                        Location = c.String(),
                        Url = c.String(),
                        IsFavourite = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.MoodleResources",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Fn = c.String(),
                        Course = c.String(),
                        ResourceType = c.String(),
                        Added = c.DateTime(nullable: false),
                        Description = c.String(),
                        IsFavourite = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.News",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        DepartmentId = c.Int(nullable: false),
                        Published = c.DateTime(nullable: false),
                        Description = c.String(),
                        IsFavourite = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.News");
            DropTable("dbo.MoodleResources");
            DropTable("dbo.Events");
        }
    }
}
