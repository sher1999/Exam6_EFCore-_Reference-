namespace Domain.Dtos;

public class GetAttendanceTeacherDto
{
     public int AttendanceTeacherId { get; set; }
        public DateTime Date { get; set; }
        public bool Status { get; set; }
        public int TeacherId {get;set;}
        public GetAttendanceTeacherDto()
        {

        }
        public GetAttendanceTeacherDto(int attendanceStudentId,bool status,int studentId)
        {
            AttendanceTeacherId = attendanceStudentId;
            Date = DateTime.UtcNow;
            Status = status;
            TeacherId=studentId;
        }
}
