
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Dtos
{
    public class GetExamDto
    {
        public int ExamId { get; set; }
        
        public DateTime Date { get; set; }
        public string? Name { get; set; }

        public int Type { get; set; }
        public GetExamDto()
        {

        }

        public GetExamDto(int exemid, string name, int type)
        {
            ExamId = exemid;
            Date = DateTime.UtcNow;
            Name = name;
            Type = type;
        }


    }
}
