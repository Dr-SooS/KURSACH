namespace KURSACH.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RemovedType : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Marks", "Type");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Marks", "Type", c => c.String(unicode: false));
        }
    }
}
