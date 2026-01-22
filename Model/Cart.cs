using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Cart : BaseEntity
    {
        private Reader idReader;
        private string discountCode;
        private double totalPrice;

        public Reader IdReader { get => idReader; set => idReader = value; }
        public string DiscountCode { get => discountCode; set => discountCode = value; }
        public double TotalPrice { get => totalPrice; set => totalPrice = value; }

        public override string ToString()
        {
            return $"Cart Id: {Id}, Reader: {idReader.FirstName} {idReader.LastName}, DiscountCode: {discountCode}, TotalPrice: {totalPrice}";
        }
    }
}
