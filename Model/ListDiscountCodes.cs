using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class ListDiscountCodes : List<DiscountCodes>
    {
        public ListDiscountCodes() { }
        public ListDiscountCodes(IEnumerable<DiscountCodes> list) : base(list) { }
        public ListDiscountCodes(IEnumerable<BaseEntity> list) : base(list.Cast<DiscountCodes>().ToList()) { }
    }
}
