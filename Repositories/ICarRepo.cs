using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestProject.Data;
using TestProject.Models;

namespace TestProject.Repositories
{
    public interface ICarRepo
    {
        IEnumerable<Car> GetAllCars();
        Car GetItemCar(int id);
        void CreateItemCar(Car car);
        void DeleteItemCar(int id);
        void UpdateItemCar(Car car);

    }
}
