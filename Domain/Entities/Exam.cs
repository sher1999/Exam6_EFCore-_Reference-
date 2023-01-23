using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace Domain.Entities
{

    public class Exam
    {
     [Key]
      public int ExamId { get; set; }
    
        public DateTime Date { get; set; }
        public string? Name { get; set; }

        public int Type { get; set; }
          public Result Results { get; set; }

        public Exam()
        {

        }

        public Exam(int examid,string name,int type)
        {
            ExamId = examid;
            Date=DateTime.UtcNow;
            Name = name;
            Type = type;
        }


        
    }
}
