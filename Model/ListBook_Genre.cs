using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class ListBook_Genre : List<Book_Genre>
    {
        public ListBook_Genre() { }
        public ListBook_Genre(IEnumerable<Book_Genre> list) : base(list) { }
        public ListBook_Genre(IEnumerable<BaseEntity> list) : base(list.Cast<Book_Genre>().ToList()) { }
    }
}
