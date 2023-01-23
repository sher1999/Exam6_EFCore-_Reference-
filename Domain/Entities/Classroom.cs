using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Domain.Entities
{

    public class Classroom
    { [Key]
        
        public int ClassroomId { get; set; }
       
        public string Section { get; set; }
        public int Grade { get; set; }
        public int TeacherId { get; set; }
        public Teacher Teacher {get;set;}
    
       public List<ClassromStudent> ClassromStudents  {get;set;}
     
     
        public Classroom()
        {

        }
            public Classroom(int classroomID, string section, int grade, int teacherId)
            {
                ClassroomId = classroomID;
                Section = section;
                Grade = grade;
                TeacherId = teacherId;
            }
    }
}
