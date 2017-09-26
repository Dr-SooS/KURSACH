namespace KURSACH.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddNoValueFieldToMark : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Marks", "NoValue", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Marks", "NoValue");
        }
    }
}
