namespace KURSACH.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ControlPointAdded : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ControlPoints",
                c => new
                    {
                        ControlPointId = c.Int(nullable: false, identity: true),
                        Date = c.DateTime(nullable: false, precision: 0),
                    })
                .PrimaryKey(t => t.ControlPointId);
            
            AddColumn("dbo.Marks", "ControlPoint_ControlPointId", c => c.Int());
            CreateIndex("dbo.Marks", "ControlPoint_ControlPointId");
            AddForeignKey("dbo.Marks", "ControlPoint_ControlPointId", "dbo.ControlPoints", "ControlPointId");
            DropColumn("dbo.Marks", "Date");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Marks", "Date", c => c.DateTime(nullable: false, precision: 0));
            DropForeignKey("dbo.Marks", "ControlPoint_ControlPointId", "dbo.ControlPoints");
            DropIndex("dbo.Marks", new[] { "ControlPoint_ControlPointId" });
            DropColumn("dbo.Marks", "ControlPoint_ControlPointId");
            DropTable("dbo.ControlPoints");
        }
    }
}
