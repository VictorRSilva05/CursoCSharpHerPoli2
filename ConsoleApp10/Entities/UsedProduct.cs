using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10.Entities
{
    internal class UsedProduct : Product
    {
        public DateTime ManufacturerDate { get; protected set; }
        
        public UsedProduct() { }

        public UsedProduct(string name, double price,DateTime manufacturerDate) : base(name, price)
        {
            ManufacturerDate = manufacturerDate;
        }

        public override sealed string PriceTag()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append(Name);
            stringBuilder.Append(" (used) ");
            stringBuilder.Append(" $ ");
            stringBuilder.Append(Price);
            stringBuilder.Append($" (Manufacture date: {ManufacturerDate.ToString("dd/MM/yyyy")})");
            return stringBuilder.ToString();
        }
    }
}
