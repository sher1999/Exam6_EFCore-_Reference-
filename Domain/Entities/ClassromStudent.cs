using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Entities;
using System.ComponentModel.DataAnnotations;
 


namespace Domain.Entities
{

    public class ClassromStudent
    {
        public int StudentId { get; set; }
        public int ClassroomId { get; set; }
           
           public Classroom Classroom {get;set;}
           public Student Student {get;set;}

        
         


        public ClassromStudent()
        {

        }
        public ClassromStudent(int studentId, int classroomId)
        {
            StudentId = studentId;
            ClassroomId = classroomId;
        }
    }
}
