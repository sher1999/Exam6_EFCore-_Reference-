
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Entities;

namespace Domain.Dtos
{
    public class GetResultDto
    {
        public int ExamId { get; set; }
        
        public int StudentId { get; set; }
        public int SubjectId { get; set; }
        public int Marks { get; set; }

        public GetResultDto()
        {

        }

        public GetResultDto(int examid, int studentId, int subjectId, int marks)
        {
            ExamId = examid;
            StudentId = studentId;
            SubjectId = subjectId;
            Marks = marks;

        }
    }
}
