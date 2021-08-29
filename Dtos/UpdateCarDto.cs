using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TestProject.Dtos
{
    public class UpdateCarDto
    {
        [Required]
        public string Parent_Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string Name { get; set; }
    }
}
