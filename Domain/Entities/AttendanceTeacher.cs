using System.ComponentModel.DataAnnotations;

namespace Domain.Entities;

public class AttendanceTeacher
{
    [Key]
     public int AttendanceTeacherId { get; set; }
        public DateTime Date { get; set; }
        public bool Status { get; set; }
        public int TeacherId {get;set;}
        public Teacher Teacher { get; set;}

        public AttendanceTeacher()
        {

        }
        public AttendanceTeacher(int attendanceStudentId,bool status,int studentId)
        {
            AttendanceTeacherId = attendanceStudentId;
            Date = DateTime.UtcNow;
            Status = status;
            TeacherId=studentId;
        }
}
