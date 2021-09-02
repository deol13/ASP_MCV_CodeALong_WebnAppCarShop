using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP_MCV_CodeALong_WebnAppCarShop.Models
{
    public class CarInsurance
    {
        public int CarId { get; set; }
        public Car Car { get; set; }

        public int InsuranceId { get; set; }
        public Insurance Insurance { get; set; }
    }
}
