using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Dtos
{
     public  class GetSubjectDto
    {
        public int SubjectId { get; set; }
        public string Name { get; set; }
        public int Grade { get; set; }
        public string Description { get; set; }
       
        public GetSubjectDto()
        {

        }
        public GetSubjectDto(int subjectId, string name, int grade, string description )
        {
            SubjectId = subjectId;
            Name = name;
            Grade = grade;
            Description = description;
            
        }
    }
}
