using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP_MCV_CodeALong_WebnAppCarShop.Models.Repo
{
    public interface ICarBrandRepo
    {
        CarBrand Create(CarBrand carBrand);
        List<CarBrand> Read();
    }
}
