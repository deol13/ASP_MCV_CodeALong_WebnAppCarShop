using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ASP_MCV_CodeALong_WebnAppCarShop.Models
{
    public class Car
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string Brand { get; set; }

        [Required]
        [MaxLength(100)]
        public string ModelName { get; set; }

        [Required]
        [Range(1,1000000000000)]
        public double Price { get; set; }

        public List<CarInsurance> CarInsurances { get; set; }
    }
}
