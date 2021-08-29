using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TestProject.Models
{
    public class Car
    {
        [Key]
        [Required]
        public int Id { get; set; }

        [Required]
        public HierarchyId Parent_Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string Name { get; set; }

        [Required]
        public DateTime DateTime { get; set; }
    }
}
