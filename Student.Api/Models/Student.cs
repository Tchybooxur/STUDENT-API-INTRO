using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Student.Api.Models
{
    [Table("StudentData")]
    public class Student
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        public string HomeAddress { get; set; }
        public string Email { get; set; }
        public int SchoolID { get; set; }
        public School School { get; set; }
    }
}
