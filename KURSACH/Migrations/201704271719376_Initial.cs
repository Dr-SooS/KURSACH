namespace KURSACH.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Departments",
                c => new
                    {
                        DepartmentId = c.Int(nullable: false, identity: true),
                        Name = c.String(unicode: false),
                        Code = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.DepartmentId);
            
            CreateTable(
                "dbo.Specialties",
                c => new
                    {
                        SpecialtyId = c.Int(nullable: false, identity: true),
                        Name = c.String(unicode: false),
                        Code = c.Int(nullable: false),
                        Department_DepartmentId = c.Int(),
                    })
                .PrimaryKey(t => t.SpecialtyId)
                .ForeignKey("dbo.Departments", t => t.Department_DepartmentId)
                .Index(t => t.Department_DepartmentId);
            
            CreateTable(
                "dbo.Groups",
                c => new
                    {
                        GroupId = c.Int(nullable: false, identity: true),
                        Number = c.Int(nullable: false),
                        Specialty_SpecialtyId = c.Int(),
                    })
                .PrimaryKey(t => t.GroupId)
                .ForeignKey("dbo.Specialties", t => t.Specialty_SpecialtyId)
                .Index(t => t.Specialty_SpecialtyId);
            
            CreateTable(
                "dbo.Students",
                c => new
                    {
                        StudentId = c.Int(nullable: false, identity: true),
                        FirstName = c.String(unicode: false),
                        MiddleName = c.String(unicode: false),
                        LastName = c.String(unicode: false),
                        Enterance = c.DateTime(nullable: false, precision: 0),
                        Group_GroupId = c.Int(),
                    })
                .PrimaryKey(t => t.StudentId)
                .ForeignKey("dbo.Groups", t => t.Group_GroupId)
                .Index(t => t.Group_GroupId);
            
            CreateTable(
                "dbo.Marks",
                c => new
                    {
                        MarkId = c.Int(nullable: false, identity: true),
                        Value = c.String(unicode: false),
                        Type = c.String(unicode: false),
                        Date = c.DateTime(nullable: false, precision: 0),
                        Student_StudentId = c.Int(),
                        Subject_SubjectId = c.Int(),
                        Teacher_TeacherId = c.Int(),
                    })
                .PrimaryKey(t => t.MarkId)
                .ForeignKey("dbo.Students", t => t.Student_StudentId)
                .ForeignKey("dbo.Subjects", t => t.Subject_SubjectId)
                .ForeignKey("dbo.Teachers", t => t.Teacher_TeacherId)
                .Index(t => t.Student_StudentId)
                .Index(t => t.Subject_SubjectId)
                .Index(t => t.Teacher_TeacherId);
            
            CreateTable(
                "dbo.Subjects",
                c => new
                    {
                        SubjectId = c.Int(nullable: false, identity: true),
                        Name = c.String(unicode: false),
                    })
                .PrimaryKey(t => t.SubjectId);
            
            CreateTable(
                "dbo.Teachers",
                c => new
                    {
                        TeacherId = c.Int(nullable: false, identity: true),
                        FirstName = c.String(unicode: false),
                        MiddleName = c.String(unicode: false),
                        LastName = c.String(unicode: false),
                    })
                .PrimaryKey(t => t.TeacherId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Marks", "Teacher_TeacherId", "dbo.Teachers");
            DropForeignKey("dbo.Marks", "Subject_SubjectId", "dbo.Subjects");
            DropForeignKey("dbo.Marks", "Student_StudentId", "dbo.Students");
            DropForeignKey("dbo.Students", "Group_GroupId", "dbo.Groups");
            DropForeignKey("dbo.Groups", "Specialty_SpecialtyId", "dbo.Specialties");
            DropForeignKey("dbo.Specialties", "Department_DepartmentId", "dbo.Departments");
            DropIndex("dbo.Marks", new[] { "Teacher_TeacherId" });
            DropIndex("dbo.Marks", new[] { "Subject_SubjectId" });
            DropIndex("dbo.Marks", new[] { "Student_StudentId" });
            DropIndex("dbo.Students", new[] { "Group_GroupId" });
            DropIndex("dbo.Groups", new[] { "Specialty_SpecialtyId" });
            DropIndex("dbo.Specialties", new[] { "Department_DepartmentId" });
            DropTable("dbo.Teachers");
            DropTable("dbo.Subjects");
            DropTable("dbo.Marks");
            DropTable("dbo.Students");
            DropTable("dbo.Groups");
            DropTable("dbo.Specialties");
            DropTable("dbo.Departments");
        }
    }
}
