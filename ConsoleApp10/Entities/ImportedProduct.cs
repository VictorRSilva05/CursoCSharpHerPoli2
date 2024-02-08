using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10.Entities
{
    internal class ImportedProduct : Product
    {
        public double CustomsFee { get; protected set; }

        public ImportedProduct() { }

        public ImportedProduct(string name, double price, double customsFee) : base(name, price)
        {
            CustomsFee = customsFee;
        }

        public override sealed string PriceTag()
        {
            return base.PriceTag();
        }

        public string TotalPrice()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append(Name);
            stringBuilder.Append(" $ ");
            stringBuilder.Append(Price);
            stringBuilder.Append($" (Customs fee: {CustomsFee})");
            return stringBuilder.ToString();
        }

    }
}
