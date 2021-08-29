using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestProject.Dtos;
using TestProject.Models;
using TestProject.Repositories;

namespace TestProject.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CarController : ControllerBase
    {
        private readonly ICarRepo _repo;
        public CarController(ICarRepo repo)
        {
            _repo = repo;
        }

        [HttpGet(Name = "GetAllCars")]
        public ActionResult<IEnumerable<CarDto>> GetAllCars()
        {
            return Ok(_repo.GetAllCars().Select(item => item.AsDto()));
        }

        [HttpGet("{id}", Name = "GetItemCar")]
        public ActionResult<CarDto> GetItemCar(int id)
        {
            var itemCar = _repo.GetItemCar(id);

            if (itemCar is null)
            {
                return NotFound();
            }
            
            return Ok(itemCar.AsDto());
        }

        [HttpPost(Name = "CreateItemCar")]
        public ActionResult CreateItemCar(CreateCarDto carDto)
        {
            var list = _repo.GetAllCars();

            foreach (var item in list)
            {
                if (item.Parent_Id.ToString() == carDto.Parent_Id)
                {
                    return BadRequest();
                }
            }

            Car car = new Car
            {
                Parent_Id = HierarchyId.Parse(carDto.Parent_Id),
                Name = carDto.Name,
                DateTime = DateTime.UtcNow
            };

            _repo.CreateItemCar(car);

            if (car is null)
            {
                return NotFound();
            }

            return RedirectToAction("GetAllCars");
        }

        [HttpPut("{id}", Name = "UpdateItemCar")]
        public ActionResult UpdateItemCar(int id, UpdateCarDto carDto)
        {
            var itemCar = _repo.GetItemCar(id);

            if (itemCar is null)
            {
                return NotFound();
            }

            Car car = new Car
            {
                Id = id,
                Parent_Id = HierarchyId.Parse(carDto.Parent_Id),
                Name = carDto.Name,
                DateTime = DateTime.UtcNow
            };

            _repo.UpdateItemCar(car);

            return Ok(car.AsDto());
        }

        [HttpDelete("{id}", Name = "DeleteItemCar")]
        public ActionResult DeleteItemCar(int id)
        {
            var itemCar = _repo.GetItemCar(id);

            if (itemCar is null)
            {
                return NotFound();
            }

            _repo.DeleteItemCar(id);

            return Ok(itemCar.AsDto());
        }
    }
}
