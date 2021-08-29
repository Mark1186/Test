using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestProject.Data;
using TestProject.Models;

namespace TestProject.Repositories
{
    public class CarRepo : ICarRepo
    {
        private readonly CarContext _db;
        public CarRepo(CarContext db)
        {
            _db = db;
        }
        public void CreateItemCar(Car car)
        {
            _db.Cars.Add(car);
            _db.SaveChanges();
        }

        public void DeleteItemCar(int id)
        {
            var carItem = _db.Cars.Find(id);

            _db.Cars.Remove(carItem);
            _db.SaveChanges();
        }

        public IEnumerable<Car> GetAllCars()
        {
            var listCars = _db.Cars.ToList();

            return listCars;
        }

        public Car GetItemCar(int id)
        {
            var itemCar = _db.Cars.Find(id);

            return itemCar;
        }

        public void UpdateItemCar(Car car)
        {
            _db.Cars.Update(car);
            _db.SaveChanges();
        }
    }
}
