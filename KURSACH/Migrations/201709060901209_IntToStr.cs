namespace KURSACH.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class IntToStr : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Absences", "Count", c => c.Int(nullable: false));
            AlterColumn("dbo.Absences", "RespectCount", c => c.Int(nullable: false));
            AlterColumn("dbo.LabWorks", "Passed", c => c.Int(nullable: false));
            AlterColumn("dbo.LabWorks", "NotPassed", c => c.Int(nullable: false));
            AlterColumn("dbo.Marks", "Value", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Marks", "Value", c => c.String(unicode: false));
            AlterColumn("dbo.LabWorks", "NotPassed", c => c.String(unicode: false));
            AlterColumn("dbo.LabWorks", "Passed", c => c.String(unicode: false));
            AlterColumn("dbo.Absences", "RespectCount", c => c.String(unicode: false));
            AlterColumn("dbo.Absences", "Count", c => c.String(unicode: false));
        }
    }
}
