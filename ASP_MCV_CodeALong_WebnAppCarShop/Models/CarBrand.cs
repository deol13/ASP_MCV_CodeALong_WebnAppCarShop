using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ASP_MCV_CodeALong_WebnAppCarShop.Models
{
    public class CarBrand
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }

        public string ImgPath { get; set; }
    }
}
