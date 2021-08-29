using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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

        [HttpGet]
        public ActionResult<IEnumerable<Car>> GetAllCars()
        {
            return Ok(_repo.GetAllCars());
        }

        [HttpGet("{id}")]
        public ActionResult<Car> GetItemCar(int id)
        {
            return Ok(_repo.GetItemCar(id));
        }

        [HttpPost]
        public ActionResult CreateItemCar(Car car)
        {
            return Ok(car);
        }

        [HttpPut]
        public ActionResult UpdateItemCar(int id, Car car)
        {
            return Ok(car);
        }

        [HttpDelete]
        public ActionResult DeleteItemCar(int id)
        {
            return Ok();
        }
    }
}
