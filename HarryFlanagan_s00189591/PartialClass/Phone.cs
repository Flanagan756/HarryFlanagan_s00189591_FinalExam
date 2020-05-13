using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HarryFlanagan_s00189591
{
    public partial class Phone
    {
        public override string ToString()
        {
            return this.Name;

        }

        public void IncreasePrice(decimal originalPrice, decimal percent)
        {
            Price = originalPrice + (originalPrice * (percent / 100));
        }
    }
}
