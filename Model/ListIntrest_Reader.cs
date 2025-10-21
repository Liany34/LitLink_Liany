using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class ListIntrest_Reader : List<Intrest_Reader>
    {
        public ListIntrest_Reader() { }
        public ListIntrest_Reader(IEnumerable<Intrest_Reader> list) : base(list) { }
        public ListIntrest_Reader(IEnumerable<BaseEntity> list) : base(list.Cast<Intrest_Reader>().ToList()) { }
    }
}
