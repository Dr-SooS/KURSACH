namespace KURSACH.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddSubjectsToTeachers : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Teachers", "Subjects", c => c.String(unicode: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Teachers", "Subjects");
        }
    }
}
