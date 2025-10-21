using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class ListReader : List<Reader>
    {
        public ListReader() { }
        public ListReader(IEnumerable<Reader> list) : base(list) { }
        public ListReader(IEnumerable<BaseEntity> list) : base(list.Cast<Reader>().ToList()) { }
    }
}
