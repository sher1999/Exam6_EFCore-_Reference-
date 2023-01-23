
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Dtos
{
    public class GetClassroomDto
    {
        public int ClassroomID { get; set; }
        public string Section { get; set; }
        public int Grade { get; set; }
        public int TeacherId { get; set; }

        public GetClassroomDto()
        {

        }
        public GetClassroomDto(int classroomID, string section, int grade, int teacherId)
        {
            ClassroomID = classroomID;
            Section = section;
            Grade = grade;
            TeacherId = teacherId;
            
        }
    }
}
