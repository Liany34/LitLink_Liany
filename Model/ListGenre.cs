using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class ListGenre : List<Genre>
    {
        public ListGenre() { }
        public ListGenre(IEnumerable<Genre> list) : base(list) { }
        public ListGenre(IEnumerable<BaseEntity> list) : base(list.Cast<Genre>().ToList()) { }
    }
}
