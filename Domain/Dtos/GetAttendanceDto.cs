
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Dtos
{
    public class GetAttendanceDto
    {
          public int AttendanceStudentId { get; set; }
        public DateTime Date { get; set; }
        public bool Status { get; set; }
        public int StudentId {get;set;}
        public GetAttendanceDto()
        {

        }
        public GetAttendanceDto(int attendanceStudentId,bool status,int studentId)
        {
            AttendanceStudentId = attendanceStudentId;
            Date = DateTime.UtcNow;
            Status = status;
            StudentId=studentId;
        }
    }
}
