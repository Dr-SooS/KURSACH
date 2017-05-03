namespace KURSACH.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RequiredFields : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("Specialties", "Department_DepartmentId", "Departments");
            DropForeignKey("Groups", "Specialty_SpecialtyId", "Specialties");
            DropForeignKey("Students", "Group_GroupId", "Groups");
            DropForeignKey("Marks", "Student_StudentId", "Students");
            DropForeignKey("Marks", "ControlPoint_ControlPointId", "ControlPoints");
            DropForeignKey("Marks", "Subject_SubjectId", "Subjects");
            DropForeignKey("Marks", "Teacher_TeacherId", "Teachers");
            DropIndex("Specialties", new[] { "Department_DepartmentId" });
            DropIndex("Groups", new[] { "Specialty_SpecialtyId" });
            DropIndex("Students", new[] { "Group_GroupId" });
            DropIndex("Marks", new[] { "ControlPoint_ControlPointId" });
            DropIndex("Marks", new[] { "Student_StudentId" });
            DropIndex("Marks", new[] { "Subject_SubjectId" });
            DropIndex("Marks", new[] { "Teacher_TeacherId" });
            AlterColumn("Specialties", "Department_DepartmentId", c => c.Int(nullable: false));
            AlterColumn("Groups", "Specialty_SpecialtyId", c => c.Int(nullable: false));
            AlterColumn("Students", "Group_GroupId", c => c.Int(nullable: false));
            AlterColumn("Marks", "ControlPoint_ControlPointId", c => c.Int(nullable: false));
            AlterColumn("Marks", "Student_StudentId", c => c.Int(nullable: false));
            AlterColumn("Marks", "Subject_SubjectId", c => c.Int(nullable: false));
            AlterColumn("Marks", "Teacher_TeacherId", c => c.Int(nullable: false));
            CreateIndex("Marks", "ControlPoint_ControlPointId");
            CreateIndex("Marks", "Student_StudentId");
            CreateIndex("Marks", "Subject_SubjectId");
            CreateIndex("Marks", "Teacher_TeacherId");
            CreateIndex("Students", "Group_GroupId");
            CreateIndex("Groups", "Specialty_SpecialtyId");
            CreateIndex("Specialties", "Department_DepartmentId");
            AddForeignKey("Specialties", "Department_DepartmentId", "Departments", "DepartmentId", cascadeDelete: true);
            AddForeignKey("Groups", "Specialty_SpecialtyId", "Specialties", "SpecialtyId", cascadeDelete: true);
            AddForeignKey("Students", "Group_GroupId", "Groups", "GroupId", cascadeDelete: true);
            AddForeignKey("Marks", "Student_StudentId", "Students", "StudentId", cascadeDelete: true);
            AddForeignKey("Marks", "ControlPoint_ControlPointId", "ControlPoints", "ControlPointId", cascadeDelete: true);
            AddForeignKey("Marks", "Subject_SubjectId", "Subjects", "SubjectId", cascadeDelete: true);
            AddForeignKey("Marks", "Teacher_TeacherId", "Teachers", "TeacherId", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("Marks", "Teacher_TeacherId", "Teachers");
            DropForeignKey("Marks", "Subject_SubjectId", "Subjects");
            DropForeignKey("Marks", "ControlPoint_ControlPointId", "ControlPoints");
            DropForeignKey("Marks", "Student_StudentId", "Students");
            DropForeignKey("Students", "Group_GroupId", "Groups");
            DropForeignKey("Groups", "Specialty_SpecialtyId", "Specialties");
            DropForeignKey("Specialties", "Department_DepartmentId", "Departments");
            DropIndex("Specialties", new[] { "Department_DepartmentId" });
            DropIndex("Groups", new[] { "Specialty_SpecialtyId" });
            DropIndex("Students", new[] { "Group_GroupId" });
            DropIndex("Marks", new[] { "Teacher_TeacherId" });
            DropIndex("Marks", new[] { "Subject_SubjectId" });
            DropIndex("Marks", new[] { "Student_StudentId" });
            DropIndex("Marks", new[] { "ControlPoint_ControlPointId" });
            AlterColumn("Marks", "Teacher_TeacherId", c => c.Int());
            AlterColumn("Marks", "Subject_SubjectId", c => c.Int());
            AlterColumn("Marks", "Student_StudentId", c => c.Int());
            AlterColumn("Marks", "ControlPoint_ControlPointId", c => c.Int());
            AlterColumn("Students", "Group_GroupId", c => c.Int());
            AlterColumn("Groups", "Specialty_SpecialtyId", c => c.Int());
            AlterColumn("Specialties", "Department_DepartmentId", c => c.Int());
            CreateIndex("Marks", "Teacher_TeacherId");
            CreateIndex("Marks", "Subject_SubjectId");
            CreateIndex("Marks", "Student_StudentId");
            CreateIndex("Marks", "ControlPoint_ControlPointId");
            CreateIndex("Students", "Group_GroupId");
            CreateIndex("Groups", "Specialty_SpecialtyId");
            CreateIndex("Specialties", "Department_DepartmentId");
            AddForeignKey("Marks", "Teacher_TeacherId", "Teachers", "TeacherId");
            AddForeignKey("Marks", "Subject_SubjectId", "Subjects", "SubjectId");
            AddForeignKey("Marks", "ControlPoint_ControlPointId", "ControlPoints", "ControlPointId");
            AddForeignKey("Marks", "Student_StudentId", "Students", "StudentId");
            AddForeignKey("Students", "Group_GroupId", "Groups", "GroupId");
            AddForeignKey("Groups", "Specialty_SpecialtyId", "Specialties", "SpecialtyId");
            AddForeignKey("Specialties", "Department_DepartmentId", "Departments", "DepartmentId");
        }
    }
}
