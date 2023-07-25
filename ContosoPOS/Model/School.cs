using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContosoPOS.Model
{
    public class School
    {
        public int ID { get; set; }
        public string? SchoolName { get; set; }
        public string? Department { get; set; }
        public string? Courses { get; set; }
        public string? Address { get; set; }
        public Student Student { get; set; } = null!;
    }
}
