using ASP_MCV_CodeALong_WebnAppCarShop.Models.Repo;
using ASP_MCV_CodeALong_WebnAppCarShop.Models.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP_MCV_CodeALong_WebnAppCarShop.Models.Service
{
    public class CarService : ICarService
    {
        ICarRepo _carRepo;

        public CarService(ICarRepo carRepo)
        {
            _carRepo = carRepo;
        }

        public Car Add(CreateCar createCar)
        {
            Car car = new Car();

            car.Brand = createCar.Brand;
            car.ModelName = createCar.ModelName;
            car.Price = createCar.Price;

            car = _carRepo.Create(car);

            return car;
        }

        public CarIndexViewModel All()
        {
            CarIndexViewModel indexViewModel = new CarIndexViewModel();

            indexViewModel.CarList = _carRepo.Read();

            return indexViewModel;
        }

        public List<Car> FindByBrand(string brand)
        {
            List<Car> carBrandList = new List<Car>();

            foreach (Car item in _carRepo.Read())
            {
                if(item.Brand.Contains(brand, StringComparison.OrdinalIgnoreCase))//.Brand.Equals(brand))
                {
                    carBrandList.Add(item);
                }
            }

            return carBrandList;
        }
    }
}
