using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class ListCart_Detail : List<Cart_Detail>
    {
        public ListCart_Detail() { }
        public ListCart_Detail(IEnumerable<Cart_Detail> list) : base(list) { }
        public ListCart_Detail(IEnumerable<BaseEntity> list) : base(list.Cast<Cart_Detail>().ToList()) { }
    }
}
