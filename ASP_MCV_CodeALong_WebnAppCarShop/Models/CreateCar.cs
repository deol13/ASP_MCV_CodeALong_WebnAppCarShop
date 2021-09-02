using ASP_MCV_CodeALong_WebnAppCarShop.Models.Repo;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ASP_MCV_CodeALong_WebnAppCarShop.Models
{
    public class CreateCar
    {
        [Required]
        public string Brand { get; set; }
        [Required]
        [StringLength(100, MinimumLength =2)]
        public string ModelName { get; set; }

        [DataType(DataType.Currency)]
        public double Price { get; set; }

        public List<string> BrandList { get; set; }

        public CreateCar(ICarBrandRepo carBrandRepo)
        {
            BrandList = new List<string>();
            foreach (var item in carBrandRepo.Read())
            {
                BrandList.Add(item.Name);
            }
        }

        public CreateCar()
        {

        }
    }
}
