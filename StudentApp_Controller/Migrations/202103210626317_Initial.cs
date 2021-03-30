namespace StudentApp_Controller.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Admins",
                c => new
                    {
                        UserEmail = c.String(nullable: false, maxLength: 64, unicode: false),
                    })
                .PrimaryKey(t => t.UserEmail)
                .ForeignKey("dbo.Users", t => t.UserEmail)
                .Index(t => t.UserEmail);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Email = c.String(nullable: false, maxLength: 64, unicode: false),
                        FirstName = c.String(nullable: false, maxLength: 32, unicode: false),
                        LastName = c.String(nullable: false, maxLength: 32, unicode: false),
                        Address = c.String(nullable: false, maxLength: 128, unicode: false),
                        City = c.String(nullable: false, maxLength: 32, unicode: false),
                        State = c.String(nullable: false, maxLength: 16, unicode: false),
                        Postcode = c.String(nullable: false, maxLength: 4, unicode: false),
                        Mobile = c.String(nullable: false, maxLength: 32, unicode: false),
                        Dob = c.DateTime(nullable: false),
                        Gender = c.String(nullable: false, maxLength: 32, unicode: false),
                        Pass = c.String(nullable: false, maxLength: 32, unicode: false),
                    })
                .PrimaryKey(t => t.Email);
            
            CreateTable(
                "dbo.Metadatas",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserId = c.String(nullable: false, maxLength: 64, unicode: false),
                        TimeStamp = c.DateTime(),
                        Description = c.String(maxLength: 256, unicode: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.Students",
                c => new
                    {
                        UserEmail = c.String(nullable: false, maxLength: 64, unicode: false),
                    })
                .PrimaryKey(t => t.UserEmail)
                .ForeignKey("dbo.Users", t => t.UserEmail)
                .Index(t => t.UserEmail);
            
            CreateTable(
                "dbo.Invoices",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        StudentEmail = c.String(nullable: false, maxLength: 64, unicode: false),
                        EnroledStudentEmail = c.String(nullable: false, maxLength: 64, unicode: false),
                        StudentYear = c.DateTime(nullable: false, storeType: "date"),
                        StudentSecondSemester = c.Boolean(nullable: false),
                        StudentCollegeId = c.Int(nullable: false),
                        CourseCode = c.String(nullable: false, maxLength: 16, unicode: false),
                        CourseYear = c.DateTime(nullable: false, storeType: "date"),
                        CourseSecondSemester = c.Boolean(nullable: false),
                        CourseCollegeId = c.Int(nullable: false),
                        Amount = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Misc = c.String(nullable: false, maxLength: 256, unicode: false),
                        InvoiceDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.RegisteredStudentEnrolInCourseAtSemesterAtColleges", t => new { t.EnroledStudentEmail, t.StudentYear, t.StudentSecondSemester, t.StudentCollegeId, t.CourseCode, t.CourseYear, t.CourseSecondSemester, t.CourseCollegeId }, cascadeDelete: true)
                .ForeignKey("dbo.Students", t => t.StudentEmail, cascadeDelete: true)
                .Index(t => t.StudentEmail)
                .Index(t => new { t.EnroledStudentEmail, t.StudentYear, t.StudentSecondSemester, t.StudentCollegeId, t.CourseCode, t.CourseYear, t.CourseSecondSemester, t.CourseCollegeId });
            
            CreateTable(
                "dbo.Receipts",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        InvoiceId = c.Int(nullable: false),
                        Amount = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Misc = c.String(nullable: false, maxLength: 256, unicode: false),
                        ReceiptDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Invoices", t => t.InvoiceId, cascadeDelete: true)
                .Index(t => t.InvoiceId);
            
            CreateTable(
                "dbo.RegisteredStudentEnrolInCourseAtSemesterAtColleges",
                c => new
                    {
                        StudentEmail = c.String(nullable: false, maxLength: 64, unicode: false),
                        StudentYear = c.DateTime(nullable: false, storeType: "date"),
                        StudentSecondSemester = c.Boolean(nullable: false),
                        StudentCollegeId = c.Int(nullable: false),
                        CourseCode = c.String(nullable: false, maxLength: 16, unicode: false),
                        CourseYear = c.DateTime(nullable: false, storeType: "date"),
                        CourseSecondSemester = c.Boolean(nullable: false),
                        CourseCollegeId = c.Int(nullable: false),
                        EnrolmentDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => new { t.StudentEmail, t.StudentYear, t.StudentSecondSemester, t.StudentCollegeId, t.CourseCode, t.CourseYear, t.CourseSecondSemester, t.CourseCollegeId })
                .ForeignKey("dbo.CourseAtSemesterAtColleges", t => new { t.CourseCode, t.CourseYear, t.CourseSecondSemester, t.CourseCollegeId }, cascadeDelete: true)
                .ForeignKey("dbo.RegisterStudentInSemesterAtColleges", t => new { t.StudentEmail, t.StudentYear, t.StudentSecondSemester, t.StudentCollegeId })
                .Index(t => new { t.StudentEmail, t.StudentYear, t.StudentSecondSemester, t.StudentCollegeId })
                .Index(t => new { t.CourseCode, t.CourseYear, t.CourseSecondSemester, t.CourseCollegeId });
            
            CreateTable(
                "dbo.CourseAtSemesterAtColleges",
                c => new
                    {
                        CourseCode = c.String(nullable: false, maxLength: 16, unicode: false),
                        Year = c.DateTime(nullable: false, storeType: "date"),
                        SecondSemester = c.Boolean(nullable: false),
                        CollegeId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.CourseCode, t.Year, t.SecondSemester, t.CollegeId })
                .ForeignKey("dbo.Courses", t => t.CourseCode, cascadeDelete: true)
                .ForeignKey("dbo.SemesterAtColleges", t => new { t.Year, t.SecondSemester, t.CollegeId }, cascadeDelete: true)
                .Index(t => t.CourseCode)
                .Index(t => new { t.Year, t.SecondSemester, t.CollegeId });
            
            CreateTable(
                "dbo.Courses",
                c => new
                    {
                        CourseCode = c.String(nullable: false, maxLength: 16, unicode: false),
                        Name = c.String(nullable: false, maxLength: 256, unicode: false),
                        Fee = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.CourseCode);
            
            CreateTable(
                "dbo.UnitInCourses",
                c => new
                    {
                        UnitCode = c.String(nullable: false, maxLength: 16, unicode: false),
                        CourseCode = c.String(nullable: false, maxLength: 16, unicode: false),
                        Core = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => new { t.UnitCode, t.CourseCode })
                .ForeignKey("dbo.Courses", t => t.CourseCode, cascadeDelete: true)
                .ForeignKey("dbo.Units", t => t.UnitCode, cascadeDelete: true)
                .Index(t => t.UnitCode)
                .Index(t => t.CourseCode);
            
            CreateTable(
                "dbo.Units",
                c => new
                    {
                        UnitCode = c.String(nullable: false, maxLength: 16, unicode: false),
                        Description = c.String(nullable: false, maxLength: 256, unicode: false),
                    })
                .PrimaryKey(t => t.UnitCode);
            
            CreateTable(
                "dbo.UnitInSubjectInCourseAtSemesterAtColleges",
                c => new
                    {
                        UnitCode = c.String(nullable: false, maxLength: 16, unicode: false),
                        SubjectId = c.Int(nullable: false),
                        CourseCode = c.String(nullable: false, maxLength: 16, unicode: false),
                        Year = c.DateTime(nullable: false, storeType: "date"),
                        SecondSemester = c.Boolean(nullable: false),
                        CollegeId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.UnitCode, t.SubjectId, t.CourseCode, t.Year, t.SecondSemester, t.CollegeId })
                .ForeignKey("dbo.SubjectInCourseAtSemesterAtColleges", t => new { t.SubjectId, t.CourseCode, t.Year, t.SecondSemester, t.CollegeId }, cascadeDelete: true)
                .ForeignKey("dbo.Units", t => t.UnitCode, cascadeDelete: true)
                .Index(t => t.UnitCode)
                .Index(t => new { t.SubjectId, t.CourseCode, t.Year, t.SecondSemester, t.CollegeId });
            
            CreateTable(
                "dbo.StudentUnitGrades",
                c => new
                    {
                        StudentEmail = c.String(nullable: false, maxLength: 64, unicode: false),
                        UnitCode = c.String(nullable: false, maxLength: 16, unicode: false),
                        SubjectId = c.Int(nullable: false),
                        CourseCode = c.String(nullable: false, maxLength: 16, unicode: false),
                        Year = c.DateTime(nullable: false, storeType: "date"),
                        SecondSemester = c.Boolean(nullable: false),
                        CollegeId = c.Int(nullable: false),
                        Grade = c.Boolean(nullable: false),
                        RPL = c.Boolean(nullable: false),
                        DateGraded = c.DateTime(),
                    })
                .PrimaryKey(t => new { t.StudentEmail, t.UnitCode, t.SubjectId, t.CourseCode, t.Year, t.SecondSemester, t.CollegeId })
                .ForeignKey("dbo.Students", t => t.StudentEmail, cascadeDelete: true)
                .ForeignKey("dbo.UnitInSubjectInCourseAtSemesterAtColleges", t => new { t.UnitCode, t.SubjectId, t.CourseCode, t.Year, t.SecondSemester, t.CollegeId }, cascadeDelete: true)
                .Index(t => t.StudentEmail)
                .Index(t => new { t.UnitCode, t.SubjectId, t.CourseCode, t.Year, t.SecondSemester, t.CollegeId });
            
            CreateTable(
                "dbo.SubjectInCourseAtSemesterAtColleges",
                c => new
                    {
                        SubjectId = c.Int(nullable: false),
                        CourseCode = c.String(nullable: false, maxLength: 16, unicode: false),
                        Year = c.DateTime(nullable: false, storeType: "date"),
                        SecondSemester = c.Boolean(nullable: false),
                        CollegeId = c.Int(nullable: false),
                        TeacherEmail = c.String(nullable: false, maxLength: 64, unicode: false),
                    })
                .PrimaryKey(t => new { t.SubjectId, t.CourseCode, t.Year, t.SecondSemester, t.CollegeId })
                .ForeignKey("dbo.CourseAtSemesterAtColleges", t => new { t.CourseCode, t.Year, t.SecondSemester, t.CollegeId }, cascadeDelete: true)
                .ForeignKey("dbo.Subjects", t => t.SubjectId, cascadeDelete: true)
                .ForeignKey("dbo.Teachers", t => t.TeacherEmail, cascadeDelete: true)
                .Index(t => t.SubjectId)
                .Index(t => new { t.CourseCode, t.Year, t.SecondSemester, t.CollegeId })
                .Index(t => t.TeacherEmail);
            
            CreateTable(
                "dbo.Subjects",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 32, unicode: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Teachers",
                c => new
                    {
                        UserEmail = c.String(nullable: false, maxLength: 64, unicode: false),
                    })
                .PrimaryKey(t => t.UserEmail)
                .ForeignKey("dbo.Users", t => t.UserEmail)
                .Index(t => t.UserEmail);
            
            CreateTable(
                "dbo.SemesterAtColleges",
                c => new
                    {
                        Year = c.DateTime(nullable: false, storeType: "date"),
                        SecondSemester = c.Boolean(nullable: false),
                        CollegeId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Year, t.SecondSemester, t.CollegeId })
                .ForeignKey("dbo.Colleges", t => t.CollegeId, cascadeDelete: true)
                .ForeignKey("dbo.Semesters", t => new { t.Year, t.SecondSemester }, cascadeDelete: true)
                .Index(t => new { t.Year, t.SecondSemester })
                .Index(t => t.CollegeId);
            
            CreateTable(
                "dbo.Colleges",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 32, unicode: false),
                        Address = c.String(nullable: false, maxLength: 128, unicode: false),
                        City = c.String(nullable: false, maxLength: 16, unicode: false),
                        State = c.String(nullable: false, maxLength: 16, unicode: false),
                        Postcode = c.String(nullable: false, maxLength: 4, unicode: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.RegisterStudentInSemesterAtColleges",
                c => new
                    {
                        StudentEmail = c.String(nullable: false, maxLength: 64, unicode: false),
                        Year = c.DateTime(nullable: false, storeType: "date"),
                        SecondSemester = c.Boolean(nullable: false),
                        CollegeId = c.Int(nullable: false),
                        RegistrationDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => new { t.StudentEmail, t.Year, t.SecondSemester, t.CollegeId })
                .ForeignKey("dbo.SemesterAtColleges", t => new { t.Year, t.SecondSemester, t.CollegeId })
                .ForeignKey("dbo.Students", t => t.StudentEmail, cascadeDelete: true)
                .Index(t => t.StudentEmail)
                .Index(t => new { t.Year, t.SecondSemester, t.CollegeId });
            
            CreateTable(
                "dbo.Semesters",
                c => new
                    {
                        Year = c.DateTime(nullable: false, storeType: "date"),
                        SecondSemester = c.Boolean(nullable: false),
                        FirstTermBegin = c.DateTime(nullable: false, storeType: "date"),
                        FirstTermEnd = c.DateTime(nullable: false, storeType: "date"),
                        SecondTermBegin = c.DateTime(nullable: false, storeType: "date"),
                        SecondTermEnd = c.DateTime(nullable: false, storeType: "date"),
                    })
                .PrimaryKey(t => new { t.Year, t.SecondSemester });
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Teachers", "UserEmail", "dbo.Users");
            DropForeignKey("dbo.Students", "UserEmail", "dbo.Users");
            DropForeignKey("dbo.Invoices", "StudentEmail", "dbo.Students");
            DropForeignKey("dbo.Invoices", new[] { "EnroledStudentEmail", "StudentYear", "StudentSecondSemester", "StudentCollegeId", "CourseCode", "CourseYear", "CourseSecondSemester", "CourseCollegeId" }, "dbo.RegisteredStudentEnrolInCourseAtSemesterAtColleges");
            DropForeignKey("dbo.RegisteredStudentEnrolInCourseAtSemesterAtColleges", new[] { "StudentEmail", "StudentYear", "StudentSecondSemester", "StudentCollegeId" }, "dbo.RegisterStudentInSemesterAtColleges");
            DropForeignKey("dbo.RegisteredStudentEnrolInCourseAtSemesterAtColleges", new[] { "CourseCode", "CourseYear", "CourseSecondSemester", "CourseCollegeId" }, "dbo.CourseAtSemesterAtColleges");
            DropForeignKey("dbo.CourseAtSemesterAtColleges", new[] { "Year", "SecondSemester", "CollegeId" }, "dbo.SemesterAtColleges");
            DropForeignKey("dbo.SemesterAtColleges", new[] { "Year", "SecondSemester" }, "dbo.Semesters");
            DropForeignKey("dbo.RegisterStudentInSemesterAtColleges", "StudentEmail", "dbo.Students");
            DropForeignKey("dbo.RegisterStudentInSemesterAtColleges", new[] { "Year", "SecondSemester", "CollegeId" }, "dbo.SemesterAtColleges");
            DropForeignKey("dbo.SemesterAtColleges", "CollegeId", "dbo.Colleges");
            DropForeignKey("dbo.CourseAtSemesterAtColleges", "CourseCode", "dbo.Courses");
            DropForeignKey("dbo.UnitInCourses", "UnitCode", "dbo.Units");
            DropForeignKey("dbo.UnitInSubjectInCourseAtSemesterAtColleges", "UnitCode", "dbo.Units");
            DropForeignKey("dbo.UnitInSubjectInCourseAtSemesterAtColleges", new[] { "SubjectId", "CourseCode", "Year", "SecondSemester", "CollegeId" }, "dbo.SubjectInCourseAtSemesterAtColleges");
            DropForeignKey("dbo.SubjectInCourseAtSemesterAtColleges", "TeacherEmail", "dbo.Teachers");
            DropForeignKey("dbo.SubjectInCourseAtSemesterAtColleges", "SubjectId", "dbo.Subjects");
            DropForeignKey("dbo.SubjectInCourseAtSemesterAtColleges", new[] { "CourseCode", "Year", "SecondSemester", "CollegeId" }, "dbo.CourseAtSemesterAtColleges");
            DropForeignKey("dbo.StudentUnitGrades", new[] { "UnitCode", "SubjectId", "CourseCode", "Year", "SecondSemester", "CollegeId" }, "dbo.UnitInSubjectInCourseAtSemesterAtColleges");
            DropForeignKey("dbo.StudentUnitGrades", "StudentEmail", "dbo.Students");
            DropForeignKey("dbo.UnitInCourses", "CourseCode", "dbo.Courses");
            DropForeignKey("dbo.Receipts", "InvoiceId", "dbo.Invoices");
            DropForeignKey("dbo.Metadatas", "UserId", "dbo.Users");
            DropForeignKey("dbo.Admins", "UserEmail", "dbo.Users");
            DropIndex("dbo.RegisterStudentInSemesterAtColleges", new[] { "Year", "SecondSemester", "CollegeId" });
            DropIndex("dbo.RegisterStudentInSemesterAtColleges", new[] { "StudentEmail" });
            DropIndex("dbo.SemesterAtColleges", new[] { "CollegeId" });
            DropIndex("dbo.SemesterAtColleges", new[] { "Year", "SecondSemester" });
            DropIndex("dbo.Teachers", new[] { "UserEmail" });
            DropIndex("dbo.SubjectInCourseAtSemesterAtColleges", new[] { "TeacherEmail" });
            DropIndex("dbo.SubjectInCourseAtSemesterAtColleges", new[] { "CourseCode", "Year", "SecondSemester", "CollegeId" });
            DropIndex("dbo.SubjectInCourseAtSemesterAtColleges", new[] { "SubjectId" });
            DropIndex("dbo.StudentUnitGrades", new[] { "UnitCode", "SubjectId", "CourseCode", "Year", "SecondSemester", "CollegeId" });
            DropIndex("dbo.StudentUnitGrades", new[] { "StudentEmail" });
            DropIndex("dbo.UnitInSubjectInCourseAtSemesterAtColleges", new[] { "SubjectId", "CourseCode", "Year", "SecondSemester", "CollegeId" });
            DropIndex("dbo.UnitInSubjectInCourseAtSemesterAtColleges", new[] { "UnitCode" });
            DropIndex("dbo.UnitInCourses", new[] { "CourseCode" });
            DropIndex("dbo.UnitInCourses", new[] { "UnitCode" });
            DropIndex("dbo.CourseAtSemesterAtColleges", new[] { "Year", "SecondSemester", "CollegeId" });
            DropIndex("dbo.CourseAtSemesterAtColleges", new[] { "CourseCode" });
            DropIndex("dbo.RegisteredStudentEnrolInCourseAtSemesterAtColleges", new[] { "CourseCode", "CourseYear", "CourseSecondSemester", "CourseCollegeId" });
            DropIndex("dbo.RegisteredStudentEnrolInCourseAtSemesterAtColleges", new[] { "StudentEmail", "StudentYear", "StudentSecondSemester", "StudentCollegeId" });
            DropIndex("dbo.Receipts", new[] { "InvoiceId" });
            DropIndex("dbo.Invoices", new[] { "EnroledStudentEmail", "StudentYear", "StudentSecondSemester", "StudentCollegeId", "CourseCode", "CourseYear", "CourseSecondSemester", "CourseCollegeId" });
            DropIndex("dbo.Invoices", new[] { "StudentEmail" });
            DropIndex("dbo.Students", new[] { "UserEmail" });
            DropIndex("dbo.Metadatas", new[] { "UserId" });
            DropIndex("dbo.Admins", new[] { "UserEmail" });
            DropTable("dbo.Semesters");
            DropTable("dbo.RegisterStudentInSemesterAtColleges");
            DropTable("dbo.Colleges");
            DropTable("dbo.SemesterAtColleges");
            DropTable("dbo.Teachers");
            DropTable("dbo.Subjects");
            DropTable("dbo.SubjectInCourseAtSemesterAtColleges");
            DropTable("dbo.StudentUnitGrades");
            DropTable("dbo.UnitInSubjectInCourseAtSemesterAtColleges");
            DropTable("dbo.Units");
            DropTable("dbo.UnitInCourses");
            DropTable("dbo.Courses");
            DropTable("dbo.CourseAtSemesterAtColleges");
            DropTable("dbo.RegisteredStudentEnrolInCourseAtSemesterAtColleges");
            DropTable("dbo.Receipts");
            DropTable("dbo.Invoices");
            DropTable("dbo.Students");
            DropTable("dbo.Metadatas");
            DropTable("dbo.Users");
            DropTable("dbo.Admins");
        }
    }
}
