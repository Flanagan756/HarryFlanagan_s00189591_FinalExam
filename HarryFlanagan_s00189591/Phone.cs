using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/***Author: Harry Flanagan***/
/***Date: 13/05/202***/
namespace HarryFlanagan_s00189591
{
    public class Phone
    {
        /*Properties*/
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string OperatingSystem { get; set; }
        public string OS_Image { get; set; }
        public string Phone_Image { get; set; }

        /*Methods*/
        public void IncreasePrice(decimal originalPrice, decimal percent)
        {
            originalPrice = originalPrice + (originalPrice * (percent/100));

            Price = originalPrice;
        }
    }
   
  
}
