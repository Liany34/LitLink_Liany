using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class ListCart : List<Cart>
    {
        public ListCart() { }
        public ListCart(IEnumerable<Cart> list) : base(list) { }
        public ListCart(IEnumerable<BaseEntity> list) : base(list.Cast<Cart>().ToList()) { }
    }
}
