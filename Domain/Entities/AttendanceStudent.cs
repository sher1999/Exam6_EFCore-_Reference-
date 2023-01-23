using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Domain.Entities
{
    public class AttendanceStudent
    {
       [Key]
        public int AttendanceStudentId { get; set; }
        public DateTime Date { get; set; }
        public bool Status { get; set; }
        public int StudentId {get;set;}
        public  Student Student { get; set; }
       
        public AttendanceStudent()
        {

        }
        public AttendanceStudent(int attendanceStudentId,bool status,int studentId)
        {
            AttendanceStudentId = attendanceStudentId;
            Date = DateTime.UtcNow;
            Status = status;
            StudentId=studentId;
        }
    }
}
