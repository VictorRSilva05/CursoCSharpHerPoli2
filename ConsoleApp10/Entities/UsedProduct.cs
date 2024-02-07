using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10.Entities
{
    internal class UsedProduct : Product
    {
        public DateTime ManufacturerDate { get; set; }
        
        public UsedProduct() { }

        public UsedProduct(DateTime manufacturerDate)
        {
            ManufacturerDate = manufacturerDate;
        }

        public override sealed string PriceTag()
        {
            return base.PriceTag();
        }
    }
}
