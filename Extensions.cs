using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestProject.Dtos;
using TestProject.Models;

namespace TestProject
{
    public static class Extensions
    {
        public static CarDto AsDto(this Car car)
        {
            return new CarDto
            {
                Id = car.Id,
                Parent_Id = car.Parent_Id.ToString(),
                Name = car.Name,
                DateTime = car.DateTime,
                Level = car.Parent_Id.GetLevel()
            };
        }
    }
}
