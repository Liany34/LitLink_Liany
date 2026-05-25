using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class ListGenre_Reader : List<Genre_Reader>
    {
        public ListGenre_Reader() { }
        public ListGenre_Reader(IEnumerable<Genre_Reader> list) : base(list) { }
        public ListGenre_Reader(IEnumerable<BaseEntity> list) : base(list.Cast<Genre_Reader>().ToList()) { }
    }
}
