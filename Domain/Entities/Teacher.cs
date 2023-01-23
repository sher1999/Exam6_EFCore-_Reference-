using System.ComponentModel.DataAnnotations;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{

    public class Teacher
    {
[Key]
        public int TeacherId { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public DateTime DOB { get; set; }
        public string Sex { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string DateOfJoin { get; set; }
        public List<Classroom> Classrooms{get;set;}=new();
        public List<AttendanceTeacher> AttendanceTeachers { get; set; }
        public Teacher()
        {
                
        }
        public Teacher(int teacherId, string email, string password, string name, string sex, string address, string phone, string dateOfJoin)
        {
            TeacherId = teacherId;
            Email = email;
            Password = password;
            Name = name;
            DOB = DateTime.UtcNow;
            Sex = sex;
            Address = address;
            Phone = phone;
            DateOfJoin = dateOfJoin;
           
        }
    }
}
