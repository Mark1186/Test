using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TestProject.Dtos
{
    public class CarDto
    {
        public int Id { get; set; }
        public string Parent_Id { get; set; }        
        public string Name { get; set; }
        public DateTime DateTime { get; set; }
        public int Level { get; set; }
    }
}
