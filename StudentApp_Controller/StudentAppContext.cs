using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentApp_Model;

namespace StudentApp_Controller {

    public class StudentAppContext : DbContext {

        public StudentAppContext() : base("name=StudentManagementConnectionString") {

            Database.SetInitializer(new CreateDatabaseIfNotExists<StudentAppContext>());
            //Database.SetInitializer(new DropCreateDatabaseAlways<StudentAppContext>());
        }

        public DbSet<Invoice> Invoices { get; set; }
        public DbSet<Receipt> Receipts { get; set; }
        public DbSet<Admin> Admins { get; set; }
        public DbSet<College> Colleges { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Metadata> Metadatas { get; set; }
        public DbSet<Semester> Semesters { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Subject> Subjects { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Unit> Units { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<SemesterAtCollege> SemesterAtColleges { get; set; }
        public DbSet<CourseAtSemesterAtCollege> CourseAtSemesterAtColleges { get; set; }
        public DbSet<SubjectInCourseAtSemesterAtCollege> SubjectInCourseAtSemesterAtColleges { get; set; }
        public DbSet<RegisterStudentInSemesterAtCollege> RegisterStudentInSemesterAtColleges { get; set; }
        public DbSet<RegisteredStudentEnrolInCourseAtSemesterAtCollege> RegisteredStudentEnrolInCourseAtSemesterAtColleges { get; set; }
        public DbSet<UnitInSubjectInCourseAtSemesterAtCollege> UnitInSubjectInCourseAtSemesterAtColleges { get; set; }
        public DbSet<StudentUnitGrade> StudentUnitGrades { get; set; }
        public DbSet<UnitInCourse> UnitInCourses { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder) {

            // User
            modelBuilder.Entity<User>()
                .HasKey(u => u.Email);

            modelBuilder.Entity<User>()
                .HasOptional(u => u.Admin)
                .WithRequired(a => a.User);

            modelBuilder.Entity<User>()
                .HasOptional(u => u.Teacher)
                .WithRequired(a => a.User);

            modelBuilder.Entity<User>()
                .HasOptional(u => u.Student)
                .WithRequired(a => a.User);

            modelBuilder.Entity<User>()
                .Property(u => u.Email)
                .IsRequired()
                .HasColumnType("varchar")
                .HasMaxLength(320);

            modelBuilder.Entity<User>()
                .Property(u => u.FirstName)
                .IsRequired()
                .HasColumnType("varchar")
                .HasMaxLength(64);

            modelBuilder.Entity<User>()
                .Property(u => u.LastName)
                .IsRequired()
                .HasColumnType("varchar")
                .HasMaxLength(64);

            modelBuilder.Entity<User>()
                .Property(u => u.Address)
                .IsRequired()
                .HasColumnType("varchar")
                .HasMaxLength(256);

            modelBuilder.Entity<User>()
                .Property(u => u.City)
                .IsRequired()
                .HasColumnType("varchar")
                .HasMaxLength(64);

            modelBuilder.Entity<User>()
                .Property(u => u.State)
                .IsRequired()
                .HasColumnType("varchar")
                .HasMaxLength(16);

            modelBuilder.Entity<User>()
                .Property(u => u.Postcode)
                .IsRequired()
                .HasColumnType("varchar")
                .HasMaxLength(4)
                .IsFixedLength();

            modelBuilder.Entity<User>()
                .Property(u => u.Mobile)
                .IsRequired()
                .HasColumnType("varchar")
                .HasMaxLength(32);

            modelBuilder.Entity<User>()
                .Property(m => m.Dob)
                .IsRequired()
                .HasColumnType("datetime");

            modelBuilder.Entity<User>()
                .Property(u => u.Gender)
                .IsRequired()
                .HasColumnType("varchar")
                .HasMaxLength(64);

            modelBuilder.Entity<User>()
                .Property(u => u.Pass)
                .IsRequired()
                .HasColumnType("varchar")
                .HasMaxLength(32);

            // Admin
            modelBuilder.Entity<Admin>()
                .HasKey(a => a.UserEmail);

            // Student
            modelBuilder.Entity<Student>()
                .HasKey(s => s.UserEmail);

            // Teacher
            modelBuilder.Entity<Teacher>()
                .HasKey(t => t.UserEmail);

            // Invoice
            modelBuilder.Entity<Invoice>()
                .HasKey(a => a.Id);

            modelBuilder.Entity<Invoice>()
                .Property(p => p.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            modelBuilder.Entity<Invoice>()
                .HasRequired(o => o.Student)
                .WithMany(p => p.Invoices)
                .HasForeignKey(o => o.StudentEmail);

            modelBuilder.Entity<Invoice>()
                .HasRequired(a => a.RegisteredStudentEnrolInCourseAtSemesterAtCollege)
                .WithMany(s => s.Invoices)
                .HasForeignKey(a => new { a.EnroledStudentEmail, a.StudentYear, a.StudentSecondSemester, a.StudentCollegeId, a.CourseCode, a.CourseYear, a.CourseSecondSemester, a.CourseCollegeId });

            modelBuilder.Entity<Invoice>()
                .Property(a => a.Amount)
                .IsRequired()
                .HasColumnType("decimal");

            modelBuilder.Entity<Invoice>()
                .Property(a => a.Misc)
                .IsRequired()
                .HasColumnType("varchar")
                .HasMaxLength(512);

            modelBuilder.Entity<Invoice>()
                .Property(m => m.InvoiceDate)
                .IsRequired()
                .HasColumnType("datetime");

            // Receipt
            modelBuilder.Entity<Receipt>()
                .HasKey(o => o.Id);

            modelBuilder.Entity<Receipt>()
                .Property(o => o.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            modelBuilder.Entity<Receipt>()
                .HasRequired(o => o.Invoice)
                .WithMany(o => o.Receipts)
                .HasForeignKey(o => o.InvoiceId);

            modelBuilder.Entity<Receipt>()
                .Property(a => a.Amount)
                .IsRequired()
                .HasColumnType("decimal");

            modelBuilder.Entity<Receipt>()
                .Property(a => a.Misc)
                .IsRequired()
                .HasColumnType("varchar")
                .HasMaxLength(512);

            modelBuilder.Entity<Receipt>()
                .Property(m => m.ReceiptDate)
                .IsRequired()
                .HasColumnType("datetime");

            // College
            modelBuilder.Entity<College>()
                .HasKey(c => c.Id);

            modelBuilder.Entity<College>()
                .Property(p => p.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            modelBuilder.Entity<College>()
                .Property(c => c.Name)
                .IsRequired()
                .HasColumnType("varchar")
                .HasMaxLength(128);

            modelBuilder.Entity<College>()
                .Property(u => u.Address)
                .IsRequired()
                .HasColumnType("varchar")
                .HasMaxLength(256);

            modelBuilder.Entity<College>()
                .Property(u => u.City)
                .IsRequired()
                .HasColumnType("varchar")
                .HasMaxLength(64);

            modelBuilder.Entity<College>()
                .Property(u => u.State)
                .IsRequired()
                .HasColumnType("varchar")
                .HasMaxLength(16);

            modelBuilder.Entity<College>()
                .Property(u => u.Postcode)
                .IsRequired()
                .HasColumnType("varchar")
                .HasMaxLength(4)
                .IsFixedLength();

            // Course
            modelBuilder.Entity<Course>()
                .HasKey(c => c.CourseCode);

            modelBuilder.Entity<Course>()
                .Property(c => c.CourseCode)
                .IsRequired()
                .HasColumnType("varchar")
                .HasMaxLength(16);

            modelBuilder.Entity<Course>()
                .Property(c => c.Name)
                .IsRequired()
                .HasColumnType("varchar")
                .HasMaxLength(256);

            modelBuilder.Entity<Course>()
                .Property(a => a.Fee)
                .IsRequired()
                .HasColumnType("decimal");

            // Metadata
            modelBuilder.Entity<Metadata>()
                .HasKey(m => m.Id);

            modelBuilder.Entity<Metadata>()
                .Property(p => p.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            modelBuilder.Entity<Metadata>()
                .HasRequired(u => u.User)
                .WithMany(m => m.Metadatas)
                .HasForeignKey(u => u.UserId);

            modelBuilder.Entity<Metadata>()
                .Property(m => m.TimeStamp)
                .IsOptional()
                .HasColumnType("datetime");

            modelBuilder.Entity<Metadata>()
                .Property(m => m.Description)
                .IsOptional()
                .HasColumnType("varchar")
                .HasMaxLength(256);

            // Semester
            modelBuilder.Entity<Semester>()
                .HasKey(s => new { s.Year, s.SecondSemester });

            modelBuilder.Entity<Semester>()
                .Property(s => s.Year)
                .IsRequired()
                .HasColumnType("date");

            modelBuilder.Entity<Semester>()
                .Property(s => s.SecondSemester)
                .IsRequired()
                .HasColumnType("bit");

            modelBuilder.Entity<Semester>()
                .Property(s => s.FirstTermBegin)
                .IsRequired()
                .HasColumnType("date");

            modelBuilder.Entity<Semester>()
                .Property(s => s.FirstTermEnd)
                .IsRequired()
                .HasColumnType("date");

            modelBuilder.Entity<Semester>()
                .Property(s => s.SecondTermBegin)
                .IsRequired()
                .HasColumnType("date");

            modelBuilder.Entity<Semester>()
                .Property(s => s.SecondTermEnd)
                .IsRequired()
                .HasColumnType("date");

            // Subject
            modelBuilder.Entity<Subject>()
                .HasKey(s => s.Id);

            modelBuilder.Entity<Subject>()
                .Property(p => p.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            modelBuilder.Entity<Subject>()
                .Property(s => s.Name)
                .IsRequired()
                .HasColumnType("varchar")
                .HasMaxLength(128);

            // Unit
            modelBuilder.Entity<Unit>()
                .HasKey(u => u.UnitCode);

            modelBuilder.Entity<Unit>()
                .Property(u => u.UnitCode)
                .IsRequired()
                .HasColumnType("varchar")
                .HasMaxLength(16);

            modelBuilder.Entity<Unit>()
                .Property(u => u.Description)
                .IsRequired()
                .HasColumnType("varchar")
                .HasMaxLength(256);

            // SemesterAtCollege
            modelBuilder.Entity<SemesterAtCollege>()
                .HasKey(s => new { s.Year, s.SecondSemester, s.CollegeId });

            modelBuilder.Entity<SemesterAtCollege>()
                .HasRequired(s => s.Semester)
                .WithMany(sc => sc.SemesterAtColleges)
                .HasForeignKey(s => new { s.Year, s.SecondSemester });

            modelBuilder.Entity<SemesterAtCollege>()
                .HasRequired(c => c.College)
                .WithMany(s => s.SemesterAtColleges)
                .HasForeignKey(c => c.CollegeId);

            modelBuilder.Entity<SemesterAtCollege>()
                .Property(s => s.Year)
                .IsRequired()
                .HasColumnType("date");

            // CourseAtSemesterAtCollege
            modelBuilder.Entity<CourseAtSemesterAtCollege>()
                .HasKey(c => new { c.CourseCode, c.Year, c.SecondSemester, c.CollegeId });

            modelBuilder.Entity<CourseAtSemesterAtCollege>()
                .HasRequired(c => c.Course)
                .WithMany(cs => cs.CourseAtSemesterAtColleges)
                .HasForeignKey(c => c.CourseCode);

            modelBuilder.Entity<CourseAtSemesterAtCollege>()
                .HasRequired(s => s.SemesterAtCollege)
                .WithMany(c => c.CourseAtSemesterAtColleges)
                .HasForeignKey(s => new { s.Year, s.SecondSemester, s.CollegeId });

            modelBuilder.Entity<CourseAtSemesterAtCollege>()
                .Property(s => s.Year)
                .IsRequired()
                .HasColumnType("date");

            // SubjectInCourseAtSemesterAtCollege
            modelBuilder.Entity<SubjectInCourseAtSemesterAtCollege>()
                .HasKey(s => new { s.SubjectId, s.CourseCode, s.Year, s.SecondSemester, s.CollegeId });

            modelBuilder.Entity<SubjectInCourseAtSemesterAtCollege>()
                .HasRequired(c => c.Subject)
                .WithMany(s => s.SubjectInCourseAtSemesterAtColleges)
                .HasForeignKey(c => c.SubjectId);

            modelBuilder.Entity<SubjectInCourseAtSemesterAtCollege>()
                .HasRequired(c => c.CourseAtSemesterAtCollege)
                .WithMany(s => s.SubjectInCourseAtSemesterAtColleges)
                .HasForeignKey(c => new { c.CourseCode, c.Year, c.SecondSemester, c.CollegeId });

            modelBuilder.Entity<SubjectInCourseAtSemesterAtCollege>()
                .HasRequired(a => a.Teacher)
                .WithMany(s => s.SubjectInCourseAtSemesterAtColleges)
                .HasForeignKey(a => a.TeacherEmail);

            // RegisterStudentInSemesterAtCollege
            modelBuilder.Entity<RegisterStudentInSemesterAtCollege>()
                .HasKey(r => new { r.StudentEmail, r.Year, r.SecondSemester, r.CollegeId });

            modelBuilder.Entity<RegisterStudentInSemesterAtCollege>()
                .HasRequired(r => r.Student)
                .WithMany(rs => rs.RegisterStudentInSemesterAtColleges)
                .HasForeignKey(r => r.StudentEmail);

            modelBuilder.Entity<RegisterStudentInSemesterAtCollege>()
                .HasRequired(r => r.SemesterAtCollege)
                .WithMany(rs => rs.RegisterStudentInSemesterAtColleges)
                .HasForeignKey(r => new { r.Year, r.SecondSemester, r.CollegeId })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<RegisterStudentInSemesterAtCollege>()
                .Property(m => m.RegistrationDate)
                .IsRequired()
                .HasColumnType("datetime");

            // RegisteredStudentEnrolInCourseAtSemesterAtCollege
            modelBuilder.Entity<RegisteredStudentEnrolInCourseAtSemesterAtCollege>()
                .HasKey(r => new { r.StudentEmail, r.StudentYear, r.StudentSecondSemester, r.StudentCollegeId, r.CourseCode, r.CourseYear, r.CourseSecondSemester, r.CourseCollegeId });

           modelBuilder.Entity<RegisteredStudentEnrolInCourseAtSemesterAtCollege>()
                .HasRequired(r => r.RegisterStudentInSemesterAtCollege)
                .WithMany(rs => rs.RegisteredStudentEnrolInCourseAtSemesterAtColleges)
                .HasForeignKey(r => new { r.StudentEmail, r.StudentYear, r.StudentSecondSemester, r.StudentCollegeId })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<RegisteredStudentEnrolInCourseAtSemesterAtCollege>()
                .HasRequired(r => r.CourseAtSemesterAtCollege)
                .WithMany(rs => rs.RegisteredStudentEnrolInCourseAtSemesterAtColleges)
                .HasForeignKey(r => new { r.CourseCode, r.CourseYear, r.CourseSecondSemester, r.CourseCollegeId });

            modelBuilder.Entity<RegisteredStudentEnrolInCourseAtSemesterAtCollege>()
                .Property(m => m.EnrolmentDate)
                .IsRequired()
                .HasColumnType("datetime");

            // UnitInSubjectInCourseAtSemesterAtCollege
            modelBuilder.Entity<UnitInSubjectInCourseAtSemesterAtCollege>()
                .HasKey(u => new { u.UnitCode, u.SubjectId, u.CourseCode, u.Year, u.SecondSemester, u.CollegeId });

            modelBuilder.Entity<UnitInSubjectInCourseAtSemesterAtCollege>()
                .HasRequired(u => u.Unit)
                .WithMany(us => us.UnitInSubjectInCourseAtSemesterAtColleges)
                .HasForeignKey(c => c.UnitCode);

            modelBuilder.Entity<UnitInSubjectInCourseAtSemesterAtCollege>()
                .HasRequired(u => u.SubjectInCourseAtSemesterAtCollege)
                .WithMany(us => us.UnitInSubjectInCourseAtSemesterAtColleges)
                .HasForeignKey(u => new { u.SubjectId, u.CourseCode, u.Year, u.SecondSemester, u.CollegeId });

            // StudentUnitGrade
            modelBuilder.Entity<StudentUnitGrade>()
                .HasKey(s => new { s.StudentEmail, s.UnitCode, s.SubjectId, s.CourseCode, s.Year, s.SecondSemester, s.CollegeId });

            modelBuilder.Entity<StudentUnitGrade>()
                .HasRequired(s => s.Student)
                .WithMany(su => su.StudentUnitGrades)
                .HasForeignKey(s => s.StudentEmail);

            modelBuilder.Entity<StudentUnitGrade>()
                .HasRequired(s => s.UnitInSubjectInCourseAtSemesterAtCollege)
                .WithMany(su => su.StudentUnitGrades)
                .HasForeignKey(s => new { s.UnitCode, s.SubjectId, s.CourseCode, s.Year, s.SecondSemester, s.CollegeId });

            modelBuilder.Entity<StudentUnitGrade>()
                .Property(u => u.Grade)
                .IsRequired()
                .HasColumnType("bit");

            modelBuilder.Entity<StudentUnitGrade>()
                .Property(u => u.RPL)
                .IsRequired()
                .HasColumnType("bit");

            modelBuilder.Entity<StudentUnitGrade>()
                .Property(m => m.DateGraded)
                .IsOptional()
                .HasColumnType("datetime");

            // UnitInCourse
            modelBuilder.Entity<UnitInCourse>()
                .HasKey(c => new { c.UnitCode, c.CourseCode });

            modelBuilder.Entity<UnitInCourse>()
                .HasRequired(c => c.Unit)
                .WithMany(cu => cu.UnitInCourses)
                .HasForeignKey(c => c.UnitCode);

            modelBuilder.Entity<UnitInCourse>()
                .HasRequired(c => c.Course)
                .WithMany(cu => cu.UnitInCourses)
                .HasForeignKey(c => c.CourseCode);

            modelBuilder.Entity<UnitInCourse>()
                .Property(u => u.Core)
                .IsRequired()
                .HasColumnType("bit");


        }

    }
}
