using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContosoPOS.Model
{
    public class Student
    {
        [Key]
        public int StudentID { get; set; }
        public string? StudentName { get; set; }
        public string? StudentEmail { get; set; }
        public string? StudentPhone { get; set; }
        public string? Address { get; set; }
        public string? School { get; set; }
        
    }
}
