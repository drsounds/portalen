namespace Portalen.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class t : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.Attendees", new[] { "StudentId" });
            DropIndex("dbo.Attendees", new[] { "CourseId" });
            CreateIndex("dbo.Attendees", "StudentId", unique: true);
            CreateIndex("dbo.Attendees", "CourseId", unique: true);
        }
        
        public override void Down()
        {
            DropIndex("dbo.Attendees", new[] { "CourseId" });
            DropIndex("dbo.Attendees", new[] { "StudentId" });
            CreateIndex("dbo.Attendees", "CourseId");
            CreateIndex("dbo.Attendees", "StudentId");
        }
    }
}
