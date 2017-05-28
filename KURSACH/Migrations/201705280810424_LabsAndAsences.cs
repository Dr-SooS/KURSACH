namespace KURSACH.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class LabsAndAsences : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Absences",
                c => new
                    {
                        AbsenceId = c.Int(nullable: false, identity: true),
                        Count = c.String(unicode: false),
                        RespectCount = c.String(unicode: false),
                        ControlPoint_ControlPointId = c.Int(nullable: false),
                        Student_StudentId = c.Int(nullable: false),
                        Subject_SubjectId = c.Int(nullable: false),
                        Teacher_TeacherId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.AbsenceId)
                .ForeignKey("dbo.ControlPoints", t => t.ControlPoint_ControlPointId, cascadeDelete: true)
                .ForeignKey("dbo.Students", t => t.Student_StudentId, cascadeDelete: true)
                .ForeignKey("dbo.Subjects", t => t.Subject_SubjectId, cascadeDelete: true)
                .ForeignKey("dbo.Teachers", t => t.Teacher_TeacherId, cascadeDelete: true)
                .Index(t => t.ControlPoint_ControlPointId)
                .Index(t => t.Student_StudentId)
                .Index(t => t.Subject_SubjectId)
                .Index(t => t.Teacher_TeacherId);
            
            CreateTable(
                "dbo.LabWorks",
                c => new
                    {
                        LabWorkId = c.Int(nullable: false, identity: true),
                        Passed = c.String(unicode: false),
                        NotPassed = c.String(unicode: false),
                        ControlPoint_ControlPointId = c.Int(nullable: false),
                        Student_StudentId = c.Int(nullable: false),
                        Subject_SubjectId = c.Int(nullable: false),
                        Teacher_TeacherId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.LabWorkId)
                .ForeignKey("dbo.ControlPoints", t => t.ControlPoint_ControlPointId, cascadeDelete: true)
                .ForeignKey("dbo.Students", t => t.Student_StudentId, cascadeDelete: true)
                .ForeignKey("dbo.Subjects", t => t.Subject_SubjectId, cascadeDelete: true)
                .ForeignKey("dbo.Teachers", t => t.Teacher_TeacherId, cascadeDelete: true)
                .Index(t => t.ControlPoint_ControlPointId)
                .Index(t => t.Student_StudentId)
                .Index(t => t.Subject_SubjectId)
                .Index(t => t.Teacher_TeacherId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Absences", "Teacher_TeacherId", "dbo.Teachers");
            DropForeignKey("dbo.Absences", "Subject_SubjectId", "dbo.Subjects");
            DropForeignKey("dbo.Absences", "Student_StudentId", "dbo.Students");
            DropForeignKey("dbo.Absences", "ControlPoint_ControlPointId", "dbo.ControlPoints");
            DropForeignKey("dbo.LabWorks", "Teacher_TeacherId", "dbo.Teachers");
            DropForeignKey("dbo.LabWorks", "Subject_SubjectId", "dbo.Subjects");
            DropForeignKey("dbo.LabWorks", "Student_StudentId", "dbo.Students");
            DropForeignKey("dbo.LabWorks", "ControlPoint_ControlPointId", "dbo.ControlPoints");
            DropIndex("dbo.LabWorks", new[] { "Teacher_TeacherId" });
            DropIndex("dbo.LabWorks", new[] { "Subject_SubjectId" });
            DropIndex("dbo.LabWorks", new[] { "Student_StudentId" });
            DropIndex("dbo.LabWorks", new[] { "ControlPoint_ControlPointId" });
            DropIndex("dbo.Absences", new[] { "Teacher_TeacherId" });
            DropIndex("dbo.Absences", new[] { "Subject_SubjectId" });
            DropIndex("dbo.Absences", new[] { "Student_StudentId" });
            DropIndex("dbo.Absences", new[] { "ControlPoint_ControlPointId" });
            DropTable("dbo.LabWorks");
            DropTable("dbo.Absences");
        }
    }
}
