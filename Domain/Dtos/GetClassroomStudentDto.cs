using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Dtos
{
    public class GetClassroomStudentDto
    {
        public int StudentId { get; set; }
        public int ClassroomId { get; set; }

        public GetClassroomStudentDto()
        {

        }
        public GetClassroomStudentDto(int studentId, int classroomId)
        {
            StudentId = studentId;
            ClassroomId = classroomId;
        }
    }
}
