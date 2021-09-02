using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP_MCV_CodeALong_WebnAppCarShop.Models.ViewModel
{
    public class CarIndexViewModel
    {
        public string FilterText { get; set; }

        public List<Car> CarList { get; set; }
    }
}
