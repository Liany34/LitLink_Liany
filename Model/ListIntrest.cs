using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class ListIntrest : List<Intrest>
    {
        public ListIntrest() { }
        public ListIntrest(IEnumerable<Intrest> list) : base(list) { }
        public ListIntrest(IEnumerable<BaseEntity> list) : base(list.Cast<Intrest>().ToList()) { }
    }
}
