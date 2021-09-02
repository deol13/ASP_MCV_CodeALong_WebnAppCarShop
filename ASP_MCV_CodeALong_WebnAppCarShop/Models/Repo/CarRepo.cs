using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP_MCV_CodeALong_WebnAppCarShop.Models.Repo
{
    public class CarRepo : ICarRepo
    {
        public static List<Car> _carList = new List<Car>();

        public static void CreateDefaultCars()
        {
            _carList.Add(new Car() { Brand = "Volvo", ModelName="V70", Price = 100000 });
            _carList.Add(new Car() { Brand = "Volvo", ModelName = "S80", Price = 140000 });
            _carList.Add(new Car() { Brand = "SAAB", ModelName = "95", Price = 200000 });
            _carList.Add(new Car() { Brand = "Toyota", ModelName = "Bil", Price = 350000 });
        }

        public Car Create(Car car)
        {
            _carList.Add(car);

            return car;
        }

        public Car Read(int id)
        {
            throw new NotImplementedException();
        }

        public List<Car> Read()
        {
            return _carList;
        }
    }
}
