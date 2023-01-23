using Domain.Entities;
using Microsoft.EntityFrameworkCore ;


namespace Infrastructure.Data;

public class DataContext:DbContext
{
    public DataContext(DbContextOptions<DataContext> options):base(options){

    }

  

    public DbSet<AttendanceStudent> AttendanceStudents{get; set;}
    public DbSet<AttendanceTeacher> AttendanceTeachers{get; set;}
    public DbSet<ClassromStudent> ClassromStudents{get; set;}
    public DbSet<Classroom> classrooms{get; set;}
    public DbSet<Exam> exams{get; set;}
    public DbSet<Issues> issues{get; set;}
    public DbSet<Result> results{get; set;}
    public DbSet<Student> students{get; set;}
    public DbSet<Subject> subjects{get; set;}
    public DbSet<Teacher> teachers{get; set;}
    public DbSet<TimeTable> timeTables{get; set;}

protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<ClassromStudent>()
            .HasKey(t => new { t.StudentId, t.ClassroomId });
 
        modelBuilder.Entity<ClassromStudent>()
            .HasOne(sc => sc.Student)
            .WithMany(s => s.ClassromStudents)
            .HasForeignKey(sc => sc.StudentId);
 
        modelBuilder.Entity<ClassromStudent>()
            .HasOne(sc => sc.Classroom)
            .WithMany(c => c.ClassromStudents)
            .HasForeignKey(sc => sc.ClassroomId);
        
            
        
    }


}
