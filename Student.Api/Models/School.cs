using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Student.Api.Models
{
    public class School
    {
        public int Id { get; set; }
        public string Name { get; set; }     

        public string SchoolAddress { get; set; }  
    }
}
