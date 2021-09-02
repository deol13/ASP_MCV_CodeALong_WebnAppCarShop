using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP_MCV_CodeALong_WebnAppCarShop.Models.Repo
{
    public interface ICarRepo
    {
        Car Read(int id); //Find specific car by ID
        List<Car> Read(); //Get all cars in repo

        Car Create(Car car);
    }
}
