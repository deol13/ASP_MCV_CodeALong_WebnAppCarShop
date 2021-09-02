using ASP_MCV_CodeALong_WebnAppCarShop.Models.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP_MCV_CodeALong_WebnAppCarShop.Models.Service
{
    public interface ICarService
    {
        Car Add(CreateCar createCar);
        CarIndexViewModel All();
        List<Car> FindByBrand(string brand);

    }
}
